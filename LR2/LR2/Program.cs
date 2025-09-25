    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Main()
        {
            int[] Array = new int[1990];
            int n = 10;
            for(int i = 0; i < 1990; i++)
            {
                Array[i] = n;
                ++n;
            }
        }
    }
}
