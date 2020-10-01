using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projeto_escola.Context;
using projeto_escola.DTO;
using projeto_escola.Model;
using projeto_escola.Repository;
using projeto_escola.Service.Impl;

namespace projeto_escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        // GET: api/<AlunoController>
        [HttpGet("all")]
        public IEnumerable<Aluno> Get()
        {

            List<Aluno> alunos = AlunoRepository.getAlunosList();
            return alunos;
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public AlunoDTO Get(int id)
        {
            Aluno aluno = AlunoRepository.getAlunosList().Find(x => x.Id == id);

            AlunoDTO alunoDTO = new AlunoDTO(aluno);

            return alunoDTO;
        }

        // POST api/<AlunoController>
        [HttpPost]
        public void Post([FromBody] Aluno aluno)
        {
            AlunoRepository.getAlunosList().Add(aluno);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Aluno aluno)
        {
            Aluno alunoSelecionado = AlunoRepository.getAlunosList().Find(x => x.Id == id);
            alunoSelecionado.Nome = aluno.Nome;
            alunoSelecionado.Telefone = aluno.Telefone;
            alunoSelecionado.Email = aluno.Email;
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            AlunoRepository.getAlunosList().RemoveAt(id);
        }
    }
}
