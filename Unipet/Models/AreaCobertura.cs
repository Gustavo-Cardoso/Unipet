using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("AreaCobertura")]
    public class AreaCobertura
    {
        [Key]
        public int IdArea { get; set; }

        [Required(ErrorMessage = "O campo NOME DA ÁREA é obrigatório")]
        [StringLength(30, ErrorMessage = "O nome da área deve possuir no máximo 30 caracteres")]
        [Display(Name = "Área")]
        public string NomeArea { get; set; }

        [Required]
        public int IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public Municipio Municipio { get; set; }

        [Required]
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [Display(Name = "Ativo?")]
        public bool ExibirHome { get; set; }
    }
}
