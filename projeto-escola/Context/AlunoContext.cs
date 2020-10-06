using Microsoft.EntityFrameworkCore;
using projeto_escola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace projeto_escola.Context
{
    public class AlunoContext : DbContext
    {
        public DbSet<Aluno> aluno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conectionString = "server=localhost;database=projeto_escola;user=root;password=root";
            optionsBuilder.UseMySQL(conectionString);
        }
    }
}
