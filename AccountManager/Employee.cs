using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManager
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Midname { get; set; }

        public int Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string midname, string surname)
        {
            Name = name;
            Midname= midname;
            Surname = surname;
           
        }

        public Employee(string name, string midname, string surname,  int salary):this(name, midname, surname)
        {
            Salary = salary;
        }
    }
}
