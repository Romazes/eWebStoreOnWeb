using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using WebStore.Core.Entities;
using WebStore.Core.Interfaces;
using WebStore.UI.Controllers;
using Xunit;

namespace WebStore.XUnitTests.UI.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void HomeController_Index_ReturnViews()
        {
            #region Arrange
            // todo: define the required assets
            var mockRepo = new Mock<IProductRepository>();

            mockRepo.Setup(repo => repo.AllProducts).Returns(GetProducts());

            var controller = new HomeController(mockRepo.Object);
            #endregion

            #region Act
            // todo: invoke the test
            var result = controller.Index() as ViewResult;
            #endregion

            #region Assert
            // todo: verify that conditions are met
            // Returns not null
            Assert.NotNull(result);
            // Returns view data model
            Assert.NotNull(result.Model);
            // Returns specific name of the view to render
            Assert.True(string.IsNullOrEmpty(result.ViewName) || result.ViewName == "Index");
            #endregion
        }

        [Fact]
        public void HomeController_Index_ReturnsViewResult()
        {
            #region Arrange
            // todo: define the required assets
            var mockRepo = new Mock<IProductRepository>();

            mockRepo.Setup(repo => repo.AllProducts).Returns(GetProducts());

            var controller = new HomeController(mockRepo.Object);
            #endregion

            #region Act
            // todo: invoke the test
            var result = controller.Index() as ViewResult;
            #endregion

            #region Assert
            // todo: verify that conditions are met
            // Returns ViewResult
            Assert.IsType<ViewResult>(result);
            #endregion
        }

        #region Service Area
        private List<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product
            {
                Name = "Red tea 1",
                Price = 12.95M,
                ShortDescription = "Our marvellous Red Tea 1!",
                LongDescription =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "/Images/Tea/redtea.jpg",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "/Images/Tea/redteasm.jpg",
                AllergyInformation = ""
            });
            products.Add(new Product
            {
                Name = "Puer 1",
                Price = 18.95M,
                ShortDescription = "Famously known for its taste - Puer 1",
                LongDescription =
                        "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",
                CategoryId = 2,
                ImageUrl = "/Images/Tea/puer.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "/Images/Tea/puersm.jpg",
                AllergyInformation = ""
            });
            return products;
        }
        #endregion
    }
}
