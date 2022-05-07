namespace HPPDirectoryLinker
{
    partial class FixPostalFGD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixPostalFGD));
            this.FixFGDbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fgdConsole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FixFGDbutton
            // 
            this.FixFGDbutton.BackColor = System.Drawing.Color.Purple;
            this.FixFGDbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixFGDbutton.ForeColor = System.Drawing.Color.Fuchsia;
            this.FixFGDbutton.Location = new System.Drawing.Point(12, 107);
            this.FixFGDbutton.Name = "FixFGDbutton";
            this.FixFGDbutton.Size = new System.Drawing.Size(196, 30);
            this.FixFGDbutton.TabIndex = 4;
            this.FixFGDbutton.Text = "Browse FGD";
            this.FixFGDbutton.UseVisualStyleBackColor = false;
            this.FixFGDbutton.Click += new System.EventHandler(this.FixFGDbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar1.Location = new System.Drawing.Point(12, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 154);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // fgdConsole
            // 
            this.fgdConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fgdConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgdConsole.ForeColor = System.Drawing.Color.Fuchsia;
            this.fgdConsole.Location = new System.Drawing.Point(0, 143);
            this.fgdConsole.Multiline = true;
            this.fgdConsole.Name = "fgdConsole";
            this.fgdConsole.ReadOnly = true;
            this.fgdConsole.Size = new System.Drawing.Size(220, 84);
            this.fgdConsole.TabIndex = 9;
            this.fgdConsole.Text = "Waiting for Input...";
            this.fgdConsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FixPostalFGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(220, 227);
            this.Controls.Add(this.fgdConsole);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FixFGDbutton);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(236, 266);
            this.MinimumSize = new System.Drawing.Size(236, 266);
            this.Name = "FixPostalFGD";
            this.ShowIcon = false;
            this.Text = "FGD Fixer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button FixFGDbutton;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private TextBox fgdConsole;
    }
}