namespace Celular.Models
{
    /// <summary>
    /// Uma classe abstrata, que implementa um smartphone genérico.
    /// </summary>
    internal abstract class Smartphone
    {
        /// <summary>
        /// O número do celular.
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// O Modelo do celular.
        /// </summary>
        private string Modelo { get; set; }

        /// <summary>
        /// O número IMEI do celular.
        /// </summary>
        private string IMEI { get; set; }

        /// <summary>
        /// A quantidade de memória disponível no celular.
        /// </summary>
        private int Memoria { get; set; }

        /// <summary>
        /// Construtor para o celular, recebendo todos os valores necessários para seus atributos.
        /// </summary>
        /// <param name="numero">O número do celular.</param>
        /// <param name="modelo">O modelo do celular.</param>
        /// <param name="imei">O número IMEI do celular.</param>
        /// <param name="memoria">A quantidade de memória do celular.</param>
        public Smartphone(string numero, string modelo, string imei, int memoria) 
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        /// <summary>
        /// Realiza uma ligação do celular.
        /// </summary>
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        /// <summary>
        /// Recebe uma ligação no celular.
        /// </summary>
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        /// <summary>
        /// Método abstrato que permite instalar um aplicativo no celular. A implementação depende da marca do celular.
        /// </summary>
        /// <param name="nomeAplicativo">O nome do aplicativo que se deseja instalar.</param>
        public abstract void InstalarAplicativo(string nomeAplicativo);
    }
}
