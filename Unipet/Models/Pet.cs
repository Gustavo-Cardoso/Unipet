using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Pet")]
    public class Pet
    {
        [Key]
        public int IdPet { get; set; }

        [Required(ErrorMessage = "O campo NOME é obrigatório")]
        [StringLength(60, ErrorMessage = "O nome do pet deve possuir no máximo 60 caracteres")]
        [Display(Name = "Nome")]
        public string NomePet { get; set; }

        [Required(ErrorMessage = "O campo DATA NASCIMENTO é obrigatório")]
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo SEXO é obrigatório")]
        public char Sexo { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }

        [Required]
        public int IdTutor { get; set; }
        [ForeignKey("IdTutor")]
        [Display(Name = "Tutor (CPF)")]
        public Tutor Tutor { get; set; }

        [Required]
        public int IdEspecie { get; set; }
        [ForeignKey("IdEspecie")]
        public Especie Especie { get; set; }

        [Required]
        public int IdRaca { get; set; }
        [ForeignKey("IdRaca")]
        public Raca Raca { get; set; }

        [Required]
        public int IdPorte { get; set; }
        [ForeignKey("IdPorte")]
        public Porte Porte { get; set; }

        [Display(Name = "Ativo?")]
        public bool ExibirHome { get; set; }
    }
}
