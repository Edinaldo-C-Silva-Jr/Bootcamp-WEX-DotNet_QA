namespace Hospedagem.Models
{
    /// <summary>
    /// Uma classe que representa uma reserva realizada no hotel, que associa hóspedes com a suíte na qual eles ficarão hospedados.
    /// </summary>
    internal class Reserva
    {
        /// <summary>
        /// A lista de hóspedes associada com essa reserva.
        /// </summary>
        public List<Pessoa>? Hospedes { get; set; }

        /// <summary>
        /// A suíte escolhida para essa reserva.
        /// </summary>
        public Suite? Suite { get; set; }

        /// <summary>
        /// A quantidade de dias que os hóspedes ficarão hospedados.
        /// </summary>
        public int DiasReservados { get; set; }

        /// <summary>
        /// O construtor da reserva, que necessita apenas dos dias para ser criada.
        /// </summary>
        /// <param name="diasReservados">A quantidade de dias reservados.</param>
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        /// <summary>
        /// Cadastra uma lista de hóspedes na reserva.
        /// </summary>
        /// <param name="hospedes">A lista de hóspede a ser cadastrada na reserva.</param>
        /// <exception cref="ArgumentException">Caso a quantidade de hóspedes seja maior do que a capacidade da suíte existente na cadastrada.</exception>
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite != null && Suite.CapacidadeSuite < hospedes.Count)
            {
                throw new ArgumentException($"A suíte atualmente cadastrada não possui capacidade para esta quantidade de hóspedes.");
            }

            Hospedes = hospedes;
        }

        /// <summary>
        /// Cadastra uma suíte escolhida na reserva.
        /// </summary>
        /// <param name="suite">A suíte a ser cadastrada na reserva.</param>
        /// <exception cref="ArgumentException">Caso a quantidade de hóspedes existente na reserva seja maior que a capacidade da suíte.</exception>
        public void CadastrarSuite(Suite suite)
        {
            if (Hospedes != null && Hospedes.Count > suite.CapacidadeSuite)
            {
                throw new ArgumentException("A suíte escolhida não possui capacidade suficiente para os hóspedes já cadastrados.");
            }

            Suite = suite;
        }

        /// <summary>
        /// Retorna a quantidade de hóspedes atualmente cadastrada na reserva.
        /// </summary>
        /// <returns>A quantidade de hóspedes na reserva. Ou 0 caso não haja hóspedes cadastrados.</returns>
        public int ObterQuantidadeHospedes()
        {
            if (Hospedes == null)
            {
                return 0;
            }

            return Hospedes.Count;
        }

        /// <summary>
        /// Calcula o valor total a ser pago pela reserva, com base no valor da diária da suíte escolhida e a quantidade de dias reservados.
        /// Também leva em conta um desconto de 10% caso a reserva seja para 10 dias ou mais.
        /// </summary>
        /// <returns>O valor total a ser pago. Ou 0, caso não haja uma suíte escolhida.</returns>
        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
            {
                return 0;
            }

            decimal valorTotal;
            valorTotal = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {
                valorTotal *= 0.9M;
            }
            return valorTotal;
        }
    }
}
