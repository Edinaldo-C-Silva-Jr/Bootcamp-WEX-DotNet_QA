namespace Celular.Models
{
    /// <summary>
    /// Uma classe que implementa um celular da marca Nokia.
    /// </summary>
    internal class Nokia : Smartphone
    {
        /// <summary>
        /// Construtor para um celular Nokia, recebendo todos os valores necessários para seus atributos.
        /// </summary>
        /// <param name="numero">O número do celular.</param>
        /// <param name="modelo">O modelo do celular.</param>
        /// <param name="imei">O número IMEI do celular.</param>
        /// <param name="memoria">A quantidade de memória do celular.</param>
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        /// <summary>
        /// Instala um aplicativo em um celular Nokia.
        /// </summary>
        /// <param name="nomeAplicativo">O nome do aplicativo a ser instalado.</param>
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando aplicativo {nomeAplicativo} no celular Nokia.");
        }
    }
}
