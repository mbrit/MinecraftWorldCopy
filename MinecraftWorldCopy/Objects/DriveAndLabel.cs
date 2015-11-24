using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftWorldCopy
{
    internal class DriveAndLabel
    {
        internal DriveInfo Drive { get; set; }

        public DriveAndLabel(DriveInfo drive)
        {
            this.Drive = drive;
        }

        public override string ToString()
        {
            if (!(string.IsNullOrEmpty(this.Drive.VolumeLabel)))
                return string.Format("{0} - {1}", this.Drive.RootDirectory.FullName, this.Drive.VolumeLabel);
            else
                return this.Drive.RootDirectory.FullName;
        }
    }
}
