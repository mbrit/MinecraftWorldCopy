using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftWorldCopy
{
    public partial class Form1 : Form
    {
        private MinecraftReader RemovableReader { get; set; }

        private MinecraftReader LocalReader { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.panelLeft.Width = this.ClientRectangle.Width / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ReportException(() =>
            {
                this.RefreshLocal();
                this.RefreshRemovable();
            });
        }

        private void RefreshLocal()
        {
            var mcPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
            if (!(Directory.Exists(mcPath)))
            {
                Alert.ShowWarning(this, "Minecraft is not installed on this computer.\r\n\r\nPath: " + mcPath);
                return;
            }

            // get..
            var saves = Path.Combine(mcPath, "saves");
            if (!(Directory.Exists(saves)))
                Directory.CreateDirectory(saves);

            // update...
            this.LocalReader = new MinecraftReader(saves);

            this.listLocalWorlds.BeginUpdate();
            try
            {
                this.listLocalWorlds.Items.Clear();
                foreach (var name in this.LocalReader.Worlds.Keys)
                    this.listLocalWorlds.Items.Add(name);
            }
            finally
            {
                this.listLocalWorlds.EndUpdate();
            }
        }

        private void RefreshRemovable()
        {
            this.listRemovable.BeginUpdate();
            try
            {
                this.listRemovable.Items.Clear();
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveType == DriveType.Removable && drive.IsReady)
                        this.listRemovable.Items.Add(new DriveAndLabel(drive));
                }

                if (this.listRemovable.Items.Count > 0)
                    this.listRemovable.SelectedIndex = 0;
            }
            finally
            {
                this.listRemovable.EndUpdate();
            }
        }

        private void listRemovable_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ReportException(() =>
            {
                this.RefreshRemovableWorlds();
            });
        }

        private void RefreshRemovableWorlds()
        {
            this.RemovableReader = null;
            this.listRemovableWorlds.BeginUpdate();
            try
            {
                this.listRemovableWorlds.Items.Clear();

                var drive = (DriveAndLabel)this.listRemovable.SelectedItem;
                if (drive != null)
                {
                    this.RemovableReader = new MinecraftReader(drive.Drive.RootDirectory.FullName);
                    foreach (var name in this.RemovableReader.Worlds.Keys)
                        this.listRemovableWorlds.Items.Add(name);
                }
            }
            finally
            {
                this.listRemovableWorlds.EndUpdate();
            }
        }

        private void buttonRefreshRemovable_Click(object sender, EventArgs e)
        {
            this.ReportException(() =>
            {
                this.RefreshRemovable();
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReportException(() =>
            {
                // check...
                var selected = (string)this.listRemovableWorlds.SelectedItem;
                if (string.IsNullOrEmpty(selected))
                {
                    Alert.ShowInfo(this, "You must select a world.");
                    return;
                }

                // if...
                if (this.LocalReader.Worlds.ContainsKey(selected))
                {
                    Alert.ShowInfo(this, string.Format("There is already a world '{0}' on the computer.", selected));
                    return;
                }

                // copy...
                new MinecraftCopier().Copy(this.RemovableReader.Worlds[selected].FullName,
                    this.LocalReader.Path);
                this.RefreshLocal();

                Alert.ShowInfo(this, "Copying complete.");
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ReportException(() =>
            {
                // check...
                var selected = (string)this.listLocalWorlds.SelectedItem;
                if (string.IsNullOrEmpty(selected))
                {
                    Alert.ShowInfo(this, "You must select a world.");
                    return;
                }

                // if...
                if (this.RemovableReader.Worlds.ContainsKey(selected))
                {
                    Alert.ShowInfo(this, string.Format("There is already a world '{0}' on the USB stick.", selected));
                    return;
                }

                // copy...
                new MinecraftCopier().Copy(this.LocalReader.Worlds[selected].FullName,
                    this.RemovableReader.Path);
                this.RefreshRemovable();

                Alert.ShowInfo(this, "Copying complete.");
            });
        }
    }
}

