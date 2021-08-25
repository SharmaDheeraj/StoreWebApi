using NUnit.Framework;
using StorePromotionBusinessLogic.StoreRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StorePromotionBusinessTestProject
{
    class StoreEngineTests
    {
        Store store = new Store();
        [Test]
        public void TestAddSKUitem()
        {
            //set up Store
            store = new Store();
            Store storeresult = store.AddSKUitem(SetupDataForTest.firstItem);

            Assert.IsTrue(store.Items.Count>0);
        }

        [Test]
        
        public void TestAddPromotion()
        {
           var store = new Store();
            store.AddSKUitem(SetupDataForTest.firstItem);
            Store storeresult = store.AddPromotion("3 of A's for 130");

            Assert.IsTrue(storeresult.Promotions.Count==1);

        }

        [Test]
        public void TestStore_CheckOut()
        {
            store = new Store()
                  .AddSKUitem(SetupDataForTest.firstItem)
                  .AddSKUitem(SetupDataForTest.secItem)
                  .AddSKUitem(SetupDataForTest.thirdItem)
                  .AddSKUitem(SetupDataForTest.fourthItems)
                  .AddPromotions(SetupDataForTest.promotions);

            store.AddItemToCart("A")
                .AddItemToCart("A")
                .AddItemToCart("A")
                .AddItemToCart("A")
                .AddItemToCart("A")
                .AddItemToCart("B")
                .AddItemToCart("B")
                .AddItemToCart("B")
                .AddItemToCart("B")
                .AddItemToCart("B")
                .AddItemToCart("C");

            Assert.AreEqual(420, store.Cart.TotalPrice);
            Assert.AreEqual(11, store.Cart.Items.Count);

            store.Checkout();
            Assert.AreEqual(370, store.Cart.TotalPrice);
        }
    }
}
