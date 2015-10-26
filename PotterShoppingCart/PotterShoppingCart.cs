using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        public void AddToCart(PotterShoppingCartItem shoppingCartItem)
        {
            throw new NotImplementedException();
        }

        public int CheckOut()
        {
            throw new NotImplementedException();
        }
    }

    public class PotterShoppingCartItem
    {
        public int Quantity { get; set; }
        public HarryPotter Volumn { get; set; }
    }

    public enum HarryPotter
    {
        VOL_1
    }
}
