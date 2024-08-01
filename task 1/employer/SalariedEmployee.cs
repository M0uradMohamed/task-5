using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employer
{
    internal class SalariedEmployee : Employee
    {

        public double Bonus { get; set; }
        public double Deductions { get; set; }

        public SalariedEmployee (double bonus, double deductions ,
            double salary, string rank, string job,
            string name, int age, string address, string nationality)
            : base(salary, rank, job,
                   name, age, address, nationality)
        {
            Bonus = bonus;
            Deductions = deductions;
        }

    }
}
