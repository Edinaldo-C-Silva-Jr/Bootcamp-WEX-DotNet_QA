using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaTarefas.Context;
using SistemaTarefas.Entities;

namespace SistemaTarefas.Controllers
{
    /// <summary>
    /// Controlador que fornece os endpoints para acessar as tarefas.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaContext _context;
        public TarefaController(TarefaContext context) 
        {
            _context = context;
        }

        /// <summary>
        /// Cria uma tarefa com os dados fornecidos.
        /// </summary>
        /// <param name="tarefa">Uma tarefa, com todos os dados necessários.</param>
        /// <returns>O link para a nova tarefa cadastrada.</returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /Tarefa
        ///     {
        ///        "titulo": "Limpar",
        ///        "descricao": "Limpar o quarto.",
        ///        "data": "2023-12-31",
        ///        "status": "Pendente"
        ///     }
        ///     
        /// </remarks>
        /// <response code="201">Retorna a tarefa recém-criada.</response>
        /// <response code="400">Caso a tarefa não possua os dados necessários.</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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

        /// <summary>
        /// Lista todas as tarefas existentes.
        /// </summary>
        /// <returns>Uma lista de tarefas.</returns>
        /// <response code="200">Retorna todas as tarefas encontradas.</response>
        /// <response code="404">Caso não exista nenhuma tarefa na base de dados.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

        /// <summary>
        /// Retorna uma tarefa, que corresponde ao ID fornecido.
        /// </summary>
        /// <param name="id">Número de identificação da tarefa.</param>
        /// <returns>Um registro de tarefa.</returns>
        /// <response code="200">Retorna a tarefa requisitada.</response>
        /// <response code="400">Caso o valor do ID fornecido não seja válido.</response>
        /// <response code="404">A tarefa com o ID fornecido não existe.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("PorId/{id}")]
        public IActionResult ObterTarefaPorID(int id)
        {
            if (id < 1 || id > int.MaxValue)
            {
                return BadRequest("Este valor de id não é válido.");
            }

            Tarefa tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
            {
                return NotFound($"Não existe tarefa com o id {id}.");
            }

            return Ok(tarefa);
        }

        /// <summary>
        /// Lista todas as tarefas que possuem o título especificado. O resultado traz todas as tarefas cujo título contém a string especificada.
        /// </summary>
        /// <param name="titulo">Uma string que deve estar contida no título das tarefas.</param>
        /// <returns>Uma lista de tarefas.</returns>
        /// <response code="200">Retorna todas as tarefas encontradas.</response>
        /// <response code="404">Caso não exista nenhuma tarefa com o título especificado.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

        /// <summary>
        /// Lista todas as tarefas existentes em uma data especificada.
        /// </summary>
        /// <param name="data">Uma data, no formato "yyyy-MM-dd", para buscar as tarefas.</param>
        /// <returns>Uma lista de tarefas.</returns>
        /// <response code="200">Retorna todas as tarefas encontradas.</response>
        /// <response code="404">Caso não exista nenhuma tarefa neste dia.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

        /// <summary>
        /// Lista todas as tarefas que possuem o status escolhido
        /// </summary>
        /// <param name="status">O status desejado para buscar as tarefas.</param>.
        /// <returns>Uma lista de tarefas.</returns>
        /// <response code="200">Retorna todas as tarefas encontradas.</response>
        /// <response code="404">Caso não exista nenhuma tarefa com este status.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

        /// <summary>
        /// Atualiza a tarefa que corresponde ao ID, utilizando as novas informações fornecidas.
        /// </summary>
        /// <param name="id">Número de identificação da tarefa.</param>
        /// <param name="tarefa">Uma tarefa, com todos os dados.</param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /Tarefa
        ///     {
        ///        "titulo": "Limpar",
        ///        "descricao": "Limpar o quarto.",
        ///        "data": "2023-12-31",
        ///        "status": "Pendente"
        ///     }
        ///     
        /// </remarks>
        /// <response code="204">A tarefa foi alterada com sucesso.</response>
        /// <response code="400">Caso a tarefa tenha dados faltando, ou caso o ID fornecido seja inválido.</response>
        /// <response code="404">Caso a tarefa com o ID fornecido não exista.</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public IActionResult AtualizarTarefa(int id, TarefaDTO tarefa)
        {
            if (id < 1 || id > int.MaxValue)
            {
                return BadRequest("Este valor de id não é válido.");
            }

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

        /// <summary>
        /// Deleta a tarefa que corresponde ao ID fornecido.
        /// </summary>
        /// <param name="id">Número de identificação da tarefa.</param>
        /// <response code="204">A tarefa foi deletada com sucesso.</response>
        /// <response code="400">Caso o valor do ID fornecido não seja válido.</response>
        /// <response code="404">A tarefa com o ID fornecido não existe.</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public IActionResult DeletarTarefa(int id)
        {
            if (id < 1 || id > int.MaxValue)
            {
                return BadRequest("Este valor de id não é válido.");
            }

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
