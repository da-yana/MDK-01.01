using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int Lenght=Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Lenght];
            for(int index = 0; index < Lenght; index++)
            {
                Console.Write($"Элемент [{index}]: ");
                Array[index] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
