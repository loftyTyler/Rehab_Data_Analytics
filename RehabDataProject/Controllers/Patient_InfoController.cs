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
    }
}
