using projeto_escola.Context;
using projeto_escola.DTO;
using projeto_escola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_escola.Service
{
    interface IAlunoService
    {
        public void add(Aluno aluno);

        public IEnumerable<AlunoDTO> getAll();

        public void delete(long id);

        public void update(long id, Aluno aluno);

        public AlunoDTO find(long id);

    }
}
