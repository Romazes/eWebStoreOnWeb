using System.Collections.Generic;
using System.Linq;
using WebStore.Core.Entities;
using WebStore.Core.Interfaces;

namespace WebStore.Infrastructure.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product {ProductId = 1, Name="Red Tea 1", Price=15.95M, ShortDescription="Our marvellous Red Tea 1!", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="/Images/Tea/redtea.jpg", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="/Images/Tea/redteasm.jpg"},
                new Product {ProductId = 2, Name="Puer 1", Price=18.95M, ShortDescription="Famously known for its taste - Puer 1", LongDescription="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="/Images/Tea/puer.jpg", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="/Images/Tea/puersm.jpg"},
                new Product {ProductId = 3, Name="Green Tea 1", Price=15.95M, ShortDescription="Our Grean Tea 1 is a miracle", LongDescription="Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="/Images/Tea/redteagreentea.jpg", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="/Images/Tea/redteasm.jpg"},
                new Product {ProductId = 4, Name="Red tea 2", Price=12.95M, ShortDescription="Our marvellous Red Tea 4!", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="/Images/Tea/redtea.jpg", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="/Images/Tea/redteasm.jpg"}
            };

        public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}