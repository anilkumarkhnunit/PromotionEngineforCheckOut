using NUnit.Framework;
using PromotionEngineforCheckOut;
using PromotionEngineforCheckOut.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ScenarioA()
        {
            List<IPack> products = new List<IPack>();           
            int a = Convert.ToInt32("3");
            //"Enter the type of product:A,B,C or D");             
            IPack p = ProductFactory.GetProduct("A");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("C");
            products.Add(p);

            var distinctProducts = products.GroupBy(x => x.ProductType)
                                     .Select(g => g.First())
                                     .ToList();
            decimal totalPrice = ProductFactory.GetTotalPrice(distinctProducts);

            Assert.AreEqual(totalPrice, 100);
            Assert.Pass();
        }

        [Test]
        public void Test_ScenarioB()
        {
            List<IPack> products = new List<IPack>();
            int a = Convert.ToInt32("11");
            //"Enter the type of product:A,B,C or D");             
            IPack p = ProductFactory.GetProduct("A");
            products.Add(p);
             p = ProductFactory.GetProduct("A");
            products.Add(p);
             p = ProductFactory.GetProduct("A");
            products.Add(p);
             p = ProductFactory.GetProduct("A");
            products.Add(p);
             p = ProductFactory.GetProduct("A");
            products.Add(p);

            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);


            p = ProductFactory.GetProduct("C");
            products.Add(p);

            var distinctProducts = products.GroupBy(x => x.ProductType)
                                    .Select(g => g.First())
                                    .ToList();
            decimal totalPrice = ProductFactory.GetTotalPrice(distinctProducts);

            Assert.AreEqual(totalPrice, 370);
            Assert.Pass();
           
        }


        [Test]
        public void Test_ScenarioC()
        {
            List<IPack> products = new List<IPack>();
            int a = Convert.ToInt32("10");
            //"Enter the type of product:A,B,C or D");             
            IPack p = ProductFactory.GetProduct("A");
            products.Add(p);
             p = ProductFactory.GetProduct("A");
            products.Add(p);
             p = ProductFactory.GetProduct("A");
            products.Add(p);
           
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);
            p = ProductFactory.GetProduct("B");
            products.Add(p);


            p = ProductFactory.GetProduct("C");
            products.Add(p);

            p = ProductFactory.GetProduct("D");
            products.Add(p);

            var distinctProducts = products.GroupBy(x => x.ProductType)
                                   .Select(g => g.First())
                                   .ToList();
            decimal totalPrice = ProductFactory.GetTotalPrice(distinctProducts);

            Assert.AreEqual(totalPrice, 285);
            Assert.Pass();

        }
    }
}