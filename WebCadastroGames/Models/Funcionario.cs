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
        [Required(ErrorMessage = "*O campo código é obrigatório")]
        [Range(1,4, ErrorMessage = "*Código inválido")]
        public int FuncCod { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*O campo nome é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "*O campo permite apenas 3 a 50 caracteres")]
        public string FuncNome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "*O campo CPF é obrigatório")]
        [StringLength(14, MinimumLength = 9, ErrorMessage = "*CPF inválido")]
        public string FuncCPF { get; set; }

        [Display(Name = "RG")]
        [Required(ErrorMessage = "*O campo RG é obrigatório")]
        [StringLength(15, MinimumLength = 12, ErrorMessage = "*RG inválido")]
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
        [StringLength(30, MinimumLength = 2, ErrorMessage = "*O campo permite apenas 5 a 30 caracteres")]
        public string FuncEnd { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "*O campo celular é obrigatório")]
        [StringLength(17, MinimumLength = 10, ErrorMessage = "*Número de contato inválido")]
        public string FuncTel { get; set; }

        [Display(Name = "E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "*E-mail em formato inválido.")]
        [Required(ErrorMessage = "*O campo E-mail é obrigatório")]
        public string FuncEmail { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "*O campo cargo é obrigatório")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "*O campo permite apenas 5 a 15 caracteres")]
        public string FuncCargo { get; set; }

    }
}