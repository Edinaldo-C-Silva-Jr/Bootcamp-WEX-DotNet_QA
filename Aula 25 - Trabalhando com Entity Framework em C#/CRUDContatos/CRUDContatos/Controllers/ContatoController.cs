using CRUDContatos.Context;
using CRUDContatos.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRUDContatos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarContato(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterContatoPorId), new { id = contato.Id }, contato);
        }

        [HttpGet]
        public IActionResult ObterTodosContatos()
        {
            var contatos = _context.Contatos.ToList();
            return Ok(contatos);
        }

        [HttpGet("PorID/{id}")]
        public IActionResult ObterContatoPorId(int id)
        {
            Contato contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("PorNome/{nome}")]
        public IActionResult ObterContatoPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarContato(int id, Contato contato)
        {
            Contato contatoExistente = _context.Contatos.Find(id);

            if (contatoExistente == null)
            {
                return NotFound();
            }

            contatoExistente.Nome = contato.Nome;
            contatoExistente.Telefone = contato.Telefone;
            contatoExistente.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoExistente);
            _context.SaveChanges();

            return Ok(contatoExistente);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarContatos(int id)
        {
            Contato contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contato);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
