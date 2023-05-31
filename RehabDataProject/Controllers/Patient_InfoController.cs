using Microsoft.AspNetCore.Mvc;

namespace RehabDataProject.Controllers
{
    public class Patient_InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
