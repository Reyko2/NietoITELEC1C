using NietoITELEC1C.Models;
using NietoITELEC1C.Services;

namespace NietoITELEC1C.Services
{
    public class MyFakeDataService : ImyFakeDataService
    {   
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        //Constructor
        public MyFakeDataService() 
        {
              StudentList = new List<Student>()
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


            InstructorList = new List<Instructor>()
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


        }

       
    }
}
