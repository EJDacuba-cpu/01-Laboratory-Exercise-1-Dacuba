using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _01_Laboratory_Exercise_1_Dacuba
{
    internal class StudentInfoClass
    {
        public delegate string
            DelegateText(string value);
        public delegate long 
            DelegateNUmber(long value);

        public static string Fname, Lname, Mname, Address;
        public static long Age, ContNum, StuNum;
        public static string Program { get; set; }

        public static string
            GetFirstName(string Fname)
        {  return Fname; }

        public static string 
            GetLastName(string Fname)
        { return Fname; }

        public static string
            GetMiddleName(string Mname)
        {  return Mname; }

        public static string
            GetAddress(string Address)
        { return Address; }

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
