using ApiTeste.Application.Services;
using ApiTeste.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTeste.Controller
{
    [Route("api/Alunos")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly AlunoService _service;

        public AlunosController(AlunoService service)
        {
            _service = service;
        }

        // GET: api/Alunos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> Get()
        {
            var alunos = await _service.ListarAlunosAsync();
            return Ok(alunos);
        }

        // GET: api/Alunos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> Get(int id)
        {
            var aluno = await _service.BuscarAlunoPorIdAsync(id);
            if (aluno == null) return NotFound();
            return Ok(aluno);
        }

        // POST: api/Alunos
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Aluno aluno)
        {
            await _service.InserirAlunoAsync(aluno);
            return CreatedAtAction(nameof(Get), new { id = aluno.Id }, aluno);
        }

        // PUT: api/Alunos/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Aluno aluno)
        {
            if (id != aluno.Id) return BadRequest();
            await _service.AlterarAlunoAsync(aluno);
            return NoContent();
        }

        // DELETE: api/Alunos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.ExcluirAlunoAsync(id);
            return NoContent();
        }
    }
}
