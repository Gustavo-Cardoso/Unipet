using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("UF")]
    public class UF
    {
        [Key]
        public int IdUF { get; set; }

        [Required(ErrorMessage = "O campo SIGLA é obrigatório")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O campo ESTADO é obrigatório")]
        [StringLength(64, ErrorMessage = "O estado deve possuir no máximo 64 caracteres")]
        public string NomeEstado { get; set; }
    }
}
