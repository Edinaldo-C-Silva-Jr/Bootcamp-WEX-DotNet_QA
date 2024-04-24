# Postman

O **Postman** é uma ferramenta que permite documentar e testar APIs.  
O runtime do Postman é baseado em **Node.js**. Ele permite adicionar comportamento dinâmico às requisições.

Alguns conceitos importantes:
- **Collection:** Conjunto de requisições com o objetivo de promover organização, colaboração, documentação e execução de testes.
- **Pre-Request Script:** Um script executado antes da requisição ser enviada ao servidor.
- **Test Script:** Um script executado após o envio da requisição e recebimento da resposta.

Escopo de variáveis:
- **Global:** Acesso em todo workspace.
- **De ambiente:** Diferentes configurações em ambientes diferentes (Dev, QA, Prod).
- **De collection:** Específica para uma collection, independente de ambiente.
- **De arquivos externos:** Definidas por arquivos CSV ou JSON.
- **Local:** Variáveis temporárias criadas e acessadas em scripts individuais, e sobrescrevem todas as outras variáveis.

Ordem de execução dos scripts:
- Collection: Pre-request script
- Folder: Pre-request script
- Request: Pre-request script
- Request
- Response
- Collection: Test script
- Folder: Test script
- Request: Test script

Pre-Request scripts são úteis para configurar pré-condições para testes: setar variáveis, parâmetros, cabeçalhos e dados no corpo da mensagem.

#### Escrevendo Scripts de Teste

- `pm`: Objeto de biblioteca JavaScript que provê funcionalidades de requisições e respostas.
- É possível usar o comando `require` para importar outras bibliotecas.
- Os testes podem utilizar a sintaxe da biblioteca *chai*, usando BSS.
- Os testes podem utilizar o conceito de *expect*.

### Utilizando o Postman

Após entrar no Postman, é preciso criar uma **Workspace**. Para criar uma Workspace, é preciso ter uma conta.

É preciso também criar um Ambiente, que também precisa de uma conta. Da para criá-lo indo em `Environments > Create Environment`. No ambiente dá para criar as variáveis de ambiente, onde é inserida a URL da API que será testada (no Valor Inicial da variável).

Com o Workspace criado, é possível então criar uma **Collection**, que também necessita de uma conta.  
Após criar a collection, algumas configurações que podem ser feitas são:
- Definir um nome para a collection.
- Definir um método de autorização, que precisa ser usado para fazer uma requisição..
- Definir variáveis de collection.

Para utilizar uma variável, é preciso colocar o nome da variável entre chaves `{}`, sendo que o Postman já mostra as variáveis disponíveis.

Para criar uma requisição, primeiro é preciso ir em `New > Request`, e então:
- Definir o verbo HTTP desejado.
- Definir o nome da requisição.
- Definir as informações necessárias para a requisição.
- No caso de uma requisição `POST` ou `PUT`, é necessário um body, que pode ser definido em vários tipos. Caso se tenha acesso ao modelo em JSON, pode-se passar os valores através de `raw > JSON`.
- No case de uma requisição `GET`, `PUT` e `DELETE`, pode ser necessário passar parâmetros, que podem ser definidos na aba `Params`.
- Depois deve-se definir a URL a ser usada. A URL é definida pela URL padrão da API e a rota a ser usada.

Após definir a requisição, basta clicar em **Send**.

#### Testes Automatizados

Os testes automatizados de API podem ser implementados em scripts no Postman, após criar uma requisição. Os scripts são feitos na aba `Tests`. Os scripts são escritos em JavaScript.  
O Postman fornece alguns snippets de código para funções mais comuns, como receber, atribuir ou limpar valores de variáveis.

As funções de teste são escritas com o comando `pm.test`:
```
pm.test("Status code is 200", funcion () {
	pm.response.to.have.status(200);
	pm.response.to.have.status("OK");
	pm.response.to.have.property("code", 200).to.be.a('number');
	pm.expect(pm.response).to.have.status(200);
});
```

O script acima verifica se o status da requisição é o status 200: Ok.  
Cada linha representa uma maneira diferente de fazer essa verificação:
- A primeira linha verifica o valor do status.
- A segunda verifica a string do nome do status.
- A terceira verifica uma propriedade da resposta, sendo a propriedade `code`, e verifica se ele é um número.
- A quarta utiliza um outro método através do comando `expect`, que espera que a resposta tenha status 200.

```
pm.test("Properties from body are correct", function () {
	pm.expect(pm.response.json().code).to.be.a('number')
	pm.expect(pm.response.json().type).to.be.a('string')
	pm.expect(pm.response.text()).to.include("type")
});
```

O script acima verifica se as propriedades do body da resposta estão corretas:
- A primeira linha verifica se o código é um número.
- A segunda verifica se o tipo é uma string.
- A terceira verifica se o texto da resposta inclui a string "type".

```
pm.test("Response time is less than 200ms", function () {
	pm.expect(pm.response.responseTime).to.be.below(200);
});
```

O script acima verifica se o tempo de resposta da API é de menos de 200 milissegundos.

#### Rodando os Testes

Cada teste pode ser executado individualmente nas requisições através do botão **Send**.  
Os testes dentro de uma collection também podem ser executados todos de uma vez. Para isso basta ir na collection, clicar nos 3 pontos e depois em **Run Collection**.  
Depois é possível definir a ordem na qual os testes serão executados (sendo que cada teste irá afetar a API então eles podem acabar afetando uns aos outros). Também é possível definir quantas iterações serão executadas.