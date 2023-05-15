using System.Collections.Generic;

namespace SmallShopIT.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
