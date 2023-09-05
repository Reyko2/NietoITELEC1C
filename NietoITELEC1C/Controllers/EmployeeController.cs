using Microsoft.AspNetCore.Mvc;

namespace NietoITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
