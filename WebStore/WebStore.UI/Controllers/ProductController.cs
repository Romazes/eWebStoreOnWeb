using Microsoft.AspNetCore.Mvc;
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
        public IActionResult List()
        {
            ProductsListViewModel productsListViewModel = new ProductsListViewModel();
            productsListViewModel.Products = _productRepository.AllProducts;

            productsListViewModel.CurrentCategory = "Tea";
            return View(productsListViewModel);
        }
    }
}
