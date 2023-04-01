using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAppleProject.Infrasrtucture;
using MyAppleProject.Models;

namespace MyAppleProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;
        public ProductsController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string categorySlug = "", int p=1)
        {
            int pageSize = 3;
            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.CategorySlug = categorySlug;

            if (categorySlug == "")
            {
                ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Products.Count() / pageSize);
                return View(await _context.Products.OrderByDescending(p=>p.Id).Skip((p-1) * pageSize).Take(pageSize).ToListAsync());
            }

            Category category = await _context.Categories.Where(c => c.Slug == categorySlug).FirstOrDefaultAsync();
            if(category == null) return RedirectToAction("Index");
            var productByCategory = _context.Products.Where(P=>P.CategoryId == category.Id);
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)productByCategory.Count() / pageSize);

            return View(await productByCategory.OrderByDescending(p=>p.Id).Skip((p-1)* pageSize).Take(pageSize).ToListAsync());
        }
    }
}
