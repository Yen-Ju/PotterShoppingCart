using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    class NoDiscount : DiscountMethod
    {
        private List<PotterShoppingCartItem> cartItemsList;

        public NoDiscount(List<PotterShoppingCartItem> cartItemsList)
        {
            this.cartItemsList = cartItemsList;
        }

        public virtual int Checkout()
        {
            int totalCost = 0;
            foreach (PotterShoppingCartItem item in cartItemsList)
                totalCost += item.Quantity * item.Price;
            return totalCost;
        }
    }
}
