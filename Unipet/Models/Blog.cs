using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int IdPublicacao { get; set; }

        [Required(ErrorMessage = "O campo TÍTULO é obrigatório")]
        [StringLength(100, ErrorMessage = "O titulo deve possuir no máximo 100 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo TEXTO é obrigatório")]
        [StringLength(1000, ErrorMessage = "O texto deve possuir no máximo 1000 caracteres")]
        public string Texto { get; set; }

        [Required]
        public DateTime DataPublicacao { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }

        [Display(Name = "Ativo?")]
        public bool ExibirHome { get; set; }
    }
}
