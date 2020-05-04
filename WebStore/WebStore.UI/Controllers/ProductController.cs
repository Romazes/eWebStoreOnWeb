using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.Core.Entities;
using WebStore.Core.Interfaces;
using WebStore.UI.ViewModels;

namespace WebStore.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List(string category, string searchString)
        {
            IEnumerable<Product> products = from p in _productRepository.AllProducts
                                            select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString, System.StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(x => x.Category.CategoryName == category);
            }

            return View(new ProductsListViewModel
            {
                Products = products,
                CurrentCategory = category
            });
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
