namespace HPPDirectoryLinker
{
    partial class PresetsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.presetCombo = new System.Windows.Forms.ComboBox();
            this.SDKpathbox = new System.Windows.Forms.TextBox();
            this.P3pathbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SDKeditButton = new System.Windows.Forms.Button();
            this.P3editButton = new System.Windows.Forms.Button();
            this.loadPathsButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.deletePresetButton = new System.Windows.Forms.Button();
            this.createNewPresetButton = new System.Windows.Forms.Button();
            this.loadOntoMainAppButton = new System.Windows.Forms.Button();
            this.presetNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Preset:";
            // 
            // presetCombo
            // 
            this.presetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetCombo.FormattingEnabled = true;
            this.presetCombo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.presetCombo.Location = new System.Drawing.Point(12, 23);
            this.presetCombo.Name = "presetCombo";
            this.presetCombo.Size = new System.Drawing.Size(173, 23);
            this.presetCombo.TabIndex = 1;
            this.presetCombo.SelectedIndexChanged += new System.EventHandler(this.presetCombo_SelectedIndexChanged);
            // 
            // SDKpathbox
            // 
            this.SDKpathbox.BackColor = System.Drawing.SystemColors.Control;
            this.SDKpathbox.Location = new System.Drawing.Point(12, 70);
            this.SDKpathbox.Name = "SDKpathbox";
            this.SDKpathbox.ReadOnly = true;
            this.SDKpathbox.Size = new System.Drawing.Size(235, 23);
            this.SDKpathbox.TabIndex = 2;
            // 
            // P3pathbox
            // 
            this.P3pathbox.Location = new System.Drawing.Point(12, 112);
            this.P3pathbox.Name = "P3pathbox";
            this.P3pathbox.ReadOnly = true;
            this.P3pathbox.Size = new System.Drawing.Size(235, 23);
            this.P3pathbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source SDK Base 2013 SP/MP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Postal III";
            // 
            // SDKeditButton
            // 
            this.SDKeditButton.Location = new System.Drawing.Point(253, 70);
            this.SDKeditButton.Name = "SDKeditButton";
            this.SDKeditButton.Size = new System.Drawing.Size(35, 23);
            this.SDKeditButton.TabIndex = 6;
            this.SDKeditButton.Text = "Edit";
            this.SDKeditButton.UseVisualStyleBackColor = true;
            this.SDKeditButton.Click += new System.EventHandler(this.SDKeditButton_Click);
            // 
            // P3editButton
            // 
            this.P3editButton.Location = new System.Drawing.Point(253, 112);
            this.P3editButton.Name = "P3editButton";
            this.P3editButton.Size = new System.Drawing.Size(35, 23);
            this.P3editButton.TabIndex = 7;
            this.P3editButton.Text = "Edit";
            this.P3editButton.UseVisualStyleBackColor = true;
            this.P3editButton.Click += new System.EventHandler(this.P3editButton_Click);
            // 
            // loadPathsButton
            // 
            this.loadPathsButton.Location = new System.Drawing.Point(12, 141);
            this.loadPathsButton.Name = "loadPathsButton";
            this.loadPathsButton.Size = new System.Drawing.Size(160, 24);
            this.loadPathsButton.TabIndex = 8;
            this.loadPathsButton.Text = "Load Paths from Main App";
            this.loadPathsButton.UseVisualStyleBackColor = true;
            this.loadPathsButton.Click += new System.EventHandler(this.newPresetButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(191, 23);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(45, 23);
            this.saveChangesButton.TabIndex = 9;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // deletePresetButton
            // 
            this.deletePresetButton.Location = new System.Drawing.Point(242, 23);
            this.deletePresetButton.Name = "deletePresetButton";
            this.deletePresetButton.Size = new System.Drawing.Size(56, 23);
            this.deletePresetButton.TabIndex = 11;
            this.deletePresetButton.Text = "Delete";
            this.deletePresetButton.UseVisualStyleBackColor = true;
            this.deletePresetButton.Click += new System.EventHandler(this.deletePresetButton_Click);
            // 
            // createNewPresetButton
            // 
            this.createNewPresetButton.Location = new System.Drawing.Point(198, 204);
            this.createNewPresetButton.Name = "createNewPresetButton";
            this.createNewPresetButton.Size = new System.Drawing.Size(104, 25);
            this.createNewPresetButton.TabIndex = 12;
            this.createNewPresetButton.Text = "New Preset";
            this.createNewPresetButton.UseVisualStyleBackColor = true;
            this.createNewPresetButton.Click += new System.EventHandler(this.createNewPresetButton_Click);
            // 
            // loadOntoMainAppButton
            // 
            this.loadOntoMainAppButton.Location = new System.Drawing.Point(12, 204);
            this.loadOntoMainAppButton.Name = "loadOntoMainAppButton";
            this.loadOntoMainAppButton.Size = new System.Drawing.Size(160, 25);
            this.loadOntoMainAppButton.TabIndex = 13;
            this.loadOntoMainAppButton.Text = "Load onto Main App";
            this.loadOntoMainAppButton.UseVisualStyleBackColor = true;
            this.loadOntoMainAppButton.Click += new System.EventHandler(this.loadOntoMainAppButton_Click);
            // 
            // presetNameBox
            // 
            this.presetNameBox.Location = new System.Drawing.Point(198, 175);
            this.presetNameBox.Name = "presetNameBox";
            this.presetNameBox.Size = new System.Drawing.Size(104, 23);
            this.presetNameBox.TabIndex = 14;
            this.presetNameBox.Text = "Postal III";
            this.presetNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(218, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Preset Name";
            // 
            // PresetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(308, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.presetNameBox);
            this.Controls.Add(this.loadOntoMainAppButton);
            this.Controls.Add(this.createNewPresetButton);
            this.Controls.Add(this.deletePresetButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.loadPathsButton);
            this.Controls.Add(this.P3editButton);
            this.Controls.Add(this.SDKeditButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P3pathbox);
            this.Controls.Add(this.SDKpathbox);
            this.Controls.Add(this.presetCombo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 0);
            this.Name = "PresetsForm";
            this.ShowIcon = false;
            this.Text = "Presets Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox presetCombo;
        private TextBox SDKpathbox;
        private TextBox P3pathbox;
        private Label label2;
        private Label label3;
        private Button SDKeditButton;
        private Button P3editButton;
        private Button loadPathsButton;
        private Button saveChangesButton;
        private Button deletePresetButton;
        private Button createNewPresetButton;
        private Button loadOntoMainAppButton;
        private TextBox presetNameBox;
        private Label label4;
    }
}