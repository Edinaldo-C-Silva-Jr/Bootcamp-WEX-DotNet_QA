namespace Celular.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) 
        {

        }

        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando aplicativo {nomeAplicativo} no celular iPhone.");
        }
    }
}
