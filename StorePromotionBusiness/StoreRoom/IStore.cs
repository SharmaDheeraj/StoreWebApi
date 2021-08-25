
using StorePromotionBusinessLogic.CartData;
using StorePromotionBusinessLogic.PromotionRules;
using System.Collections.Generic;


namespace StorePromotionBusinessLogic.StoreRoom
{
    public interface IStore
    {
        public Store AddSKUitem(SKUitem item);
        public Store AddPromotions(List<PromotionRule> promotions);
        public Store AddPromotion(PromotionRule promotion);
        public Store AddPromotion(string promotion);
        public Store AddItemToCart(string itemSKU);       
        public Store Checkout();
   
   

    }
}
