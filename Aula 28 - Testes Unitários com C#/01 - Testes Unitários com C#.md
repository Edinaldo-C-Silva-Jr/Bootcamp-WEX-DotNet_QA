# Testes Unitários

### O que é um Teste?

Os testes são fundamentais para garantir que o software está funcionando de forma correta. Eles servem para garantir que não hajam erros na execução do sistema, e também para confirmar que eles atendem às necessidades que levaram à criação do software.  
Existem vários tipos de testes de software: teste unitário, teste de integração, teste regressivo, teste de segurança, dentre outros.

Os testes são feitos de forma diferente dependendo do objetivo desejado e de quem está fazendo o teste. A visão do desenvolvedor é diferente da visão do cliente em relação a se o software funciona como esperado.  
Os testes unitários são os testes feitos pelo desenvolvedor, para garantir que o código que foi escrito funciona. O cliente faz os testes baseados na usabilidade do software, e se ele atende às necessidades do negócio.

### Testes Unitários

O teste unitário, ou teste de unidade, é um teste feito diretamente no código fonte, testando uma menor unidade de código com cenários que podem ocorrer no sistema.  
O teste unitário é um código escrito para validar um código do sistema. Ele chama o código do sistema para garantir que o resultado é o esperado. O teste unitário foca em testar partes pequenas do código, como um único método, para garantir que aquela parte funciona.

Por exemplo, um aplicativo de calculadora que possui quatro métodos: somar, subtrair, multiplicar e dividir.  
Os testes unitários podem ser usados para testar cada um dos quatro métodos separadamente, chamando o método e garantindo que o retorno está correto.

Um teste unitário deve tentar cobrir a maioria dos casos possíveis, para garantir que o método retorna o resultado esperado em diferentes entradas de dados.  
Ao testar o método Somar, por exemplo, é importante testar entradas de dados válidas, entradas inválidas, se uma soma retorna um valor correto, dentre outros casos.

### Vantagens dos Testes

A maior vantagem dos testes é a qualidade.  
Os testes garantem que o sistema atende ao que foi requisitado, pois caso o código passe nos testes, então ele funciona corretamente para aquela situação.

O teste também garante que uma alteração não cause impactos em funções já existentes no sistema. Quando o código possui uma cobertura de testes, eles podem ser usados para verificar se as alterações geram algum impacto, assim prevenindo problemas futuros no sistema.  
É importante que as novas implementações também tenham uma cobertura de testes, para que sempre seja possível verificar esses impactos.

Os testes ajudam a minimizar a quantidade de bugs ou problemas no sistema, permitindo ter uma maior confiança de que as classes e métodos funcionam corretamente e retornam os resultados esperados. 

### Frameworks de Teste

Os frameworks de teste mais usados são:
- MSTest
- NUnit
- xUnit

#### Organização dos Testes Unitários com xUnit

Cada solução possui projetos de software, que são identificados por arquivos do tipo `.csproj`.  
Por exemplo, um projeto de console com nome `Calculadora.csproj`.

Os testes são implementados em um projeto separado, identificado por um outro arquivo `.csproj` (normalmente com um nome que reflete o do projeto principal) e que possui uma referência ao projeto principal. O projeto de teste é do tipo **xUnit**.  
Neste caso, o projeto de teste seria chamado `CalculadoraTest.csproj`.

# Criando o Projeto de Testes Calculadora

### Criando os Projetos e a Solução

Para criar o projetos de testes, é necessário criar a estrutura do projeto:

- Criar uma solution, que irá agrupar os dois projetos.
- Criar o projeto que representa a aplicação, neste caso um projeto `Calculadora.csproj`, do tipo Aplicativo de Console do .NET.
- Criar o projeto de testes da aplicação, neste caso é o projeto `CalculadoraTestes.csproj`, do tipo Projeto de Testes do xUnit.
- Adicionar uma Referência de Projeto ao projeto principal (`Calculadora.csproj`) no projeto de testes (`CalculadoraTestes.csproj`).

### Implementando a Classe de Teste

Para implementar os testes, deve haver uma classe de testes para cada classe do projeto principal. As classes de teste, por padrão, são nomeadas com o mesmo nome da classe no projeto principal, porém com a palavra "Tests" no final.  
Neste caso, a classe `Calculadora.cs` acarreta na criação de uma classe `CalculadoraTests.cs`.

A classe de testes possui cenários de testes, que são basicamente métodos, usados para validar o cenário.  
Eles possuem uma anotação `[Fact]`, que indica que esse método é um cenário de teste que deve ser validado. O atributo `[Fact]` é necessário em todo método de teste para que ele seja reconhecido como um teste no xUnit.  
O nome do cenário de testes deve ser descritivo, para que seja possível entender o que o teste faz.

Dentro do método/cenário de testes, as etapas são escritas para criar o teste. A criação de um teste é feita com base em 3 conceitos:
- **Arrange:** Serve para montar o cenário de testes, preparando os dados e disponibilizando o cenário.
- **Act:** Agora que o cenário foi montado, ele executa a ação para que seja testado.
- **Assert:** Agora que ele foi executado, valida se o que foi feito retornou o resultado desejado.

#### Criando o Cenário de Testes

O primeiro passo é instanciar a classe que se deseja testar. Isso pode ser feito no construtor da classe de testes, para disponibilizá-la para todos os cenários:
```
Calculadora _calc;
public CalculadoraTestes()
{
	_calc = new Calculadora();
}
```

Depois de instanciar a classe, é hora de montar o cenário.

- **Montando o Arrange:** é necessário determinar os dados que serão passados para o método. Neste caso, os dois valores que serão passados para a calculadora para executar a soma.
- **Montando o Act:** A ação consiste em chamar o método que passará pelo cenário de teste, do qual se deseja validar o retorno, passando os dados definidos no Arrange. Neste caso, o método Somar dentro da classe calculadora.
- **Montando o Assert:** Após executar o método, ele valida se o retorno está de acordo com o esperado.  
Existe uma classe no xUnit chamada `Assert`, que é usada para realizar vários tipos de verificações em diferentes cenários de testes. Neste caso, o método será `Assert.Equals()`, que valida se os valores são iguais. O método `Assert.Equals()` recebe como parâmetros o valor esperado e o valor atual.

#### Executando os Testes

Agora que os testes foram escritos, eles podem ser executados.  
Ao executar os testes, são exibidos os resultados, quais testes foram executados, quais passaram, quais falharam e quais foram ignorados.  
Caso o teste falhe, também são exibidas informações relacionadas ao erro, como quais foram os valores esperados e valores retornados.

É possível também implementar vários cenários de testes para um mesmo método, para garantir que ele funciona com valores diferentes.

### Utilizando o Theory

Quando desejamos testar vários valores em um único cenário, devemos usar a anotação `[Theory]`, que indica que aquele teste será executado para um conjunto de valores.  
A anotação `[Theory]` é utilizada no lugar da anotação `[Fact]`.

Ao utilizar o Theory, devem ser passados os valores que serão usados para os cenários de teste, através de uma anotação `[InlineData]`, que indica os parâmetros que serão usados no teste. Para cada anotação `[InlineData]`, um teste é executado com os valores passados por aquela anotação.
```
[Theory]
[InlineData(2)]
[InlineData(4)]
[InlineData(6)]
[InlineData(8)]
[InlineData(10)]
public void TestaSeOsNumerosSaoPares(int numero)
{
	bool resultado = Calculadora.Par(numero);

	Assert.True(resultado);
}
```

O teste acima será executado 5 vezes, com os valores: 2, 4, 6, 8 e 10.

#### Refatorando o Theory

Alternativamente, o método pode também receber uma lista de valores, para que não seja necessário ter múltiplas anotações `[InlineData]`.  
Todos os valores podem ser passados através de uma única lista.

Também pode ser usado o método `Assert.All()`, da classe Assert, que recebe uma coleção de valores e uma ação que será executada para eles.
```
[Theory]
[InlineData(new int[] {2,4,6,8,10})]
public void TestaSeOsNumerosSaoPares(int numero)
{
	bool resultado = Calculadora.Par(numero);

	Assert.All(resultado);
}
```