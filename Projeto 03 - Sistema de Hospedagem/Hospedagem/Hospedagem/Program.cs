using Hospedagem.Models;

Console.WriteLine("Bem-vindo ao Sistema de Hospedagem do Hotel!");
Console.WriteLine("Pressione Enter para realizar o teste padrão.");
Console.ReadLine();

Pessoa hospede1 = new("João", "da Silva");
Pessoa hospede2 = new("José");

List<Pessoa> listaHospedes = new() { hospede1, hospede2 };

Suite suiteBasica = new("Basica", 2, 80.00M);

Reserva reserva = new(diasReservados: 10);
reserva.CadastrarHospedes(listaHospedes);
reserva.CadastrarSuite(suiteBasica);

Console.WriteLine($"Quantidade de hóspedes na reserva: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total a ser pago: {reserva.CalcularValorDiaria():#.##}");

Console.ReadLine();