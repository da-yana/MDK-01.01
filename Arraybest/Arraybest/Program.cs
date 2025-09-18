using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraybest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3] {"кот", "собака", "попугай"};
            array[2] = "хомяк";
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
        }
    }
}
