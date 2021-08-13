using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Models
{
    public class Jogo
    {
        public ushort JogoCod { get; set; }

        public string JogoNome { get; set; }

        public  int JogoVers { get; set; }

        public string JogoDes { get; set; }

        public string JogoGender { get; set; }

        public ushort JogoFaixa { get; set; }

        public string JogoPlat { get; set; }

        public DateTime JogoDtLanc { get; set; }

        public string JogoSinopse { get; set; }
    }
}