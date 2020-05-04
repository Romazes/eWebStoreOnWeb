using System.Collections.Generic;
using WebStore.Core.Entities;
using WebStore.Core.Interfaces;

namespace WebStore.Infrastructure.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Red tea", Description="Chinese red tea is a highly fermented tea"},
                new Category{CategoryId=2, CategoryName="Puer", Description="The most popular variety of Chinese tea today, shu puer"},
                new Category{CategoryId=3, CategoryName="Green tea", Description="Represents the largest category of Chinese teas"}
            };
    }
}
