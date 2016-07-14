using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AccountManager
{
    static class SaveLoadHelper
    {
        public static string file = "DB.json";
        
        public static void save(List<Employee> emp)
        {
            string json = JsonConvert.SerializeObject(emp);

            File.WriteAllText(file, json);
        }

        public static List<Employee> load()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(file));
        }
    }
}
