using Microsoft.AspNetCore.Mvc;
using NietoITELEC1C.Models;

namespace NietoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {

            List<Instructor> InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Caster",
                    LastName = "Lopez",
                    HiringDate = DateTime.Parse("8/09/2023"),
                    Rank = Rank.AssistantProfessor,
                    Status = false
                },
               new Instructor()
                {
                    Id = 2,
                    FirstName = "Gelo",
                    LastName = "Filomeno",
                    HiringDate = DateTime.Parse("04/01/2016"),
                    Rank = Rank.Professor,
                    Status = true
                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Draico",
                    LastName = "Gallardo",
                    HiringDate = DateTime.Parse("04/01/2022"),
                    Rank = Rank.Instructor,
                    Status = false
                }
                };
        public IActionResult Instructor()
        {
            return View(InstructorList);
        }
        public IActionResult showDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

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
            InstructorList.Add(newInstructor);
            return View("Instructor", InstructorList);
        }











        [HttpPost]
        public IActionResult EditInstructor(Instructor newInstructor)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)
            {
                instructor.Id = newInstructor.Id;
                instructor.FirstName = newInstructor.FirstName;
                instructor.LastName = newInstructor.LastName;
                instructor.Status = newInstructor.Status;
                instructor.HiringDate = newInstructor.HiringDate;
                instructor.Rank = newInstructor.Rank;
            }
            return View("Instructor", InstructorList);
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }
    }
}
