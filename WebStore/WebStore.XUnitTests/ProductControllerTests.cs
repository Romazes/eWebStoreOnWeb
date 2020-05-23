using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Core.Entities;
using WebStore.Core.Interfaces;
using WebStore.UI.Areas.Manage.Controllers;
using Xunit;

namespace WebStore.XUnitTests
{
    public class ProductControllerTests
    {
        [Fact]
        public void IndexReturnsContentWithProductNotFoundWhenProductNotFound()
        {
            // Arrange
            //int testProductId = 1;


            //var mockRepo = new Mock<IProductRepository>();
            //mockRepo.Setup(repo => repo.GetProductById(testProductId)).Returns((Product)null)
            //    .Verifiable();
            //var controller = new ProductController(mockRepo.);
            //var newSession = new HomeController.NewSessionModel()
            //{
            //    SessionName = "Test Name"
            //};



            //var mockRepo = new Mock<IProductRepository>();
            //mockRepo.Setup(repo => repo.GetProductById(testProductId))
            //    .Returns((Product)null);
            //ProductController controller = new ProductController(mockRepo.Object());
        }
    }
}
