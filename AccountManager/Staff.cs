using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManager
{
    class Staff
    {
        private List<Employee> _employees;

        public int TotalSalary
        {
            get
            {
                int totalSalary = 0;
                foreach (var employee in _employees)
                {
                    totalSalary += employee.Salary;
                }
                return totalSalary;
            }
        }

        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }

        public Staff()
        {
            _employees = new List<Employee>();
        }

        public Staff(List<Employee> employees)
        {
            _employees = employees;
        }

        public void addEmployee(string name, string midname, string surname, int salary)
        {
            Employee newEmployee = new Employee(name, midname, surname, salary);
            _employees.Add(newEmployee);
        }

        public void addEmployee(Employee newEmployee)
        {
            _employees.Add(newEmployee);
        }

        private Employee search(string name, string midname, string surname)
        {
            return _employees.Single(emp => emp.Name == name && emp.Midname == midname && emp.Surname == surname);
        }

        public void deleteEmployee(string name, string midname, string surname)
        {
            var employerToDelete = search(name, midname, surname);
            _employees.Remove(employerToDelete);
        }

        public void deleteEmployee(Employee employeeToDelete)
        {
            _employees.Remove(employeeToDelete);
        }

        public void changeSalary(string name, string midname, string surname, int salary)
        {
            var employerToChange = search(name, midname, surname);
            employerToChange.Salary = salary;
        }


    }
}
