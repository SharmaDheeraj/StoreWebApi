using System;
using System.Collections.Generic;

namespace StorePromotionBusinessTestProject
{
    internal class Cart
    {
        public List<CartItem> Items { get; }
        public double TotalPrice { get; internal set; }

        internal void AddItem(SKUitem firstItem)
        {
            throw new NotImplementedException();
        }

        internal void AddItems(SKUitem firstItem, int v)
        {
            throw new NotImplementedException();
        }
    }
}