using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.Models.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        public string Name { get; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
        public string ReturnUrl { get; set; }
    }
}
