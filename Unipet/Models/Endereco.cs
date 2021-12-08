using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [Required(ErrorMessage = "O campo LOGRADOURO é obrigatório")]
        [StringLength(60, ErrorMessage = "O logradouro deve possuir no máximo 60 caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo NÚMERO é obrigatório")]
        [StringLength(9, ErrorMessage = "O número deve possuir no máximo 9 caracteres")]
        public int NumeroCasa { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        [StringLength(9, ErrorMessage = "O CEP deve possuir no máximo 8 caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo BAIRRO é obrigatório")]
        [StringLength(60, ErrorMessage = "O bairro deve possuir no máximo 60 caracteres")]
        public string Bairro { get; set; }

        [Required]
        public int IdMunicipio { get; set; }
        [ForeignKey("IdMunicipio")]
        public Municipio Municipio { get; set; }
    }
}
