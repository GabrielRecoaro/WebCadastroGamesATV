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
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1, 10, ErrorMessage = "*Código inválido")]
        public int JogoCod { get; set; }

        [Display(Name="Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo nome permite apenas 2 a 30 caracteres")]
        public string JogoNome { get; set; }

        [Display(Name="Versão")]
        public  string JogoVers { get; set; }

        [Display(Name="Desenvolvedor")]
        [Required(ErrorMessage = "*O campo desenvolvedor é obrigatório")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "*O campo desenvolvedor permite apenas 4 a 30 caracteres")]
        public string JogoDes { get; set; }

        [Display(Name="Gênero")]
        [Required(ErrorMessage = "*O campo gênero é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo gênero permite apenas 2 a 30 caracteres")]
        public string JogoGender { get; set; }

        [Display(Name="Faixa Etária")]
        [Required(ErrorMessage = "*O campo faixa etária é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "*O campo faixa etária permite apenas 2 a 10 caracteres")]
        public string JogoFaixa { get; set; }

        [Display(Name="Plataforma")]
        [Required(ErrorMessage = "*O campo plataforma é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "*O campo plataforma permite apenas 2 a 10 caracteres")]
        public string JogoPlat { get; set; }

        [Display(Name = "Data de lançamento")]
        [Required(ErrorMessage = "*O campo data de lançamento é obrigatório")]
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
        [Required(ErrorMessage = "*O campo sinopse é obrigatório")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "*O campo permite apenas 10 a 300 caracteres")]
        public string JogoSinopse { get; set; }
    }
}