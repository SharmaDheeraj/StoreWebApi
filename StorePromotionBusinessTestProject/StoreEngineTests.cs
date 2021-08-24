using NUnit.Framework;

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

            Assert.IsTrue(store.Items.Contains(SetupDataForTest.firstItem));
        }

        [Test]
        public void TestAddPromotion(string promotion)
        {
           var store = new Store();
            store.AddSKUitem(SetupDataForTest.firstItem);
            Store storeresult = store.AddPromotion("3 of A's for 130");

            Assert.IsTrue(storeresult.Promotions.Count==1);

        }

        [Test]
        public void TestStore_CheckOut()
        {
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
               .AddItemToCart("C")
               .AddItemToCart("D");

            Assert.AreEqual(420, store.Cart.TotalPrice);
            Assert.AreEqual(11, store.Cart.Items.Count);

            store.Checkout();
            Assert.AreEqual(370, store.Cart.TotalPrice);
        }
    }
}
