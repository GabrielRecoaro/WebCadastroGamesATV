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
        public string CliNome { get; set; }

        [Display(Name = "CPF")]
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


        [Display(Name = "Email")]
        public string CliEmail { get; set; }

        [Display(Name ="Telefone de contato")]
        public string CliTel { get; set; }

        [Display(Name ="Endereço")]
        public string CliEnd { get; set; }
    }
}