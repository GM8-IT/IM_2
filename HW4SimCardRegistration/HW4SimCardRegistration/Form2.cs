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
    public partial class Form2 : Form
    {
        public Form2(String NumBox1, String Fname1, String Lname1,String Gender1,String Status1, DateTime DateTime1,String Loc1,Image pic1)
        {
            InitializeComponent();
            NumBox2.Text = NumBox1;
            Fname2.Text = Fname1;
            Lname2.Text = Lname1;
            dateTimePicker1.Value = DateTime1;
            textBox4.Text = Loc1;
            pictureBox1.Image = pic1;


            if(Gender1 == "Male")
            {
                MaleBtn.Checked = true;
            }else if(Gender1 == "Female")
            {
                FemaleBtn.Checked = true;
            }
            if (StatusBox.Items.Contains(Status1))
            {
                StatusBox.SelectedItem = Status1;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void NumBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Fname2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname2_TextChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
