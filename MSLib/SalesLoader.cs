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
        List <Product> Sales = new List <Product> ();
        public List <Product> Load (string path)
        {
            List <Product> products = new List<Product> ();
            StreamReader reader = new StreamReader (path);  
            reader.ReadLine ();
            string line; 
            while ((line = reader.ReadLine ()) != null)
            {
                string[] ProductInf = line.Split (' ');
                string name_ = ProductInf[0];
                int price = Convert.ToInt32(ProductInf[1]);
                int quantity = Convert.ToInt32(ProductInf[2]);
                Product product = new Product (name_, price, quantity);
                Sales.Add(product); 
            }
            return Sales;
        }
    }
}
