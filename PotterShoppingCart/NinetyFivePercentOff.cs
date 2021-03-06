﻿using System.Collections.Generic;

namespace PotterShoppingCart
{
    internal class NinetyFivePercentOff : NoDiscount
    {
        public NinetyFivePercentOff(List<PotterShoppingCartItem> cartItemsList)
            : base(cartItemsList)
        {
        }

        public override int Checkout()
        {
            return base.Checkout() * 95 / 100;
        }
    }
}