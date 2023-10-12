using Estacionamento.Models;

decimal precoInicial, precoHora;

Console.WriteLine("Bem-vindo(a) ao Gerenciador de Estacionamento!");

Console.WriteLine("Para iniciar, digite o preço inicial cobrado ao estacionar um veículo: ");
while(!decimal.TryParse(Console.ReadLine(), out precoInicial) || precoInicial <= 0)
{
    Console.WriteLine("Valor inválido. O preço inicial deve ser um valor numérico positivo.");
    Console.WriteLine("Digite novamente o preço inicial: ");
}

Console.WriteLine("Agora digite o preço cobrado por hora dos veículos estacionados: ");
while (!decimal.TryParse(Console.ReadLine(), out precoHora) || precoHora <= 0)
{
    Console.WriteLine("Valor inválido. O preço por hora deve ser um valor numérico positivo.");
    Console.WriteLine("Digite novamente o preço por hora: ");
}

EstacionamentoVeiculos estacionamento = new(precoInicial, precoHora);

int opcao = 0;
while(opcao != 4)
{
    Console.Clear();
    Console.WriteLine("     -- MENU --    ");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos Estacionados");
    Console.WriteLine("4 - Encerrar");

    Console.WriteLine("Digite uma opção: ");
    int.TryParse(Console.ReadLine(), out opcao);

    switch(opcao)
    {
        case 1:
            {
                estacionamento.AdicionarVeiculo();
                break;
            }
        case 2:
            {
                estacionamento.RemoverVeiculo();
                break;
            }
        case 3:
            {
                estacionamento.ListarVeiculos();
                break;
            }
        case 4:
            {
                Console.WriteLine("Encerrando programa.");
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
