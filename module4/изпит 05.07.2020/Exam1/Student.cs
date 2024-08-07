using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam1
{
    class Student
    {
        private string name;
        private double grade;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Grade
        {
            set { this.grade = value; }
            get { return this.grade; }
        }
        public Student()
        {

        }
        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
        public override string ToString()
        {
            return $"Student {this.Name} has {this.Grade:F2}.";
        }
    }
}
