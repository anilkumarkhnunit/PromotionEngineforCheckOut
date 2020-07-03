using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineforCheckOut.Interface
{

    public interface IPack
    {
        string ProductType { get; set; }
        decimal GetPrice();
    }
}
