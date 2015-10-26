using System;
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
            return FindDiscountMethod().Checkout();
        }

        private DiscountMethod FindDiscountMethod()
        {
            if (cartItemsList.Count == 1)
                return new NoDiscount(cartItemsList);
            else if (cartItemsList.Count == 2)
                return new NinetyFivePercentOff(cartItemsList);
            else if (cartItemsList.Count == 3)
                return new NinetyPercentOff(cartItemsList);
            else if (cartItemsList.Count == 4)
                return new EightyPercentOff(cartItemsList);
            else
                return new SeventyFivePercentOff(cartItemsList);
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
        VOL_2,
        VOL_3,
        VOL_4,
        VOL_5
    }
}
