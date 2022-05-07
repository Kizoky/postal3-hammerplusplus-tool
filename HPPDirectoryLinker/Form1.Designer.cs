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
            this.HammerPPLink = new System.Windows.Forms.LinkLabel();
            this.FGDbutton = new System.Windows.Forms.Button();
            this.programVersion = new System.Windows.Forms.Label();
            this.UPDATEbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CLEARbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SDKbutton
            // 
            this.SDKbutton.Location = new System.Drawing.Point(8, 43);
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
            this.POSTAL3button.Location = new System.Drawing.Point(8, 86);
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
            this.SDKpathBox.Location = new System.Drawing.Point(166, 51);
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
            this.P3pathBox.Location = new System.Drawing.Point(166, 95);
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
            this.LINKbutton.Location = new System.Drawing.Point(7, 118);
            this.LINKbutton.Name = "LINKbutton";
            this.LINKbutton.Size = new System.Drawing.Size(121, 41);
            this.LINKbutton.TabIndex = 4;
            this.LINKbutton.Text = "Link Directories";
            this.LINKbutton.UseVisualStyleBackColor = true;
            this.LINKbutton.Click += new System.EventHandler(this.LINKbutton_Click);
            // 
            // gameFolders
            // 
            this.gameFolders.CheckOnClick = true;
            this.gameFolders.Enabled = false;
            this.gameFolders.FormattingEnabled = true;
            this.gameFolders.Location = new System.Drawing.Point(7, 20);
            this.gameFolders.Name = "gameFolders";
            this.gameFolders.Size = new System.Drawing.Size(120, 220);
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
            "shaders",
            "sound"});
            this.resourceFolders.Location = new System.Drawing.Point(25, 19);
            this.resourceFolders.Name = "resourceFolders";
            this.resourceFolders.Size = new System.Drawing.Size(84, 94);
            this.resourceFolders.TabIndex = 8;
            this.resourceFolders.SelectedIndexChanged += new System.EventHandler(this.resourceFolders_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Folders to Link";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 202);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // HammerPPLink
            // 
            this.HammerPPLink.AutoSize = true;
            this.HammerPPLink.Location = new System.Drawing.Point(163, 366);
            this.HammerPPLink.Name = "HammerPPLink";
            this.HammerPPLink.Size = new System.Drawing.Size(109, 15);
            this.HammerPPLink.TabIndex = 13;
            this.HammerPPLink.TabStop = true;
            this.HammerPPLink.Text = "Link to Hammer++";
            this.HammerPPLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HammerPPLink_LinkClicked);
            // 
            // FGDbutton
            // 
            this.FGDbutton.Location = new System.Drawing.Point(468, 165);
            this.FGDbutton.Name = "FGDbutton";
            this.FGDbutton.Size = new System.Drawing.Size(84, 44);
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
            this.programVersion.Text = "v1.05";
            this.programVersion.Click += new System.EventHandler(this.programVersion_Click);
            // 
            // UPDATEbutton
            // 
            this.UPDATEbutton.Location = new System.Drawing.Point(452, 124);
            this.UPDATEbutton.Name = "UPDATEbutton";
            this.UPDATEbutton.Size = new System.Drawing.Size(112, 27);
            this.UPDATEbutton.TabIndex = 16;
            this.UPDATEbutton.Text = "Check for Updates";
            this.UPDATEbutton.UseVisualStyleBackColor = true;
            this.UPDATEbutton.Click += new System.EventHandler(this.UPDATEbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game Folders to Link";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gameFolders);
            this.groupBox2.Location = new System.Drawing.Point(5, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 246);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.LINKbutton);
            this.groupBox3.Controls.Add(this.resourceFolders);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(443, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 165);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // CLEARbutton
            // 
            this.CLEARbutton.Enabled = false;
            this.CLEARbutton.Location = new System.Drawing.Point(309, 362);
            this.CLEARbutton.Name = "CLEARbutton";
            this.CLEARbutton.Size = new System.Drawing.Size(128, 23);
            this.CLEARbutton.TabIndex = 20;
            this.CLEARbutton.Text = "Clear Linked Folders";
            this.CLEARbutton.UseVisualStyleBackColor = true;
            this.CLEARbutton.Click += new System.EventHandler(this.CLEARbutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.presetsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(579, 23);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.aboutToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.presetsToolStripMenuItem.Text = "Presets";
            this.presetsToolStripMenuItem.Click += new System.EventHandler(this.presetsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 113);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // HPPDirectoryLinker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 393);
            this.Controls.Add(this.SDKbutton);
            this.Controls.Add(this.CLEARbutton);
            this.Controls.Add(this.UPDATEbutton);
            this.Controls.Add(this.FGDbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HammerPPLink);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.programVersion);
            this.Controls.Add(this.P3pathBox);
            this.Controls.Add(this.SDKpathBox);
            this.Controls.Add(this.POSTAL3button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(595, 500);
            this.MinimumSize = new System.Drawing.Size(595, 387);
            this.Name = "HPPDirectoryLinker";
            this.Text = "Hammer++ Directory Linker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private LinkLabel HammerPPLink;
        private Button FGDbutton;
        private Label programVersion;
        private Button UPDATEbutton;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Button CLEARbutton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private ToolStripMenuItem presetsToolStripMenuItem;
    }
}