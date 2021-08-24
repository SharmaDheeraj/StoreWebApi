using System;
using System.Collections.Generic;

namespace StorePromotionBusinessTestProject
{
    internal class Store
    {

        public List<SKUitem> Items { get; internal set; }

        public List<PromotionRule> Promotions { get; }
       

        internal Store AddSKUitem(SKUitem firstItem)
        {
            throw new NotImplementedException();
        }

        internal Store AddPromotion(string v)
        {
            throw new NotImplementedException();
        }
    }
}