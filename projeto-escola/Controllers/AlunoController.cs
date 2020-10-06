using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_escola.DTO;
using projeto_escola.Model;
using projeto_escola.Service.Impl;

namespace projeto_escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        AlunoServiceImpl alunoService = new AlunoServiceImpl();
        private readonly ILogger<AlunoController> logger;
        private readonly IMapper mapper;
        public AlunoController(ILogger<AlunoController> logger)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Aluno, AlunoDTO>();
            });
            mapper = configuration.CreateMapper();

            this.logger = logger;
        }

        //GET: api/<AlunoController>
        [HttpGet("all")]
        public IEnumerable<Aluno> Get()
        {
            //var alunos = alunoService.getAll();
            //var alunosDto = mapper.Map<AlunoDTO>(alunos);
            return alunoService.getAll();
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public AlunoDTO Get(int id)
        {
            if (alunoService.find(id) == null)
            {
                logger.LogError("Não foi encontrado aluno com esse ID {0}", id);
            }

            var aluno = alunoService.find(id);
            var alunoDto = mapper.Map<AlunoDTO>(aluno);
            return alunoDto;
        }

        // POST api/<AlunoController>
        [HttpPost]
        public void Post([FromBody] Aluno aluno)
        {
            alunoService.add(aluno);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Aluno aluno)
        {
            alunoService.update(id, aluno);
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            alunoService.delete(id);
        }
    }
}
