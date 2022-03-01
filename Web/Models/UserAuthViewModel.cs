using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class UserAuthViewModel
    {
        [Required(ErrorMessage = "Поле Логин является обязательным")]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле Пароль является обязательным")]
        [Display(Name = "Password")]
        public string Password { get; set; }

		public string redirectUrl { get; set; }
	}
}
