﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisiTrace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFullName.Hide();
            txtbxFullName.Hide();
            lblAddress.Hide();
            txtbxAddress.Hide();
            lblContactNo.Hide();
            txtbxContactNo.Hide();
            lblDate.Hide();
            txtbxDate.Hide();
            lblQuestion1.Hide();
            txtbxQuestion1.Hide();
            lblQuestion2.Hide();
            txtbxQuestion2.Hide();
            lblQuestion3.Hide();
            txtbxQuestion3.Hide();
            lblQuestion4.Hide();
            txtbxQuestion4.Hide();
            lblQuestion5.Hide();
            txtbxQuestion5.Hide();
            lblQuestion6.Hide();
            txtbxQuestion6.Hide();
            btnSave.Hide();
            btnNewForm.Hide();
            RecordList.Hide();
            lblSpecifyDate.Hide();
            txtbxSearch.Hide();
            btnSearch.Hide();
            lblMonth.Hide();
            lblDay.Hide();
            lblYear.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            lblFullName.Show();
            txtbxFullName.Show();
            lblAddress.Show();
            txtbxAddress.Show();
            lblContactNo.Show();
            txtbxContactNo.Show();
            lblDate.Show();
            txtbxDate.Show();
            lblQuestion1.Show();
            txtbxQuestion1.Show();
            lblQuestion2.Show();
            txtbxQuestion2.Show();
            lblQuestion3.Show();
            txtbxQuestion3.Show();
            lblQuestion4.Show();
            txtbxQuestion4.Show();
            lblQuestion5.Show();
            txtbxQuestion5.Show();
            lblQuestion6.Show();
            txtbxQuestion6.Show();
            btnNewForm.Show();
            btnSave.Show();
            RecordList.Hide();
            lblSpecifyDate.Hide();
            txtbxSearch.Hide();
            btnSearch.Hide();
            lblMonth.Show();
            lblDay.Show();
            lblYear.Show();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuestion6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxContactNo_TextChanged(object sender, EventArgs e)
        {

        }
        private void RecordListtry_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader record = new StreamReader(Application.StartupPath + "\\Records\\" + "June 24, 2022.txt");
            StreamReader list = new StreamReader(Application.StartupPath + "\\Records\\" + "June 25, 2022.txt");
            String line = record.ReadLine();
            RecordList.Items.Add(record.ReadToEnd());
            RecordList.Text = list.ReadToEnd();
            record.Close();
            list.Close();
        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            RecordList.Show();
            lblSpecifyDate.Show();
            txtbxSearch.Show();
            btnSearch.Show();
            lblFullName.Hide();
            txtbxFullName.Hide();
            lblAddress.Hide();
            txtbxAddress.Hide();
            lblContactNo.Hide();
            txtbxContactNo.Hide();
            lblDate.Hide();
            txtbxDate.Hide();
            lblQuestion1.Hide();
            txtbxQuestion1.Hide();
            lblQuestion2.Hide();
            txtbxQuestion2.Hide();
            lblQuestion3.Hide();
            txtbxQuestion3.Hide();
            lblQuestion4.Hide();
            txtbxQuestion4.Hide();
            lblQuestion5.Hide();
            txtbxQuestion5.Hide();
            lblQuestion6.Hide();
            txtbxQuestion6.Hide();
            btnSave.Hide();
            btnNewForm.Hide();
            lblYear.Hide();
            lblMonth.Hide();
            lblDay.Hide();

          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter save = File.AppendText(Application.StartupPath +"\\Records\\"+txtbxDate.Text+".txt");

            save.WriteLine("Name: " + txtbxFullName.Text);
            save.WriteLine("Contact Number: " + txtbxContactNo.Text);
            save.WriteLine("Address: " + txtbxAddress.Text);
            save.WriteLine("Date: " + txtbxDate.Text);
            save.WriteLine("Fever? " + txtbxQuestion1.Text);
            save.WriteLine("Cough? " + txtbxQuestion2.Text);
            save.WriteLine("Sore Throat? " + txtbxQuestion3.Text);
            save.WriteLine("Headache? " + txtbxQuestion4.Text);
            save.WriteLine("COVID contact? " + txtbxQuestion5.Text);
            save.WriteLine("Gone outside the country? " + txtbxQuestion6.Text);
            save.WriteLine("");
            save.Close();

            MessageBox.Show("Saved!");
            RecordList.Items.Add(txtbxFullName.Text);
            RecordList.Items.Add(txtbxAddress.Text);
            RecordList.Items.Add(txtbxDate.Text);
            RecordList.Items.Add(txtbxContactNo.Text);
            RecordList.Items.Add("");
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            txtbxFullName.Clear();
            txtbxContactNo.Clear();
            txtbxAddress.Clear();
            txtbxDate.Clear();
            txtbxQuestion1.Clear();
            txtbxQuestion2.Clear();
            txtbxQuestion3.Clear();
            txtbxQuestion4.Clear();
            txtbxQuestion5.Clear();
            txtbxQuestion6.Clear();

        }



       
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Application.StartupPath + "\\Records\\" + txtbxDate.Text + ".txt");
            RecordList.Text = reader.ReadToEnd();
            reader.Close();
        }
    }
}
       