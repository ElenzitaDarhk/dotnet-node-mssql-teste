using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controller
{
    [Route("api/Alunos")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        // GET: api/Alunos
        [HttpGet]
        public IActionResult Get()
        {
            // Retorna lista de alunos (exemplo)
            var alunos = new[] { "João", "Maria", "Pedro" };
            return Ok(alunos);
        }

        // GET: api/Alunos/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // Retorna aluno por id (exemplo)
            var aluno = $"Aluno {id}";
            return Ok(aluno);
        }

        // POST: api/Alunos
        [HttpPost]
        public IActionResult Post([FromBody] string aluno)
        {
            // Adiciona novo aluno (exemplo)
            return CreatedAtAction(nameof(Get), new { id = 1 }, aluno);
        }

        // PUT: api/Alunos/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string aluno)
        {
            // Atualiza aluno (exemplo)
            return NoContent();
        }

        // DELETE: api/Alunos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Remove aluno (exemplo)
            return NoContent();
        }
    }
}
