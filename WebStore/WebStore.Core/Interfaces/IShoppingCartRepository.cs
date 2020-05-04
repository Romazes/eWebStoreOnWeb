using System.Collections.Generic;
using WebStore.Core.Entities;

namespace WebStore.Core.Interfaces
{
    public interface IShoppingCartRepository
    {
        public void AddToCart(Product product, int amount);
        public int RemoveFromCart(Product product);
        public List<ShoppingCartItem> GetShoppingCartItems();
        public void ClearCart();
        public decimal GetShoppingCartTotal();
    }
}
