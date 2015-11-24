namespace MinecraftWorldCopy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonRefreshRemovable = new System.Windows.Forms.Button();
            this.listRemovableWorlds = new System.Windows.Forms.ListBox();
            this.listRemovable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.listLocalWorlds = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCopyToLocal = new System.Windows.Forms.Button();
            this.buttonCopyToRemovable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 75);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(584, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minecraft World Copy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(16, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 63);
            this.panel2.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonCopyToLocal);
            this.panelLeft.Controls.Add(this.buttonRefreshRemovable);
            this.panelLeft.Controls.Add(this.listRemovableWorlds);
            this.panelLeft.Controls.Add(this.listRemovable);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 75);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(450, 512);
            this.panelLeft.TabIndex = 1;
            // 
            // buttonRefreshRemovable
            // 
            this.buttonRefreshRemovable.Location = new System.Drawing.Point(364, 32);
            this.buttonRefreshRemovable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRefreshRemovable.Name = "buttonRefreshRemovable";
            this.buttonRefreshRemovable.Size = new System.Drawing.Size(74, 23);
            this.buttonRefreshRemovable.TabIndex = 3;
            this.buttonRefreshRemovable.Text = "Refresh";
            this.buttonRefreshRemovable.UseVisualStyleBackColor = true;
            this.buttonRefreshRemovable.Click += new System.EventHandler(this.buttonRefreshRemovable_Click);
            // 
            // listRemovableWorlds
            // 
            this.listRemovableWorlds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemovableWorlds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRemovableWorlds.FormattingEnabled = true;
            this.listRemovableWorlds.IntegralHeight = false;
            this.listRemovableWorlds.ItemHeight = 25;
            this.listRemovableWorlds.Location = new System.Drawing.Point(16, 60);
            this.listRemovableWorlds.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listRemovableWorlds.Name = "listRemovableWorlds";
            this.listRemovableWorlds.Size = new System.Drawing.Size(422, 411);
            this.listRemovableWorlds.TabIndex = 2;
            // 
            // listRemovable
            // 
            this.listRemovable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemovable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRemovable.FormattingEnabled = true;
            this.listRemovable.Location = new System.Drawing.Point(16, 33);
            this.listRemovable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listRemovable.Name = "listRemovable";
            this.listRemovable.Size = new System.Drawing.Size(341, 21);
            this.listRemovable.TabIndex = 1;
            this.listRemovable.SelectedIndexChanged += new System.EventHandler(this.listRemovable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worlds on USB stick";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.buttonCopyToRemovable);
            this.panelRight.Controls.Add(this.listLocalWorlds);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(450, 75);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(482, 512);
            this.panelRight.TabIndex = 2;
            // 
            // listLocalWorlds
            // 
            this.listLocalWorlds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLocalWorlds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLocalWorlds.FormattingEnabled = true;
            this.listLocalWorlds.IntegralHeight = false;
            this.listLocalWorlds.ItemHeight = 25;
            this.listLocalWorlds.Location = new System.Drawing.Point(10, 60);
            this.listLocalWorlds.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listLocalWorlds.Name = "listLocalWorlds";
            this.listLocalWorlds.Size = new System.Drawing.Size(461, 411);
            this.listLocalWorlds.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Worlds on this computer";
            // 
            // buttonCopyToLocal
            // 
            this.buttonCopyToLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyToLocal.Location = new System.Drawing.Point(16, 477);
            this.buttonCopyToLocal.Name = "buttonCopyToLocal";
            this.buttonCopyToLocal.Size = new System.Drawing.Size(422, 23);
            this.buttonCopyToLocal.TabIndex = 4;
            this.buttonCopyToLocal.Text = "Copy world on USB stick to computer >>";
            this.buttonCopyToLocal.UseVisualStyleBackColor = true;
            this.buttonCopyToLocal.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCopyToRemovable
            // 
            this.buttonCopyToRemovable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyToRemovable.Location = new System.Drawing.Point(10, 477);
            this.buttonCopyToRemovable.Name = "buttonCopyToRemovable";
            this.buttonCopyToRemovable.Size = new System.Drawing.Size(461, 23);
            this.buttonCopyToRemovable.TabIndex = 5;
            this.buttonCopyToRemovable.Text = "<< Copy world on computer to USB stick";
            this.buttonCopyToRemovable.UseVisualStyleBackColor = true;
            this.buttonCopyToRemovable.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(932, 587);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft World Copy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ComboBox listRemovable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRemovableWorlds;
        private System.Windows.Forms.Button buttonRefreshRemovable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listLocalWorlds;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCopyToLocal;
        private System.Windows.Forms.Button buttonCopyToRemovable;
    }
}

