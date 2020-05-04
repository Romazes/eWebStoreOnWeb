using System.Collections.Generic;
using WebStore.Core.Entities;

namespace WebStore.UI.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
