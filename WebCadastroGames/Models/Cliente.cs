using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Models
{
    public class Cliente
    {
        public string CliNome { get; set; }

        public ushort CliCPF { get; set; }

        public DateTime CliDtNasc { get; set; }

        public string CliEmail { get; set; }

        public int CliTel { get; set; }

        public string CliEnd { get; set; }
    }
}