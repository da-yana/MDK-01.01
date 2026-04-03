using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSLib;
using System;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "D:\\п30\\Буренина\\репреп\\MSTest";
           SalesLoader loader = new SalesLoader();
            List<Product> at = loader.Load(path);

            List<Product> aspect = new List<Product>;
            aspect.Add(new Product ("Печенье"; 100; 5));
        }
    }
}
