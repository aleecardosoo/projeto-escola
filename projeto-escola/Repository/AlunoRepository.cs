using projeto_escola.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_escola.Repository
{
    public class AlunoRepository
    {

        private static List<Aluno> alunos = new List<Aluno>();

        public static List<Aluno> getAlunosList() {

            alunos.Add(new Aluno() { Id = 1, Nome = "Alexandre", Telefone = "99209-4940", Email = "ale@ale.com.br" });
            alunos.Add(new Aluno() { Id = 2, Nome = "João", Telefone = "88888-8888", Email = "ale@ale.com.br" });
            alunos.Add(new Aluno() { Id = 3, Nome = "Paulo", Telefone = "55555-5555", Email = "ale@ale.com.br" });
            alunos.Add(new Aluno() { Id = 4, Nome = "Ana Luiza", Telefone = "33333-3333", Email = "ale@ale.com.br" });
            alunos.Add(new Aluno() { Id = 5, Nome = "André", Telefone = "00000-0000", Email = "ale@ale.com.br" });
            return alunos;
        }
    }
}
