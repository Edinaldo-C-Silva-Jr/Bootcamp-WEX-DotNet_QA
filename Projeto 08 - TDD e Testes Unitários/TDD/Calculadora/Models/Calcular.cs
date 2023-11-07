namespace Calculadora.Models
{
    public class Calcular
    {
        private List<String> historico;

        public Calcular()
        {
            historico = new List<String>();
        }

        public int Somar(int numero1, int numero2)
        {
            historico.Insert(0, $"Soma: {numero1} + {numero2} = {numero1 + numero2}");
            return numero1 + numero2;
        }
        public int Subtrair(int numero1, int numero2)
        {
            historico.Insert(0, $"Subtração: {numero1} - {numero2} = {numero1 - numero2}");
            return numero1 - numero2;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            historico.Insert(0, $"Multiplicação: {numero1} * {numero2} = {numero1 * numero2}");
            return numero1 * numero2;
        }
        public int Dividir(int numero1, int numero2)
        {
            historico.Insert(0, $"Divisão: {numero1} / {numero2} = {numero1 / numero2}");
            return numero1 / numero2;
        }

        public List<string> RetornarHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
