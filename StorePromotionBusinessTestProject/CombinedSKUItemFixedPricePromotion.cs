using System.Collections.Generic;

namespace StorePromotionBusinessTestProject
{
    public class CombinedSKUItemFixedPricePromotion : PromotionRule
    {
        private List<string> list;
        private int v;

        public CombinedSKUItemFixedPricePromotion(List<string> list, int v)
        {
            this.list = list;
            this.v = v;
        }
    }
}