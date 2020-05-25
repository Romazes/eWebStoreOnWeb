using WebStore.Core.Entities;
using Xunit;

namespace WebStore.XUnitTests.Core
{
    public class CategoryTests
    {
        [Fact]
        public void Create_Category()
        {
            #region Arrange
            // todo: define the required assets
            int categoryId = 1;
            string categoryName = "Category 1";
            string categoryDescription = "Category 1 Description";
            #endregion

            #region Act
            // todo: invoke the test
            var category = new Category
            {
                CategoryId = categoryId,
                CategoryName = categoryName,
                Description = categoryDescription
            };
            #endregion

            #region Assert
            // todo: verify that conditions are met
            Assert.Equal(categoryId, category.CategoryId);
            Assert.Equal(categoryName, category.CategoryName);
            Assert.Equal(categoryDescription, category.Description);
            #endregion
        }
    }
}
