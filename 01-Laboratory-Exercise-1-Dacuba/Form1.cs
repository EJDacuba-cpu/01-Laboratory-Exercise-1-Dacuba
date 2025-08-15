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
            // ARRAY NG PROGRAM
            comboBox1.Items.Add("BSIT");
            comboBox1.Items.Add("BSCS");
            comboBox1.Items.Add("BSEDUC");
            comboBox1.Items.Add("BS");
            comboBox1.Items.Add("BS");
            comboBox1.Items.Add("BBC");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set ng static variables 
            StudentInfoClass.Fname = textBox1.Text;
            StudentInfoClass.Mname = textBox4.Text;
            StudentInfoClass.Lname = textBox3.Text;
            StudentInfoClass.Address = textBox6.Text;
            StudentInfoClass.StuNum = long.Parse(textBox2.Text);
            StudentInfoClass.ContNum = long.Parse(textBox7.Text);
            StudentInfoClass.Age = long.Parse(textBox5.Text);

            if (comboBox1.SelectedItem != null)
            {
                StudentInfoClass.Program = comboBox1.SelectedItem.ToString();
            }

 

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
    }
}
