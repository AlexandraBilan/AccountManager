using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    static class SaveLoadHelper
    {
        public static void save(List<Employee> emp)
        {
            StreamWriter str = new StreamWriter("DB.txt");

            foreach (var employee in emp)
            {
                str.Write("{0} {1} {2} {3};", employee._name, employee._midname, employee._surname,  employee.Salary);
            }
            str.Close();
        }

        public static List<Employee> load()
        {
            List<Employee> lStaff = new List<Employee>();
            using (StreamReader reader = new StreamReader(new FileStream("DB.txt", FileMode.Open)))
            {
                foreach (string s in reader.ReadToEnd().Split(';'))
                {
                    if (s != "")
                    {
                        Employee emp = new Employee(s.Split(' ')[0], s.Split(' ')[1], s.Split(' ')[2], Int32.Parse(s.Split(' ')[3]));
                        lStaff.Add(emp);
                    }
                }
            }
            return lStaff;
        }
    }
}
