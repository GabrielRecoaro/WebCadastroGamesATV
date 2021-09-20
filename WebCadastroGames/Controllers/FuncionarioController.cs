﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCadastroGames.Repositorio;
using System.Web.Mvc;
using WebCadastroGames.Models;

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

        public ActionResult Cadfuncionario(Funcionario fun)
        {
            ac.CadastrarFuncionario(fun);
            return View(fun);
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }

   
}