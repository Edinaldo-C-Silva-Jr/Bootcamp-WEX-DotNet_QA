using Hospedagem.Models;

namespace Hospedagem
{
    internal class MenuReserva
    {
        List<Pessoa> hospedesSelecionados = new();
        Reserva? reserva;

        public void MostrarMenu(Hotel hotel)
        {
            reserva = CriarReserva();

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
                            InserirHospedeNaReserva(hotel.HospedesHotel);
                            break;
                        }
                    case 2:
                        {
                            RemoverHospedeDaReserva();
                            break;
                        }
                    case 3:
                        {
                            MostrarDadosDaReserva();
                            break;
                        }
                    case 4:
                        {
                            EscolherSuiteDaReserva(hotel.SuitesHotel);
                            break;
                        }
                    case 5:
                        {
                            if (reserva.ObterQuantidadeHospedes() > 0 && reserva.Suite != null)
                            {
                                Console.WriteLine("Reserva realizada com sucesso!");
                                Console.WriteLine($"Quantidade de hóspedes na reserva: {reserva.ObterQuantidadeHospedes()}");
                                Console.WriteLine($"Valor total a ser pago: {reserva.CalcularValorDiaria():C}");
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

        private Reserva CriarReserva()
        {
            Console.Clear();

            int dias;

            Console.WriteLine("--- Cadastro de Reserva ---");
            Console.WriteLine("Digite a quantidade de dias que deseja reservar (número inteiro positivo): ");
            (int top, int left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0)
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }
            return new Reserva(dias);
        }

        private void InserirHospedeNaReserva(List<Pessoa> hospedesHotel)
        {
            int hospedeId;

            Console.WriteLine("Lista de todos os hóspedes:");
            for (int i = 0; i < hospedesHotel.Count; i++)
            {
                Console.WriteLine($"Hóspede #{i + 1}: {hospedesHotel[i].NomeCompleto}");
            }

            Console.WriteLine("Digite o número do hóspede que deseja incluir na reserva (0 para cancelar): ");
            (int top, int left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out hospedeId) || hospedeId < 0 || hospedeId > hospedesHotel.Count)
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }

            if (hospedeId != 0)
            {
                if (hospedesSelecionados.Any(hospedeNaReserva => hospedeNaReserva.NomeCompleto == hospedesHotel[hospedeId - 1].NomeCompleto))
                {
                    Console.WriteLine($"O hóspede {hospedesHotel[hospedeId - 1].NomeCompleto} já está cadastrado nessa reserva.");
                }
                else
                {
                    try
                    {
                        hospedesSelecionados.Add(hospedesHotel[hospedeId - 1]);
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
            }
            else
            {
                Console.WriteLine("Operação de cadastro de hóspede cancelada.");
            }
        }

        private void RemoverHospedeDaReserva()
        {
            int hospedeId;

            Console.WriteLine("Digite o número do hóspede que deseja remover da reserva (0 para cancelar): ");
            (int top, int left) = Console.GetCursorPosition();
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
            else
            {
                Console.WriteLine("Operação de remoção de hóspede cancelada.");
            }
        }

        private void MostrarDadosDaReserva()
        {
            if (hospedesSelecionados.Any())
            {
                Console.WriteLine("Lista de hóspedes na reserva:");
                for (int i = 0; i < hospedesSelecionados.Count; i++)
                {
                    Console.WriteLine($"Hóspede #{i + 1}: {hospedesSelecionados[i].NomeCompleto}");
                }
            }
            else
            {
                Console.WriteLine("Não há hóspedes cadastrados na reserva.");
            }

            if (reserva.Suite != null)
            {
                Console.WriteLine($"Suíte escolhida: {reserva.Suite.TipoSuite}, capacidade: {reserva.Suite.CapacidadeSuite}, valor da diária: {reserva.Suite.ValorDiaria:C}");
            }
            else
            {
                Console.WriteLine("Não há suíte escolhida nessa reserva.");
            }
        }

        private void EscolherSuiteDaReserva(List<Suite> suitesHotel)
        {
            int suiteId;

            Console.WriteLine("Lista de todas as suítes:");
            for (int i = 0; i < suitesHotel.Count; i++)
            {
                Console.WriteLine($"Suíte #{i + 1}: {suitesHotel[i].TipoSuite}, capacidade: {suitesHotel[i].CapacidadeSuite}, valor da diária: {suitesHotel[i].ValorDiaria:C}");
            }

            Console.WriteLine("Digite o número da suíte que deseja escolher para a reserva (0 para cancelar): ");
            (int top, int left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out suiteId) || suiteId < 0 || suiteId > suitesHotel.Count)
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }

            if (suiteId != 0)
            {
                try
                {
                    reserva.CadastrarSuite(suitesHotel[suiteId - 1]);
                    Console.WriteLine("Suíte incluída na reserva!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Escolha uma nova suíte ou diminua a quantidade de hóspedes da reserva.");
                }
            }
            else
            {
                Console.WriteLine("Operação de escolha de suíte cancelada.");
            }
        }
    }
}
