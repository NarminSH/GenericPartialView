using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmptyMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly PhoneDbContext _context;
        public CategoryController(PhoneDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        

    }
}

