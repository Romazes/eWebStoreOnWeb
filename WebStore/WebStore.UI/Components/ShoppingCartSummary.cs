using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Data.Repositories;
using WebStore.UI.ViewModels;

namespace WebStore.UI.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCartRepository _shoppingCart;

        public ShoppingCartSummary(ShoppingCartRepository shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };
            return View(shoppingCartViewModel);
        }
    }
}
