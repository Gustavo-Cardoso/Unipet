using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Prestador")]
    public class Prestador
    {
        [Key]
        public int IdPrestador { get; set; }

        [Required(ErrorMessage = "O campo RAZÃO SOCIAL é obrigatório")]
        [StringLength(60, ErrorMessage = "A razão social deve possuir no máximo 60 caracteres")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        [StringLength(14, ErrorMessage = "O CNPJ deve possuir no máximo 14 caracteres")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O campo E-MAIL é obrigatório")]
        [StringLength(60, ErrorMessage = "O e-mail deve possuir no máximo 60 caracteres")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = "O telefone deve possuir no máximo 20 caracteres")]
        [Display(Name = "Telefone")]
        public string Fone { get; set; }

        [StringLength(200)]
        public string Logotipo { get; set; }

        [Required]
        public int IdEndereco { get; set; }
        [ForeignKey("IdEndereco")]
        public Endereco Endereco { get; set; }

        public string IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Display(Name = "Ativo?")]
        public bool ExibirHome { get; set; }

        public ICollection<PrestadorEmpresa> PrestadorEmpresas { get; set; }

    }
}
