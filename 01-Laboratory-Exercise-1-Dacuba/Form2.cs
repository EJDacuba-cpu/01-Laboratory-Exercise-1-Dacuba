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
        private readonly DelString DelFirstName;
        private readonly DelString DelMiddleName;
        private readonly DelString DelLastName;
        private readonly DelString DelProgram;
        private readonly DelString DelAddress;

        private readonly DelLong DelAge;
        private readonly DelLong DelContactnum;
        private readonly DelLong DelStudentnum;
        public Form2()
        {
            InitializeComponent();
            DelFirstName = StudentInfoClass.GetFirstName;
            DelMiddleName = StudentInfoClass.GetMiddleName;
            DelLastName = StudentInfoClass.GetLastName;
            DelProgram = StudentInfoClass.GetProgram;
            DelAddress = StudentInfoClass.GetAddress;


            DelAge =  StudentInfoClass.GetAge;
            DelContactnum = StudentInfoClass.GetContactNumber;
            DelStudentnum = StudentInfoClass.GetStudentNumber;
 
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // call Delegates to pass static table values
            label1.Text = DelFirstName(StudentInfoClass.Fname); 
            label2.Text = DelMiddleName(StudentInfoClass.Mname);
            label3.Text = DelLastName(StudentInfoClass.Lname);
            label4.Text = DelAddress(StudentInfoClass.Address);
            label5.Text = DelContactnum(StudentInfoClass.ContNum).ToString();
            label6.Text = DelStudentnum(StudentInfoClass.StuNum).ToString();
            label7.Text = DelAge(StudentInfoClass.Age).ToString();
            label8.Text = DelProgram(StudentInfoClass.Program).ToString();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
