using System;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.ViewModels.Account
{
	public class LoginVM
	{
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MinLength(9),MaxLength(100), DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

