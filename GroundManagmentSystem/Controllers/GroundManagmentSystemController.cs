using Microsoft.AspNetCore.Mvc;
using GroundManagmentSystem.Data;
using GroundManagmentSystem.Models;
using GroundManagmentSystem.Controllers;
using Microsoft.Data.SqlClient;

namespace GroundManagmentSystem.Controllers
{
    public class GroundManagmentSystem : Controller
    {
        private readonly Ground_Managment_System_Db_context _db;

        public GroundManagmentSystem(Ground_Managment_System_Db_context db)
        {
            _db = db;
        }

       
        public IActionResult Pit()
        {
            return View();
        }
        public IActionResult Lines_view()
        {
            return View();
        }
        public IActionResult part_view()
        {
            return View();

        }
        public IActionResult Index()
        {
            IEnumerable<ISA_Model> objCategoryList = _db.ISA_Models;
            return View(objCategoryList);
        }

        public IActionResult Create()  //GET
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ISA_Model obj) //POST
        {
            _db.ISA_Models.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)  //GET
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.ISA_Models.Find(id);
            if (CategoryFromDb == null)
            {
                return NotFound();
            }

            return View(CategoryFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ISA_Model obj) //POST
        {


            _db.ISA_Models.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
        public IActionResult Delete(int? id)  //GET
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.ISA_Models.Find(id);
            if (CategoryFromDb == null)
            {
                return NotFound();
            }

            return View(CategoryFromDb);
        }


        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id) 
        {

            var obj = _db.ISA_Models.Find(id);
            if (obj==null)
            {
                return NotFound();
            }
            _db.ISA_Models.Remove(obj);
                _db.SaveChanges();
            return RedirectToAction("Index");

            



        }
        public IActionResult Details(int? id)  //GET
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.ISA_Models.Find(id);
            if (CategoryFromDb == null)
            {
                return NotFound();
            }

            return View(CategoryFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ISA_Model obj) //POST
        {


            _db.ISA_Models.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }

        public IActionResult Index1()
        {

            return View();
        }

        


    }
}

