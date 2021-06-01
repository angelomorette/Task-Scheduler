using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskScheduler.Models;

namespace TaskScheduler.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario/Casdastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Usuario/Login
        public ActionResult Login()
        {
            return View();
        }

        //POST 
        [HttpPost]
        public ActionResult AutenticarUsuario(LoginModel model)
        {
            //verificar se nao ocorreram erros de validação na model
            if (ModelState.IsValid)
            {
                ViewBag.Mensagem = "Teste";
            }
            return View("Login"); //page_load

        }

        //POST
        [HttpPost]
        public ActionResult CadastrarUsuario(CadastroModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensagem = "Teste";
            }
            return View("Cadastro"); //page_load
        }
    }
}