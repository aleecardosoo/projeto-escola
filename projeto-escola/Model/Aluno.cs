using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_escola.Model
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("Id")]
        [Key]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}

        [NotNull]
        [Column("Nome")]
        public string Nome { get; set; }

        [NotNull]
        [Column("Telefone")]
        public string Telefone { get; set; }

        [NotNull]
        [Column("Email")]
        public string Email { get; set; }
    }
}
