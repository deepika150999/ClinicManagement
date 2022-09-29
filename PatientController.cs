using Microsoft.AspNetCore.Mvc;
using PatientApp.Models;

namespace PatientApp.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Getpatient()
        {
            Patient pat = new Patient()
            {
                Id = 101,
                Name = "Mehna",
                Disease = "Viral Flu "
            };
            return View("Patient", pat);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
