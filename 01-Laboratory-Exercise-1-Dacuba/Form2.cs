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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // PARA MA DISPLAY YUNG ANO BAWAT PIECE NG INFO
            label1.Text = StudentInfoClass.Fname;
            label2.Text = StudentInfoClass.Mname;
            label3.Text = StudentInfoClass.Lname;
            label4.Text = StudentInfoClass.Address;
            label5.Text = StudentInfoClass.ContNum.ToString();
            label6.Text = StudentInfoClass.StuNum.ToString();
            label7.Text = StudentInfoClass.Age.ToString();
            label8.Text = StudentInfoClass.Program.ToString();
 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
