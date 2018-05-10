using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        //Data members
        private string program;
        private int year;
        private double fee;

        //Properties
        public string Program
        {
            set { program = value; }
            get { return program; }

        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Fee
        {
            set { fee = value; }
            get { return fee; }
        }

        //default constructors
        public Student()
        {
            Address = "1570 Wodward Ave, Detroit, MI, 48202";
        }

        //overloaded
        public Student(string n, string a, string p, int y, double f) : base(n, a)
        {
            program = p;
            year = y;

        }
        //method
        public override string ToString()
        {
            return base.ToString() + $" Program = {Program} Year = {Year} Fee = {Fee}";
        }
    }

        }
   
   
