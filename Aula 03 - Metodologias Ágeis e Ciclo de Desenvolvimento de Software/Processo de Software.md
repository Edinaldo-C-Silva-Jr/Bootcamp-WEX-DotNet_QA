# Processo, fluxo e padrões de software

O desenvolvimento de software é um processo de aprendizado social. Ele tem processos técnicos, gerenciais e de pessoas.
um processo de software é normalmente chamado de "ciclo de vida", pois ele define todas as etapas, atividades e tarefas necessárias para desenvolver o software, desde o nascimento, desenvolvimento, manutenção, até a "morte" do software. 
O processo do software depende de todos os envolvidos para ter sucesso, é necessário que todos conheçam as características e definições do software.

As atividades (ou estágios) do processo podem ser definidas de várias maneiras, dependendo do autor, mas no geral, os estágios funcionam de forma similar.
O curso tem como foco o modelo de Pressman, que define 5 estágios do processo de software:
- Comunicação
- Planejamento
- Modelagem
- Construção
- Entrega

### Fluxos de Processo

O fluxo do processo é a maneira que os estágios se organizam e se relacionam no processo de desenvolvimento do software.

##### Fluxo de Processo Linear

O fluxo linear é um processo no qual os estágios são implementados de forma linear, portanto o próximo estágio só começa quando o anterior é finalizado.
Comunicação > Planejamento > Modelagem > Construção > Entrega

##### Fluxo de Processo Interativo

No processo interativo, os estágios seguem uma ordem linear de execução, porém, ao final de cada etapa, há um feedback em relação àquela etapa, e a possibilidade de retorno entre a etapas anteriores, caso necessário.
Por exemplo, caso haja um problema na Construção, é possível voltar ao estágio de Comunicação para decidir como seguir.

##### Fluxo de Processo Evolucionário

O processo evolucionário é um fluxo linear que acontece de forma cíclica, entregando incrementos do software a cada ciclo do processo. Portanto ele segue as etapas linearmente, mas inicia uma nova etapa de Comunicação após uma Entrega anterior.

##### Fluxo de Processo Paralelo

No fluxo paralelo, os estágios podem acontecer sobrepostos, com um estágio podendo ser iniciado sem que o anterior tenha sido finalizado. Assim é possível, por exemplo, já iniciar a Modelagem enquanto o Planejamento ainda está em andamento.

### Atividades

Cada atividade, ou estágio, do processo é uma atividade central que possui várias tarefas envolvidas na finalização dela.
Por exemplo, no estágio de Planejamento, a atividade principal é o planejamento de todo o desenvolvimento do software, mas dentro dela, existem várias tarefas que levam até de fato o software ser planejado.

### Padrões de Processo

Um padrão de processo descreve um problema de processo e uma sugestão de solução para resolução daquele problema em um determinado contexto. Os padrões são templates, ou esquemas, usados para chegar à solução de um problema conhecido no processo de software em um contexto específico.

# Modelo Prescritivo

Também conhecidos como "Modelos tradicionais" ou "Modelos clássicos".
Estes modelos focam na ordem e consistência do processo, tendo uma ordem bem definida de começo, meio e fim no desenvolvimento de um software. Eles são chamados "prescritivos" pois eles prescrevem um roteiro sequencial de elementos do processo para serem seguidos no desenvolvimento do software.

### Modelo Cascata

O modelo cascata é um modelo linear, onde cada estágio só começa após a finalização do estágio anterior.
As etapas de um modelo cascata são:
- Comunicação: O início do projeto de software, onde ocorre o levantamento dos requisitos, definindo as necessidades do cliente, o escopo, o orçamento do software.
- Planejamento: É nesta etapa onde são definidas as tecnologias utilizadas, o tamanho e composição da equipe que irá trabalhar nele, o cronograma e estimativas de entrega. Todas as informações não técnicas referentes ao desenvolvimento do software.
- Modelagem: A etapa onde são definidas todas as questões técnicas da arquitetura do software. Onde são feitos os diagramas da modelagem do software, os fluxogramas, o projeto do banco de dados.
- Construção: Onde de fato é iniciada e feita a implementação do software, onde são feitos a codificação e os testes.
- Entrega: A parte do processo onde o software é disponibilizado em produção. É nesse momento onde são feitos o feedback e o suporte ao software entregue.

O modelo cascata, por ser consistente e precisar de uma ordem, utiliza bastante documentação. Diversos modelos, diagramas, planos de teste, relatórios. Cada etapa necessita de documentação para que se possa entrar na próxima etapa.

##### Vantagens
- Este modelo é útil quando os requisitos do software são bem compreendidos e definidos. Em especial, quando o cliente já conhece suas necessidades.
- O processo é linear e sistemático, facilitando o entendimento das etapas e tarefas.

##### Desvantagens
- Um projeto de software real dificilmente segue um fluxo sequencial
- Normalmente, os requisitos de um software não são bem definidos na primeira fase, levando a modificações durante o desenvolvimento.
- O processo é pouco adaptável, portanto não é possível alterar os requisitos ou o escopo após o início do desenvolvimento. Uma mudança no escopo requer retornar ao início do processo.
- A validação e os testes são feitos apenas no fim do ciclo de desenvolvimento
- A primeira versão do software demora muito tempo para ser visualizada, pois ela requer que o fluxo seja finalizado
- Gera muitos estados de bloqueio para a equipe, pois há sempre a necessidade de ter a documentação das etapas anteriores antes de se partir para uma próxima etapa

### Modelo V

O modelo V é um modelo com foco maior em testes. No qual cada etapa tem uma etapa de testes definida para ela.
Porém, este modelo segue um fluxo linear idêntico ao do modelo cascata. A única diferença é em relação a como os testes são visualizados e relacionados com cada etapa.

# Modelos Incremental, Evolucionário e Concorrente

## Modelo de Processo Incremental

Este modelo é melhor utilizado quando os requisitos iniciais são bem definidos, mas não refinados.

Neste modelo, o processo de desenvolvimento do software é feito de forma linear, mas incremental. 
Cada etapa do fluxo ocorre apenas após a finalização da etapa anterior, funcionando exatamente da mesma forma que em um fluxo em modelo de cascata. Porém, o fluxo tem uma escala menor, e acontece várias vezes durante o desenvolvimento, com várias entregas de protótipos sendo feitas durante o processo, em vez de ter apenas uma entrega final. 

## Modelo Evolucionário

Os modelos evolucionários possibilitam que o software desenvolvido se adapte e cresça constantemente. Ele é melhor utilizado em softwares de grande escala e grande complexidade, têm a necessidade de um acompanhamento e uma evolução constante.

Há dois tipos principais de modelos evolucionários:

### Prototipação

O modelo de prototipação é um modelo focado na entrega rápida de versões pouco refinadas do software, os protótipos, de forma a receber feedback constante do usuário.
No modelo de prototipação, há a presença de etapas de planejamento, modelagem e construção rápidos, com o objetivo de construir uma versão pronta para entrega, e a partir desta entrega, ter uma etapa de comunicação com o cliente para alinhar o caminho que o software está seguindo, validando funcionalidades e requisitos.
Este modelo pode ser usado isoladamente, ou com outros processos.

##### Problemas da prototipação
- Falta de consideração com a qualidade do software. Como o protótipo é feito para ser apenas "funcional", e não necessariamente uma entrega de qualidade, ele deve ser refinado após a entrega. Porém, pode ocorrer de uma equipe se acomodar com as escolhas feitas no protótipo e acabar não evoluindo o protótipo para uma qualidade acima da entregue inicialmente.

### Modelo Espiral

O modelo espiral une a natureza iterativa da prototipação com o aspecto sistemático do modelo cascata.
O modelo espiral trabalha com ciclos, que representam a evolução do software ao longo do tempo. Ele utiliza um processo linear, como no modelo de cascata, mas utiliza protótipos para comunicação com o cliente. Após a finalização de uma entrega, o ciclo se reinicia, com a construção de uma nova versão, com melhorias em relação à versão iniciar, baseado na comunicação com o cliente.
Este modelo normalmente é usado em projetos grandes, nos quais a cada entrega o software evolui de uma versão para a próxima. Existe também um foco em diminuição de riscos, pois a cada ciclo se considera os aspectos que podem trazer risco para o projeto.

## Modelo Concorrente

No modelo concorrente, todas as tarefas existem ao mesmo tempo, de forma concorrente. Porém, cada tarefa possui um estado, que define em que parte do processo aquela tarefa se encontra.
Os estados podem ser Inativo, aguardando modificações, em desenvolvimento, em revisão, em exame, ponto de partida ou concluído. 
Cada tarefa pode estar em um estado específico, e o modelo possui eventos que podem causar a transição de estado para estado em cada tarefa.

# Modelos Especializados

Estes modelos são chamados de especializados pois eles necessitam de técnicas e métodos muito específicos de acordo com o contexto do software.

### Modelo Baseado em componentes

É um modelo de desenvolvimento onde se utiliza componentes, bibliotecas ou módulos integrados de forma direta no software. Os componentes são encaixados no software, como se fossem peças que constroem o todo, sem a necessidade de uma modelagem mais complexa. 
Este modelo é evolucionário, pois ele é adaptado de acordo com as necessidades do software. A cada novo ciclo de desenvolvimento, são pesquisados componentes existentes no mercado que podem integrar ao software para suprir essas necessidades.

### Modelo de Métodos Formais

Utilizado em situações bem específicas. Requer muito tempo, dinheiro e conhecimento técnico.
Este modelo é utilizado em sistemas com prioridade pela coesão. Um sistema no qual não pode ocorrer falhas, pois este modelo garante alta confiabilidade no sistema.
Os métodos formais são desenvolvidos a partir de princípios matemáticos, que garantem a exatidão na expressão das ideias do software. Os métodos formais podem ser aplicados durante todas as etapas do desenvolvimento.

##### Especificação Formal

Etapa semelhante à identificação de requisitos, onde são identificados os requisitos funcionais e não funcionais do sistema.
A especificação formal consiste em formalizar os requisitos descobertos utilizando algum método formal, como Teoria de Conjuntos em notação B ou Z, Álgebra de Processos com notação LOTOS, dentre outros. 
Esta fase necessita também de uma descrição textual dos requisitos, para facilitar a interação e revisão com o cliente.
Nesta etapa, é importante modelar os requisitos, e também as circunstâncias de relacionamento entre esses requisitos.

##### Refinamento

Esta fase é onde é definida a arquitetura do sistema, seus componentes, dados e relacionamentos. Nela, é criado um modelo de sistema, que analisa o seu comportamento, os procedimentos para cumprir as finalidades, as atividades e as sequências de execução, funções, entradas e saídas do sistema.

##### Síntese

A fase de síntese consiste na geração de esqueletos de código com base no modelo refinado, que pode servir de base para a implementação real do sistema.

##### Prototipagem e Prova

A fase de prova é utilizada para verificar se o sistema atende a todos os requisitos funcionais e não funcionais. A fase de prototipagem consiste em elaborar um protótipo funcional do sistema, para validar com o cliente se atende às suas necessidades.
A fase de prova pode ser feita através de:
- Uma prova de teorema automatizada, que utiliza uma descrição do sistema e aplica inferências lógicas verificando o grau de correção do sistema.
- Verificação de modelo, que utiliza o modelo refinado para testar exaustivamente todos os estados de comportamento do sistema.

### Modelo Orientado a Aspectos

Provém de um paradigma de programação: Programação Orientada  a Aspectos.
Ele é baseado na construção de aspectos, que são pontos de interesse da aplicação que se propagam e entrecortam outras partes da aplicação. Os aspectos são um interesse geral da aplicação. 

# Processo unificado (RUP)

O processo unificado é um processo iterativo e adaptativo que permite conduzir um projeto de maneira organizada e consistente.
O ciclo de vida desse projeto é baseado em refinamentos e incrementos sucessivos, onde em cada iteração incrementa-se um pouco mais o produto, com base nas experiências e feedback obtidos nas iterações anteriores.
Cada iteração possui todas as etapas de um ciclo de vida do software, e o resultado é um sistema funcional, porém incompleto, que não está pronto para ser colocado em produção. O resultado é também um sistema com qualidade de produto final, e não um protótipo.

O processo unificado é guiado por casos de uso, que detalham a interação do usuário com o sistema.
Ele é um processo que aceita mudanças e adaptações como fatores inevitáveis, e até essenciais, do desenvolvimento de software, pregando que não se deve especificar todos os requisitos do sistema de uma vez só.
Cada iteração escolhe um pequeno subconjunto de requisitos para projetar, implementar e disponibilizar para o teste do usuário. Assim há uma rápida realimentação de dados que possibilitam adaptar os requisitos do projeto.
Esse ciclo de avaliações permite a detecção de falhas rapidamente, e é uma maneira rápida de melhorar a compreensão dos requisitos mais importantes para o usuário, assim garantindo que o projeto está no caminho certo.

Os principais benefícios do processo unificado são:
- Mitigação rápida de altos riscos
- Progresso visível desde o início
- Realimentação de dados e envolvimento do usuário, levando a um refinamento rápido do sistema de forma a atender mais adequadamente às reais necessidades dos interessados.
- A complexidade é administrada, não há uma sobrecarga de passos longos ou complexos, nem a "paralisia da análise"
- O aprendizado obtido em uma iteração pode ser usado para melhorar o processo de desenvolvimento

### Fases do processo unificado

É recomendado que no processo unificado, cada iteração tenha um tempo fixo pré-determinado e que se cumpra o seu prazo. As iterações devem ser pequenas, de duas a seis semanas.
As iterações do processo unificado possuem quatro fases principais:
- Concepção: Fase na qual se levanta o escopo do projeto, de forma genérica. Os requisitos não devem ser detalhados, apenas deve-se ter uma visão inicial do problema e estimar prazos e soluções para definir se o projeto é viável.
- Elaboração: Todos os requisitos são levantados com detalhes. Na primeira iteração, são especificados um ou dois dos requisitos de maior risco, e depois de implementados, eles servem como base para o planejamento da próxima iteração. A cada nova iteração, pode-se levantar novos requisitos ou detalhar mais os existentes. A fase de elaboração também contempla o início da codificação.
- Construção: Implementação iterativa dos elementos do sistema, com a realização da codificação e dos testes. Também são realizadas ações referentes à implantação do software no ambiente.
- Transição: Fase onde é feita a conclusão dos testes e a implantação do sistema no ambiente. Podem também ser feitos ajustes finais no código.