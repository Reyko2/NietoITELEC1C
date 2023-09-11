using Microsoft.AspNetCore.Mvc;
using NietoITELEC1C.Models;

namespace NietoITELEC1C.Controllers
{
    public class StudentController : Controller
    {
            /* var st = new Student();
             * st.FirstName = "Rico";
             * st.LastName = "Nieto";
             * st.Id = 1;
             * st.Birthday = DateTime.Parse("05/01/1993");
             * st.Email = "rico.nieto.cics@ust.edu.ph";
             * st.Major = Major.BSIT;
             * 
             * ViewBag.student =st; */

            List<Student> StudentList = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Rico",
                    LastName = "Nieto",
                    Birthday = DateTime.Parse("04/01/2002"),
                    Major = Major.BSIT,
                    Email = "rico.nieto.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Zeke",
                    LastName = "Gonzalez",
                    Birthday = DateTime.Parse("04/01/2001"),
                    Major = Major.BSIS,
                    Email = "ezequiel.gonzalez.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Edmund",
                    LastName = "Garraton",
                    Birthday = DateTime.Parse("12/12/2003"),
                    Major = Major.BSCS,
                    Email = "edmund.garraton.cics@ust.edu.ph"
                }
                };
        public IActionResult Student()
        {
            return View(StudentList);
        }
        public IActionResult showDetails(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
    }
}
