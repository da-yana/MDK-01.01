using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Graph
{
    public class Sale
    {
        public int DrinkId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public Sale(int drinkId, DateTime date, int quantity)
        {
            DrinkId = drinkId;
            Date = date;
            Quantity = quantity;
        }
    }
}
