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
            dictionary.Add("cat", new List<string>() { "Black", "white", "blue"});
            dictionary.Add("dog", new List<string>() {"Brown", "yellow" });
            dictionary.Add("bear", new List<string>() {"Dark brown" });

        }
        
    }
}
