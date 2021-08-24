using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;

namespace StorePromotionBusinessTestProject
{
    public class PromotionRuleTests
    {

        [Test]
        public void TestNitemOfSKUForFixedPricePromotion_instanceCreation()
        {
            var promotion = new NitemOfSKUForFixedPricePromotion("A", 3, 130);
            Assert.NotNull(promotion);
            Assert.AreEqual("A", promotion.SKU);
            Assert.AreEqual(3, promotion.NumberOfItems);
            Assert.AreEqual(130, promotion.FixedPrice);
            Assert.AreEqual("3 of A's for 130", promotion.Name);
        }
               

       

        [Test]
        public void TestCombinedSKUItemFixedPricePromotion_instanceCreation()
        {
            var promotion = new CombinedSKUItemFixedPricePromotion(new List<string> { "C", "D" }, 30);
            Assert.NotNull(promotion);
            Assert.AreEqual(new List<string> { "C", "D" }, promotion.SKUs);
            Assert.AreEqual(30, promotion.FixedPrice);
            Assert.AreEqual("C & D for 30", promotion.Name);
        }

       

      
    }
}
