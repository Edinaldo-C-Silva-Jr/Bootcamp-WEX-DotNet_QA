using Validacoes.Services;

namespace ValidacoesTestes
{
    public class ValidacoesStringTests
    {
        private readonly ValidacoesString _validaString;

        public ValidacoesStringTests()
        {
            _validaString = new ValidacoesString();
        }

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            int quantidadeCaracteres;
            string stringDeTeste = "Matrix";

            // Act
            quantidadeCaracteres = _validaString.RetornarQuantidadeCaracteres(stringDeTeste);

            // Assert
            Assert.Equal(6, quantidadeCaracteres);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            // Arrange
            bool palavraExiste;
            string texto = "Este é um texto qualquer.", palavra = "qualquer";

            // Act
            palavraExiste = _validaString.ContemCaractere(texto, palavra);

            // Assert
            Assert.True(palavraExiste);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            // Arrange
            bool palavraExiste;
            string texto = "Este é um texto qualquer.", palavra = "teste";

            // Act
            palavraExiste = _validaString.ContemCaractere(texto, palavra);

            // Assert
            Assert.False(palavraExiste);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            // Arrange
            bool terminaComPalavra;
            string texto = "Começo, meio e fim do texto procurado", palavra = "procurado";

            // Act
            terminaComPalavra = _validaString.TextoTerminaCom(texto, palavra);

            // Assert
            Assert.True(terminaComPalavra);
        }
    }
}
