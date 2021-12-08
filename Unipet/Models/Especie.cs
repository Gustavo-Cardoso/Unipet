using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Especie")]
    public class Especie
    {
        [Key]
        public int IdEspecie { get; set; }

        [Required(ErrorMessage = "O campo ESPÉCIE é obrigatório")]
        [StringLength(20, ErrorMessage = "A espécie do pet deve possuir no máximo 20 caracteres")]
        public string NomeEspecie { get; set; }
    }
}