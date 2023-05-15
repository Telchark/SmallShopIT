using Microsoft.AspNetCore.Mvc;
using SmallShopIT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallShopIT.Components
{
    public class SearchBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new SearchViewModel() { Phrase = "" };
            return View(model);
        }
    }
}
