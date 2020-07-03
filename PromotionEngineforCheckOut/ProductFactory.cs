using PromotionEngineforCheckOut.Interface;
using PromotionEngineforCheckOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngineforCheckOut
{
   public static class ProductFactory
    {
        //use getShape method to get object of type shape 
        public static IPack GetProduct(String ProductType)
        {

            if (ProductType == null)
            {
                return null;
            }

            if (ProductType.Equals("A", StringComparison.InvariantCultureIgnoreCase))
            {
                //if (AProductPack.ProductsCount > 0)
                //{
                //    AProductPack.ProductsCount++;
                //}
                //else
                    return new AProductPack();
            }

            else if (ProductType.Equals("B", StringComparison.InvariantCultureIgnoreCase))
            {
               
                    return new BProductPack();
            }

            else if (ProductType.Equals("C", StringComparison.InvariantCultureIgnoreCase))
            {
               
                    return new CProductPack();
            }

            else if (ProductType.Equals("D", StringComparison.InvariantCultureIgnoreCase))
            {
               
                    return new DProductPack();
            }

            return null;
        }

        public static decimal GetTotalPrice(List<IPack> products) => products.Sum(p => p.GetPrice());

        //public static decimal GetTotalPrice(List<IPack> products)
        //{
        //    decimal Total = 0;

        //    if (AProductPack.ProductsCount > 0)
        //    {
        //        Total += AProductPack.GetPrice();
        //    }
        //    if (BProductPack.ProductsCount > 0)
        //    {
        //        Total += BProductPack.GetPrice();
        //    }
        //    if (CProductPack.ProductsCount > 0)
        //    {
        //        Total += CProductPack.GetPrice();
        //    }
        //    if (DProductPack.ProductsCount > 0)
        //    {
        //        Total += DProductPack.GetPrice();
        //    }

        //    return Total;
        //}


    }
}
