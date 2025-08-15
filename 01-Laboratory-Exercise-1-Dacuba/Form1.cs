using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Laboratory_Exercise_1_Dacuba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // list Ng Course
            comboBox1.Items.Add("BSIT");
            comboBox1.Items.Add("BSCS");
            comboBox1.Items.Add("BSEDUC");
            comboBox1.Items.Add("BS");
            comboBox1.Items.Add("BS");
            comboBox1.Items.Add("BBC");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please Enter Your First name");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please Enter Your Middle Name");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please Enter Your Last Name");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please Enter your Address");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please Enter your Student Number");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please Enter your Contact Number");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please Enter your Age");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Ah di mo alam Program mo?");
                return;

                



            }
            // para dun sa mga numeric 
            if (!long.TryParse(textBox2.Text, out StudentInfoClass.StuNum))
            {
                MessageBox.Show("invalid Student Number");
                return;
            }

            if (!long.TryParse(textBox7.Text, out StudentInfoClass.ContNum))
            {
                MessageBox.Show("invalid Contact Number");
                return;
            }

            if (!long.TryParse(textBox5.Text, out StudentInfoClass.Age))
            {
                MessageBox.Show("invalid Age");
                return;
            }

            //set ng values
            StudentInfoClass.Fname = textBox1.Text;
            StudentInfoClass.Mname = textBox4.Text;
            StudentInfoClass.Lname = textBox3.Text;
            StudentInfoClass.Address = textBox6.Text;
            StudentInfoClass.Program = comboBox1.SelectedItem.ToString();





            // kung approve ba kay form 1 para maka tuloy ka kay form 2
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(" Submitted na boooooyy!!!!");

            }
        }    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
