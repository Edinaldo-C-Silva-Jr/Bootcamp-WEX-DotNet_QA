using Calculadora.Models;

namespace CalculadoraTestes
{
    public class CalcularTests
    {
        private readonly Calcular _calcular;

        public CalcularTests()
        {
            _calcular = new Calcular();
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 4, 4)]
        [InlineData(7, 0, 7)]
        [InlineData(1, 2, 3)]
        [InlineData(10, 20, 30)]
        [InlineData(-5, -4, -9)]
        [InlineData(-3, 4, 1)]
        [InlineData(7, -5, 2)]
        public void DeveSomarDoisValoresERetornarOTerceiro(int numero1, int numero2, int resultado)
        {
            // Arrange
            int resultadoDaSoma;

            // Act
            resultadoDaSoma = _calcular.Somar(numero1, numero2);

            // Assert
            Assert.Equal(resultado, resultadoDaSoma);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 0, 2)]
        [InlineData(0, 2, -2)]
        [InlineData(2, 1, 1)]
        [InlineData(2, 3, -1)]
        [InlineData(-3, -7, 4)]
        [InlineData(-5, 5, -10)]
        [InlineData(8, -3, 11)]
        public void DeveSubtrairOSegundoValorDoPrimeiroERetornarOTerceiro(int numero1, int numero2, int resultado)
        {
            // Arrange
            int resultadoDaSubtracao;

            // Act
            resultadoDaSubtracao = _calcular.Subtrair(numero1, numero2);

            // Assert
            Assert.Equal(resultado, resultadoDaSubtracao);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(5, 0, 0)]
        [InlineData(0, 9, 0)]
        [InlineData(1, 2, 2)]
        [InlineData(50, 10, 500)]
        [InlineData(-5, -4, 20)]
        [InlineData(-3, 8, -24)]
        [InlineData(5, -2, -10)]
        public void DeveMultiplicarDoisValoresERetornarOTerceiro(int numero1, int numero2, int resultado)
        {
            // Arrange
            int resultadoDaMultiplicacao;

            // Act
            resultadoDaMultiplicacao = _calcular.Multiplicar(numero1, numero2);

            // Assert
            Assert.Equal(resultado, resultadoDaMultiplicacao);
        }

        [Fact]
        public void DeveGerarExcecaoAoDividirPorZero()
        {
            // Arrange
            int numero1 = 3, numero2 = 0;

            // Act / Assert
            Assert.Throws<DivideByZeroException>(() => _calcular.Dividir(numero1, numero2));
        }

        [Theory]
        [InlineData(0, 6, 0)]
        [InlineData(2, 1, 2)]
        [InlineData(20, 5, 4)]
        [InlineData(-40, -4, 10)]
        [InlineData(-9, 3, -3)]
        [InlineData(15, -3, -5)]
        public void DeveDividirOSegundoValorDoPrimeiroERetornarOTerceiro(int numero1, int numero2, int resultado)
        {
            // Arrange
            int resultadoDaDivisao;

            // Act
            resultadoDaDivisao = _calcular.Dividir(numero1, numero2);

            // Assert
            Assert.Equal(resultado, resultadoDaDivisao);
        }

        [Fact]
        public void VerificaSeHistoricoRetornaListaCom3Elementos()
        {
            // Arrrange
            _calcular.Somar(0, 1);
            _calcular.Somar(1, 2);
            _calcular.Somar(2, 3);
            _calcular.Somar(3, 4);
            List<string> historico;

            // Act
            historico = _calcular.RetornarHistorico();

            // Assert
            Assert.NotEmpty(historico);
            Assert.Equal(3, historico.Count);
        }
    }
}