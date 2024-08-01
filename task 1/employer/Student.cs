using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employer
{
    internal class Student : Person
    {

        public int StudyLevel { get; set; }
        public string Specialization { get; set; }
        public double GPA { get; set; }
        public Student(int studyLevel, string specialization, double gPA ,
            string name , int age , string address , string nationality ) 
            : base ( name , age , address , nationality)
        {
            StudyLevel = studyLevel;
            Specialization = specialization;
            GPA = gPA;
        }
    }
}
