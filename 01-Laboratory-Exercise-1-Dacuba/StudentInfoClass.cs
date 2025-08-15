using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _01_Laboratory_Exercise_1_Dacuba
{
    public delegate string DelString(string value);
    public delegate long DelLong(long value);
    internal class StudentInfoClass
    {
        // Table Variable
        public static string 
            Fname, Lname, Mname, Address,Program;
        public static long Age, ContNum, StuNum;

        //return type method
        public static string
            GetFirstName(string Fname)
        {  return Fname; }

        public static string 
            GetLastName(string Lname)
        { return Fname; }

        public static string
            GetMiddleName(string Mname)
        {  return Mname; }

        public static string
            GetAddress(string Address)
        { return Address; }

        public static string
    GetProgram(string program)
        { return program; }

        public static long
            GetAge(long Age) 
        { return Age; }

        public static long
            GetContactNumber(long ContNum)  
        { return ContNum; }

        public static long
            GetStudentNumber(long StuNum)
        { return StuNum; }

    }
}
