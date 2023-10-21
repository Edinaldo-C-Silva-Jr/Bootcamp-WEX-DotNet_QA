using Hospedagem;

Hotel hotel = new();

int opcao = 0;

while (opcao != 5)
{
    Console.Clear();
    Console.WriteLine("--- Bem-vindo ao Sistema de Hospedagem do Hotel! --- \n");

    Console.WriteLine("1 - Cadastrar um novo hóspede.");
    Console.WriteLine("2 - Cadastrar uma Suite");
    Console.WriteLine("3 - Listar hóspedes e suítes");
    Console.WriteLine("4 - Fazer uma Reserva");
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
                hotel.ListarHospedes();
                hotel.ListarSuites();
                break;
            }
        case 4:
            {
                MenuReserva cadastrarReserva = new();
                cadastrarReserva.MostrarMenu(hotel);
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