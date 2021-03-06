
using StorePromotionBusinessLogic.StoreRoom;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorePromotionBusinessLogic.CartData
{
    public class Cart
    {
        public List<CartItem> Items { get; }

        public float TotalPrice
        {
            get { return Items.Sum(i => i.FinalPrice); }
        }

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddItems(SKUitem item, int numberOfItems)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                Items.Add(new CartItem { Item = item, FinalPrice = item.UnitPrice, PromotionApplied = false });
            }
        }

        public void AddItem(SKUitem item)
        {
            Items.Add(new CartItem { Item = item, FinalPrice = item.UnitPrice, PromotionApplied = false });
        }

       

        


    }
}
