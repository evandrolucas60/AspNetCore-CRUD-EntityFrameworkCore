using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoCrudMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrudMvc.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IESContext _context;

        public DepartmentController(IESContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Departments.OrderBy(c => c.Name).ToListAsync());
        }
    }
}
