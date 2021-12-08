using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Unipet.Models
{
    [Table("Relato")]
    public class Relato
    {
        [Key]
        public int IdRelato { get; set; }

        [Required(ErrorMessage = "O campo NOME é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo TEXTO é obrigatório")]
        [StringLength(1000, ErrorMessage = "O texto deve possuir no máximo 1000 caracteres")]
        public string Texto { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }

        [Display(Name = "Ativo?")]
        public bool ExibirHome { get; set; }
    }
}


    