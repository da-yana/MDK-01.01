using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShops
{
    public class Recipe
    {
        public List<Products> products = new List<Products>();
    }
    public void Recipe()
    {

        Products potato = new Products
        {
            Name = "Пирожное Картошка",
            Price = 80,
            Expiry = DateTime.Now.AddDays(2),
            ingredients = new List<Ingredients>()
        };

        Ingredients ing1 = new Ingredients
        {
            Name = "Печенье",
            Quantity = 150
        };

        Ingredients ing2 = new Ingredients
        {
            Name = "Сгущенка",
            Quantity = 50
        };

        Ingredients ing3 = new Ingredients
        {
            Name = "Масло",
            Quantity = 30
        };

        Products honey = new Products
        {
            Name = "Торт Медовик",
            Price = 350,
            Expiry = DateTime.Now.AddDays(3),
            ingredients = new List<Ingredients>()
        };

        Ingredients h1 = new Ingredients
        {
            Name = "Мука",
            Quantity = 200
        };

        Ingredients h2 = new Ingredients
        {
            Name = "Мед",
            Quantity = 100
        };

        Ingredients h3 = new Ingredients
        {
            Name = "Яйца",
            Quantity = 2
        };

        Ingredients h4 = new Ingredients
        {
            Name = "Сметана",
            Quantity = 300
        };

    }
}
