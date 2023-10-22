using Hospedagem.Models;

namespace Hospedagem
{
    /// <summary>
    /// Uma classe que implementa um menu para a criação da reserva, e cuida de todo o gerenciamento das entradas e validações de dados para inserí-los na reserva.
    /// </summary>
    internal class MenuReserva
    {
        List<Pessoa> hospedesSelecionados = new(); // Lista de hóspedes escolhidos para esta reserva.
        Reserva? reserva; // A reserva que será criada.

        /// <summary>
        /// Exibe o menu de criação da reserva, que gerencia todo o processo de receber os dados e criar a reserva.
        /// </summary>
        /// <param name="hotel">O hotel, que contém os hóspedes e suítes utilizados na reserva.</param>
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
                Console.WriteLine("2 - Remover Hóspedes da reserva.");
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
                            if (reserva.ObterQuantidadeHospedes() > 0 && reserva.Suite != null) // Cria a reserva apenas se ela tiver hóspedes e uma suíte cadastrados.
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

        /// <summary>
        /// Instancia uma nova reserva. Solicita ao usuário a quantidade de dias reservados.
        /// </summary>
        /// <returns></returns>
        private Reserva CriarReserva()
        {
            Console.Clear();

            int dias;

            Console.WriteLine("--- Cadastro de Reserva ---");
            Console.WriteLine("Digite a quantidade de dias que deseja reservar (número inteiro positivo): ");
            (int top, int left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0) // Garante que a quantidade de dias é um número inteiro e positivo.
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }
            return new Reserva(dias);
        }

        /// <summary>
        /// Insere um hóspede na reserva.
        /// Utiliza a lista de hóspedes já cadastrados no hotel, listando-os e solicitando o índice correspondente ao hóspede escolhido, que é então inserido na lista de hóspedes escolhidos.
        /// Também é verificado se o hóspede escolhido já está incluído na reserva, antes de inserí-lo.
        /// </summary>
        /// <param name="hospedesHotel">A lista de hóspedes existentes no hotel.</param>
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
            while (!int.TryParse(Console.ReadLine(), out hospedeId) || hospedeId < 0 || hospedeId > hospedesHotel.Count) // Garante que o número do hóspede seja um número positivo e que exista na lista de hóspedes
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }

            if (hospedeId != 0)
            {
                if (hospedesSelecionados.Any(hospedeNaReserva => hospedeNaReserva.NomeCompleto == hospedesHotel[hospedeId - 1].NomeCompleto)) // Verifica se o hóspede já existe na reserva
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
                    catch (ArgumentException ex)
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

        /// <summary>
        /// Remove um hóspede na reserva, com base no número do hóspede (fornecido ao listar os hóspedes existentes)
        /// </summary>
        private void RemoverHospedeDaReserva()
        {
            int hospedeId;

            Console.WriteLine("Digite o número do hóspede que deseja remover da reserva (0 para cancelar): ");
            (int top, int left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out hospedeId) || hospedeId < 0 || hospedeId > hospedesSelecionados.Count) // Garante que o número do hóspede é um inteiro positivo e existe na lista de hóspedes
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

        /// <summary>
        /// Exibe os dados da reserva. Lista todos os hóspedes atualmente cadastrados e a suíte escolhida para a reserva.
        /// Também informa caso não existam hóspedes ou suíte cadastrados.
        /// </summary>
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

        /// <summary>
        /// Realiza a escolha de uma suíte para a reserva.
        /// Utiliza a lista de suítes já cadastradas no hotel, listando-as e solicitando o índice correspondente à suíte escolhida.
        /// </summary>
        /// <param name="suitesHotel"></param>
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
            while (!int.TryParse(Console.ReadLine(), out suiteId) || suiteId < 0 || suiteId > suitesHotel.Count) // Garante que o número da suíte é um inteiro positivo e que existe na lista.
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
                catch (ArgumentException ex)
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
