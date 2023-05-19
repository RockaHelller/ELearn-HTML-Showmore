using Fiorelle_BACKEND.Areas.Admin.ViewModels.Slider;
using Fiorelle_BACKEND.Data;
using Fiorelle_BACKEND.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fiorelle_BACKEND.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }





    }
}