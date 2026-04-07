using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLib
{
    public class SalesAnalizer
    {
            public int LessAVG(List<Product> products) 
            {
                int result = 0;
                double avg = Avg(products);
                foreach (Product sale in products)  
                {
                    int revenue = sale.Price * sale.Quantity;  
                    if (revenue <= avg) 
                    {
                        result += revenue;
                    }
                }
                return result;
            }

            public double Avg(List<Product> products)
            {
                double total = 0; 
                foreach (Product sale in products)
                {
                    total += (sale.Price * sale.Quantity);
                }
                double result = total / products.Count; 
                return result;
            }
    }
}
