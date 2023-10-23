using Microsoft.EntityFrameworkCore;
using NietoITELEC1C.Models;

namespace NietoITELEC1C.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(


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
                );

        modelBuilder.Entity<Instructor>().HasData(
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
                );


    }
    }
}
