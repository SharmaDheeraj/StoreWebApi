using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using StorePromotionBusinessLogic.CartData;
using StorePromotionBusinessLogic.PromotionRules;

namespace StorePromotionBusinessLogic.StoreRoom
{
    public class Store : IStore
    {
        public Cart Cart { get; private set; }
        public List<PromotionRule> Promotions { get; }
        public List<SKUitem> Items { get; }
        public Store()
        {
            Cart = new Cart();
            Promotions = new List<PromotionRule>();
            Items = new List<SKUitem>();
        }
        public Store AddSKUitem(SKUitem item)
        {
            if (item != null) Items.Add(item);
            return this;
        }
        public Store AddPromotions(List<PromotionRule> promotions)
        {
            if (promotions != null && promotions.Count > 0) Promotions.AddRange(promotions);
            return this;
        }

        public Store AddPromotion(PromotionRule promotion)
        {
            if (promotion != null) Promotions.Add(promotion);
            return this;
        }
        public Store AddPromotion(string promotion)
        {
            if (Regex.IsMatch(promotion, @"^\d"))
            {
                AddPromotion(promotion.ToNitemForFixedPricePromotion());
            }
            else
            {
                AddPromotion(promotion.ToCombinedItemFixedPricePromotion());
            }
            return this;
        }     
        public Store AddItemToCart(string itemSKU)
        {
            if (!IsValidSKU(itemSKU)) throw new ArgumentException("SKU not found!");

            if (!string.IsNullOrWhiteSpace(itemSKU)) Cart.AddItem(Items.First(i => itemSKU.Equals(i.ID)));
            return this;
        }      
        public Store Checkout()
        {            Promotions.ForEach(p =>
            { if (p.IsApplicable(Cart)) p.Execute(Cart); });
            return this;
        }          
        private bool IsValidSKU(string sku)
        {
            return Items.Any(i => sku.Equals(i.ID));
        }
    }
}