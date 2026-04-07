using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLib
{
    public class SalesLoader
    {
        private List<Product> products_ = new List<Product>();

        public List<Product> ReadAllFromFile()
        {
            string path = @".\MSTest.txt";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                products_.Add(new Product
                {
                    Name = lines[0],
                    Price = Convert.ToInt32(lines[1]),
                    Quantity = Convert.ToInt32(lines[2])
                });
            }
            info.Close();
            return products_;
        }
    }
}
