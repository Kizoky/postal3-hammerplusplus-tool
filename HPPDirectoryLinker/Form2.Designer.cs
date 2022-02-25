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
            this.FixFGDbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // FixFGDbutton
            // 
            this.FixFGDbutton.Location = new System.Drawing.Point(12, 107);
            this.FixFGDbutton.Name = "FixFGDbutton";
            this.FixFGDbutton.Size = new System.Drawing.Size(196, 30);
            this.FixFGDbutton.TabIndex = 4;
            this.FixFGDbutton.Text = "Browse FGD";
            this.FixFGDbutton.UseVisualStyleBackColor = true;
            this.FixFGDbutton.Click += new System.EventHandler(this.FixFGDbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Progress";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fix Postal III FGD";
            // 
            // FixPostalFGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(220, 149);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FixFGDbutton);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(236, 188);
            this.MinimumSize = new System.Drawing.Size(236, 188);
            this.Name = "FixPostalFGD";
            this.ShowIcon = false;
            this.Text = "Fix Postal III FGD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button FixFGDbutton;
        private ProgressBar progressBar1;
        private Label label2;
        private GroupBox groupBox1;
    }
}