﻿using Microsoft.AspNetCore.Mvc;
using NietoITELEC1C.Data;
using NietoITELEC1C.Models;
using NietoITELEC1C.Services;

namespace NietoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbContext;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Instructor()
        {
            return View(_dbContext.Instructors);
        }
        public IActionResult showDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

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
            if (!ModelState.IsValid)
            {
                return View();
            }
            _dbContext.Instructors.Add(newInstructor);
            //return View("Instructor", _fakeData.InstructorList);
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }


        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
          //  Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);
           // _fakeData.InstructorList.Remove(instructor);
           // return View("Instructor", _fakeData.InstructorList);

        //}



        [HttpPost]
        public IActionResult EditInstructor(Instructor newInstructor)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)
            {
                instructor.Id = newInstructor.Id;
                instructor.FirstName = newInstructor.FirstName;
                instructor.LastName = newInstructor.LastName;
                instructor.Status = newInstructor.Status;
                instructor.HiringDate = newInstructor.HiringDate;
                instructor.Rank = newInstructor.Rank;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }

        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult DeleteInstructor(Instructor delInstructor)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == delInstructor.Id);
            _dbContext.Instructors.Remove(instructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }
    }
}
