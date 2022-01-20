using Gra_Projekt_ASP.NET.Data;
using Gra_Projekt_ASP.NET.Models;
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
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
