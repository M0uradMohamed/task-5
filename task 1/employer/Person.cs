using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employer
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public Person(string name, int age , string address, string nationality)
        {
            Name = name;
            Age = age;
            Address = address;
            Nationality = nationality;
        }
    }
}
