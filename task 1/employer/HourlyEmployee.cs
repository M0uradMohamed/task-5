using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employer
{
    internal class HourlyEmployee : Employee
    {

        public int WorkingHours { get; set; }
        public double HoureRate { get; set; }

        public HourlyEmployee(int workingHours, double houreRate,
           double salary, string rank, string job,
            string name, int age, string address, string nationality) 
            : base (salary , rank ,job , 
                  name , age , address , nationality )
        {
            WorkingHours = workingHours;
            HoureRate = houreRate;
        }

    }
}
