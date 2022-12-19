using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Defining_Classes_Advanced_Exercises
{
    public class Employee
    {
        private string name;
        private int age;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}