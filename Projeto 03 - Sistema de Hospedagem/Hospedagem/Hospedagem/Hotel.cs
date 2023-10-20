using Hospedagem.Models;

namespace Hospedagem
{
    internal class Hotel
    {
        List<Pessoa> HospedesHotel = new();
        List<Suite> SuitesHotel = new();

        public void CadastrarHospedeNoHotel()
        {
            string nome = "", sobrenome = "";
            Pessoa hospede;

            Console.WriteLine("Digite o primeiro nome do hóspede a ser cadastrado (campo obrigatório): ");
            (int top, int left) = Console.GetCursorPosition();
            while (string.IsNullOrEmpty(nome))
            {
                Console.SetCursorPosition(top, left);
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
            HospedesHotel.Add(hospede);
            Console.WriteLine($"Hóspede cadastrado com sucesso: {hospede.NomeCompleto}");
        }

        public void CadastrarSuitesNoHotel()
        {
            string tipo = "";
            int capacidade;
            decimal valor;
            Suite suite;

            Console.WriteLine("Digite o Tipo da suíte (obrigatório): ");
            (int top, int left) = Console.GetCursorPosition();
            while (string.IsNullOrEmpty(tipo))
            {
                Console.SetCursorPosition(top, left);
                tipo = Console.ReadLine();
            };

            Console.WriteLine("Digite a capacidade da suíte (número inteiro positivo): ");
            (top, left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out capacidade) || capacidade <= 0)
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }

            Console.WriteLine("Digite o valor da diária da suíte (número decimal positivo): ");
            (top, left) = Console.GetCursorPosition();
            while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }

            suite = new(tipo, capacidade, valor);
            SuitesHotel.Add(suite);
            Console.WriteLine($"Suíte cadastrada com sucesso: {suite.TipoSuite}");
        }

        public void CadastrarReserva()
        {
            Console.Clear();

            int dias;
            List<Pessoa> hospedesSelecionados = new();
            (int top, int left) = (0, 0);

            Console.WriteLine("--- Cadastro de Reserva ---");
            Console.WriteLine("Digite a quantidade de dias que deseja reservar (número inteiro positivo): ");
            (top, left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0)
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }
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
                Console.WriteLine("5 - Confirmar Reserva");

                Console.Write("Digite a opção: ");
                int.TryParse(Console.ReadLine(), out reservaOpcao);

                switch (reservaOpcao)
                {
                    case 1:
                        {
                            int hospedeId;

                            Console.WriteLine("Lista de todos os hóspedes:");
                            for (int i = 0; i < HospedesHotel.Count; i++)
                            {
                                Console.WriteLine($"Hóspede #{i + 1}: {HospedesHotel[i].NomeCompleto}");
                            }

                            Console.WriteLine("Digite o número do hóspede que deseja incluir na reserva (0 para cancelar): ");
                            (top, left) = Console.GetCursorPosition();
                            while (!int.TryParse(Console.ReadLine(), out hospedeId) || hospedeId < 0 || hospedeId > HospedesHotel.Count)
                            {
                                Console.SetCursorPosition(top, left);
                                Console.WriteLine(new string(' ', 300));
                                Console.SetCursorPosition(top, left);
                            }

                            if (hospedeId != 0)
                            {
                                try
                                {
                                    hospedesSelecionados.Add(HospedesHotel[hospedeId - 1]);
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

                            Console.WriteLine("Digite o número do hóspede que deseja remover da reserva (0 para cancelar): ");
                            (top, left) = Console.GetCursorPosition();
                            while (!int.TryParse(Console.ReadLine(), out hospedeId) || hospedeId < 0 || hospedeId > hospedesSelecionados.Count)
                            {
                                Console.SetCursorPosition(top, left);
                                Console.WriteLine(new string(' ', 300));
                                Console.SetCursorPosition(top, left);
                            }

                            if (hospedeId != 0)
                            {
                                hospedesSelecionados.RemoveAt(hospedeId - 1);
                                Console.WriteLine("Hóspede removido da reserva.");
                            }

                            break;
                        }
                    case 3:
                        {
                            if (hospedesSelecionados.Count == 0)
                            {
                                Console.WriteLine("Não há hóspedes cadastrados na reserva.");
                            }
                            else
                            {
                                Console.WriteLine("Lista de hóspedes na reserva:");
                                for (int i = 0; i < hospedesSelecionados.Count; i++)
                                {
                                    Console.WriteLine($"Hóspede #{i + 1}: {hospedesSelecionados[i].NomeCompleto}");
                                }
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
                            for (int i = 0; i < SuitesHotel.Count; i++)
                            {
                                Console.WriteLine($"Suíte #{i + 1}: {SuitesHotel[i].TipoSuite}, capacidade: {SuitesHotel[i].CapacidadeSuite}, valor da diária: {SuitesHotel[i].ValorDiaria:C}");
                            }

                            Console.WriteLine("Digite o número da suíte que deseja escolher para a reserva (0 para cancelar): ");
                            (top, left) = Console.GetCursorPosition();
                            while (!int.TryParse(Console.ReadLine(), out suiteId) || suiteId < 0 || suiteId > SuitesHotel.Count)
                            {
                                Console.SetCursorPosition(top, left);
                                Console.WriteLine(new string(' ', 300));
                                Console.SetCursorPosition(top, left);
                            }

                            if (suiteId != 0)
                            {
                                try
                                {
                                    reserva.CadastrarSuite(SuitesHotel[suiteId - 1]);
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
                            if (reserva.ObterQuantidadeHospedes() > 0 && reserva.Suite != null)
                            {
                                Console.WriteLine("Reserva realizada com sucesso!");
                                Console.WriteLine($"Quantidade de hóspedes na reserva: {reserva.ObterQuantidadeHospedes()}");
                                Console.WriteLine($"Valor total a ser pago: {reserva.CalcularValorDiaria():#.##}");
                            }
                            else
                            {
                                Console.WriteLine("A reserva não pôde ser realizada pois há dados faltando.");
                            }

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
        }
    }
}
