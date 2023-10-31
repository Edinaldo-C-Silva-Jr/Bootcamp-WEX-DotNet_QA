using Microsoft.EntityFrameworkCore;
using SistemaTarefas.Entities;

namespace SistemaTarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options) 
        { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
