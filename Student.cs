using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record_Management
{
    internal class Student
    {
        // Properties to store student ID, name, and mark
        public int ID { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }

        // Constructor to initialize a student object
        public Student(int id, string name, double mark)
        {
            ID = id;
            Name = name;
            Mark = mark;
        }

        // ToString() for easy display in ListBox
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Mark: {Mark}"; // This makes it easy to show student info as a string
        }
    }
}
