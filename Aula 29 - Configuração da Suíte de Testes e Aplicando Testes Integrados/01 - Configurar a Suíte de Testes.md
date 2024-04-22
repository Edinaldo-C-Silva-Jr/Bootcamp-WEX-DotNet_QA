# Configurando a Suite de Testes

Normalmente, os testes são definidos em uma pirâmide de 3 níveis:

- A **base** da pirâmide são os **Testes de Unidade**, ou Testes Unitários
- O **meio** da pirâmide são os **Testes de Integração**
- E o **topo** da pirâmide são os **Testes de Usuário Final**, ou Ponta a Ponta

Quanto mais alto o teste, mais caro ele é para desenvolver e consertar.

### Testar uma API: Criar Host em Memória

Para testar uma API, é possível simular um servidor em memória para realizar os testes.

Para isso, primeiramente, é necessário criar o projeto de teste do xUnit para a API.  
Depois criar uma pasta de `Controllers` onde serão criadas as classes de teste para os controllers da API.

Após criar a classe de testes, precisamos incluir, no construtor da classe, um parâmetro do tipo `WebApplicationFactory`, para injetar a dependência em uma variável `_factory`.  
Para isso, é necessário instalar o pacote `Microsoft.AspNetCore.Mvc.Testing`, e também a classe deve implementar a interface `IClassFixture`.  
Depois precisamos criar uma variável do tipo `HttpClient`, que recebe o resultado do método `CreateClient` da factory criada anteriormente. Isso cria um cliente que permite trafegar nas rotas HTTP da API que desejamos testar.

Para fazer um teste de integração de uma API, é necessário utilizar a ação HTTP correspondente, para testar a rota.  
O *Arrange* configura todos os dados necessários. Por exemplo, para um método de login, ele instancia as informações de login de um usuário. Para testar um método POST, é necessário serializar os dados em um JSON para passar para o método.  
O *Act* chama um método HTTP no cliente gerado anteriormente, e então pega a requisição gerada pelo método HTTP.  
Por fim, o *Assert* verifica se o status retornado na requisição é o mesmo status definido na rota da API.

### Auto Bogus

`AutoBogus` é uma biblioteca do C# que ajuda a gerar dados aleatórios de testes.  
Para usar essa biblioteca, é necessário criar uma instância da classe `AutoFaker`, passando o tipo de objeto que se deseja gerar.
```
ObjetoPessoa obj = new AutoFaker<ObjetoPessoa>();
```

Com isso, ele já gera um objeto com valores aleatórios para serem usados em testes.

É possível também criar regras específicas para tipos específicos de dados.  
Por exemplo, para criar uma regra para gerar e-mails, é possível passar uma função de regra para a criação do objeto:
```
ObjetoPessoa obj = new AutoFaker<ObjetoPessoa>().RuleFor(p => p.Email, faker => faker.Person.Email);
```