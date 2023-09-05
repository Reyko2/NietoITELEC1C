using Microsoft.AspNetCore.Mvc;

namespace NietoITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }
    }
}
