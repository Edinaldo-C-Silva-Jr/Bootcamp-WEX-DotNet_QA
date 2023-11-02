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

        [Fact]
        public void DeveSomarMenos10Com20ERetornar10()
        {
            // Arrange
            int n1 = -10, n2 = 20;

            // Act
            int resultado = _calcular.Somar(n1, n2);

            // Assert
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void DeveSubtrair8De40ERetornar32()
        {
            // Arrange
            int n1 = 40, n2 = 8;

            // Act
            int resultado = _calcular.Subtrair(n1, n2);

            // Assert
            Assert.Equal(32, resultado);
        }

        [Fact]
        public void DeveSubtrairMenos10De20ERetornar30()
        {
            // Arrange
            int n1 = 20, n2 = -10;

            // Act
            int resultado = _calcular.Subtrair(n1, n2);

            // Assert
            Assert.Equal(30, resultado);
        }

        [Fact]
        public void DeveMultiplicar5Por4ERetornar20()
        {
            // Arrange
            int n1 = 5, n2 = 4;

            // Act
            int resultado = _calcular.Multiplicar(n1, n2);

            // Assert
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void DeveMultiplicarMenos6Por3ERetornarMenos18()
        {
            // Arrange
            int n1 = -6, n2 = 3;

            // Act
            int resultado = _calcular.Multiplicar(n1, n2);

            // Assert
            Assert.Equal(-18, resultado);
        }

        [Fact]
        public void DeveDividir50Por5ERetornar10()
        {
            // Arrange
            int n1 = 50, n2 = 5;

            // Act
            int resultado = _calcular.Dividir(n1, n2);

            // Assert
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void DeveDividirMenos100Por20ERetornarMenos5()
        {
            // Arrange
            int n1 = -100, n2 = 20;

            // Act
            int resultado = _calcular.Dividir(n1, n2);

            // Assert
            Assert.Equal(-5, resultado);
        }

        [Fact]
        public void DeveRetornar0AoDividirPor0()
        {
            // Arrange
            int n1 = 12345, n2 = 0;

            // Act
            int resultado = _calcular.Dividir(n1, n2);

            // Assert
            Assert.Equal(0, resultado);
        }
    }
}