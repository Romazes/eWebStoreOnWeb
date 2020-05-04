using WebStore.Infrastructure.Data.Repositories;

namespace WebStore.UI.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartRepository ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
