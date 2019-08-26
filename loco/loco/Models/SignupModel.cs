using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;



namespace loco.Models
{ 
    public class SignupModel
    {
        [Required, MaxLength(25), MinLength(3)]
        public string Name { get; set; }

        [Required, MaxLength(15), MinLength(5)]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}
