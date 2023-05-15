using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmallShopIT.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> RecommendedProducts
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.Recommended);
            }
        }

        public IEnumerable<Product> GetProductByPhrase(string phrase)
        {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.Name.ToLower().Contains(phrase.ToLower()));
        }
        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
