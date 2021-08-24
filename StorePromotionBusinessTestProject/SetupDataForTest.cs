using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePromotionBusinessTestProject
{
    public class SetupDataForTest
    {
        public static readonly SKUitem firstItem = new("A", 50);
        
        public static readonly  NitemOfSKUForFixedPricePromotion pr1 = new("A", 3, 130);
        public static readonly NitemOfSKUForFixedPricePromotion pr2 = new("B", 2, 45);
        public static readonly CombinedSKUItemFixedPricePromotion pr3 = new(new List<string> { "C", "D" }, 30);
    }
}
