using Microsoft.AspNetCore.Mvc;
using RehabDataProject.Data;
using RehabDataProject.Models;

namespace RehabDataProject.Controllers
{
    public class Patient_InfoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public Patient_InfoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Patient_Info> objPatientsList = _db.Patients_Info;
            return View(objPatientsList);
        }
        //GET
        public IActionResult Create()
        {
            
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Patient_Info obj)
        {
            if (ModelState.IsValid)
            {
                _db.Patients_Info.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
		//GET
		public IActionResult Edit(int? id)
		{
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var patientFromDb = _db.Patients_Info.Find(id);

            if(patientFromDb == null)
            {
                return NotFound();
            }
			return View(patientFromDb);
		}
		//POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Patient_Info obj)
		{
			if (ModelState.IsValid)
			{
				_db.Patients_Info.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);
		}
	}
}
