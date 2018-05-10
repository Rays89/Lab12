using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        //Data members 
        private string name;
        private string address;

        //Properties

        public string Name
        {
            set { name = value; }
            get { return address;  }
        }

        public string Address
        {
            set { address = value; }
            get { return address;  }
        }

        //default constructor

        public Person()
        {
            Address = "1570 Woodward Ave, Detroit, MI, 48202";
        }

        //overloaded constructor

        public Person(string n, string a)
        {
            name = n;
            address = a;
        }

        //method
        public override string ToString()
        {
            return  $"Name = {Name} Address = {Address}";
        }

       
    }
}
