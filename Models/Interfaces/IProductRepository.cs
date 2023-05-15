using System.Collections.Generic;

namespace SmallShopIT.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        Product GetProductById(int productId);
        IEnumerable<Product> GetProductByPhrase(string phrase);
        IEnumerable<Product> RecommendedProducts { get; }
    }
}
