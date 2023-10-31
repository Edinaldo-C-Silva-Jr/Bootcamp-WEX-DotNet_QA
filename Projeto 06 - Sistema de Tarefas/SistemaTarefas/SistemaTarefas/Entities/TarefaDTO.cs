using System.ComponentModel.DataAnnotations;

namespace SistemaTarefas.Entities
{
    /// <summary>
    /// Uma classe utilizada para o cadastro de tarefas.
    /// </summary>
    public class TarefaDTO
    {
        /// <summary>
        /// O título da tarefa.
        /// </summary>
        [Required]
        public string Titulo { get; set; }

        /// <summary>
        /// A descrição da tarefa, que fornece todos os detalhes sobre ela.
        /// </summary>
        [Required]
        public string Descricao { get; set; }

        /// <summary>
        /// A data na qual a tarefa deve ser executada.
        /// </summary>
        [Required]
        public DateTime Data { get; set; }

        /// <summary>
        /// O status de execução da tarefa.
        /// </summary>
        [Required]
        public StatusTarefa Status { get; set; }
    }
}
