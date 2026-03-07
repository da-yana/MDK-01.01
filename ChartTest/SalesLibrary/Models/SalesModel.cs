using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesLibrary.Models
{
    public class SalesModel
    {
        private Dictionary<Item, List<Sale>> salesByItems_ =
            new Dictionary<Item, List<Sale>>();

        public void AddSales(Item item, List<Sale> sales)
        {
            if (salesByItems_.ContainsKey(item))
            {
                salesByItems_[item].AddRange(sales);
            }
            else
            {
                salesByItems_.Add(item, sales);
            }
        }

        /// <summary>
        /// метод используется для получения информации обо всех продажах
        /// элемента item
        /// </summary>
        /// <param name="item">Конкретный объект (то, что продается)</param>
        /// <returns>Список всех продаж</returns>
        public List<Sale> LoadSalesForItem(string itemName)
        {
            List<Item> allItems = salesByItems_.Keys.ToList();
            Item targetItem = allItems.Find(item => item.Name == itemName);
            if (targetItem != null)
            {
                return salesByItems_[targetItem];
            }

            return new List<Sale>();
        }

        public bool Load()
        {
            AddSales(new Item { Name = "Конфетки Заоблачные", Price = 100 },
                new List<Sale>() { 
                    new Sale {Time = new System.DateTime(2026, 2, 1), Count = 10 } ,
                    new Sale {Time = new System.DateTime(2026, 2, 2), Count = 20 },
                    new Sale {Time = new System.DateTime(2026, 2, 3), Count = 30 },
                    new Sale {Time = new System.DateTime(2026, 2, 4), Count = 40 },
                    new Sale {Time = new System.DateTime(2026, 2, 5), Count = 50 },
                    new Sale {Time = new System.DateTime(2026, 2, 6), Count = 60 },
                    new Sale {Time = new System.DateTime(2026, 2, 7), Count = 70 },
                    new Sale {Time = new System.DateTime(2026, 2, 8), Count = 55 },
                    new Sale {Time = new System.DateTime(2026, 2, 9), Count = 35 },
                    new Sale {Time = new System.DateTime(2026, 2, 10), Count = 1 },
                });

            AddSales(new Item { Name = "Зефирка Воздушная", Price = 200 },
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 2, 1), Count = 15 } ,
                    new Sale {Time = new System.DateTime(2026, 2, 2), Count = 25 },
                    new Sale {Time = new System.DateTime(2026, 2, 3), Count = 31 },
                    new Sale {Time = new System.DateTime(2026, 2, 10), Count = 2 },
                    new Sale {Time = new System.DateTime(2026, 3, 1), Count = 35 },
               });

            return true;
        }

        public List<Item> GetAllItems()
        {
            return salesByItems_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach(KeyValuePair<Item, List<Sale>> keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * item.Price);
            }

            return result;
        }

        public Item GetItem(string itemName)
        {
            foreach (KeyValuePair<Item, List<Sale>> keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                if(item.Name == itemName)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
