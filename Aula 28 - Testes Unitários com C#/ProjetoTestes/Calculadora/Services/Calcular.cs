namespace Calculadora.Services
{
    public class Calcular
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        
        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        
        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        
        public int Dividir(int numero1, int numero2)
        {
            if (numero2 != 0)
            { 
                return numero1 / numero2;
            }

            return 0;
        }

        public bool Par(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
