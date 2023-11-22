using FrontToBack_2.DAL;
using FrontToBack_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack_2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products.Include(p=>p.Department).ToListAsync();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) return View();

            bool result = _context.Products.Any(c => c.Name.ToLower().Trim() == product.Name.ToLower().Trim());
            if (result)
            {
                ModelState.AddModelError("Name", "Bu Product artiq movcuddur.");
                return View();
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }

    }
}
