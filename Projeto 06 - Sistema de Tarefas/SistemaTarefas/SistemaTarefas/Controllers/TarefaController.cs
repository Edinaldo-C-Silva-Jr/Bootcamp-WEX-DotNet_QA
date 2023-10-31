using Microsoft.AspNetCore.Mvc;
using SistemaTarefas.Context;
using SistemaTarefas.Entities;

namespace SistemaTarefas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaContext _context;
        public TarefaController(TarefaContext context) 
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarTarefa(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterTarefaPorID), new { id = tarefa.Id }, tarefa);
        }

        [HttpGet("Todas")]
        public IActionResult ObterTodasTarefas()
        {
            List<Tarefa> tarefas = _context.Tarefas.ToList();
            return Ok(tarefas);
        }

        [HttpGet("PorId/{id}")]
        public IActionResult ObterTarefaPorID(int id)
        {
            Tarefa tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }

        [HttpGet("PorTitulo/{titulo}")]
        public IActionResult ObterTarefaPorTitulo(string titulo)
        {
            List<Tarefa> tarefas = _context.Tarefas.Where(t => t.Titulo.Contains(titulo)).ToList();
            return Ok(tarefas);
        }

        [HttpGet("PorData/{data}")]
        public IActionResult ObterTarefaPorData(string data)
        {
            DateTime dataValida;

            if (!DateTime.TryParse(data, out dataValida))
            {
                return BadRequest();
            }

            List<Tarefa> tarefas = _context.Tarefas.Where(t => t.Data.Date == dataValida.Date).ToList();
            return Ok(tarefas);
        }

        [HttpGet("PorStatus/{status}")]
        public IActionResult ObterTarefaPorStatus(StatusTarefa status)
        {
            List<Tarefa> tarefas = _context.Tarefas.Where(t => t.Status == status).ToList();
            return Ok(tarefas);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarTarefa(int id, Tarefa tarefa)
        {
            Tarefa tarefaExistente = _context.Tarefas.Find(id);

            if (tarefaExistente == null)
            {
                return NotFound();
            }

            tarefaExistente.Titulo = tarefa.Titulo;
            tarefaExistente.Descricao = tarefa.Descricao;
            tarefaExistente.Data = tarefa.Data;
            tarefaExistente.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaExistente);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeletarTarefa(int id)
        {
            Tarefa tarefaExistente = _context.Tarefas.Find(id);

            if (tarefaExistente == null)
            {
                return NotFound();
            }

            _context.Tarefas.Remove(tarefaExistente);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
