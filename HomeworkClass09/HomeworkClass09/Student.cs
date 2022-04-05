using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass09
{
    internal class Student
    {
        public string Name { get; set; }
        public string CurrentSubject { get; set; }
        public int Grades { get; set; }
        public Student(string name, string currentSubject, int grades)
        {
            Name = name;
            CurrentSubject = currentSubject;
            Grades = grades;
        }
    }
}
