namespace VisiTrace
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.btnTraceMe = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::VisiTrace.Properties.Resources.image_2022_06_08_135506116_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblApp.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.ForeColor = System.Drawing.Color.Navy;
            this.lblApp.Location = new System.Drawing.Point(186, 12);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(120, 31);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "VisiTrace";
            // 
            // btnTraceMe
            // 
            this.btnTraceMe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTraceMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraceMe.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraceMe.ForeColor = System.Drawing.Color.Snow;
            this.btnTraceMe.Location = new System.Drawing.Point(192, 55);
            this.btnTraceMe.Name = "btnTraceMe";
            this.btnTraceMe.Size = new System.Drawing.Size(85, 24);
            this.btnTraceMe.TabIndex = 2;
            this.btnTraceMe.Text = "Trace me";
            this.btnTraceMe.UseVisualStyleBackColor = false;
            this.btnTraceMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFullName.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Navy;
            this.lblFullName.Location = new System.Drawing.Point(25, 105);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name: \r\n";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(92, 102);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(264, 23);
            this.txtbxFullName.TabIndex = 4;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContactNo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.Navy;
            this.lblContactNo.Location = new System.Drawing.Point(385, 105);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(99, 15);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "Contact Number: \r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 23);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(706, 320);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtbxFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnTraceMe);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Wheat;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisiTrace";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Button btnTraceMe;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

