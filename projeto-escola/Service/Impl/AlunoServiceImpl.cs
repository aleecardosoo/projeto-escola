using Microsoft.Extensions.Logging;
using projeto_escola.Context;
using projeto_escola.DTO;
using projeto_escola.Model;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILogger = Serilog.ILogger;

namespace projeto_escola.Service.Impl
{
    public class AlunoServiceImpl : IAlunoService
    {
        AlunoContext context = new AlunoContext();

        public void add(Aluno aluno)
        {
            context.Add<Aluno>(aluno);
            context.SaveChanges();
        }

        public void delete(int id)
        {
            Aluno aluno = context.Find<Aluno>(id);
            context.Remove<Aluno>(aluno);
            context.SaveChanges();
        }

        public Aluno find(int id)
        {
            return context.Find<Aluno>(id);
        }

        public IEnumerable<Aluno> getAll()
        {
            return context.aluno;
        }

        public void update(int id, Aluno aluno)
        {

            context.Update(aluno);
            context.SaveChanges();
        }
    }
}
