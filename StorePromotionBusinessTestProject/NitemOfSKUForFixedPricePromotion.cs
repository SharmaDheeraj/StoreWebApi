namespace StorePromotionBusinessTestProject
{
    public class NitemOfSKUForFixedPricePromotion : PromotionRule
    {
       
        public NitemOfSKUForFixedPricePromotion(string v1, int v2, int v3)
        {
            this.SKU = v1;
            this.NumberOfItems = v2;
            this.FixedPrice = v3;
        }

        public string SKU { get; internal set; }
        public double NumberOfItems { get; internal set; }
        public double FixedPrice { get; internal set; }
        public string Name { get; internal set; }
    }
}