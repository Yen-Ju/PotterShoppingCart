using System.Collections.Generic;

namespace PotterShoppingCart
{
    internal class EightyPercentOff : NoDiscount
    { 
        public EightyPercentOff(List<PotterShoppingCartItem> cartItemsList) 
            : base(cartItemsList)
        {
        }

        public override int Checkout()
        {
            return base.Checkout() * 80 / 100;
        }
    }
}