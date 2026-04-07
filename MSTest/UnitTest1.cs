using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSLib;
using System;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        SalesLoader sales = new SalesLoader();
        [TestMethod]
        public void TestMethod1()
        {

            
                List<Product> productFromFile = sales.ReadAllFromFile();
                List<Product> aspect = new List<Product>();
                aspect.Add(new Product
                {
                    Name = "Печенье",
                    Price = 100,
                    Quantity = 5
                });
                aspect.Add(new Product
                {
                    Name = "Молоко",
                    Price = 150,
                    Quantity = 10
                });
                aspect.Add(new Product
                {
                    Name = "Сахар",
                    Price = 40,
                    Quantity = 7
                });
                aspect.Add(new Product
                {
                    Name = "Апельсин",
                    Price = 120,
                    Quantity = 8
                });
                Assert.AreEqual(aspect.Count, productFromFile.Count);
            for (int i = 0; i < aspect.Count; i++)
            {
                Assert.AreEqual(aspect[i].Name, aspect[i].Name);
                Assert.AreEqual(aspect[i].Price, aspect[i].Price);
                Assert.AreEqual(aspect[i].Quantity, aspect[i].Quantity);
            }
               
            

        }
    }
}
