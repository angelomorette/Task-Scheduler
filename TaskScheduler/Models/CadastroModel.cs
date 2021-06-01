using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskScheduler.Models
{
    public class CadastroModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome do usuário.")]
        [RegularExpression("^[A-Za-zÀ-Üà-ü\\s]{6,50}$", 
            ErrorMessage = "Erro. Nome inválido.")]
        [Display(Name = "Informe seu Nome:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o login do usuario.")]
        [RegularExpression("^[a-z0-9]{6,20}$",
            ErrorMessage = "Erro. Login inválido.")]
        [Display(Name = "Login de Acesso:")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha do usuario.")]
        [RegularExpression("^[A-Za-z0-9@]{6,20}$",
            ErrorMessage = "Erro. Senha inválida.")]
        [Display(Name = "Senha de Acesso:")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Por favor, confirme a senha do usuario.")]
        [Compare("Senha",
            ErrorMessage = "Erro. Confirme sua Senha corretamente.")]
        [Display(Name = "Confirme sua Senha:")] 
        public string SenhaConfirm { get; set; }
    }
}