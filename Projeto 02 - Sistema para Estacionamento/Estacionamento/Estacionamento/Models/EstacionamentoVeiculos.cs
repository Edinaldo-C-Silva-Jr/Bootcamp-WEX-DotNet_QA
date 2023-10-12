namespace Estacionamento.Models
{
    internal class EstacionamentoVeiculos
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos = new();

        public EstacionamentoVeiculos(decimal precoInicial, decimal precoHora) 
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo (Formato AAA-0000): ");
            placa = MascaraEntradaPlaca();

            if (veiculos.Any(placaVeiculo => placaVeiculo == placa))
            {
                Console.WriteLine("Este veículo já se encontra estacionado.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo (Formato AAA-0000): ");
            placa = MascaraEntradaPlaca();

            if (veiculos.Any(placaVeiculo => placaVeiculo == placa))
            {
                int quantidadeHoras;
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");
                while (!(int.TryParse(Console.ReadLine(), out quantidadeHoras)) || quantidadeHoras <= 0)
                {
                    Console.WriteLine("Valor inválido. A hora deve ser um valor numérico positivo.");
                    Console.WriteLine("Digite novamente a quantidade de horas: ");
                }

                veiculos.Remove(placa);
                Console.WriteLine($"Veículo removido. Valor total do estacionamento: R${precoInicial + precoHora * quantidadeHoras}");
            }
            else
            {
                Console.WriteLine("Não há nenhum veículo estacionado com esta placa");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                foreach(string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private string MascaraEntradaPlaca()
        {
            Console.CursorVisible = false;
            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            string placa = "";
            ConsoleKeyInfo entrada;

            bool entradaCorreta = false;
            while(!entradaCorreta)
            {
                entrada = Console.ReadKey(true);

                switch(entrada.Key)
                {
                    case ConsoleKey.Backspace:
                        {
                            if (placa.Length == 4)
                            {
                                placa = placa[..^1];
                            }

                            if (placa.Length > 0)
                            {
                                placa = placa[..^1];
                            }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            entradaCorreta = placa.Length == 8;
                            break;
                        }
                    default:
                        {
                            if (placa.Length < 3 && Char.IsLetter(entrada.KeyChar))
                            {
                                placa += Char.ToUpper(entrada.KeyChar);
                            }

                            if (placa.Length == 3)
                            {
                                placa += '-';
                            }

                            if (placa.Length > 3 && placa.Length < 8 && Char.IsDigit(entrada.KeyChar))
                            {
                                placa += entrada.KeyChar;
                            }
                            break;
                        }
                }

                Console.SetCursorPosition(cursorX, cursorY);
                Console.WriteLine(placa + new string(' ', 7));
            }

            Console.CursorVisible = true;
            return placa;
        }
    }
}
