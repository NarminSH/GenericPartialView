using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EmptyMVC.Controllers
{
    public class ComputerController : Controller
    {
        private readonly PhoneDbContext _context;
        public ComputerController(PhoneDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Computers.ToListAsync());
        //}

        public async Task<IActionResult> Index(string brand)
        {
            if (brand == null)
            {
                var comps = await _context.Computers.ToListAsync();
                return View(comps);
            }

            var computers = await _context.Computers.Where(x => x.Brand == brand).ToListAsync();
            return View(computers);
        }
    }
}

