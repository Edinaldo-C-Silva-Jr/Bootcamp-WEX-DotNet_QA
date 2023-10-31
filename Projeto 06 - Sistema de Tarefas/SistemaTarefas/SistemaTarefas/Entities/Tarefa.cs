using System.ComponentModel.DataAnnotations;

namespace SistemaTarefas.Entities
{
    /// <summary>
    /// Uma classe que representa um registro de tarefa no banco de dados.
    /// </summary>
    public class Tarefa
    {
        /// <summary>
        /// O número de identificação da tarefa.
        /// </summary>
        public int Id { get; set; }

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
