using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Models
{
    public class Cliente
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo permite apenas 2 a 30 caracteres")]
        public string CliNome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "*O campo CPF é obrigatório")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "*CPF inválido")]
        public string CliCPF { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "*A data de nascimento é obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CliDtNasc
        {
            get
            {
                return this.cliDtNasc.HasValue
                    ? this.cliDtNasc.Value
                    : DateTime.Now;
            }
            set
            {
                this.cliDtNasc = value;
            }


        }

        private DateTime? cliDtNasc = null;


        [Display(Name = "E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "*E-mail em formato inválido.")]
        [Required(ErrorMessage = "*O campo E-mail é obrigatório")]
        public string CliEmail { get; set; }

        [Display(Name ="Celular")]
        [Required(ErrorMessage = "*O campo celular é obrigatório")]
        [StringLength(20, MinimumLength = 9, ErrorMessage = "*Número de contato inválido")]
        public string CliTel { get; set; }

        [Display(Name ="Endereço")]
        [Required(ErrorMessage = "*O campo endereço é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo permite apenas 5 a 30 caracteres")]
        public string CliEnd { get; set; }
    }
}