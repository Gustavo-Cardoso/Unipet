using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Porte")]
    public class Porte
    {
        [Key]
        public int IdPorte { get; set; }

        [Required(ErrorMessage = "O campo PORTE é obrigatório")]
        public char NomePorte { get; set; }
    }
}
