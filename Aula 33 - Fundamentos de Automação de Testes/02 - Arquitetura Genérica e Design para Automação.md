# Arquitetura e Design para Automação

### Conceitos de Arquitetura de Software

- O que é arquitetura de software?

A arquitetura de software é uma descrição e compreensão dos componentes do sistema, suas estruturas e relações. Ela não trata diretamente do código, mas sim dos componentes que compõem o software como um todo, como o ambiente, o design, a estratégia de negócio, a dinâmica humana, dentre outros fatores.  
Essa arquitetura considera fatores externos na sua definição. Qual banco de dados será usado, a mão de obra, a estrutura, os componentes. Todos esses fatores que afetam como o software será construído.

#### Padrões Arquiteturais

Os padrões arquiteturais são soluções gerais e reutilizáveis para resolver problemas recorrentes dentro de um contexto. Eles se inserem em um escopo maior do sistema. Alguns exemplos incluem:
- N-camadas
- Cliente-Servidor
- Broker
- Peer-to-Peer
- Event Bus
- Pipe-Filter

#### Padrões de Projeto

Os padrões de projetos são soluções gerais e reutilizáveis usados para resolver problemas comuns na construção do software, independente da linguagem. Eles são divididos em:
- Padrões de Criação: Factory, Singleton...
- Padrões Estruturais: Adapter, Composide, Facade, Proxy...
- Padrões Comportamentais: Command, Observer, Mediator...

#### SOLID

Padrão de boas práticas de código que conta com 5 princípios:
- **Responsabilidade Única:** Cada componente deve ter uma única responsabilidade e deve estar encapsulada.
- **Extensão:** Cada componente deve estar aberto para expansão, mas fechado para modificação.
- **Substituição:** Cada componente deve ser substituível sem afetar o comportamento geral da solução.
- **Segregação:** É melhor ter componentes específicos do que um componente geral multiuso.
- **Inversão de Dependência:** Os componentes devem depender de abstração e não de detalhes de baixo nível.

### Arquitetura de Projetos de Automação

#### Camada de Geração de Testes

- Criação manual dos casos de testes.
- Desenvolvimento ou obtenção de dados de teste.
- Geração automática de casos de teste a partir de modelos.

#### Camada de Definição de Teste 

- Especificação dos casos de teste.
- Definição dos casos de teste.
- Especificação dos procedimentos de teste.
- Definição de scripts para execução dos testes.
- Conceder acesso às bibliotecas de testes.

#### Camada de Execução de Testes

- Executar os testes automaticamente.
- Registrar execuções.
- Relatar execuções.

#### Camada de Adaptação de Testes

- Controlar o ambiente de testes.
- Interagir com o sistema a ser testado.
- Monitorar o sistema sendo testado.
- Simular ou emular o ambiente sendo testado.

#### Gerenciamento de Projeto de Testes Automatizados

- Prestar atenção ao gerenciamento de configuração do projeto.
- Seguir boas práticas de versionamento.
- Extração de métricas deve ser analisada da mesma forma que em uma abordagem manual.

### O que Considerar Antes de Iniciar o Projeto

 O que pensar ao iniciar um projeto de automação?
- Qual atividade ou fase do processo de testes será automatizada?  
	- Existem ferramentas que automatizam muitas fases. Pode ser a criação, a execução, os relatórios, dentre outros.
- Qual nível de teste queremos ter suporte?
- Qual o tipo de teste?
	- Existem vários tipos e níveis de testes, e eles influenciam na escolha da ferramenta e da abordagem de teste.
- Quem executará e implementará o teste?
	- Algumas pessoas tem habilidades diferentes que podem afetar a criação e execução dos testes.
- Quais ferramentas são gratuitas e quais podem ser compradas?
- Quais tecnologias queremos ter suporte? E a complexidade?
	- A escolha das ferramentas utilizadas depende das necessidades de tecnologias utilizadas nos softwares e das necessidades dos testes.
- Que linguagens queremos utilizar?
	- O conhecimento de uma linguagem influencia na escrita dos testes.
- Qual modelo de ciclo de vida do software estamos inseridos?
	- A abordagem de testes muda completamente dependendo do modelo de ciclo de vida. Os testes em um projeto ágil são diferentes dos testes em um projeto de cascata.
- Qual a complexidade da implementação e como afeta o projeto?
- Será necessário treinamento?

### Abordagens para Automação de Testes

Os casos de testes correspondem à sequência de ações executadas sobre o sistema que está sendo testado. Existem 4 abordagens para a automação de testes:

- A solução implementa casos de teste diretamente em scripts automatizados.
- A solução projeta procedimentos de teste e transforma em scripts automatizados.
- A solução utiliza uma ferramenta para traduzir procedimentos de teste em scripts automatizados.
- A solução utiliza uma ferramenta que gera procedimentos automatizados de teste ou traduz scripts diretamente dos modelos. Abordagem com maior grau de automação.

#### Abordagem de Captura e Reprodução

As ferramentas são usadas para capturar a interação com o sistema enquanto executa a sequência de ações, registrando as saídas. 
- Fácil de usar e configurar.
- Difícil de evoluir e manter.

#### Geração de Scripts Lineares

As ferramentas são usadas para capturar a interação com o sistema enquanto executa a sequência de ações, registrando as saídas. e gerando scripts lineares.
- Fácil de usar e configurar.
- Difícil de evoluir e manter.

#### Geração de Scripts Estruturados

Geração de bibliotecas de scripts reutilizáveis para os casos de testes.
- Menor manutenção e custo para novos testes.
- Custo maior para a criação de scripts compartilhados. Precisa de boas habilidades de programação.

#### Orientado a Dados

Os scripts utilizam arquivos com diversas massas de dados
- Reduz o custo para adição de testes. Aumenta a variação com dados de teste.
- Deve-se gerenciar bem os arquivos lidos pela solução.

#### Uso de palavras-chaves

O script baseado em palavras-chaves utiliza arquivos de definições a partir de palavras descritivas e/ou arquivos de dados.
- Reduz o custo para adição de testes. Aumenta a variação com dados de teste.
- A implementação das palavras-chaves deve ser com boas palavras-chaves, para que elas possam ser reutilizadas.

#### Testes baseados em modelos

Geração automatizada de casos de teste em oposição à execução de casos de testes. Pode derivar qualquer tipo de script.
- Abstração garante foco no objetivo do teste. Manutenção somente dos modelos.
- É necessário bom conhecimento dos modelos de testes, e garantir que as ferramentas sejam maduras e gerem bons relatórios.

#### Orientado a Comportamento (BDD)

Uso de linguagem natural para definir o comportamento da funcionalidade.
- Maior compreensão do negócio. Facilita a criação de casos.
- Ambiguidade. Pode gerar código repetido se não for bem pensado.