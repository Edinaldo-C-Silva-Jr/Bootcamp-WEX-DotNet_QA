namespace Celular.Models
{
    /// <summary>
    /// Uma classe que implementa um celular da marca Iphone.
    /// </summary>
    internal class Iphone : Smartphone
    {
        /// <summary>
        /// Construtor para um celular Iphone, recebendo todos os valores necessários para seus atributos.
        /// </summary>
        /// <param name="numero">O número do celular.</param>
        /// <param name="modelo">O modelo do celular.</param>
        /// <param name="imei">O número IMEI do celular.</param>
        /// <param name="memoria">A quantidade de memória do celular.</param>
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) 
        {

        }

        /// <summary>
        /// Instala um aplicativo em um celular Iphone.
        /// </summary>
        /// <param name="nomeAplicativo">O nome do aplicativo a ser instalado.</param>
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando aplicativo {nomeAplicativo} no celular iPhone.");
        }
    }
}
