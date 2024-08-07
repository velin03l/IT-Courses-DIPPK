using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam1
{
    class School
    {
        private string name;
        private List<Student> students;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }
        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        public School(){}

        public School(string name)
        {
            this.Name = name;
            Students = new List<Student>();
        }
        public void AddStudent(string name, double grade)
        {
            Student novstudent = new Student(name, grade);
            Students.Add(novstudent);
        }
        public double AverageResultInRange(int start, int end)
        {
            List<double> list = new List<double>();
            double avr = 0;
            for (int i = start; i <= end; i++)
            {
                list.Add(this.students[i].Grade);
                avr = avr + list[i];
            }
            avr = avr / list.Count;
            return avr;
        }
        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Grade < grade)
                {
                    list.Add(this.students[i].Name);
                }
            }
            return list.ToList();
        }
        public List<Student> SortAscendingByName()
        {
            IEnumerable<Student> query = this.students.OrderBy(pet => pet.Name).ToList();
            this.students = query.ToList();
            return this.students.ToList();
        }
        public List<Student> SortDescendingByGrade()
        {
            /*for (int i = 0; i < this.students.Count-1; i++)
            {
                for (int j = 0; j < this.students.Count-1; j++)
                {
                    if (this.students[j].Grade < this.students[j + 1].Grade)
                    {
                        Student tmp = this.students[j];
                        this.students[j] = this.students[j + 1];
                        this.students[j + 1] = tmp;
                    }
                }
            }
            return this.students.ToList();*/ //това бях писал аз
            IEnumerable<Student> query = this.students.OrderByDescending(pet => pet.Grade).ToList();
            this.students = query.ToList();
            return this.students.ToList(); //това трябваше да напиша, за да ми даде 100т.
        }
        public bool CheckStudentIsInSchool(string name)
        {
            bool d = false;
            for (int i = 0; i < this.students.Count; i++)
            {
                if (this.students[i].Name == name)
                {
                    d = true;
                }
            }
            return d;
        }
        public string[] ProvideInformationAboutAllStudents()
        {
            List<string> info = new List<string>();
            for (int i = 0; i < Students.Count; i++)
            {
                info.Add(Students[i].ToString());
            }
            return info.ToArray();
        }
    }
}
//90 от 100
