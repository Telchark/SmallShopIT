using Microsoft.AspNetCore.Mvc;
using SmallShopIT.Models;
using SmallShopIT.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SmallShopIT.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "Wszystkie produkty";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductsListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult SearchList(SearchViewModel svm)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(svm.Phrase))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "Wszystkie produkty";
            }
            else
            {
                products = _productRepository.GetProductByPhrase(svm.Phrase);
                currentCategory = $"Wyniki dla '{svm.Phrase}'";
            }

            return View(new ProductsListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
