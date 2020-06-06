using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace student.Model
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter student's name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter student's last name")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter student's last name")]
        [Range(1, 120, ErrorMessage = "Age must be a number")]
        public int Age { get; set; }
    }
}
