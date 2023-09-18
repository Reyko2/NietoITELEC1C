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
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Student", StudentList);
        }



        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditStudent(Student updStudent)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == updStudent.Id);

            if (student != null)
            {
                student.Id = updStudent.Id;
                student.FirstName = updStudent.FirstName;
                student.LastName = updStudent.LastName;
                student.Email = updStudent.Email;
                student.Birthday = updStudent.Birthday;
                student.Major = updStudent.Major;
            }
            return View("Student", StudentList);
        }
       
    }
}
