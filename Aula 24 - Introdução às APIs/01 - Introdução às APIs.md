
# O Que é uma API?

API é a sigla de **Application Programming Interface**. Uma API é um software que permite a comunicação entre computadores ou aplicativos. Ela permite que um software busque informações que provém de outro lugar, fazendo uma intermediação entre dois sistemas diferentes.  
A API permite integração entre um front-end e um back-end, ou entre aplicações de back-end diferentes, fazendo a intermediação do acesso aos dados e recursos do sistema.

A API é a camada que faz a comunicação de uma aplicação utilizada por um usuário final com o banco de dados do servidor de um sistema. O usuário não acessa diretamente o banco de dados, a API atua neste meio, levando os dados necessários ao cliente.

Existem muitas APIs disponíveis na internet, como o nager.date, que mostra todos os feriados de um determinado país em cada ano.  
Ao acessar o site, há informações de como utilizar a API. Assim é possível utilizá-la em softwares que desenvolvemos para utilizar os dados que ela retorna.

As APIs são feitas para retornar informações para desenvolvedores, que podem ser utilizados na criação de aplicativos e sistemas. Elas não são feitas para retornar dados diretamente ao usuário final, pois normalmente trabalham com dados de forma bruta, como em um JSON.

Toda API deve ter uma documentação, que explica como utilizá-la. A documentação explica quais são os endpoints da API, os parâmetros necessários e qual o seu retorno.  
Para utilizar a API, é necessário fazer uma requisição, utilizando um link que leva a uma rota da API, com os dados necessários para que a API possa retornar os dados. Os parâmetros devem ser passados da mesma maneira que a API define.

A API pode ser externa ou interna:
- Uma API Externa deve estar disponibilizada na internet para que pessoas de fora da organização possam acessar.
- Uma API Interna é uma API usada apenas dentro de uma empresa, em um sistema, que não precisa ser disponibilizada na internet.

### Criando uma API

Para criar uma API, é necessário criar um projeto do tipo "ASP.NET Core Web API". No Visual Studio, basta selecionar o tipo de projeto e criar.  
No Visual Studio Code, pelo terminal, o comando para criar o projeto é:
```
dotnet new webapi
```
Ao criar um projeto Web API no .NET, ele já vem com um projeto padrão, que permite entender a estrutura básica e testar a API. O projeto é chamado "WeatherForecast".

Ao executar o projeto Web API, ela abre no navegador através do endereço "localhost", que é acessível apenas no computador que roda a API. Para disponibilizar a API para outra pessoa, ela precisa ser hospedada em um servidor web.

Um projeto de Web API do .NET Core, ao ser executado, abre uma página do Swagger, que é uma ferramenta de documentação e teste de APIs.  
A API não tem um front end, um local onde se possa visualizar ela rodando. O Swagger é uma maneira de visualizar a API para facilitar os testes e a documentação.  
O uso do Swagger não é obrigatório ao criar uma API, porém o .NET Core já o configura por padrão ao criar um projeto.

### Controller

Um projeto Web API possui uma pasta chamada "Controller", que possui os arquivos de classe configurados como Controllers da API. Esses arquivos possuem em seu nome a palavra "Controller", e é importante manter o padrão de nomenclatura ao criar uma API.

Uma Controller é uma classe que agrupa as requisições HTTP utilizadas pela API. Ela possui todos os métodos relacionados a uma entidade ou domínio específico, para cadastrar, alterar, recuperar e/ou deletar dados.  
Por exemplo, um sistema que trabalha com cadastro de produtos pode ter uma controller para todos os métodos relacionados a produtos.

Os métodos dentro de uma controller são métodos que são chamados quando uma rota específica é acessada na API. Esses métodos então realizam o seu processamento e retornam os dados necessários para quem os acessou.  
Um método de uma controller deve ser do tipo IActionResult, e retornar um código HTTP, que sinaliza o status da requisição. Esse status pode ser acompanhado de um retorno de dados, ou simplesmente ser um status que sinaliza se a requisição foi processada com sucesso.

Os métodos de uma API possuem uma rota, que é uma URL HTTP utilizada para acessá-los. A URL é acessada no formato:
```
localhost/[Número da Porta]/[Nome da Controller]/[Rota do Método]
```
O nome "localhost" é um domínio disponível somente no computador atual. O `[Número da Porta]` identifica a porta que o computador utiliza para acessar o localhost (ambos são definidos automaticamente ao rodar a API).  
O `[Nome da Controller]` é o nome que foi dado ao arquivo de classe da controller no projeto, desconsiderando a palavra "Controller" dentro dele (Por exemplo, uma controller chamada "ProdutoController" será acessada pela rota "Produto").  
E a `[Rota do Método]` é a rota do endpoint definido para o método, através de um atributo definido no código.

### Definindo O Método da Controller

Todo método de controller deve ter uma rota HTTP definida para ele através de um atributo. Essa rota é definida da seguinte forma:
```
[[Verbo HTTP]([Rota])]
public IActionResult [Nome do Método]()
{
	[Código]
	return [Status HTTP]
}

[HttpGet("GetHelloWorld")]
public IActionResult HelloWorld()
{
	string mensagem = "Hello World!";
	return Ok(mensagem);
}
```
O verbo HTTP pode ser qualquer um dos verbos utilizados em requisições HTTP:
- HttpGet
- HttpPost
- HttpPut
- HttpDelete