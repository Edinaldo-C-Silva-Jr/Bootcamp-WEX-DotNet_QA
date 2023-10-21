using Hospedagem.Models;

namespace Hospedagem
{
    internal class Hotel
    {
        public List<Pessoa> HospedesHotel { get; }
        public List<Suite> SuitesHotel { get; }

        public Hotel()
        {
            HospedesHotel = new List<Pessoa>();
            SuitesHotel = new List<Suite>();
        }

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

            if (HospedesHotel.Any(hospedeExistente => hospedeExistente.NomeCompleto == hospede.NomeCompleto))
            {
                Console.WriteLine($"Já existe um hóspede cadastrado com o nome {hospede.NomeCompleto}");
            }
            else
            {
                HospedesHotel.Add(hospede);
                Console.WriteLine($"Hóspede cadastrado com sucesso: {hospede.NomeCompleto}");
            }
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

            if (SuitesHotel.Any(suiteExistente => suiteExistente.TipoSuite == suite.TipoSuite))
            {
                Console.WriteLine($"Já existe uma suíte cadastrada do tipo {suite.TipoSuite}");
            }
            else
            {
                SuitesHotel.Add(suite);
                Console.WriteLine($"Suíte cadastrada com sucesso: {suite.TipoSuite}");
            }
        }

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
