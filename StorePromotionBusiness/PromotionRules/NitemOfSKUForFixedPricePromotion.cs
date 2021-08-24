
using StorePromotionBusinessLogic.CartData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePromotionBusinessLogic.PromotionRules
{
    public class NitemOfSKUForFixedPricePromotion : PromotionRule
    {
        public string SKU { get; }
        public int NumberOfItems { get; }
        public int FixedPrice { get; }

        public NitemOfSKUForFixedPricePromotion(string sku, int numberOfItems, int fixedPrice)
        {
            if (string.IsNullOrWhiteSpace(sku)) throw new ArgumentException("Invalid or missing SKU!");
            if (numberOfItems <= 0) throw new ArgumentException("Invalid number of items in promotion rule! It must be grater than zero!");
            if (fixedPrice <= 0) throw new ArgumentException("Invalid number for fixed price in promotion rule! It must be grater than zero!");

            SKU = sku;
            NumberOfItems = numberOfItems;
            FixedPrice = fixedPrice;
        }

        public override void Execute(Cart cart)
        {
          
        }

        public override bool IsApplicable(Cart cart)
        {
            return true;
        }
        public override string ToString()
        {
            return $"{NumberOfItems} of {SKU}'s for {FixedPrice}";
        }



    }
}
