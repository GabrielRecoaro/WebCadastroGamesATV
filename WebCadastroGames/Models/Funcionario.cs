using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCadastroGames.Models
{
    public class Funcionario
    {
        [Display(Name = "Código")]
        [Range(1,4, ErrorMessage = "O código deve ter de 1 a 4 caracteres")]
        public ushort FuncCod { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "*O campo permite apenas de 5 a 50 caracteres")]
        public string FuncNome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "*O campo CPF é obrigatório")]
        public string FuncCPF { get; set; }

        [Display(Name = "RG")]
        [Required(ErrorMessage = "*O campo RG é obrigatório")]
        public string FuncRG { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "*A data de nascimento é obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime FuncDtNasc
        {
            get
            {
                return this.funcDtNasc.HasValue 
                    ? this.funcDtNasc.Value
                    : DateTime.Now;
            }
            set
            {
                this.funcDtNasc = value;
            }


        }

        private DateTime? funcDtNasc = null;
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "*O campo endereço é obrigatório")]
        public string FuncEnd { get; set; }

        [Display(Name = "Telefone de contato")]
        [Required(ErrorMessage = "*O campo telefone é obrigatório")]
        public string FuncTel { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "*O campo Email é obrigatório")]
        public string FuncEmail { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "*O campo cargo é obrigatório")]
        public string FuncCargo { get; set; }

    }
}