using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Models
{
    public class Funcionario
    {
        public ushort FuncCod { get; set; }

        public string FuncNome { get; set; }

        public int FuncCPF { get; set; }

        public int FuncRG { get; set; }

        public DateTime FuncDtNasc { get; set; }

        public string FuncEnd { get; set; }

        public int FuncTel { get; set; }

        public string FuncEmail { get; set; }

        public string FuncCargo { get; set; }

    }
}