using NietoITELEC1C.Models;
namespace NietoITELEC1C.Services
{
    public interface ImyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
