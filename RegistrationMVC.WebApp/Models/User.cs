using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationMVC.WebApp.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(18, 120, ErrorMessage = "Age must be 18 or older.")]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
