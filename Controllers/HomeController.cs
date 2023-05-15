using Microsoft.AspNetCore.Mvc;
using SmallShopIT.Models;
using SmallShopIT.ViewModels;

namespace SmallShopIT.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                RecommendedProducts = _productRepository.RecommendedProducts
            };

            return View(homeViewModel);
        }
    }
}
