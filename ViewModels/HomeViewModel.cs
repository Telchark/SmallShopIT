using SmallShopIT.Models;
using System.Collections.Generic;

namespace SmallShopIT.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> RecommendedProducts { get; set; }
    }
}
