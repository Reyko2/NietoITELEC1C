using System.ComponentModel.DataAnnotations;

namespace NietoITELEC1C.Models
{
    public enum Major
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        [Required(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter a valid date")]
        public DateTime? Birthday { get; set; }

        [Display(Name = "Major")]
        [Required(ErrorMessage = "Select a major")]
        public Major? Major { get; set; }
     






    }
}
