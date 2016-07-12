using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManager
{
    class Employee
    {
        public readonly string _name;
        public readonly string _surname;
        public readonly string _midname;
        private int _salary;

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }

        public Employee(string name, string midname, string surname)
        {
            _name = name;
            _midname = midname;
            _surname = surname;
           
        }

        public Employee(string name, string midname, string surname,  int salary):this(name, midname, surname)
        {
            _salary = salary;
        }
    }
}
