namespace Hospedagem.Models
{
    internal class Suite
    {
        public string TipoSuite { get; set; }
        public int CapacidadeSuite { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipo, int capacidade, decimal valor) 
        {
            TipoSuite = tipo;
            CapacidadeSuite = capacidade;
            ValorDiaria = valor;
        }

    }
}
