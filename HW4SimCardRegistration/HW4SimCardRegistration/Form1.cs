using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4SimCardRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select an image";
            openFile.Filter = "Image Files|*.jpg;*.jepg;*.png;*";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void NumBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FemaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            String NumBox1 = NumBox.Text;
            String Fname1 = textBox3.Text;
            String Lname1 = textBox2.Text;
            String Gender1 = "";
            String Status1 = StatusBox.SelectedItem.ToString();
            DateTime DateTime1 = dateTimePicker1.Value;
            String Loc1 = textBox4.Text;
            Image pic = pictureBox1.Image;
            if (MaleBtn.Checked)
            {
                Gender1 = "Male";
            }else if (FemaleBtn.Checked)
            {
                Gender1 = "Female";
            }

            Form2 form2 = new Form2(NumBox1,Fname1,Lname1,Gender1,Status1,DateTime1,Loc1,pic);
            form2.Show();
        }
    }
}
