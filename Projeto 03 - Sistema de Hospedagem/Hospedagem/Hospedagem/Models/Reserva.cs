namespace Hospedagem.Models
{
    internal class Reserva
    {
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite != null && Suite.CapacidadeSuite < hospedes.Count)
            {
                throw new Exception($"A suíte cadastrada não possui capacidade para esta quantidade de hóspedes.");
            }

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            if (Hospedes != null && Hospedes.Count > suite.CapacidadeSuite)
            {
                throw new Exception("A suíte escolhida não possui capacidade suficiente para os hóspedes cadastrados.");
            }

            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            if (Hospedes == null)
            {
                return 0;
            }

            return Hospedes.Count;
        }

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
