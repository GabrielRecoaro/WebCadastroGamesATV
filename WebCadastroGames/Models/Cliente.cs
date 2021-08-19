using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Models
{
    public class Cliente
    {
        public string CliNome { get; set; }

        public string CliCPF { get; set; }

        public DateTime CliDtNasc { get; set; }

        public string CliEmail { get; set; }

        public string CliTel { get; set; }

        public string CliEnd { get; set; }
    }
}