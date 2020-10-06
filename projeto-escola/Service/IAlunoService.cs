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

        public IEnumerable<Aluno> getAll();

        public void delete(int id);

        public void update(int id, Aluno aluno);

        public Aluno find(int id);

    }
}
