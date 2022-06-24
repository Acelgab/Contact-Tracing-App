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
            this.txtbxContactNo = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.txtbxQuestion1 = new System.Windows.Forms.TextBox();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.txtbxQuestion2 = new System.Windows.Forms.TextBox();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.txtbxQuestion3 = new System.Windows.Forms.TextBox();
            this.lblQuestion4 = new System.Windows.Forms.Label();
            this.txtbxQuestion4 = new System.Windows.Forms.TextBox();
            this.lblQuestion5 = new System.Windows.Forms.Label();
            this.txtbxQuestion5 = new System.Windows.Forms.TextBox();
            this.lblQuestion6 = new System.Windows.Forms.Label();
            this.txtbxQuestion6 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewForm = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::VisiTrace.Properties.Resources.image_2022_06_08_135506116_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(214, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 108);
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
            this.lblApp.Location = new System.Drawing.Point(271, 21);
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
            this.btnTraceMe.Location = new System.Drawing.Point(276, 55);
            this.btnTraceMe.Name = "btnTraceMe";
            this.btnTraceMe.Size = new System.Drawing.Size(74, 24);
            this.btnTraceMe.TabIndex = 2;
            this.btnTraceMe.Text = "Trace me";
            this.btnTraceMe.UseVisualStyleBackColor = false;
            this.btnTraceMe.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFullName.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Navy;
            this.lblFullName.Location = new System.Drawing.Point(22, 105);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name: \r\n";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(93, 101);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(238, 23);
            this.txtbxFullName.TabIndex = 4;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContactNo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.Navy;
            this.lblContactNo.Location = new System.Drawing.Point(337, 105);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(99, 15);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "Contact Number: \r\n";
            // 
            // txtbxContactNo
            // 
            this.txtbxContactNo.Location = new System.Drawing.Point(433, 101);
            this.txtbxContactNo.Name = "txtbxContactNo";
            this.txtbxContactNo.Size = new System.Drawing.Size(154, 23);
            this.txtbxContactNo.TabIndex = 6;
            this.txtbxContactNo.TextChanged += new System.EventHandler(this.txtbxContactNo_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Navy;
            this.lblAddress.Location = new System.Drawing.Point(34, 143);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 15);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(91, 139);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(308, 23);
            this.txtbxAddress.TabIndex = 8;
            this.txtbxAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDate.Location = new System.Drawing.Point(408, 143);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 15);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date:";
            // 
            // txtbxDate
            // 
            this.txtbxDate.Location = new System.Drawing.Point(443, 140);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.Size = new System.Drawing.Size(154, 23);
            this.txtbxDate.TabIndex = 10;
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion1.Location = new System.Drawing.Point(22, 176);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(267, 15);
            this.lblQuestion1.TabIndex = 11;
            this.lblQuestion1.Text = "Have you experienced a fever in the last 14 days?";
            // 
            // txtbxQuestion1
            // 
            this.txtbxQuestion1.Location = new System.Drawing.Point(295, 172);
            this.txtbxQuestion1.Name = "txtbxQuestion1";
            this.txtbxQuestion1.Size = new System.Drawing.Size(41, 23);
            this.txtbxQuestion1.TabIndex = 12;
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion2.Location = new System.Drawing.Point(22, 206);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(272, 15);
            this.lblQuestion2.TabIndex = 13;
            this.lblQuestion2.Text = "Have you experienced a cough in the last 14 days?";
            // 
            // txtbxQuestion2
            // 
            this.txtbxQuestion2.Location = new System.Drawing.Point(295, 202);
            this.txtbxQuestion2.Name = "txtbxQuestion2";
            this.txtbxQuestion2.Size = new System.Drawing.Size(41, 23);
            this.txtbxQuestion2.TabIndex = 14;
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion3.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion3.Location = new System.Drawing.Point(22, 236);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(71, 15);
            this.lblQuestion3.TabIndex = 15;
            this.lblQuestion3.Text = "Sore throat?";
            // 
            // txtbxQuestion3
            // 
            this.txtbxQuestion3.Location = new System.Drawing.Point(99, 233);
            this.txtbxQuestion3.Name = "txtbxQuestion3";
            this.txtbxQuestion3.Size = new System.Drawing.Size(41, 23);
            this.txtbxQuestion3.TabIndex = 16;
            // 
            // lblQuestion4
            // 
            this.lblQuestion4.AutoSize = true;
            this.lblQuestion4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion4.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion4.Location = new System.Drawing.Point(150, 236);
            this.lblQuestion4.Name = "lblQuestion4";
            this.lblQuestion4.Size = new System.Drawing.Size(63, 15);
            this.lblQuestion4.TabIndex = 17;
            this.lblQuestion4.Text = "Headache?";
            // 
            // txtbxQuestion4
            // 
            this.txtbxQuestion4.Location = new System.Drawing.Point(219, 233);
            this.txtbxQuestion4.Name = "txtbxQuestion4";
            this.txtbxQuestion4.Size = new System.Drawing.Size(41, 23);
            this.txtbxQuestion4.TabIndex = 18;
            // 
            // lblQuestion5
            // 
            this.lblQuestion5.AutoSize = true;
            this.lblQuestion5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion5.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion5.Location = new System.Drawing.Point(22, 265);
            this.lblQuestion5.Name = "lblQuestion5";
            this.lblQuestion5.Size = new System.Drawing.Size(422, 15);
            this.lblQuestion5.TabIndex = 19;
            this.lblQuestion5.Text = "Did you have any history of contact with a COVID patient in the last 14 days?";
            // 
            // txtbxQuestion5
            // 
            this.txtbxQuestion5.Location = new System.Drawing.Point(450, 261);
            this.txtbxQuestion5.Name = "txtbxQuestion5";
            this.txtbxQuestion5.Size = new System.Drawing.Size(41, 23);
            this.txtbxQuestion5.TabIndex = 20;
            // 
            // lblQuestion6
            // 
            this.lblQuestion6.AutoSize = true;
            this.lblQuestion6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion6.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion6.Location = new System.Drawing.Point(22, 295);
            this.lblQuestion6.Name = "lblQuestion6";
            this.lblQuestion6.Size = new System.Drawing.Size(276, 15);
            this.lblQuestion6.TabIndex = 21;
            this.lblQuestion6.Text = "Did you go outside the country in the last 14 days?";
            this.lblQuestion6.Click += new System.EventHandler(this.lblQuestion6_Click);
            // 
            // txtbxQuestion6
            // 
            this.txtbxQuestion6.Location = new System.Drawing.Point(304, 291);
            this.txtbxQuestion6.Name = "txtbxQuestion6";
            this.txtbxQuestion6.Size = new System.Drawing.Size(41, 23);
            this.txtbxQuestion6.TabIndex = 22;
            this.txtbxQuestion6.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Snow;
            this.btnSave.Location = new System.Drawing.Point(556, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewForm
            // 
            this.btnNewForm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNewForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewForm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewForm.ForeColor = System.Drawing.Color.Snow;
            this.btnNewForm.Location = new System.Drawing.Point(475, 335);
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.Size = new System.Drawing.Size(75, 24);
            this.btnNewForm.TabIndex = 24;
            this.btnNewForm.Text = "New Form";
            this.btnNewForm.UseVisualStyleBackColor = false;
            this.btnNewForm.Click += new System.EventHandler(this.btnNewForm_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecords.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.Snow;
            this.btnRecords.Location = new System.Drawing.Point(362, 55);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(74, 24);
            this.btnRecords.TabIndex = 27;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(649, 382);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnNewForm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtbxQuestion6);
            this.Controls.Add(this.lblQuestion6);
            this.Controls.Add(this.txtbxQuestion5);
            this.Controls.Add(this.lblQuestion5);
            this.Controls.Add(this.txtbxQuestion4);
            this.Controls.Add(this.lblQuestion4);
            this.Controls.Add(this.txtbxQuestion3);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.txtbxQuestion2);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.txtbxQuestion1);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.txtbxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtbxContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtbxFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnTraceMe);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Snow;
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
        private System.Windows.Forms.TextBox txtbxContactNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtbxDate;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.TextBox txtbxQuestion1;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.TextBox txtbxQuestion2;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.TextBox txtbxQuestion3;
        private System.Windows.Forms.Label lblQuestion4;
        private System.Windows.Forms.TextBox txtbxQuestion4;
        private System.Windows.Forms.Label lblQuestion5;
        private System.Windows.Forms.TextBox txtbxQuestion5;
        private System.Windows.Forms.Label lblQuestion6;
        private System.Windows.Forms.TextBox txtbxQuestion6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewForm;
        private System.Windows.Forms.Button btnRecords;
    }
}

