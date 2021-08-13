using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCadastroGames.Models;

namespace WebCadastroGames.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente


        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]

        public ActionResult Index (Cliente cliente)
        {
            return View("Listar", cliente);
        }

    }
}