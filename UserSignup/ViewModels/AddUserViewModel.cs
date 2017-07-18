using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match") ]
        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]
        public string Verify { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        public void AddUser()
        {
            User user = new User {
                Username = Username,
                Password = Password,
                Email = Email
            };
            UserData.Add(user);
        }

        public AddUserViewModel() { }



    }
}
