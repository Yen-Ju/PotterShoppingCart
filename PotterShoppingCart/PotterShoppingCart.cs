﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        List<PotterShoppingCartItem> cartItemsList = new List<PotterShoppingCartItem>();

        public void AddToCart(PotterShoppingCartItem shoppingCartItem)
        {
            cartItemsList.Add(shoppingCartItem);
        }

        public int CheckOut()
        {
            return cartItemsList.Count == 1?
                CheckOutByOriginalPrice() : CheckOutBy95PercentOff();
        }

        private int CheckOutBy95PercentOff()
        {
            return CheckOutByOriginalPrice() * 95 / 100;
        }

        private int CheckOutByOriginalPrice()
        {
            int totalCost = 0;
            foreach (PotterShoppingCartItem item in cartItemsList)
                totalCost += item.Quantity * item.Price;
            return totalCost;
        }
    }

    public class PotterShoppingCartItem
    {
        internal int Price = 100;
        public int Quantity { get; set; }
        public HarryPotter Volumn { get; set; }
    }

    public enum HarryPotter
    {
        VOL_1,
        VOL_2
    }
}
