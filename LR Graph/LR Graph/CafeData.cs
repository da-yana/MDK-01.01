using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Graph
{
    public class CafeData
    {
        public List<Drink> Drinks { get; private set; }
        public List<Sale> Sales { get; private set; }

        public CafeData()
        {
            Drinks = new List<Drink>();
            Sales = new List<Sale>();
            InitializeData();
        }

        private void InitializeData()
        {

            Drinks.Add(new Drink(1, "Кофе", 120));
            Drinks.Add(new Drink(2, "Чай", 40));
            Drinks.Add(new Drink(3, "Сок", 100));
            Drinks.Add(new Drink(6, "Морс", 80));

            Sales.Add(new Sale(1, new DateTime(2026, 3, 10), 15));
            Sales.Add(new Sale(1, new DateTime(2026, 3, 11), 12));
            Sales.Add(new Sale(1, new DateTime(2026, 3, 12), 18));
            Sales.Add(new Sale(1, new DateTime(2026, 3, 13), 20));
            Sales.Add(new Sale(1, new DateTime(2026, 3, 14), 16));

            Sales.Add(new Sale(2, new DateTime(2026, 3, 10), 10));
            Sales.Add(new Sale(2, new DateTime(2026, 3, 11), 8));
            Sales.Add(new Sale(2, new DateTime(2026, 3, 12), 12));
            Sales.Add(new Sale(2, new DateTime(2026, 3, 13), 15));
            Sales.Add(new Sale(2, new DateTime(2026, 3, 14), 11));
            Sales.Add(new Sale(2, new DateTime(2026, 3, 15), 9));

            Sales.Add(new Sale(3, new DateTime(2026, 3, 10), 5));
            Sales.Add(new Sale(3, new DateTime(2026, 3, 11), 7));
            Sales.Add(new Sale(3, new DateTime(2024, 3, 15), 4));

            Sales.Add(new Sale(6, new DateTime(2026, 3, 10), 4));
            Sales.Add(new Sale(6, new DateTime(2026, 3, 11), 3));
            Sales.Add(new Sale(6, new DateTime(2026, 3, 12), 5));
            Sales.Add(new Sale(6, new DateTime(2026, 3, 13), 6));
        }

        public List<Sale> GetSalesForDrink(int drinkId)
        {
            return Sales.Where(s => s.DrinkId == drinkId).ToList();
        }

        public Dictionary<string, decimal> GetRevenueByDrink()
        {
            var revenue = new Dictionary<string, decimal>();

            foreach (var drink in Drinks)
            {
                decimal totalRevenue = Sales
                    .Where(s => s.DrinkId == drink.Id)
                    .Sum(s => s.Quantity * drink.Price);

                revenue.Add(drink.Name, totalRevenue);
            }

            return revenue;
        }
    }
}
