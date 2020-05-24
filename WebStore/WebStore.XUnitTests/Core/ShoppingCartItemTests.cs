using WebStore.Core.Entities;
using Xunit;

namespace WebStore.XUnitTests.Core
{
    public class ShoppingCartItemTests
    {
        [Fact]
        public void Create_Product()
        {
            #region Arrange
            // todo: define the required assets
            int shoppingCartItemId = 1;
            Product product = null;
            int amount = 1;
            string shoppingCartId = "ShoppingCartId";
            #endregion

            #region Act
            // todo: invoke the test
            var shoppingCartItem = new ShoppingCartItem
            {
                ShoppingCartId = shoppingCartId,
                Product = product,
                Amount = amount,
                ShoppingCartItemId = shoppingCartItemId
            };
            #endregion

            #region Assert
            // todo: verify that conditions are met
            Assert.Equal(shoppingCartId, shoppingCartItem.ShoppingCartId);
            Assert.Equal(product, shoppingCartItem.Product);
            Assert.Equal(amount, shoppingCartItem.Amount);
            Assert.Equal(shoppingCartItemId, shoppingCartItem.ShoppingCartItemId);
            #endregion
        }
    }
}
