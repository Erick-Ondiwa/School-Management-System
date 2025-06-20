using System;
using System.ComponentModel.DataAnnotations;

namespace schoolManagement.API.Dtos
{
   public class TeacherDto
    {
        public string? TeacherId { get; set; }

          // [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }


        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? Department { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }

        public string? PhotoUrl { get; set; }

        public string UserId { get; set; }

    }
}


