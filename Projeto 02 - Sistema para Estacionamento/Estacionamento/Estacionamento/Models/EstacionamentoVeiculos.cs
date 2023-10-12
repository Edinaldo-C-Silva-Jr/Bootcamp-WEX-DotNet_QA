using System.Numerics;
using System.Text;

namespace Estacionamento.Models
{
    /// <summary>
    /// Classe que implementa os métodos relacionados ao gerenciamento do Estacionamento.
    /// </summary>
    internal class EstacionamentoVeiculos
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos = new(); // Lista de veículos estacionados.

        public EstacionamentoVeiculos(decimal precoInicial, decimal precoHora) 
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        /// <summary>
        /// Método que inclui um veículo na lista de veículos estacionados, com base no valor da sua placa.
        /// </summary>
        public void AdicionarVeiculo()
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo (Formato AAA-0000): ");
            placa = MascaraEntradaPlaca();

            if (veiculos.Any(placaVeiculo => placaVeiculo == placa)) // Se existir um veículo com a placa digitada...
            {
                Console.WriteLine("Este veículo já se encontra estacionado.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
        }

        /// <summary>
        /// Método que remove um veículo da lista de veículos estacionados, com base no valor da sua placa.
        /// </summary>
        public void RemoverVeiculo()
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo (Formato AAA-0000): ");
            placa = MascaraEntradaPlaca();

            if (veiculos.Any(placaVeiculo => placaVeiculo == placa)) // Se existir um veículo com a placa digitada...
            {
                int quantidadeHoras;
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");
                while (!(int.TryParse(Console.ReadLine(), out quantidadeHoras)) || quantidadeHoras <= 0) // Verifica se o valor digitado é um número inteiro, e se é maior que 0.
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

        /// <summary>
        /// Método que lista todos os veículos estacionados.
        /// </summary>
        public void ListarVeiculos()
        {
            if (veiculos.Any()) // Se existir algum veículo...
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

        /// <summary>
        /// Método que implementa uma máscara para a entrada da placa, garantindo que a placa inserida tenha o formato AAA-0000.
        /// </summary>
        /// <returns>Retorna o valor da placa, devidamente formatado.</returns>
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
                Console.SetCursorPosition(cursorX, cursorY);
                Console.WriteLine(CriaMascaraParaExibir(placa)); // Exibe a máscara do valor da placa.

                entrada = Console.ReadKey(true);

                switch(entrada.Key)
                {
                    case ConsoleKey.Backspace: // Se a tecla apertada for Backspace...
                        {
                            if (placa.Length == 4) // Remove o hífen, se necessário
                            {
                                placa = placa[..^1];
                            }

                            if (placa.Length > 0) // Remove um caractere da string
                            {
                                placa = placa[..^1];
                            }
                            break;
                        }
                    case ConsoleKey.Enter: // Se a tecla apertada for Enter...
                        {
                            entradaCorreta = placa.Length == 8; // Marca a entrada como correta caso a string tenha todos os caracteres
                            break;
                        }
                    default: // Se for digitada outra tecla...
                        {
                            if (placa.Length < 3 && Char.IsLetter(entrada.KeyChar)) // Só aceita letras para os 3 primeiros caracteres
                            {
                                placa += Char.ToUpper(entrada.KeyChar);
                            }

                            if (placa.Length == 3) // Adiciona o hífen depois das letras
                            {
                                placa += '-';
                            }

                            if (placa.Length > 3 && placa.Length < 8 && Char.IsDigit(entrada.KeyChar)) // Só aceita números para os 4 últimos caracteres
                            {
                                placa += entrada.KeyChar;
                            }
                            break;
                        }
                }
            }

            Console.CursorVisible = true;
            return placa;
        }

        /// <summary>
        /// Método que cria a máscara do valor da placa para exibir na tela.
        /// </summary>
        /// <param name="textoOriginal">O valor da placa.</param>
        /// <returns>Uma string com a máscara aplicada na placa.</returns>
        private string CriaMascaraParaExibir(string textoOriginal)
        {
            string textoMascara = "";

            for (int i = 0; i < 8; i++) // Uma iteração para cada caractere (3 letras + hífen + 4 números).
            {
                if (i == 3) // Adiciona o hífen na quarta posição.
                {
                    textoMascara += "- ";
                }
                else
                {
                    if (textoOriginal.Length > i) // Se a string original já tiver um caractere nessa posição, ele é exibido.
                    {
                        textoMascara += textoOriginal.Substring(i, 1) + ' ';
                    }
                    else // Se não tiver caractere, exibe um underline _
                    {
                        textoMascara += "_ ";
                    }
                }
            }

            return textoMascara;
        }
    }
}
