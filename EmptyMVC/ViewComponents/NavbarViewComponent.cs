using System;
using EmptyMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmptyMVC.ViewComponents
{
    [ViewComponent(Name = "Navbar")]
    public class NavbarViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }

    }
}

