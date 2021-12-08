using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Raca")]
    public class Raca
    {
        [Key]
        public int IdRaca { get; set; }

        [Required(ErrorMessage = "O campo RAÇA é obrigatório")]
        [StringLength(30, ErrorMessage = "A raça do pet deve possuir no máximo 30 caracteres")]
        public string NomeRaca { get; set; }

        [Required]
        public int IdEspecie { get; set; }
        [ForeignKey("IdEspecie")]
        public Especie Especie { get; set; }
    }
}
