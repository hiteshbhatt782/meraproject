using System.ComponentModel.DataAnnotations;

namespace meraproject.Models
{
    public class Student
    {
        [Key]
        [Display(Name ="Student Id")]

        public int StudentId { get; set; }
        [Required]
        [Display(Name="Student Name")]
        public string StudentName { get; set; }
        public string? course { get; set; }
        public string email { get; set; }
    }
}
