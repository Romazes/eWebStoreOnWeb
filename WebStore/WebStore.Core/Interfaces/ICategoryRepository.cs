using System.Collections.Generic;
using WebStore.Core.Entities;

namespace WebStore.Core.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
