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

            string[] a = new string[3];
            a[0] = array[2];
            a[1] = array[1];
            a[2] = array[0];
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);

            int[] c = new int[10000] ;

            for (int i = 0; i < c.Length; i++)
            {
                c[i] = (i+1)*2;

            }
            Console.Write("[");
            for (int i = 0; i < c.Length -1; i++)
            {
                
                    Console.Write(c[i]  + ",");
            }
            Console.Write(c.Length*2);
            Console.Write( "]");

            


        }
    }
}
