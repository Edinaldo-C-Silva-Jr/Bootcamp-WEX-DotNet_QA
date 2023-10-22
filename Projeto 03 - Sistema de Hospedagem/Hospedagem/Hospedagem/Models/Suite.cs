namespace Hospedagem.Models
{
    /// <summary>
    /// Uma classe que representa uma suíte existente no hotel.
    /// </summary>
    internal class Suite
    {
        /// <summary>
        /// O tipo da suíte, que é um nome que a identifica.
        /// </summary>
        public string TipoSuite { get; set; }

        /// <summary>
        /// A capacidade da suíte, que é a quantidade máxima de hóspedes que ela pode receber.
        /// </summary>
        public int CapacidadeSuite { get; set; }

        /// <summary>
        /// O valor pago pela estadia diária nesta suíte.
        /// </summary>
        public decimal ValorDiaria { get; set; }

        /// <summary>
        /// O construtor da suíte, que necessita de todos os dados.
        /// </summary>
        /// <param name="tipo">O tipo (nome) da suíte.</param>
        /// <param name="capacidade">A capacidade da suíte.</param>
        /// <param name="valor">O valor pago pela diária da suíte.</param>
        public Suite(string tipo, int capacidade, decimal valor) 
        {
            TipoSuite = tipo;
            CapacidadeSuite = capacidade;
            ValorDiaria = valor;
        }

    }
}
