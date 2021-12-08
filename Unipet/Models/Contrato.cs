using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Contrato")]
    public class Contrato
    {
        [Key]
        public int IdContrato { get; set; }

        [Required(ErrorMessage = "O campo DATA DE INÍCIO é obrigatório")]
        [Display(Name = "Vigência")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O campo DATA DE TÉRMINO é obrigatório")]
        [Display(Name = "Vigência")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "O campo VALOR COMBINADO é obrigatório")]
        [Display(Name = "Valor (R$)")]
        public decimal ValorCombinado { get; set; }

        [Required]
        public int IdPlano { get; set; }
        [ForeignKey("IdPlano")]
        public Plano Plano { get; set; }

        [Required]
        public int IdTutor { get; set; }
        [ForeignKey("IdTutor")]
        public Tutor Tutor { get; set; }

        [Required]
        public int IdPet { get; set; }
        [ForeignKey("IdPet")]
        public Pet Pet { get; set; }

        [Required]
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }
    }
}