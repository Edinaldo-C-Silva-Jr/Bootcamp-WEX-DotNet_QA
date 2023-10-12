using System.Numerics;

namespace Estacionamento.Models
{
    internal class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoHora) 
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo: ");
            placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(placaVeiculo => placaVeiculo == placa))
            {
                Console.WriteLine("Este veículo já se encontra estacionado.");
            }
            else
            {
                veiculos.Add(placa);
            }

            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo: ");
            placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(placaVeiculo => placaVeiculo == placa))
            {
                int quantidadeHoras;
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");
                while (int.TryParse(Console.ReadLine(), out quantidadeHoras) || quantidadeHoras < 0)
                {
                    Console.WriteLine("Valor inválido");
                }

                veiculos.Remove(placa);
                Console.WriteLine($"Veículo removido. Valor total do estacionamento: {precoInicial + precoHora * quantidadeHoras}");
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
    }
}
