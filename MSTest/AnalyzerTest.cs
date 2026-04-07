using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSLib;
using System;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class AnalyzerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"MSTest.txt";
            SalesLoader salesLoader = new SalesLoader();
            SalesAnalizer salesAnalizer = new SalesAnalizer();
            List<Product> products = salesLoader.ReadAllFromFile();
            int expected = 0;
            double avg = salesAnalizer.Avg(products);

            foreach (Product product in products)
            {
                if ((product.Price * product.Quantity) <= avg)
                {
                    expected++;
                }
            }

            int actual = salesAnalizer.LessAVG(products);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AVGTest()
        {
            string path = @"MSTest.txt";
            SalesLoader salesLoader = new SalesLoader();
            SalesAnalizer salesAnalizer = new SalesAnalizer();
            List<Product> products = salesLoader.ReadAllFromFile();

            double expected = salesAnalizer.Avg(products);
            double actual = salesAnalizer.Avg(products);


            Assert.AreEqual(expected, actual);
        }
    }
}  
