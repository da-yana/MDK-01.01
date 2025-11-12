using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sale = new (DateTime Data, string Model, int Quantity, int Price)[]
            {
               (new DateTime(2025, 11, 9), "iPhone 17", 7, 110000),
               (new DateTime(2025, 11, 9), "Xiaomi Redmi Note 14", 5, 16200),
               (new DateTime(2025, 11, 10), "iPhone 16 Pro", 4, 98800),
               (new DateTime(2025, 11, 10), "Samsung S25 Ultra", 2, 75000),
               (new DateTime(2025, 11, 11), "HONOR X9d", 1, 29990),
               (new DateTime(2025, 11, 11), "iPhone 17 Pro Max", 9, 173000),
               (new DateTime(2025, 11, 12), "Tecno CAMON 40", 3, 17500),
            };
            int sum = 0;
            foreach (var i in sale)
            {
                sum += i.Quantity * i.Price;
            }
            Console.WriteLine($"Общая сумма проданных телефонов за весь период: " + sum);

            int maxQuantity = 0;
            string popularFhone = "";
        }
    }
}
