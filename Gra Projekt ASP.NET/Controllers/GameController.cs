using Gra_Projekt_ASP.NET.Data;
using Gra_Projekt_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gra_Projekt_ASP.NET.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GameController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<GameModel> objGameList = _db.Game;
            return View(objGameList);
        }
        //GET   
        public IActionResult Create()
        {

            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GameModel obj)
        {
            if(obj.Name == obj.Category.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Game.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category crated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET   
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            var gameFromDb = _db.Game.Find(id);
            //var categoryFromFDbFirst  =_db.Categories.FirstOrDefault(u => u.Id == id);
            //var categoryFromFDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);
            
            if (gameFromDb == null)
            {
                return NotFound();
            }
            return View(gameFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(GameModel obj)
        {
            if (obj.Name == obj.Category.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Game.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var gameFromDb = _db.Game.Find(id);
            //var categoryFromFDbFirst  =_db.Categories.FirstOrDefault(u => u.Id == id);
            //var categoryFromFDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (gameFromDb == null)
            {
                return NotFound();
            }
            return View(gameFromDb);
        }
        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
         {
           var obj = _db.Game.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
                _db.Game.Remove(obj);
                _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
            
            
        }
    }
}
