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
            comboBox1.Items.AddRange(new
                object[]
            {
                "BS in Computer Science",
                "BS in Information Technology",
                "BS information System",
                "BS in Computer Engineering"
            });
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("lagay mo naman First name mo nak nang teteng ohh!!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("lagay mo naman Middle name mo nak nang teteng ohh!!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("lagay mo naman last name mo nak nang teteng ohh!!");
                textBox1.Focus();
                return;

            }

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("lagay mo naman address name mo nak nang teteng ohh!!");
                textBox1.Focus();
                return;
            }


            // para dun sa mga numeric 
            if (!long.TryParse(textBox2.Text, out var StuNum))
            {
                MessageBox.Show("Enter valid Student number");
                textBox2.Focus();
                return;
            }
            if (!long.TryParse(textBox7.Text, out var ContNum))
            {
                MessageBox.Show("Enter valid Contact Number");
                textBox7.Focus();
                return;
            }
            if (!long.TryParse(textBox5.Text, out var Age))
            {
                MessageBox.Show("Enter valid age");
                textBox5.Focus();
                return;

            }




            //set static values
            StudentInfoClass.StuNum = StuNum;
            StudentInfoClass.Program = comboBox1.Text;
            StudentInfoClass.Fname = textBox1.Text.Trim();
            StudentInfoClass.Mname = textBox4.Text.Trim();
            StudentInfoClass.Lname = textBox3.Text.Trim();
            StudentInfoClass.ContNum = ContNum;
            StudentInfoClass.Address = textBox6.Text.Trim();
            StudentInfoClass.Age = Age;



            // kung approve ba kay form 1 para maka tuloy ka kay form 2
            using (var form = new Form2())
            {

                var result = form.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(" Submitted Successfully");
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox tb) tb.Clear();
                    }
                    textBox2.Focus();

                }
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
