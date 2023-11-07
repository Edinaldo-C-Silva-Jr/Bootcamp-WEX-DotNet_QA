namespace Calculadora.Models
{
    public class Calcular
    {
        private List<string> historico;
        private string dataOperacao;

        public Calcular(string data)
        {
            historico = new List<string>();
            dataOperacao = data;
        }

        private void InserirNoHistorico(string operacao)
        {
            historico.Insert(0, $"Data: {dataOperacao}, {operacao}");
        }

        public int Somar(int numero1, int numero2)
        {
            InserirNoHistorico($"Soma: {numero1} + {numero2} = {numero1 + numero2}");
            return numero1 + numero2;
        }
        public int Subtrair(int numero1, int numero2)
        {
            InserirNoHistorico($"Subtração: {numero1} - {numero2} = {numero1 - numero2}");
            return numero1 - numero2;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            InserirNoHistorico($"Multiplicação: {numero1} * {numero2} = {numero1 * numero2}");
            return numero1 * numero2;
        }
        public int Dividir(int numero1, int numero2)
        {
            InserirNoHistorico($"Divisão: {numero1} / {numero2} = {numero1 / numero2}");
            return numero1 / numero2;
        }

        public List<string> RetornarHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
