using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskScheduler.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Por favor, informe o login de acesso.")]
        [Display(Name = "Informe seu login:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha de acesso")]
        [Display(Name = "Informe sua Senha:")] //label
        public string Senha { get; set; }
    }
}