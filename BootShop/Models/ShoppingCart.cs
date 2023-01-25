using System.Runtime.CompilerServices;

namespace BootShop.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (ShoppingCartItem shoppingCartItem in this.Items)
            {
                totalPrice += shoppingCartItem.Amount * shoppingCartItem.ProductVariant.PriceDiscount;
            }

            return totalPrice;
        }
    }
}
