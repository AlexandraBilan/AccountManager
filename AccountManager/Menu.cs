using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManager
{
    class Menu
    {
        private Staff _staff;
        private bool _isEnd;

        public Menu()
        {
            _staff = new Staff(load());
            _isEnd = false;
        }

        public void runProgramm()
        {
            while (!_isEnd)
            {
                try {
                    printHello();
                    printMenu();
                    int choose = Int32.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 0:
                            _isEnd = true;
                            break;
                        case 1:
                            addEmployee();
                            break;
                        case 2:
                            showAll();
                            break;
                        case 3:
                            deleteEmp();
                            break;
                        case 4:
                            changeEmp();
                            break;
                        case 5:
                            save();
                            break;
                        case 6:
                            total();
                            break;
                        default: break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void printHello()
        {
            Console.WriteLine("Здравствуйте. \nЭто альфа-версия программы по учету сотрудников и их заработной плате. \nПожалуйста, выберите, что вы хотите сделать.");
        }

        private void printMenu()
        {
            Console.WriteLine("1. Добавить сотрудника.");
            Console.WriteLine("2. Показать список сотрудников.");
            Console.WriteLine("3. Удалить сотрудника.");
            Console.WriteLine("4. Сменить зарплату сотрудника.");
            Console.WriteLine("5. Сохранить список в файл.");
            Console.WriteLine("6. Показать сумму з/п всех сотрудников.");
            Console.WriteLine("0. Выйти из программы.");
        }

        private void showAll()
        {
            foreach (var emp in _staff.Employees)
            {
                Console.WriteLine("{0} {1} {2} имеет зарплату в {3} рублей.", emp.Name, emp.Midname, emp.Surname, emp.Salary);
            }
        }

        private void addEmployee()
        {
            Console.WriteLine("Введите имя, отчество, фамилию и зарплату сотрудника через ВВОД");
            string name = Console.ReadLine();
            string midname = Console.ReadLine();
            string surname = Console.ReadLine();
            int salary = Int32.Parse(Console.ReadLine());
            _staff.addEmployee(name, midname, surname, salary);
        }
        private void deleteEmp()
        {
            Console.WriteLine("Введите имя, отчество и фамилию сотрудника, которого вы хотите удалить.\nВводить через ВВОД");
            string name = Console.ReadLine();
            string midname = Console.ReadLine();
            string surname = Console.ReadLine();
            _staff.deleteEmployee(name, midname, surname);
        }
        private void changeEmp()
        {
            Console.WriteLine("Введите имя и фамилию сотрудника, которому вы хотите изменить зарплату.\nВводить через ВВОД");
            string name = Console.ReadLine();
            string midname = Console.ReadLine();
            string surname = Console.ReadLine();
            int salary = Int32.Parse(Console.ReadLine());
            _staff.changeSalary(name, midname, surname, salary);
        }

        private void save()
        {
            Console.WriteLine("Сохраняю....");
            SaveLoadHelper.save(_staff.Employees);
        }

        private List<Employee> load()
        {
            return SaveLoadHelper.load();          
        }

        private void total()
        {
            Console.WriteLine("Итоговая зарплата {0} рублей.", _staff.TotalSalary);
        }

    }
}
