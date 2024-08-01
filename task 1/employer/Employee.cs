using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employer
{
    internal class Employee : Person
    {

        public double Salary { get; set; }
        public string Rank { get; set; }
        public string Job { get; set; }

        public Employee(double salary, string rank, string job ,
            string name, int age, string address, string nationality) 
            : base( name,  age,  address, nationality)
        {
            Salary = salary;
            Rank = rank;
            Job = job;
        }

    }
}
