using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("PrestadorEmpresa")]
    public class PrestadorEmpresa
    {
        [Key]
        [Column(Order = 1)]
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdPrestador { get; set; }
        [ForeignKey("IdPrestador")]
        public Prestador Prestador { get; set; }
    }
}
