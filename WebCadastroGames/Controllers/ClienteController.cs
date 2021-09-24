using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCadastroGames.Models;
using WebCadastroGames.Repositorio;

namespace WebCadastroGames.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Cliente()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        Acoes ac = new Acoes();
        [HttpPost]


        public ActionResult ListarCliente(Cliente cliente)
        {
            var ExibirCliente = new Acoes();
            var TodosCliente = ExibirCliente.ListarCliente();
            return View(TodosCliente);
        }


    }
}