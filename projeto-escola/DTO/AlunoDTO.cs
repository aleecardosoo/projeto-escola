using projeto_escola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_escola.DTO
{
    public class AlunoDTO
    {
        public string nome { get; set; }

        public AlunoDTO(Aluno aluno)
        {
            this.nome = aluno.Nome;
        }
    }
}
