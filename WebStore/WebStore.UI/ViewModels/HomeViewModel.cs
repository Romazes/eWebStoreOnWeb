using System.Collections.Generic;
using WebStore.Core.Entities;

namespace WebStore.UI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek { get; set; }
    }
}
