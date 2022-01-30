using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio03.Models
{
    public class Contact
    {
        
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public String Emri { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public String Projekti { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(200)]

        public String Mesazhi { get; set; }
    }
}
