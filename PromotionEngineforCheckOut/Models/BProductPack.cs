using PromotionEngineforCheckOut.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineforCheckOut.Models
{
    class BProductPack : IPack
    {
        public static int ProductsCount { get; set; }
        public string ProductType { get; set; }

        public BProductPack()
        {
            ProductType = "B";
            ProductsCount++;
        }
        public  decimal GetPrice() => 45 * (ProductsCount / 2) + 30 * (ProductsCount % 2);
    }
}
