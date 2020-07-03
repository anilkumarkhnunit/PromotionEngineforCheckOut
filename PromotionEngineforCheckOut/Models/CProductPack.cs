using PromotionEngineforCheckOut.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineforCheckOut.Models
{
    class CProductPack : IPack
    {
        public static int ProductsCount { get; set; }
        public string ProductType { get; set; }

        public CProductPack()
        {
            ProductType = "C";
            ProductsCount++;
        }
        public  decimal GetPrice() => ProductsCount * 20;
    }
}
