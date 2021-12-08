using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Municipio")]
    public class Municipio
    {
        [Key]
        public int IdMunicipio { get; set; }

        [Required(ErrorMessage = "O campo MUNICÍPIO é obrigatório")]
        [StringLength(64, ErrorMessage = "O município deve possuir no máximo 64 caracteres")]
        public string NomeMunicipio { get; set; }

        [Required]
        public int IdUF { get; set; }
        [ForeignKey("IdUF")]
        public UF UF { get; set; }
    }
}
