using Microsoft.AspNetCore.Mvc;
using NietoITELEC1C.Models;
using NietoITELEC1C.Services;

namespace NietoITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly ImyFakeDataService _fakeData;

        public StudentController(ImyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }
            /* var st = new Student();
             * st.FirstName = "Rico";
             * st.LastName = "Nieto";
             * st.Id = 1;
             * st.Birthday = DateTime.Parse("05/01/1993");
             * st.Email = "rico.nieto.cics@ust.edu.ph";
             * st.Major = Major.BSIT;
             * 
             * ViewBag.student =st; */

            
        public IActionResult Student()
        {
            return View(_fakeData.StudentList);
        }
        public IActionResult showDetails(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);

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
            _fakeData.StudentList.Add(newStudent);
            return RedirectToAction("Student");
        }


        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }


        [HttpPost]
        public IActionResult EditStudent(Student updStudent)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == updStudent.Id);

            if (student != null)
            {
                student.Id = updStudent.Id;
                student.FirstName = updStudent.FirstName;
                student.LastName = updStudent.LastName;
                student.Email = updStudent.Email;
                student.Birthday = updStudent.Birthday;
                student.Major = updStudent.Major;
            }
            return RedirectToAction("Student");
            //return View("Student", _fakeData.StudentList);
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult DeleteStudent(Student delStudent)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == delStudent.Id);
            _fakeData.StudentList.Remove(student);
            return RedirectToAction("Student");
            //return View("Student", _fakeData.StudentList);
        }

    }
}
