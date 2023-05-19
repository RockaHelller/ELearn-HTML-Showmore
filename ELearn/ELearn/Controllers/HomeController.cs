using ELearn.Data;
using ELearn.Models;
using ELearn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ELearn.Controllers
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

            List<Slider> slider = await _context.Sliders.ToListAsync();
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.Author).Include(m=>m.CourseImages).ToListAsync();
            IEnumerable<MileStone> mileStones = await _context.MileStones.ToListAsync();

            HomeVM model = new()
            {
                Slider = slider,
                Courses = courses,
                MileStones = mileStones

            };


            return View(model);
        }



    }
}