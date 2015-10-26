using System.Collections.Generic;

namespace PotterShoppingCart
{
    internal class SeventyFivePercentOff : NoDiscount
    {
        public SeventyFivePercentOff(List<PotterShoppingCartItem> cartItemsList)
            : base(cartItemsList)
        {
        }

        public override int Checkout()
        {
            return base.Checkout() * 75 / 100;
        }
    }
}