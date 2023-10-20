using Hospedagem;
using Hospedagem.Models;

Hotel hotel = new Hotel();

int opcao = 0;

while (opcao != 5)
{
    Console.Clear();
    Console.WriteLine("--- Bem-vindo ao Sistema de Hospedagem do Hotel! --- \n");

    Console.WriteLine("1 - Cadastrar um novo hóspede.");
    Console.WriteLine("2 - Cadastrar uma Suite");
    Console.WriteLine("3 - Fazer uma Reserva");
    Console.WriteLine("4 - Utilizar o teste predefinido");
    Console.WriteLine("5 - Sair \n");

    Console.Write("Digite a opção: ");
    int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1:
            {
                hotel.CadastrarHospedeNoHotel();
                break;
            }
        case 2:
            {
                hotel.CadastrarSuitesNoHotel();
                break;
            }
        case 3:
            {
                hotel.CadastrarReserva();
                break;
            }
        case 4:
            {
                Console.Clear();
                Console.WriteLine("--- Teste padrão ---");

                Pessoa hospede1 = new("João", "da Silva");
                Pessoa hospede2 = new("José");
                List<Pessoa> listaHospedes = new() { hospede1, hospede2 };
                Suite suite = new("Basica", 2, 80.00M);
                int dias = 10;

                Console.WriteLine($"Hóspedes: \n{listaHospedes[0].NomeCompleto} \n{listaHospedes[1].NomeCompleto}");
                Console.WriteLine($"Suite: {suite.TipoSuite}, capacidade: {suite.CapacidadeSuite}, valor da diária: {suite.ValorDiaria}");
                Console.WriteLine($"Dias reservados: {dias} \n");

                Reserva reserva = new(diasReservados: dias);
                reserva.CadastrarHospedes(listaHospedes);
                reserva.CadastrarSuite(suite);

                Console.WriteLine($"Quantidade de hóspedes na reserva: {reserva.ObterQuantidadeHospedes()}");
                Console.WriteLine($"Valor total a ser pago: {reserva.CalcularValorDiaria():#.##}");
                break;
            }
        case 5:
            {
                Console.WriteLine("Encerrando o Programa.");
                break;
            }
        default:
            {
                Console.WriteLine("Opção inválida!");
                break;
            }
    }
    Console.ReadLine();
}