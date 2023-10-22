using Hospedagem.Models;

namespace Hospedagem
{
    /// <summary>
    /// Uma classe que representa um hotel no sistema. Usada para armazenar o cadastro dos hóspedes e suítes usadas nas reservas.
    /// </summary>
    internal class Hotel
    {
        /// <summary>
        /// A lista de todos os hóspedes cadastrados no hotel.
        /// </summary>
        public List<Pessoa> HospedesHotel { get; }

        /// <summary>
        /// A lista de todas as suítes cadastradas no hotel.
        /// </summary>
        public List<Suite> SuitesHotel { get; }

        /// <summary>
        /// O construtor do hotel, que inicializa as listas de hóspedes e suítes.
        /// </summary>
        public Hotel()
        {
            HospedesHotel = new List<Pessoa>();
            SuitesHotel = new List<Suite>();
        }

        /// <summary>
        /// Cadastra um hóspede no hotel. 
        /// O método solicita duas entradas de usuário: o primeiro nome (obrigatório) e o sobrenome (opcional). Depois cria um hóspede com o nome e sobrenome fornecidos.
        /// Caso o hóspede inserido já esteja cadastrado no hotel, é retornado um aviso. Caso não exista, o hóspede é adicionado no hotel. 
        /// </summary>
        public void CadastrarHospedeNoHotel()
        {
            string nome = "", sobrenome = "";
            Pessoa hospede;

            Console.WriteLine("Digite o primeiro nome do hóspede a ser cadastrado (campo obrigatório): ");
            (int top, int left) = Console.GetCursorPosition();
            while (string.IsNullOrEmpty(nome)) // Garante que a entrada do nome contenha dados.
            {
                Console.SetCursorPosition(top, left);
                nome = Console.ReadLine();

            };

            Console.WriteLine("Digite o sobrenome do hóspede a ser cadastrado: ");
            sobrenome = Console.ReadLine();

            if (string.IsNullOrEmpty(sobrenome)) // Chama o construtor correto de acordo com a nulidade do sobrenome
            {
                hospede = new(nome);
            }
            else
            {
                hospede = new(nome, sobrenome);
            }

            if (HospedesHotel.Any(hospedeExistente => hospedeExistente.NomeCompleto == hospede.NomeCompleto)) // Verifica se o hóspede já está cadastrado no hotel. 
            {
                Console.WriteLine($"Já existe um hóspede cadastrado com o nome {hospede.NomeCompleto}");
            }
            else
            {
                HospedesHotel.Add(hospede);
                Console.WriteLine($"Hóspede cadastrado com sucesso: {hospede.NomeCompleto}");
            }
        }

        /// <summary>
        /// Cadastra uma suíte no hotel.
        /// O método solicita três entradas de dados, todas obrigatórias: Tipo da suíte, capacidade e valor da diária. Depois cria uma suíte com os dados fornecidos.
        /// Caso o tipo de suíte já exista no hotel, é retornado um aviso. Caso não exista, a suíte é adicionada ao hotel.
        /// </summary>
        public void CadastrarSuitesNoHotel()
        {
            string tipo = "";
            int capacidade;
            decimal valor;
            Suite suite;

            Console.WriteLine("Digite o Tipo da suíte (obrigatório): ");
            (int top, int left) = Console.GetCursorPosition();
            while (string.IsNullOrEmpty(tipo)) // Garante que o tipo de suíte contenha dados.
            {
                Console.SetCursorPosition(top, left);
                tipo = Console.ReadLine();
            };

            Console.WriteLine("Digite a capacidade da suíte (número inteiro positivo): ");
            (top, left) = Console.GetCursorPosition();
            while (!int.TryParse(Console.ReadLine(), out capacidade) || capacidade <= 0) // Garante que a capacidade seja um número válido e positivo.
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }

            Console.WriteLine("Digite o valor da diária da suíte (número decimal positivo): ");
            (top, left) = Console.GetCursorPosition();
            while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0) // Garante que o valor da diária seja um número válido e positivo.
            {
                Console.SetCursorPosition(top, left);
                Console.WriteLine(new string(' ', 300));
                Console.SetCursorPosition(top, left);
            }

            suite = new(tipo, capacidade, valor);

            if (SuitesHotel.Any(suiteExistente => suiteExistente.TipoSuite == suite.TipoSuite)) // Verifica se a suíte já existe no hotel
            {
                Console.WriteLine($"Já existe uma suíte cadastrada do tipo {suite.TipoSuite}");
            }
            else
            {
                SuitesHotel.Add(suite);
                Console.WriteLine($"Suíte cadastrada com sucesso: {suite.TipoSuite}");
            }
        }

        /// <summary>
        /// Exibe uma lista de todos os hóspedes cadastrados no hotel, ou informa caso não haja nenhum hóspede cadastrado.
        /// </summary>
        public void ListarHospedes()
        {
            if (HospedesHotel.Any())
            {
                Console.WriteLine("Lista de hóspedes cadastrados no hotel:");
                for (int i = 0; i < HospedesHotel.Count; i++)
                {
                    Console.WriteLine($"Hóspede #{i + 1}: {HospedesHotel[i].NomeCompleto}");
                }
            }
            else
            {
                Console.WriteLine("Não há hóspedes cadastrados no hotel.");
            }

        }

        /// <summary>
        /// Exibe uma lista de todas as suítes existentes no hotel, mostrando todos os seus dados, ou informa caso não existam suítes no hotel.
        /// </summary>
        public void ListarSuites()
        {
            if (SuitesHotel.Any())
            {
                Console.WriteLine("Lista de suítes cadastradas no hotel:");
                for (int i = 0; i < SuitesHotel.Count; i++)
                {
                    Console.WriteLine($"Suíte #{i + 1}: {SuitesHotel[i].TipoSuite}, Capacidade: {SuitesHotel[i].CapacidadeSuite}, Valor da Diária: {SuitesHotel[i].ValorDiaria:C}");
                }
            }
            else
            {
                Console.WriteLine("Não há suítes cadastradas no hotel.");
            }
        }
    }
}
