using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Models
{
    public class Jogo
    {
        [Display(Name="Código")]
        public ushort JogoCod { get; set; }

        [Display(Name="Nome")]
        public string JogoNome { get; set; }

        [Display(Name="Versão")]
        public  string JogoVers { get; set; }

        [Display(Name="Desenvolvedor")]
        public string JogoDes { get; set; }

        [Display(Name="Genêro")]
        public string JogoGender { get; set; }

        [Display(Name="Faixa Etária")]
        public ushort JogoFaixa { get; set; }

        [Display(Name="Plataforma")]
        public string JogoPlat { get; set; }

        [Display(Name = "Data de lançamento")]
        [Required(ErrorMessage = "*A data de lançamento é obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JogoDtLanc
        {
            get
            {
                return this.jogoDtLanc.HasValue
                    ? this.jogoDtLanc.Value
                    : DateTime.Now;
            }
            set
            {
                this.jogoDtLanc = value;
            }


        }

        private DateTime? jogoDtLanc = null;

        [Display(Name="Sinopse")]
        public string JogoSinopse { get; set; }
    }
}