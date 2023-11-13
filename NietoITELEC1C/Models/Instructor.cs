using NietoITELEC1C.Models;
using System.ComponentModel.DataAnnotations;

namespace NietoITELEC1C.Models
{
    public enum Rank
    {
       NotSelected, Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Please select a status")]
        public bool Status { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter a valid date")]
        public DateTime? HiringDate { get; set; }

        [Required(ErrorMessage = "Please select a rank")]
        [Range(typeof(Rank), nameof(Rank.Instructor), nameof(Rank.Professor), ErrorMessage = "Please select a rank")]
        public Rank Rank { get; set; }





    }
}
