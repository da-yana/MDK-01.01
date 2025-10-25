using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaru
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            dictionary.Add("кошка", new List<string>() { "Вслоухая", "Сфинкс", "Русская голубая" });
            dictionary.Add("собаки", new List<string>() { "Дворовая", "Чихуахуаа" });
            dictionary.Add("медведи", new List<string>() { "Бурый" });

          
            
                Console.Write(string.Join(" , ", dictionary.Keys)); 
            


        }

    }
}
