# APIs no Mundo de QA

### Conceitos de APIs

API significa **Application Programming Interface**, e ela tem a função de permitir a comunicação entre aplicações ou sistemas a partir de um contrato de serviços.  
Esse contrato define a forma como as partes devem se comunicar a partir de uma solicitação e uma resposta para ela. Para a comunicação acontecer, o cliente deve saber o que enviar para o servidor, e o servidor deve saber o que responder.

#### Benefícios

- Integração | Inovação | Expansão | Manutenção

### Tipos e Tecnologias Envolvendo APIs

#### REST

A sigla significa **REpresentational State Transfer**.  
O REST é um estilo de arquitetura com restrições para criação de aplicações com o protocolo HTTP. Para que uma API seja considerada RESTful, ou seja, uma API que segue o padrão REST, ela precisa se encaixar em alguns conceitos: Interface Uniforme, Cliente-Servidor, Stateless, Uso de Camadas, Uso de Cache e Código Sob-Demanda.  
Uma API REST pode retornar mensagens em formatos: HTML, XML, JSON e texto.

##### Interface Uniforme

Esse tipo de interface é necessário para desacoplar o cliente do servidor. A API permite a comunicação entre duas aplicações independentes, então ela precisa ser uniforme para que essa comunicação possa ocorrer. Isso cria formas melhores de controlar os recursos.

O controle de interface passa pelos seguintes pontos:
- Identificação dos recursos, os itens que serão manipulados pelo sistema.
- Gerenciamento de recursos por representações.
- Comunicações auto descritivas, todos os dados devem estar dentro da requisição, para que seja enviada apenas uma mensagem.
- Hipermídia como mecanismo de estado de aplicativo.

##### Cliente-Servidor

A API REST precisa trabalhar com o modelo Cliente-Servidor, pois só assim é possível ter a comunicação entre duas aplicações. Uma das aplicações sempre possui o papel de servidor, pois ela tem os dados ou serviços que a outra procura.

##### Stateless

A API REST não tem estado. As requisições são feitas de forma independente, elas nunca irão depender de outras requisições para que possam ser completadas. Cada chamada possui todos os seus dados para completar a requisição.

##### Uso de Camadas

As responsabilidades são bem definidas entre cada módulo. Os módulos possuem apenas uma função. Isso permite maior escalabilidade, segurança e desempenho de cada módulo da aplicação.

##### Uso de Cache

As aplicações clientes podem utilizar cache para armazenar os dados, dessa forma evitando ter que fazer várias requisições durante sua execução.  
O servidor envia todos os dados necessários para o cliente, mesmo que ele não precise utilizar todos os dados. Com isso, os dados não utilizados são armazenados em cache pelo cliente, para serem usados posteriormente caso necessário.

##### Código Sob Demanda

A restrição de código sob demanda é opcional.  
Ela define a possibilidade dos serviços responderem uma informação executável. Com isso, uma requisição do cliente é respondida com um script de código que pode ser executado pelo cliente, permitindo que um cliente execute uma função mesmo sem precisar implementá-la.

#### SOAP

A sigla significa **Simple Object Access Protocol**.
Ele é um protocolo de acesso a objetos simples baseado no XML. Ele foi criado para possibilitar a comunicação entre diferentes aplicações e plataformas. O SOAP suporta diferentes protocolos de comunicação, como HTTP e SMTP.

O SOAP envia a informação no formato de um envelope, com headers e body.

#### WebSocket API

Estas APIs guardam os estados e os dados da comunicação.  
Elas são APIs bidirecionais, então qualquer lado pode enviar mensagens para a outra parte, não é preciso esperar pela resposta de uma requisição para fazer a comunicação. Ela funciona com uma conexão TCP única, e é utilizada em aplicações IoT, por funcionar em tempo real.

##### Diferenças entre WebSocket e REST

| Base | WebSocket | REST |
| ---- | --------- | ---- |  
| HTTP | Uso na conexão inicial | Comum |
| Comunicação | Bidirecional | Unidimensional |
| Natureza | Baseada em socket | Baseado em recursos |
| Cenário | Tempo real | Principalmente requisições GET |
| Custo | Baixo | Alto |
| Performance | Altas cargas | Comunicação ocasional |
| Estado | Sim | Não |
| Dependência | IP e Porta | HTTP methods |

#### GraphQL

Query language para APIs, que surgiu como alternativa ao REST.  
Ela não depende em nenhum tipo de banco de dados específico, e é organizada em tipos e campos, em vez de endpoints, o que facilita na manutenção da API.

#### RPC

A sigla significa **Remote Procedure Calls**.  
Ela é uma API construída com base na definição de métodos que são chamados via argumentos. Ela faz uma chamada remota para métodos que se deseja executar, em vez de implementá-los localmente.
Ela possui quatro implementações:
- XML | JSON | SOAP | gRPC

### Importância dos Testes de API

Na pirâmide de testes, os testes de API se encontram no meio, onde ficam os testes de integração.  
Um teste de API consiste em monitorar e validar as requisições e repostas de uma API, garantindo que elas se comportam como esperado. A partir da API, é possível avaliar:
- Erros relacionados às regras de negócio, antes de chegar ao nível da interface.
- Problemas de performance, antes de integrar com a interface, pois a API trabalha de forma mais rápida.
- Integração com outras API.

#### Abordagens para testes de API

- **Teste Funcional:** Verifica se a API retorna o resultado esperado para uma requisição.
- **Teste de Carga:** Verifica o desempenho a partir de um grande volume de requisições em um curto período.
- **Detecção de erros:** Verifica se a API foi bem desenhada e se os erros são bem monitorados com mensagens claras.
- **Segurança:** Verifica se a API resiste bem durante ataques.
- **Penetração:** Verifica se uma pessoa com pouco conhecimento da API consegue atacá-la.
- **Fizz:** Envio de requisições aleatórias e análise o comportamento da API.

#### Importância dos Testes

- Garantem que a API se comporta como deve, mesmo em situações inesperadas.
- Garante que erros não cheguem ao nível de interface.
- Avalia questões de segurança e performance.
- Verifica integrações entre APIs.

### Planejando Testes de API

O que pensar antes de iniciar os testes de API?
- Qual o modelo de ciclo de vida do projeto?
- Quantas pessoas estão na equipe de QA?
- Qual a priorização dos requisitos?
- Qual o prazo?
- Quais processos devemos seguir?
- Quais ferramentas utilizaremos?

#### Revisar as Especificações da API

Revisar as especificações é importante para entender o propósito da API, a relação que ela tem com as regras de negócio e quais são os resultados esperados. É necessário verificar se a forma que a API foi feito está em conformidade com as definições, se a requisição foi feita de maneira correta.

É necessário também definir como a especificação será criada e mantida pela equipe.  
Existe um padrão para descrições: OpenAPI. Estes padrões são usados para descrever APIs HTTP independente da linguagem. A ferramenta que utiliza o OpenAPI é o Swagger, que constrói várias utilidades e facilidades para geração e manutenção de documentação de API. É possível também fazer testes pelo Swagger.

#### Determinar os Requerimentos e Complexidades do Teste

- O que deve ser testado?
- Serão testados os status codes? Os cabeçalhos? O corpo e o schema?
- Qual a complexidade envolvida na codificação dos testes?
- Qual será a infraestrutura usada? Haverá vários ambientes, ou apenas um?
- Quais serão os tipos de testes usados?
- Quais as abordagens de testes?
- Quais as integrações que existem com a API? Os testes serão feitos na API, no banco de dados?
- Quais testes serão automatizados? Quais serão apenas manuais?
- Quais cenários serão priorizados? Os casos de sucesso? Os casos de erro?

#### Determinar a Ferramenta de Testes

A ferramenta será escolhida depois de responder a todas as perguntas anteriores, para garantir que todas as decisões foram tomadas, e assim a ferramenta mais adequada é escolhida.