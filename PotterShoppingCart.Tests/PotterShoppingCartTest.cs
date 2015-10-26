﻿using System;
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
        public void Buy_1_Of_Each_Vol_1_and_2_Cost_100()
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
    }
}
