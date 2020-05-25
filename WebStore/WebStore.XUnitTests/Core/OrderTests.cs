using System;
using System.Collections.Generic;
using WebStore.Core.Entities;
using Xunit;

namespace WebStore.XUnitTests.Core
{
    public class OrderTests
    {
        [Fact]
        public void Create_Order()
        {
            #region Arrange
            // todo: define the required assets
            int orderId = int.MaxValue;
            string firstName = new String('x', 50);
            string lastName = new String('x', 50);
            string addressLine1 = new String('x', 100);
            string addressLine2 = new String('x', 100);
            string zipCode = new String('x', 10);
            string city = new String('x', 50);
            string state = new String('x', 10);
            string country = new String('x', 50);
            string phoneNumber = new String('x', 25);
            string email = new String('x', 50);
            decimal orderTotal = Decimal.MaxValue;
            DateTime orderPlaced = DateTime.Now;
            List<OrderDetail> orderDetails = new List<OrderDetail> { GetOrderDetails() };
            #endregion

            #region Act
            // todo: invoke the test
            var order= new Order
            {
                OrderId = orderId,
                FirstName = firstName,
                LastName = lastName,
                AddressLine1 = addressLine1,
                AddressLine2 = addressLine2,
                ZipCode = zipCode,
                City = city,
                State = state,
                Country = country,
                PhoneNumber = phoneNumber,
                Email = email,
                OrderTotal = orderTotal,
                OrderPlaced = orderPlaced,
                OrderDetails = orderDetails
            };
            #endregion

            #region Assert
            // todo: verify that conditions are met
            Assert.Equal(orderId, order.OrderId);
            Assert.Equal(firstName, order.FirstName);
            Assert.Equal(lastName, order.LastName);
            Assert.Equal(addressLine1, order.AddressLine1);
            Assert.Equal(addressLine2, order.AddressLine2);
            Assert.Equal(city, order.City);
            Assert.Equal(state, order.State);
            Assert.Equal(country, order.Country);
            Assert.Equal(phoneNumber, order.PhoneNumber);
            Assert.Equal(email, order.Email);
            Assert.Equal(orderTotal, order.OrderTotal);
            Assert.Equal(orderPlaced, order.OrderPlaced);
            Assert.Equal(orderDetails, order.OrderDetails);
            #endregion
        }

        public OrderDetail GetOrderDetails()
        {
            #region Generate dummy category and dummy product for the dummy order
            Category category = new Category
            {
                CategoryId = int.MaxValue,
                CategoryName = "Category 1",
                Description = "Category 1 Description"
            };

            Product product = new Product
            {
                ProductId = int.MaxValue,
                Name = "Product Name 1",
                ShortDescription = "Product 1 Short Description",
                LongDescription = "Product 1 Long Description",
                AllergyInformation = "Product 1 Allergy Information",
                Price = Decimal.MaxValue,
                ImageUrl = "Product 1 Image URL",
                ImageThumbnailUrl = "Product 1 Image Thumbnail URL",
                IsProductOfTheWeek = true,
                InStock = true,
                CategoryId = int.MaxValue,
                Category = category
            };

            Order order = new Order();
            #endregion

            #region Generate dummy order
            int orderId = int.MaxValue;
            int orderDetailId = int.MaxValue;
            int productId = int.MaxValue;
            int amount = int.MaxValue;
            decimal price = Decimal.MaxValue;

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

            return orderDetail;
        }
    }
}