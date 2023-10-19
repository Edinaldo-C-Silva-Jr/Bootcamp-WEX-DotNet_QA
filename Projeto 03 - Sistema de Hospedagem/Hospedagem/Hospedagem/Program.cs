using Hospedagem.Models;

List<Pessoa> todosHospedes = new();
List<Suite> todasSuites = new();

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
                string nome = "", sobrenome = "";
                Pessoa hospede;

                Console.WriteLine("Digite o primeiro nome do hóspede a ser cadastrado (campo obrigatório): ");
                while (string.IsNullOrEmpty(nome))
                {
                    nome = Console.ReadLine();
                };

                Console.WriteLine("Digite o sobrenome do hóspede a ser cadastrado: ");
                sobrenome = Console.ReadLine();

                if (string.IsNullOrEmpty(sobrenome))
                {
                    hospede = new(nome);
                }
                else
                {
                    hospede = new(nome, sobrenome);
                }
                todosHospedes.Add(hospede);
                Console.WriteLine($"Hóspede cadastrado com sucesso: {hospede.NomeCompleto}");
                break;
            }
        case 2:
            {
                string tipo = "";
                int capacidade;
                decimal valor;
                Suite suite;

                Console.WriteLine("Digite o Tipo da suíte (obrigatório): ");
                while (string.IsNullOrEmpty(tipo))
                {
                    tipo = Console.ReadLine();
                };

                Console.WriteLine("Digite a capacidade da suíte (obrigatório)(número inteiro positivo): ");
                while (!int.TryParse(Console.ReadLine(), out capacidade) || capacidade <= 0) { }

                Console.WriteLine("Digite o valor da diária da suíte (obrigatório)(número inteiro positivo): ");
                while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0) { }

                suite = new(tipo, capacidade, valor);
                todasSuites.Add(suite);
                Console.WriteLine($"Suíte cadastrada com sucesso: {suite.TipoSuite}");
                break;
            }
        case 3:
            {
                Console.Clear();

                int dias;
                List<Pessoa> hospedesSelecionados = new();

                Console.WriteLine("--- Cadastro de Reserva ---");
                Console.WriteLine("Digite a quantidade de dias que deseja reservar (número inteiro positivo): ");
                while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0) { }
                Reserva reserva = new(dias);

                int reservaOpcao = 0;

                while (reservaOpcao != 5)
                {
                    Console.Clear();
                    Console.WriteLine("--- Cadastro de Reserva ---");
                    Console.WriteLine($"Reserva para {reserva.DiasReservados} dias. \n");

                    Console.WriteLine("1 - Inserir Hóspedes na reserva.");
                    Console.WriteLine("2 - Remover Hóspedes da reserva."); ;
                    Console.WriteLine("2 - Visualizar Dados da reserva.");
                    Console.WriteLine("4 - Escolher Suíte");
                    Console.WriteLine("5 - Finalizar");

                    Console.Write("Digite a opção: ");
                    int.TryParse(Console.ReadLine(), out reservaOpcao);

                    switch (reservaOpcao)
                    {
                        case 1:
                            {
                                int hospedeId;

                                Console.WriteLine("Lista de todos os hóspedes:");
                                for (int i = 0; i < todosHospedes.Count; i++)
                                {
                                    Console.WriteLine($"Hóspede #{i + 1}: {todosHospedes[i].NomeCompleto}");
                                }

                                Console.WriteLine("Digite o número do hóspede que deseja incluir na reserva (0 para cancelar): ");
                                while (!int.TryParse(Console.ReadLine(), out hospedeId) || hospedeId < 0 || hospedeId > todosHospedes.Count) { }

                                if (hospedeId != 0)
                                {
                                    try
                                    {
                                        hospedesSelecionados.Add(todosHospedes[hospedeId - 1]);
                                        reserva.CadastrarHospedes(hospedesSelecionados);
                                        Console.WriteLine("Hóspede incluído na reserva!");
                                    }
                                    catch (Exception ex)
                                    {
                                        hospedesSelecionados.RemoveAt(hospedesSelecionados.Count - 1);
                                        Console.WriteLine(ex.Message);
                                        Console.WriteLine("Para cadastrar mais hóspedes, escolha uma nova suíte com capacidade maior.");
                                    }
                                }

                                break;
                            }
                        case 2:
                            {
                                int hospedeId;

                                Console.WriteLine("Digite o número do hóspede que deseja remover da reserva (o para cancelar): ");
                                while (!int.TryParse(Console.ReadLine(), out hospedeId) || hospedeId < 0 || hospedeId > todosHospedes.Count) { }

                                if (hospedeId != 0)
                                {
                                    hospedesSelecionados.RemoveAt(hospedeId - 1);
                                }

                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Lista de hóspedes na reserva:");
                                for (int i = 0; i < hospedesSelecionados.Count; i++)
                                {
                                    Console.WriteLine($"Hóspede #{i + 1}: {hospedesSelecionados[i].NomeCompleto}");
                                }

                                if (reserva.Suite == null)
                                {
                                    Console.WriteLine("Não há suíte escolhida nessa reserva.");
                                }
                                else
                                {
                                    Console.WriteLine($"Suíte escolhida: {reserva.Suite.TipoSuite}, capacidade: {reserva.Suite.CapacidadeSuite}, valor da diária: {reserva.Suite.ValorDiaria:C}");
                                }

                                break;
                            }
                        case 4:
                            {
                                int suiteId;

                                Console.WriteLine("Lista de todas as suítes:");
                                for (int i = 0; i < todasSuites.Count; i++)
                                {
                                    Console.WriteLine($"Suíte #{i + 1}: {todasSuites[i].TipoSuite}, capacidade: {todasSuites[i].CapacidadeSuite}, valor da diária: {todasSuites[i].ValorDiaria:C}");
                                }

                                Console.WriteLine("Digite o número da suíte que deseja escolher para a reserva (0 para cancelar): ");
                                while (!int.TryParse(Console.ReadLine(), out suiteId) || suiteId < 0 || suiteId > todasSuites.Count) { }

                                if (suiteId != 0)
                                {
                                    try
                                    {
                                        reserva.CadastrarSuite(todasSuites[suiteId - 1]);
                                        Console.WriteLine("Suíte incluída na reserva!");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        Console.WriteLine("Escolha uma nova suíte ou diminua a quantidade de hóspedes da reserva.");
                                    }
                                }
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Reserva realizada com sucesso!");
                                Console.WriteLine($"Quantidade de hóspedes na reserva: {reserva.ObterQuantidadeHospedes()}");
                                Console.WriteLine($"Valor total a ser pago: {reserva.CalcularValorDiaria():#.##}");
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
                break;
            }
        case 4:
            {
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