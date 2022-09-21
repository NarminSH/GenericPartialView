using System;
using Microsoft.AspNetCore.Mvc;

namespace EmptyMVC.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }
}

