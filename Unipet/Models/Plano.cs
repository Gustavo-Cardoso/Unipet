using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Plano")]
    public class Plano
    {
        [Key]
        public int IdPlano { get; set; }

        [Required(ErrorMessage = "O campo NOME DO PLANO é obrigatório")]
        [StringLength(20, ErrorMessage = "O nome do plano deve possuir no máximo 20 caracteres")]
        [Display(Name = "Plano")]
        public string NomePlano { get; set; }

        [Required(ErrorMessage = "O campo DESCRIÇÃO é obrigatório")]
        [StringLength(500, ErrorMessage = "A descrição deve possuir no máximo 500 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo VALOR é obrigatório")]
        [Display(Name = "Valor (R$)")]
        [Range(0.01, 2000)]

        public decimal Valor { get; set; }

        [Required]
        public int IdArea { get; set; }
        [ForeignKey("IdArea")]
        [Display(Name = "Área/cobertura")]
        public AreaCobertura AreaCobertura { get; set; }

        [Required]
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        [Display(Name = "Email")]
        public Empresa Empresa { get; set; }

        [Display(Name = "Ativo?")]
        public bool ExibirHome { get; set; }

        public ICollection<EspecialidadePlano> EspecialidadesPlanos { get; set; }
    }
}
