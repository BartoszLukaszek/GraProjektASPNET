using Gra_Projekt_ASP.NET.Data;
using Microsoft.AspNetCore.Mvc;

namespace Gra_Projekt_ASP.NET.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}
