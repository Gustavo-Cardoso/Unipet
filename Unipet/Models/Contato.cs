using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unipet.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Key]
        public int IdContato { get; set; }

        [Required(ErrorMessage = "O campo NOME é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo ASSUNTO é obrigatório")]
        [StringLength(100, ErrorMessage = "O assunto deve possuir no máximo 100 caracteres")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O campo E-MAIL é obrigatório")]
        [StringLength(100, ErrorMessage = "O e-mail deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = "O telefone deve possuir no máximo 20 caracteres")]
        public string Telefone { get; set; }

        [StringLength(20, ErrorMessage = "O celular deve possuir no máximo 20 caracteres")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "O campo MENSAGEM é obrigatório")]
        [StringLength(1000, ErrorMessage = "A mensagem deve possuir no máximo 1000 caracteres")]
        public string Mensagem { get; set; }
    }
}
