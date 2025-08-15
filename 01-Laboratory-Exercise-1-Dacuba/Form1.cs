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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set ng static variables 
            StudentInfoClass.Fname = textBox1.Text;
            StudentInfoClass.Mname = textBox4.Text;
            StudentInfoClass.Lname = textBox3.Text;
            StudentInfoClass.Address = textBox6.Text;
            StudentInfoClass.Program = comboBox1.Text;
            StudentInfoClass.StuNum = long.Parse(textBox2.Text);
            StudentInfoClass.ContNum = long.Parse(textBox7.Text);
            StudentInfoClass.Age = long.Parse(textBox5.Text);

            Form2 ConfirmForm =  new Form2();
            ConfirmForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
