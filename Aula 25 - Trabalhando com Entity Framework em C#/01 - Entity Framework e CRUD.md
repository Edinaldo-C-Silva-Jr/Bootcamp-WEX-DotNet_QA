# Entity Framework e CRUD

Para fazer a persistência dos dados de um programa através de um banco de dados, é necessário fazer a comunicação através da linguagem utilizada pelo banco de dados. A linguagem de programação não consegue trabalhar com banco de dados por si só, então é necessário escrever os comandos SQL para cada operação feita no banco de dados, e então passar para o código da aplicação.

O **Entity Framework** é um framework ORM (Object Relational Mapping) que facilita a integração entre a programação e um banco de dados. Ele mapeia tabelas e gera comandos SQL automaticamente.  
O Entity Framework fica responsável por fazer a comunicação com o banco de dados, para que não seja necessário passar os comandos SQL para a linguagem.

O Entity Framework cria os comandos SQL dinamicamente, mapeando uma tabela do banco de dados em uma classe de programação.

### CRUD

O CRUD é um acrônimo para as operações mais comuns feitas em um banco de dados:
- CREATE (Insert)
- READ (Select)
- UPDATE (Update)
- DELETE (Delete)

#### Verbos HTTP

Os verbos HTTP representam as ações que podem ocorrer em uma API.  
Existem 4 verbos HTTP principais:

- **POST**: Create  
Envia uma nova informação para a API. Cria um novo registro no banco de dados ou uma nova informação no sistema.  
Retorna os Status 201 (Created), 404 (Not Found) e 409 (Conflict).

- **GET**: Read  
Obtém uma informação da API, retornando os dados para quem fez a requisição.  
Retorna os Status 200 (Ok) e 404 (Not Found).

- **PUT**: Update / Replace  
Atualiza um recurso existente no banco de dados, pegando uma informação nova e substituindo no lugar da existente. O PUT sempre recebe o registro completo para atualizar, mesmo quando a atualização não é de todos os dados do registro.  
Retorna os Status 200 (Ok), 204 (No Content) e 404 (Not Found).

- **DELETE**: Delete  
Deleta um registro existente no banco de dados.  
Retorna os Status 200 (Ok), 204 (No Content) e 404 (Not Found).

### Instalando o Pacote do Entity Framework

Instalar os pacotes:
```
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

#### Migrations

Embora o Entity Framework gere os comandos SQL dinamicamente, os comandos de criação de tabelas devem ser executados manualmente. Com isso, cada vez que tivermos novas entidades, ou alterações em entidades existentes, que precisem ser refletidas no banco de dados, isso deve ser informado ao Entity Framework para que os comandos de criação sejam executados novamente.

# Criando um Projeto CRUD para Contatos

#### Criando a Classe Contatos

Para que o Entity Framework possa fazer a criação da tabela, é primeiro necessário criar uma classe para ser usada como base para a tabela. Cada atributo da classe se torna uma coluna da tabela.  
Para este exemplo, foi criada uma classe Contatos, com atributos Id, Nome, Telefone e Ativo.

#### Criando o Contexto

O contexto é uma classe que centraliza todas as informações de um banco de dados.  
Para criar um contexto, deve ser criada uma classe de contexto, que herda da classe `DBContext`. Essa classe vem do pacote `EntityFrameworkCore`, e possui todas as operações que serão utilizadas para trabalhar com o banco de dados.

Para que ela possa trabalhar com um banco de dados, é necessário receber a conexão com o banco, que é feito através do construtor. Ele recebe a conexão através de um parâmetro, e então passa essa conexão para a classe que ela herda, DBContext.

Ela também precisa de uma propriedade que se refere à entidade, que é a classe que será mapeada em uma tabela no banco de dados, através do tipo `DBSet`.

#### Configurando a Conexão

O projeto possui dois arquivos de JSON chamados "appsettings":
- `appsettings.Development.json:` Esse é o arquivo de configurações do aplicativo para o ambiente de desenvolvimento.
- `appsettings.json:` Esse é o arquivo de configurações do aplicativo para o ambiente de produção.

Esses arquivos permitem que as configurações sejam definidas especificamente para cada ambiente do aplicativo.  
Dentro destes arquivos é onde se deve cadastrar a `ConnectionString`, a string de conexão que será utilizada para conectar com o banco de dados.

Agora para configurar a conexão com o banco em si, é necessário ir em `Program.cs`, onde ficam as configurações iniciais do projeto, e incluir um serviço para pegar a ConnectionString.

#### Criando as Migrations

Após a criação da(s) classe(s) necessária(s) para o funcionamento do sistema, é necessário executar as **Migrations**, que fazem o mapeamento das classes existentes para a criação de tabelas. Com isso, cada entidade configurada como um DBSet na classe DBContext se transformará em uma tabela do banco de dados.

Para execurtar uma migration, é necessário que o banco de dados esteja rodando.  
A migration é executada em duas etapas, primeiro a criação, através do comando `add-migration [Nome da Migration]`, onde o nome é o nome dado para identificar a migration, e depois através do comando `update-database`, que aplica a migration no banco de dados, executando todos os comandos SQL necessários.

A Migration cria uma tabela `MigrationHistory` que é utilizada para identificar quais migrations já foram aplicadas.

#### Criando a Classe ContatoController

O primeiro passo para criar uma Controller é criar uma classe dentro da pasta de Controllers.  
No caso deste projeto, o nome da controller é `ClienteController`.

Para fazer com que ela se comporte como controller, são necessárias algumas configurações extras:
- Primeiramente, é necessário herdar da classe `ControllerBase`, que é uma classe usada como base para a criação de controllers.
- Então, é preciso colocar o atributo `[ApiController]` acima do nome da classe, para indicar que essa classe é um controller que serve respostas HTTP.
- É também necessário definir uma rota, que é a parte da URL usada para acessar essa controller. A rota é definida pelo atributo `[Route("[controller]")]`, onde o parâmetro `[controller]` indica que a rota será o nome da classe atual. Neste exemplo, a classe "ClienteController" será acessada através da rota "Cliente".

#### Recebendo o Contexto do Banco de Dados

Antes de começar a utilizar o banco, é necessário receber o contexto da conexão do banco.  
Para isso, deve ser criada uma propriedade `readonly` para receber o contexto, e ele deve ser recebido por um construtor. Isso é feito através de um padrão chamado Injeção de Dependência, na qual a dependência da classe é passada para ela em vez de ser instanciada.

#### Criando os Métodos da Controller

Agora que a classe foi criada, o próximo passo é criar os métodos que farão o acesso ao banco de dados.  
Todos os métodos devem ser do tipo `IActionResult`, o que indica que eles retornam um Status HTTP como resposta a uma requisição da API.

#### Criando o Método CREATE

O primeiro método da sigla CRUD, o método **Create**, é usado para inserir dados no banco de dados.  
Ele deve receber um contato, e usar o contexto do banco para inserir o contato recebido na entidade, através do método `Add`. Depois o método `SaveChanges()` é usado para atualizar o banco de dados.  
Então, ele retorna um status HTTP indicando que o contato foi inserido, no caso o Status `200 (Ok)`.
```
_context.Contatos.Add(contato);
_context.SaveChanges();
return Ok(contato);
```

O método também deve receber um atributo que define o verbo HTTP usado por este método. Neste caso, como o método é de criação, o verbo HTTP deve ser `[HttpPost]`.

#### Criando o Método READ

Agora que temos o método de criar um contato, é hora de criar o método **Read**, o R da sigla CRUD.  
Esse método permite obter um registro existente no banco de dados. Neste caso, o registro será encontrado com base no valor do ID.  
Para isso, o método deve receber o ID como parâmetro, e depois será feita uma pesquisa no banco de dados, através do método `Find`.
```
Contato contato = _context.Contatos.Find(id);
```

Este método recebe um atributo com o verbo HTTP usado em busca. Neste caso é o `[HttpGet]`. Porém, como ele recebe um parâmetro, ele também precisa definir este parâmetro como parte da rota, para permitir que a requisição o traga quando o endpoint for acessado.  
Assim, o atributo fica `[HttpGet("{id}")]`.

#### Criando o Método UPDATE

Depois do Create e Read, é hora de criar o **Update**.  
O método Update deve encontrar um registro já existente, através de um parâmetro usado como filtro (normalmente o ID), e depois atualizá-lo utilizando novos valores recebidos em um parâmetro de contato. Portanto ele utiliza um pouco do Read e um pouco do Create.  
Para isso, ele recebe um ID, através do qual ele encontra o registro, e um contato, que contém os novos valores. Depois atribui os dados do novo contato ao existente no banco, e por fim atualiza o registro e salva as alterações no banco.
```
_context.Contatos.Update(contatoExistente);
_context.SaveChanges();
```

Esse método recebe um atributo com o verbo HTTP de update, que é o verbo `[HttpPut]`. Ele também recebe um parâmetro, portanto o atributo será `[HttpPut("{id}")]`.

Esse método terá a mesma rota do método Read: "Contatos/id", porém o verbo HTTP usado nele é diferente (PUT para o Update e GET para o Read), assim não haverá conflito. Caso eles usassem o mesmo verbo e a mesma rota, haveria conflitos, e a rota teria de ser alterada.

#### Criando o Método DELETE

Por último, é hora de criar o **Delete**.  
O método Delete, assim como os anteriores, recebe um ID para buscar um contato, e então deleta esse contato encontrado.
```
_context.Contatos.Remove(contatoExistente)
_context.SaveChanges();
```
Esse método recebe um atributo com o verbo HTTP `[HttpDelete]`. Assim como antes, ele também recebe o ID como parâmetro, portanto o verbo será `[HttpDelete("{id}")]`.