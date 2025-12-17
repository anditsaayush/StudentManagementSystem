using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        public string Department { get; set; }

        [Range(1, 8)]
        public int Semester { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
