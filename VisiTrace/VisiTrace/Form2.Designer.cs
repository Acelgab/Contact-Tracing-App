namespace VisiTrace
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnQR = new System.Windows.Forms.Button();
            this.pctrbxQR = new System.Windows.Forms.PictureBox();
            this.btnSaveQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.Color.Honeydew;
            this.btnQR.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnQR.Location = new System.Drawing.Point(94, 28);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(75, 22);
            this.btnQR.TabIndex = 0;
            this.btnQR.Text = "Generate";
            this.btnQR.UseVisualStyleBackColor = false;
            // 
            // pctrbxQR
            // 
            this.pctrbxQR.Location = new System.Drawing.Point(71, 57);
            this.pctrbxQR.Name = "pctrbxQR";
            this.pctrbxQR.Size = new System.Drawing.Size(232, 173);
            this.pctrbxQR.TabIndex = 1;
            this.pctrbxQR.TabStop = false;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.BackColor = System.Drawing.Color.Honeydew;
            this.btnSaveQR.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveQR.Location = new System.Drawing.Point(175, 28);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(108, 23);
            this.btnSaveQR.TabIndex = 2;
            this.btnSaveQR.Text = "Save QR Code";
            this.btnSaveQR.UseVisualStyleBackColor = false;
            this.btnSaveQR.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(379, 297);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.pctrbxQR);
            this.Controls.Add(this.btnQR);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Generate QR Code";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.PictureBox pctrbxQR;
        private System.Windows.Forms.Button btnSaveQR;
    }
}