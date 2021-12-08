using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Especialidade")]
    public class Especialidade
    {
        [Key]
        public int IdEspecialidade { get; set; }

        [Required(ErrorMessage = "O campo ESPECIALIDADE é obrigatório")]
        [StringLength(20, ErrorMessage = "A especialidade deve possuir no máximo 20 caracteres")]
        public string NomeEspecialidade { get; set; }

        public ICollection<EspecialidadePlano> EspecialidadesPlanos { get; set; }
    }
}
