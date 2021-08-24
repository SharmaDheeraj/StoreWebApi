using System.Collections.Generic;

namespace StorePromotionBusinessTestProject
{
    public class CombinedSKUItemFixedPricePromotion : PromotionRule
    {
        public List<string> SKUs { get; internal set; }
        public int FixedPrice { get; internal set; }
        public string Name { get; internal set; }
        public CombinedSKUItemFixedPricePromotion(List<string> list, int v)
        {
            this.SKUs = list;
            this.FixedPrice = v;
        }

      
    }
}