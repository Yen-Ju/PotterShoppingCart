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
            int totalCost = 0;
            while (cartItemsList.Count > 0)
            {
                totalCost += FindBestDiscountMethod().Checkout();
            }
            return totalCost;
        }

        private DiscountMethod FindBestDiscountMethod()
        {
            var bestPackage =  FoundBestPackage();
            if (bestPackage.Count == 1)
                return new NoDiscount(bestPackage);
            else if (bestPackage.Count == 2)
                return new NinetyFivePercentOff(bestPackage);
            else if (bestPackage.Count == 3)
                return new NinetyPercentOff(bestPackage);
            else if (bestPackage.Count == 4)
                return new EightyPercentOff(bestPackage);
            else
                return new SeventyFivePercentOff(bestPackage);
        }

        private List<PotterShoppingCartItem> FoundBestPackage()
        {
            List<PotterShoppingCartItem> bestPackage = new List<PotterShoppingCartItem>();
            foreach (PotterShoppingCartItem cartItem in cartItemsList)
            {
                bestPackage.Add(new PotterShoppingCartItem() {
                    Volumn = cartItem.Volumn,
                    Quantity = 1
                });
                cartItem.Quantity -= 1;
            }
            cartItemsList.RemoveAll(item => item.Quantity == 0);
            return bestPackage;
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
