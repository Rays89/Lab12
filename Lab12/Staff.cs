using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff:Person
    {

        //Data members 
        private string school;
        private double pay;

        //Properties
        public string School
        {
            set { school = value; }
            get { return school;  }
        }

        public double Pay
        {
            set { pay = value; }
            get { return pay;  }
        }

        //default constructors
        public Staff(string n, string a, string s, double p):base(n, a)
        {
            school = s;
            pay = p;
        }

        //overloaded constructor

        public override string ToString()
        {
            return base.ToString() + $" School = {School} pay {pay}";
        }

    }
}
