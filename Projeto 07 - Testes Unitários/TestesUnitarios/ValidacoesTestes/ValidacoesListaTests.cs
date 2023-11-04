using Validacoes.Services;

namespace ValidacoesTestes
{
    public class ValidacoesListaTests
    {
        private readonly ValidacoesLista _validaLista;

        public ValidacoesListaTests()
        {
            _validaLista = new ValidacoesLista();
        }

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            List<int> lista = new() { 2, 5, -9, -1, 4, -3 };
            List<int> listaEsperada = new() { 2, 5, 4 };

            // Act
            lista = _validaLista.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(listaEsperada, lista);
        }

        [Fact]
        public void RetornaAMesmaListaCasoNaoHajaNumerosNegativos()
        {
            // Arrange
            List<int> lista = new() { 2, 4, 5, 8 };
            List<int> listaEsperada = new() { 2, 4, 5, 8 };

            // Act
            lista = _validaLista.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(listaEsperada, lista);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            // Arrange
            List<int> lista = new() { 1, 3, 5, 7, 9 };
            bool contemNumero;

            // Act
            contemNumero = _validaLista.ListaContemDeterminadoNumero(lista, 9);

            // Assert
            Assert.True(contemNumero);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            // Arrange
            List<int> lista = new() { 1, 3, 5, 7, 9 };
            bool contemNumero;

            // Act 
            contemNumero = _validaLista.ListaContemDeterminadoNumero(lista, 10);

            // Assert
            Assert.False(contemNumero);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Arrange
            List<int> lista = new() { 12, 8, 3, 95, 17 };
            List<int> listaEsperada = new() { 24, 16, 6, 190, 34 };

            // Act
            lista = _validaLista.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.Equal(listaEsperada, lista);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            // Arrange
            List<int> lista = new() { -4, 8, 9, 0, -12, -648 };
            int numero;

            // Act
            numero = _validaLista.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, numero);
        }

        [Fact]
        public void DeveRetornarMenos9ComoMaiorNumeroDaLista()
        {
            // Arrange
            List<int> lista = new() { -40, -9, -92, -345 };
            int numero;

            // Act
            numero = _validaLista.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(-9, numero);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            // Arrange
            List<int> lista = new() { -8, 19, 1, 0, -5, 75 };
            int numero;

            // Act
            numero = _validaLista.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-8, numero);
        }

        [Fact]
        public void DeveRetornarDozeComoMenorNumeroDaLista()
        {
            // Arrange
            List<int> lista = new() { 12, 19, 94, 30, 75 };
            int numero;

            // Act
            numero = _validaLista.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(12, numero);
        }
    }
}