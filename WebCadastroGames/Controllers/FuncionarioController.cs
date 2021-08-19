using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCadastroGames.Models;

namespace WebCadastroGames.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }

        [HttpPost]

        public ActionResult Index(Funcionario funcionario)
        {
            return View("Listar", funcionario);
        }
    }

   
}