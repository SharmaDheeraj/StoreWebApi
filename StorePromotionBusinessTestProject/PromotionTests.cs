using NUnit.Framework;
using StorePromotionBusinessLogic.CartData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePromotionBusinessTestProject
{
    class PromotionTests
    {
        Cart cart;

        [SetUp]
        public void Setup()
        {
            cart = new Cart();
        }

        [Test]
        public void ScenarioA()
        {
            cart.AddItem(SetupDataForTest.firstItem);
            cart.AddItem(SetupDataForTest.secItem);
            cart.AddItem(SetupDataForTest.thirdItem);

            Assert.AreEqual(3, cart.Items.Count);
            Assert.AreEqual(cart.TotalPrice, 100);

            ApplyPromotionsOnCart();

            Assert.AreEqual(cart.TotalPrice, 100);
        }

        [Test]
        public void ScenarioB()
        {
            cart.AddItems(SetupDataForTest.firstItem,5);
            cart.AddItems(SetupDataForTest.secItem,5);
            cart.AddItem(SetupDataForTest.thirdItem);         

            Assert.AreEqual(11, cart.Items.Count);
            Assert.AreEqual(cart.TotalPrice, 420);

            //ApplyPromotionsOnCart();

            //Assert.AreEqual(cart.TotalPrice, 370);
        }

        [Test]
        public void ScenarioC()
        {
            cart.AddItems(SetupDataForTest.firstItem, 3);
            cart.AddItems(SetupDataForTest.secItem, 5);
            cart.AddItem(SetupDataForTest.thirdItem);
            cart.AddItem(SetupDataForTest.fourthItems);

            Assert.AreEqual(10, cart.Items.Count);
            Assert.AreEqual(cart.TotalPrice, 335);

            //ApplyPromotionsOnCart();

            //Assert.AreEqual(cart.TotalPrice, 280);
        }

        private void ApplyPromotionsOnCart()
        {
            SetupDataForTest.promotions.ForEach(p => { if (p.IsApplicable(cart)) p.Execute(cart); });
        }
    }
}
