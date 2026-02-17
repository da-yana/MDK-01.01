using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShops
{
    public class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime Expiry { get; set; }
        public List<Ingredients> ingredients { get; set; }
    }


}
