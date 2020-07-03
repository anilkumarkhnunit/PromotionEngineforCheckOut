using PromotionEngineforCheckOut.Interface;
using PromotionEngineforCheckOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineforCheckOut
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<IPack> products = new List<IPack>();

            Console.WriteLine("Enter total number of order");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                IPack p = ProductFactory.GetProduct(type);
                if (p != null)
                    products.Add(p);
            }

            var distinctProducts = products.GroupBy(x => x.ProductType)
                                  .Select(g => g.First())
                                  .ToList();

            decimal totalPrice = ProductFactory.GetTotalPrice(distinctProducts);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        
    }
}
