using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void Buy_1_First_Vol_Cost_100()
        {
            //arrange
            var target = new PotterShoppingCart();
            var shoppingCartItem = new PotterShoppingCartItem() {
                Volumn = HarryPotter.VOL_1,
                Quantity = 1
            };
            var expectedCost = 100;

            //act
            int actualCost;
            target.AddToCart(shoppingCartItem);
            actualCost = target.CheckOut();

            //assert
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void Buy_1_Of_Each_Vol_1_and_2_Cost_190()
        {
            //arrange
            var target = new PotterShoppingCart();
            var shoppingCartItem1 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_1,
                Quantity = 1
            };            
            var shoppingCartItem2 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_2,
                Quantity = 1
            };
            var expectedCost = 190;

            //act
            int actualCost;
            target.AddToCart(shoppingCartItem1);
            target.AddToCart(shoppingCartItem2);
            actualCost = target.CheckOut();

            //assert
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void Buy_1_Of_Each_Vol_1_to_3_Cost_270()
        {
            //arrange
            var target = new PotterShoppingCart();
            var shoppingCartItem1 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_1,
                Quantity = 1
            };
            var shoppingCartItem2 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_2,
                Quantity = 1
            };
            var shoppingCartItem3 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_3,
                Quantity = 1
            };
            var expectedCost = 270;

            //act
            int actualCost;
            target.AddToCart(shoppingCartItem1);
            target.AddToCart(shoppingCartItem2);
            target.AddToCart(shoppingCartItem3);
            actualCost = target.CheckOut();

            //assert
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void Buy_1_Of_Each_Vol_1_to_4_Cost_320()
        {
            //arrange
            var target = new PotterShoppingCart();
            var shoppingCartItem1 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_1,
                Quantity = 1
            };
            var shoppingCartItem2 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_2,
                Quantity = 1
            };
            var shoppingCartItem3 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_3,
                Quantity = 1
            };
            var shoppingCartItem4 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_4,
                Quantity = 1
            };
            var expectedCost = 320;

            //act
            int actualCost;
            target.AddToCart(shoppingCartItem1);
            target.AddToCart(shoppingCartItem2);
            target.AddToCart(shoppingCartItem3);
            target.AddToCart(shoppingCartItem4);
            actualCost = target.CheckOut();

            //assert
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void Buy_1_Of_Each_Vol_1_to_5_Cost_375()
        {
            //arrange
            var target = new PotterShoppingCart();
            var shoppingCartItem1 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_1,
                Quantity = 1
            };
            var shoppingCartItem2 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_2,
                Quantity = 1
            };
            var shoppingCartItem3 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_3,
                Quantity = 1
            };
            var shoppingCartItem4 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_4,
                Quantity = 1
            };
            var shoppingCartItem5 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_5,
                Quantity = 1
            };
            var expectedCost = 375;

            //act
            int actualCost;
            target.AddToCart(shoppingCartItem1);
            target.AddToCart(shoppingCartItem2);
            target.AddToCart(shoppingCartItem3);
            target.AddToCart(shoppingCartItem4);
            target.AddToCart(shoppingCartItem5);
            actualCost = target.CheckOut();

            //assert
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void Buy_1_Of_Each_Vol_1_and_2_and_2_Vol_3_Cost_370()
        {
            //arrange
            var target = new PotterShoppingCart();
            var shoppingCartItem1 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_1,
                Quantity = 1
            };
            var shoppingCartItem2 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_2,
                Quantity = 1
            };
            var shoppingCartItem3 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_3,
                Quantity = 2
            };
            var expectedCost = 370;

            //act
            int actualCost;
            target.AddToCart(shoppingCartItem1);
            target.AddToCart(shoppingCartItem2);
            target.AddToCart(shoppingCartItem3);
            actualCost = target.CheckOut();

            //assert
            Assert.AreEqual(expectedCost, actualCost);
        }
        [TestMethod]
        public void Buy_1_Vol_1_and_2_Vol_2_and_2_Vol_3_Cost_460()
        {
            //arrange
            var target = new PotterShoppingCart();
            var shoppingCartItem1 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_1,
                Quantity = 1
            };
            var shoppingCartItem2 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_2,
                Quantity = 2
            };
            var shoppingCartItem3 = new PotterShoppingCartItem()
            {
                Volumn = HarryPotter.VOL_3,
                Quantity = 2
            };
            var expectedCost = 460;

            //act
            int actualCost;
            target.AddToCart(shoppingCartItem1);
            target.AddToCart(shoppingCartItem2);
            target.AddToCart(shoppingCartItem3);
            actualCost = target.CheckOut();

            //assert
            Assert.AreEqual(expectedCost, actualCost);
        }
    }    
}
