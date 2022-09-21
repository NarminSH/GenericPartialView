using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmptyMVC.Controllers
{
    public class PhoneController : Controller
    {
        private readonly PhoneDbContext _context;
        public PhoneController(PhoneDbContext context)
        {
            _context = context;
        }
        //PhoneDbContext _context = new PhoneDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_context.Phones.ToList());
        }
    }
}

