using PromotionEngineforCheckOut.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineforCheckOut.Models
{
    class DProductPack :  IPack
    {
        public static int ProductsCount { get; set; }
        public string ProductType { get; set; }

        public DProductPack()
        {
            ProductType = "D";
            ProductsCount++;
        }
        public  decimal GetPrice() => ProductsCount * 15;
    }
}
