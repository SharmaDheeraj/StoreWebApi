using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePromotionBusinessLogic.PromotionRules
{
    public static class PromotionRuleExtensions
    {
        public static NitemOfSKUForFixedPricePromotion ToNitemForFixedPricePromotion(this string promotion)
        {
            //3 A for 130 3 of A's for 130
            var promotionDetails = promotion.Split(" ")
                .Where(p => !string.IsNullOrEmpty(p.Trim())
                && !"for".Equals(p)
                && !"of".Equals(p)).ToList();
            var sku = promotionDetails[1].Replace("'s", "");
            var numberOfItems = Convert.ToInt32(promotionDetails.First());
            var price = Convert.ToInt32(promotionDetails.Last());

            return new NitemOfSKUForFixedPricePromotion(sku, numberOfItems, price);
        }

        public static CombinedSKUItemFixedPricePromotion ToCombinedItemFixedPricePromotion(this string promotion)
        {
            //C D for 30
            var promotionDetails = promotion.Split(" ")
                .Where(p => !string.IsNullOrEmpty(p.Trim())
                && !"for".Equals(p)
                && !"&".Equals(p)).ToList();
            var skus = promotionDetails.Take(promotionDetails.Count() - 1).ToList();
            var price = Convert.ToInt32(promotionDetails.Last());

            return new CombinedSKUItemFixedPricePromotion(skus, price);
        }
    }
}
