using WebStore.Core.Entities;
using Xunit;

namespace WebStore.XUnitTests.Core
{
    public class OrderDetailTests
    {
        [Fact]
        public void Create_OrderDetail()
        {
            #region Arrange
            // todo: define the required assets
            int orderDetailId = 1;
            int orderId = 1;
            int productId = 1;
            int amount = 100;
            decimal price = 100.00M;
            Category category = new Category
            {
                CategoryId = 1,
                CategoryName = "Category 1",
                Description = "Category Description"
            };
            Product product = new Product
            {
                ProductId = 1,
                Name = "Product Name 1",
                ShortDescription = "Product 1 Short Description",
                LongDescription = "Product 1 Long Description",
                AllergyInformation = "Product 1 Allergy Information",
                Price = 100.00M,
                ImageUrl = "Product 1 Image URL",
                ImageThumbnailUrl = "Product 1 Image Thumbnail URL",
                IsProductOfTheWeek = true,
                InStock = true,
                CategoryId = 1,
                Category = category
            };
            Order order = null;
            #endregion

            #region Act
            // todo: invoke the test
            var orderDetail = new OrderDetail
            {
                OrderDetailId = orderDetailId,
                OrderId = orderId,
                ProductId = productId,
                Amount = amount,
                Price = price,
                Product = product,
                Order = order
            };
            #endregion

            #region Assert
            // todo: verify that conditions are met
            Assert.Equal(orderDetailId, orderDetail.OrderDetailId);
            Assert.Equal(orderId, orderDetail.OrderId);
            Assert.Equal(productId, orderDetail.ProductId);
            Assert.Equal(amount, orderDetail.Amount);
            Assert.Equal(price, orderDetail.Price);
            Assert.Equal(product, orderDetail.Product);
            Assert.Equal(order, orderDetail.Order);
            #endregion
        }
    }
}