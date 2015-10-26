using System.Collections.Generic;

namespace PotterShoppingCart
{
    internal class NinetyPercentOff : NoDiscount
    {
        public NinetyPercentOff(List<PotterShoppingCartItem> cartItemsList) 
            : base(cartItemsList)
        {
        }

        public override int Checkout()
        {
            return base.Checkout() * 90 / 100;
        }
    }
}