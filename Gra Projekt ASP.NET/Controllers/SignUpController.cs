using Gra_Projekt_ASP.NET.Data;
using Gra_Projekt_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gra_Projekt_ASP.NET.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SignUpController(ApplicationDbContext db)

        {
            _db = db;
        }
      

        public IActionResult Index()
        {
            IEnumerable<SignUp> objSingUpList= _db.SignUp;
            return View(objSingUpList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SignUp obj)
        {
            
            _db.SignUp.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}
