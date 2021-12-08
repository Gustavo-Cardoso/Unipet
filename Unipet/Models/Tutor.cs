using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Tutor")]
    public class Tutor
    {
        [Key]
        public int IdTutor { get; set; }

        [Required(ErrorMessage = "O campo NOME é obrigatório")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
        [Display(Name = "Nome")]
        public string NomeTutor { get; set; }

        [StringLength(100, ErrorMessage = "O e-mail deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [StringLength(11, ErrorMessage = "O CPF deve possuir no máximo 11 caracteres")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo RG é obrigatório")]
        [StringLength(20, ErrorMessage = "O RG deve possuir no máximo 20 caracteres")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O campo GÊNERO é obrigatório")]
        public char Sexo { get; set; }

        [StringLength(200)]
        public string Foto { get; set; }

        [StringLength(20, ErrorMessage = "O telefone deve possuir no máximo 20 caracteres")]
        public string Fone { get; set; }

        [StringLength(20, ErrorMessage = "O celular deve possuir no máximo 20 caracteres")]
        public string Celular { get; set; }

        [Required]
        public int IdEndereco { get; set; }
        [ForeignKey("IdEndereco")]
        public Endereco Endereco { get; set; }
        
        public string IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Display(Name = "Ativo?")]
        public bool ExibirHome { get; set; }
    }
}
