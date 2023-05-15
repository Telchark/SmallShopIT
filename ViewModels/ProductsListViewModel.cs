using SmallShopIT.Models;
using System.Collections.Generic;

namespace SmallShopIT.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
