using WebStore.Core.Entities;
using Xunit;

namespace WebStore.XUnitTests.Core
{
    public class ProductTests
    {
        [Fact]
        public void Create_Product()
        {
            #region Arrange
            // todo: define the required assets
            int productId = 1;
            string name = "Product 1";
            string shortDescription = "Product 1 Short Description";
            string longDescription = "Product 1 Long Description";
            string allergyInformation = "Product 1 Allegry Information";
            decimal price = 100.00M;
            string imageUrl = "Product 1 Image URL";
            string imageThumbnailUrl = "Product 1 Image Thumbnail URL";
            bool isProductOfTheWeek = true;
            bool inStock = true;
            int categoryId = 1;
            Category category = new Category
            {
                CategoryId = 1,
                CategoryName = "Category 1",
                Description = "Category Description"
            };
            #endregion

            #region Act
            // todo: invoke the test
            var product = new Product
            {
                ProductId = productId,
                Name = name,
                ShortDescription = shortDescription,
                LongDescription = longDescription,
                AllergyInformation = allergyInformation,
                Price = price,
                ImageUrl = imageUrl,
                ImageThumbnailUrl = imageThumbnailUrl,
                IsProductOfTheWeek = isProductOfTheWeek,
                InStock = inStock,
                CategoryId = categoryId,
                Category = category
            };
            #endregion

            #region Assert
            // todo: verify that conditions are met
            Assert.Equal(productId, product.ProductId);
            Assert.Equal(name, product.Name);
            Assert.Equal(shortDescription, product.ShortDescription);
            Assert.Equal(longDescription, product.LongDescription);
            Assert.Equal(allergyInformation, product.AllergyInformation);
            Assert.Equal(price, product.Price);
            Assert.Equal(imageUrl, product.ImageUrl);
            Assert.Equal(imageThumbnailUrl, product.ImageThumbnailUrl);
            Assert.Equal(isProductOfTheWeek, product.IsProductOfTheWeek);
            Assert.Equal(inStock, product.InStock);
            Assert.Equal(categoryId, product.CategoryId);
            Assert.Equal(category, product.Category);
            #endregion
        }
    }
}
