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
        [Range(1, 10, ErrorMessage = "O código deve ter de 1 a 10 caracteres")]
        public ushort JogoCod { get; set; }

        [Display(Name="Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo permite apenas de 2 a 30 caracteres")]
        public string JogoNome { get; set; }

        [Display(Name="Versão")]
        public  string JogoVers { get; set; }

        [Display(Name="Desenvolvedor")]
        [Required(ErrorMessage = "*O campo desenvolvedor é obrigatório")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "*O campo permite apenas de 4 a 30 caracteres")]
        public string JogoDes { get; set; }

        [Display(Name="Genêro")]
        [Required(ErrorMessage = "*O campo genêro é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo permite apenas de 2 a 30 caracteres")]
        public string JogoGender { get; set; }

        [Display(Name="Faixa Etária")]
        [Required(ErrorMessage = "*O campo faixa etária é obrigatório")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "*O campo permite apenas de 2 a 3 caracteres")]
        public string JogoFaixa { get; set; }

        [Display(Name="Plataforma")]
        [Required(ErrorMessage = "*O campo plataforma é obrigatório")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "*O campo permite apenas de 2 a 10 caracteres")]
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
        [Required(ErrorMessage = "*O campo sinopse é obrigatório")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "*O campo permite apenas de 10 a 100 caracteres")]
        public string JogoSinopse { get; set; }
    }
}