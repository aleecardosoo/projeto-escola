using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_escola.Model
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Telefone")]
        public string Telefone { get; set; }

        [Column("Email")]
        public string Email { get; set; }
    }
}
