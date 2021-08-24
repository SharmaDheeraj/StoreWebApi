using StorePromotionBusinessLogic.CartData;
using StorePromotionBusinessLogic.StoreRoom;
using System;
using System.Collections.Generic;

namespace StorePromotionBusinessTestProject
{
    internal class Store
    {

        public List<SKUitem> Items { get; internal set; }

        public List<PromotionRule> Promotions { get; }
        public Cart Cart { get; internal set; }

        internal Store AddSKUitem(SKUitem firstItem)
        {
            throw new NotImplementedException();
        }

        internal Store AddPromotion(string v)
        {
            throw new NotImplementedException();
        }

        internal Store AddItemToCart(string v)
        {
            throw new NotImplementedException();
        }

        internal void Checkout()
        {
            throw new NotImplementedException();
        }
    }
}