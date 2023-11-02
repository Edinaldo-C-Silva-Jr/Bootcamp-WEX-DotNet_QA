using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalcularTests
    {
        Calcular _calcular;

        public CalcularTests()
        {
            _calcular = new Calcular();
        }

        [Fact]
        public void DeveSomar5Com10ERetornar15()
        {
            // Arrange
            int n1 = 5, n2 = 10;

            // Act
            int resultado = _calcular.Somar(n1, n2);

            // Assert
            Assert.Equal(15, resultado);
        }
    }
}