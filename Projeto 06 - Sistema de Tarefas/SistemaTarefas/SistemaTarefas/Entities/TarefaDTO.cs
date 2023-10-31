namespace SistemaTarefas.Entities
{
    public class TarefaDTO
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public StatusTarefa Status { get; set; }
    }
}
