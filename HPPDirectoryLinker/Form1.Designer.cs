namespace HPPDirectoryLinker
{
    partial class HPPDirectoryLinker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HPPDirectoryLinker));
            this.SDKbutton = new System.Windows.Forms.Button();
            this.POSTAL3button = new System.Windows.Forms.Button();
            this.SDKpathBox = new System.Windows.Forms.TextBox();
            this.P3pathBox = new System.Windows.Forms.TextBox();
            this.LINKbutton = new System.Windows.Forms.Button();
            this.gameFolders = new System.Windows.Forms.CheckedListBox();
            this.resourceFolders = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HammerPPLink = new System.Windows.Forms.LinkLabel();
            this.FGDbutton = new System.Windows.Forms.Button();
            this.programVersion = new System.Windows.Forms.Label();
            this.UPDATEbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SDKbutton
            // 
            this.SDKbutton.Location = new System.Drawing.Point(12, 12);
            this.SDKbutton.Name = "SDKbutton";
            this.SDKbutton.Size = new System.Drawing.Size(152, 37);
            this.SDKbutton.TabIndex = 0;
            this.SDKbutton.Text = "Source SDK Base 2013";
            this.SDKbutton.UseVisualStyleBackColor = true;
            this.SDKbutton.Click += new System.EventHandler(this.SDKbutton_Click);
            // 
            // POSTAL3button
            // 
            this.POSTAL3button.Enabled = false;
            this.POSTAL3button.Location = new System.Drawing.Point(12, 55);
            this.POSTAL3button.Name = "POSTAL3button";
            this.POSTAL3button.Size = new System.Drawing.Size(152, 38);
            this.POSTAL3button.TabIndex = 1;
            this.POSTAL3button.Text = "Postal III";
            this.POSTAL3button.UseVisualStyleBackColor = true;
            this.POSTAL3button.Click += new System.EventHandler(this.POSTAL3button_Click);
            // 
            // SDKpathBox
            // 
            this.SDKpathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SDKpathBox.Location = new System.Drawing.Point(170, 20);
            this.SDKpathBox.Name = "SDKpathBox";
            this.SDKpathBox.ReadOnly = true;
            this.SDKpathBox.Size = new System.Drawing.Size(397, 23);
            this.SDKpathBox.TabIndex = 2;
            this.SDKpathBox.Text = "<Path to your Source SDK Base 2013 SP/MP installation>";
            // 
            // P3pathBox
            // 
            this.P3pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P3pathBox.Location = new System.Drawing.Point(170, 64);
            this.P3pathBox.Name = "P3pathBox";
            this.P3pathBox.ReadOnly = true;
            this.P3pathBox.Size = new System.Drawing.Size(397, 23);
            this.P3pathBox.TabIndex = 3;
            this.P3pathBox.Text = "<Path to your Postal III installation>";
            // 
            // LINKbutton
            // 
            this.LINKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LINKbutton.Enabled = false;
            this.LINKbutton.Location = new System.Drawing.Point(7, 124);
            this.LINKbutton.Name = "LINKbutton";
            this.LINKbutton.Size = new System.Drawing.Size(121, 41);
            this.LINKbutton.TabIndex = 4;
            this.LINKbutton.Text = "Link Directories";
            this.LINKbutton.UseVisualStyleBackColor = true;
            this.LINKbutton.Click += new System.EventHandler(this.LINKbutton_Click);
            // 
            // gameFolders
            // 
            this.gameFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gameFolders.CheckOnClick = true;
            this.gameFolders.Enabled = false;
            this.gameFolders.FormattingEnabled = true;
            this.gameFolders.Location = new System.Drawing.Point(12, 114);
            this.gameFolders.Name = "gameFolders";
            this.gameFolders.Size = new System.Drawing.Size(120, 202);
            this.gameFolders.TabIndex = 7;
            // 
            // resourceFolders
            // 
            this.resourceFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resourceFolders.CheckOnClick = true;
            this.resourceFolders.Enabled = false;
            this.resourceFolders.FormattingEnabled = true;
            this.resourceFolders.Items.AddRange(new object[] {
            "models",
            "materials",
            "particles",
            "shaders"});
            this.resourceFolders.Location = new System.Drawing.Point(25, 42);
            this.resourceFolders.Name = "resourceFolders";
            this.resourceFolders.Size = new System.Drawing.Size(84, 76);
            this.resourceFolders.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Folders to Link";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 202);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Made by Kizoky";
            // 
            // HammerPPLink
            // 
            this.HammerPPLink.AutoSize = true;
            this.HammerPPLink.Location = new System.Drawing.Point(243, 324);
            this.HammerPPLink.Name = "HammerPPLink";
            this.HammerPPLink.Size = new System.Drawing.Size(109, 15);
            this.HammerPPLink.TabIndex = 13;
            this.HammerPPLink.TabStop = true;
            this.HammerPPLink.Text = "Link to Hammer++";
            this.HammerPPLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HammerPPLink_LinkClicked);
            // 
            // FGDbutton
            // 
            this.FGDbutton.Location = new System.Drawing.Point(472, 132);
            this.FGDbutton.Name = "FGDbutton";
            this.FGDbutton.Size = new System.Drawing.Size(84, 38);
            this.FGDbutton.TabIndex = 14;
            this.FGDbutton.Text = "Fix Postal III FGD";
            this.FGDbutton.UseVisualStyleBackColor = true;
            this.FGDbutton.Click += new System.EventHandler(this.FGDbutton_Click);
            // 
            // programVersion
            // 
            this.programVersion.AutoSize = true;
            this.programVersion.Location = new System.Drawing.Point(533, 2);
            this.programVersion.Name = "programVersion";
            this.programVersion.Size = new System.Drawing.Size(34, 15);
            this.programVersion.TabIndex = 15;
            this.programVersion.Text = "v1.00";
            this.programVersion.Click += new System.EventHandler(this.programVersion_Click);
            // 
            // UPDATEbutton
            // 
            this.UPDATEbutton.Location = new System.Drawing.Point(456, 93);
            this.UPDATEbutton.Name = "UPDATEbutton";
            this.UPDATEbutton.Size = new System.Drawing.Size(112, 27);
            this.UPDATEbutton.TabIndex = 16;
            this.UPDATEbutton.Text = "Check for Updates";
            this.UPDATEbutton.UseVisualStyleBackColor = true;
            this.UPDATEbutton.Click += new System.EventHandler(this.UPDATEbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 108);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(5, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 248);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.LINKbutton);
            this.groupBox3.Controls.Add(this.resourceFolders);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(447, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 171);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game Folders to Link";
            // 
            // HPPDirectoryLinker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 348);
            this.Controls.Add(this.UPDATEbutton);
            this.Controls.Add(this.FGDbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HammerPPLink);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameFolders);
            this.Controls.Add(this.programVersion);
            this.Controls.Add(this.P3pathBox);
            this.Controls.Add(this.SDKpathBox);
            this.Controls.Add(this.POSTAL3button);
            this.Controls.Add(this.SDKbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(595, 387);
            this.MinimumSize = new System.Drawing.Size(595, 387);
            this.Name = "HPPDirectoryLinker";
            this.Text = "Hammer++ Directory Linker";
            this.Load += new System.EventHandler(this.HPPDirectoryLinker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button SDKbutton;
        private Button POSTAL3button;
        private TextBox SDKpathBox;
        private TextBox P3pathBox;
        private Button LINKbutton;
        private CheckedListBox gameFolders;
        private CheckedListBox resourceFolders;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel HammerPPLink;
        private Button FGDbutton;
        private Label programVersion;
        private Button UPDATEbutton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
    }
}