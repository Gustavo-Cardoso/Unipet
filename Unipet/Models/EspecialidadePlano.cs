using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("EspecialidadePlano")]
    public class EspecialidadePlano
    {
        [Key]
        [Column(Order = 1)]
        public int IdEspecialidade { get; set; }
        [ForeignKey("IdEspecialidade")]
        public Especialidade Especialidade { get; set; }

        [Key]
        [Column(Order =2)]
        public int IdPlano { get; set; }
        [ForeignKey("IdPlano")]
        public Plano Plano { get; set; }
    }
}
