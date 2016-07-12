using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                menu.runProgramm();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }
    }
}
