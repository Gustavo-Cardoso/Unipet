using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Unipet.Models
{
    [Table("Usuario")]
    public class Usuario : IdentityUser
    {        
        [StringLength(60)]
        public string Nome { get; set; }

        public int LimiteAlteracaoNomeUsuario { get; set; } = 10;

        public byte[] Avatar { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}   
