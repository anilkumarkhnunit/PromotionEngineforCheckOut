using PromotionEngineforCheckOut.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineforCheckOut.Models
{
    class AProductPack : IPack
    {
        public static int ProductsCount { get; set; }
        public string ProductType { get; set; }

        public AProductPack()
        {
            ProductType = "A";
            ProductsCount++;
        }
        public  decimal GetPrice() => 130 * (ProductsCount / 3) + 50 * (ProductsCount % 3);
    }
}
