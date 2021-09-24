using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCadastroGames.Models;
using WebCadastroGames.Repositorio;

namespace WebCadastroGames.Controllers
{
    public class FuncionarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult Funcionario(Funcionario funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ac.CadastrarFuncionario(funcionario);
                    return RedirectToAction("ListarFuncionario");
                }
                return View(funcionario);
            }
            catch
            {
                return RedirectToAction("Funcionario");
            }
        }


        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);

        }
    }

   
}