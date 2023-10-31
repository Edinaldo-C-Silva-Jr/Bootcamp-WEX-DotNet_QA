using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult CriarTarefa(TarefaDTO tarefa)
        {
            if (tarefa == null)
            {
                return BadRequest("A tarefa não pode ser nula.");
            }

            Tarefa tarefaBanco = new()
            { Titulo = tarefa.Titulo, Descricao = tarefa.Descricao, Data = tarefa.Data, Status = tarefa.Status };

            _context.Tarefas.Add(tarefaBanco);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterTarefaPorID), new { id = tarefaBanco.Id }, tarefaBanco);
        }

        [HttpGet("Todas")]
        public IActionResult ObterTodasTarefas()
        {
            List<Tarefa> tarefas = _context.Tarefas.ToList();

            if (tarefas.Count == 0)
            {
                return NotFound("Não há tarefas cadastradas.");
            }

            return Ok(tarefas);
        }

        [HttpGet("PorId/{id}")]
        public IActionResult ObterTarefaPorID(int id)
        {
            Tarefa tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
            {
                return NotFound($"Não existe tarefa com o id {id}.");
            }

            return Ok(tarefa);
        }

        [HttpGet("PorTitulo/{titulo}")]
        public IActionResult ObterTarefaPorTitulo(string titulo)
        {
            List<Tarefa> tarefas = _context.Tarefas.Where(t => t.Titulo.Contains(titulo)).ToList();

            if (tarefas.Count == 0)
            {
                return NotFound($"Não há tarefas com o título {titulo}.");
            }

            return Ok(tarefas);
        }

        [HttpGet("PorData/{data}")]
        public IActionResult ObterTarefaPorData(string data)
        {
            if (!DateTime.TryParse(data, out DateTime dataValida))
            {
                return BadRequest("A data não estava em um formato válido.");
            }

            List<Tarefa> tarefas = _context.Tarefas.Where(t => t.Data.Date == dataValida.Date).ToList();

            if (tarefas.Count == 0)
            {
                return NotFound("Não há tarefas cadastradas neste dia.");
            }

            return Ok(tarefas);
        }

        [HttpGet("PorStatus/{status}")]
        public IActionResult ObterTarefaPorStatus(StatusTarefa status)
        {
            List<Tarefa> tarefas = _context.Tarefas.Where(t => t.Status == status).ToList();

            if (tarefas.Count == 0)
            {
                return NotFound("Não há tarefas cadastradas com este status.");
            }

            return Ok(tarefas);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarTarefa(int id, Tarefa tarefa)
        {
            if (tarefa == null)
            {
                return BadRequest("A tarefa não pode ser nula.");
            }

            Tarefa tarefaExistente = _context.Tarefas.Find(id);

            if (tarefaExistente == null)
            {
                return NotFound($"Não existe tarefa com o id {id}.");
            }

            tarefaExistente.Titulo = tarefa.Titulo;
            tarefaExistente.Descricao = tarefa.Descricao;
            tarefaExistente.Data = tarefa.Data;
            tarefaExistente.Status = tarefa.Status;

            _context.Entry(tarefaExistente).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeletarTarefa(int id)
        {
            Tarefa tarefaExistente = _context.Tarefas.Find(id);

            if (tarefaExistente == null)
            {
                return NotFound($"Não existe tarefa com o id {id}.");
            }

            _context.Tarefas.Remove(tarefaExistente);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
