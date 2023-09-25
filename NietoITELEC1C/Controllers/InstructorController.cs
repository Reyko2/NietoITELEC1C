using Microsoft.AspNetCore.Mvc;
using NietoITELEC1C.Models;
using NietoITELEC1C.Services;

namespace NietoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly ImyFakeDataService _fakeData;

        public InstructorController(ImyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }

        public IActionResult Instructor()
        {
            return View(_fakeData.InstructorList);
        }
        public IActionResult showDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            _fakeData.InstructorList.Add(newInstructor);
            return View("Instructor", _fakeData.InstructorList);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);
            _fakeData.InstructorList.Remove(instructor);
            return View("Instructor", _fakeData.InstructorList);

        }



        [HttpPost]
        public IActionResult EditInstructor(Instructor newInstructor)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)
            {
                instructor.Id = newInstructor.Id;
                instructor.FirstName = newInstructor.FirstName;
                instructor.LastName = newInstructor.LastName;
                instructor.Status = newInstructor.Status;
                instructor.HiringDate = newInstructor.HiringDate;
                instructor.Rank = newInstructor.Rank;
            }
            return View("Instructor", _fakeData.InstructorList);
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult DeleteInstructor(Instructor delInstructor)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == delInstructor.Id);
            _fakeData.InstructorList.Remove(instructor);
            return View("Instructor", _fakeData.InstructorList);
        }
    }
}
