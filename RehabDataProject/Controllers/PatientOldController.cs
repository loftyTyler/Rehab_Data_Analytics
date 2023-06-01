using Microsoft.AspNetCore.Mvc;
using RehabDataProject.Data;

namespace RehabDataProject.Controllers
{
   
    public class PatientOldController : Controller
    {
        public PatientOldController(ApplicationDbContext db)
        {
           
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
