using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>()
            {
                {"name", "Cayce"},
                {"age", "41"}
            });
            myFamily.Add("firstBorn", new Dictionary<string, string>(){
                { "name", "Maximus"},
                { "age", "15"}
            });
            myFamily.Add("secondBorn", new Dictionary<string, string>(){
                { "name", "Matthias"},
                { "age", "13"}
            });
            myFamily.Add("dog", new Dictionary<string, string>(){
                { "name", "Eleanor"},
                { "age", "7"}
            });

            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key}.");
            }

            Console.Read();
        }
    }
}
