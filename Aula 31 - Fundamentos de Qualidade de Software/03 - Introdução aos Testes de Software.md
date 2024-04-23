
# Conceitos e Objetivos

### O que é teste?

- É um processo de avaliar e reduzir risco de falhas de software. Os testes mantém a satisfação do usuário, e diminuem o risco financeiro em relação ao software.
- Os testes fazem parte do controle de qualidade.
- O processo de teste engloba muito mais que somente o ato de executar os testes.

### Objetivos Gerais:

- Evitar defeitos e avaliar produtos de trabalho.
- Verificar cumprimento de requisitos.
- Validar se o produto funciona como o cliente espera.
- Criar confiança no nível de qualidade do objeto testado.
- Redução de riscos.
- Atuar junto do cliente para tomada de decisões.

#### Teste x Depuração

- Os testes mostram falhas causadas por defeitos no software.
- A depuração é um processo de investigação e correção do erro no desenvolvimento do código.

### Princípios de Teste

- Teste mostra a presença de defeitos, e não a ausência. Eles servem para achar um defeito e depois corrigi-lo. Os testes não provam que não existem erros no sistema.
- Testes exaustivos são impossíveis. Não é possível testar tudo no sistema, os testes tentam mitigar o máximo possível de erros, mas não há como testar todos os cenários.
- Testes iniciais economizam tempo e dinheiro. Quanto mais cedo forem realizados os testes, mais rápido se evitam os impactos no sistema. Testar durante o desenvolvimento é muito importante.
- Defeitos se agrupam. Quando são encontrados alguns erros em uma parte do sistema, a tendência em que novos erros apareçam nesta mesma parte.
- O mesmo teste não encontra novos defeitos. Para verificar novos erros, é necessário criar novos testes, novas entradas e novas condições. Os testes de regressão são uma exceção, pois eles verificam se alterações no código afetam testes anteriores.
- O teste depende do contexto. Não é possível fazer todos os tipos de testes em todos os contextos. Os testes devem ser definidos baseados na necessidade.
- A ausência de erros é uma ilusão. A perfeição não existe, mas os testes visam chegar o mais próximo possível dela.

# Processo de Teste

Os fatores que influenciam o processo de testes são:
- O modelo de ciclo de vida utilizado. Se a metodologia é ágil ou não afeta como os testes serão feitos.
- Níveis e tipos de teste. Deve-se analisar cuidadosamente quais níveis e tipos serão utilizados.
- Risco de produto e de projeto.
- Entender o domínio do negócio.
- As restrições operacionais. Os testes dependem do acesso ao sistema e permissões que o tester possui.
- Políticas organizacionais.
- Normas internas e externas.

### Atividades de Teste

As atividades de testes são as atividades necessárias para realização dos testes. Muitas vezes, as etapas podem se sobrepor. O processo não é engessado, ele deve ser flexível.

#### Planejamento

Define o propósito do teste e a abordagem utilizada. Especifica tarefas e estimativas de prazo.  
Algumas estratégias formalizadas de planejamento:
- **Analítica:** Estratégia baseada na análise de um fator.
- **Baseada em modelo:** Baseada em um aspecto necessário do produto.
- **Metódica:** Planejada com um conjunto pré-definido de testes.
- **Compatível com processo:** Baseado em padrões da empresa.
- **Dirigida:** Orientada pelos stakeholders.
- **Regressão:** Evitar regressão de recursos existentes.
- **Reativo:** Reage a um componente ou evento durante a execução.

#### Monitoramento e Controle

Comparação do progresso real com o plano de teste a partir de critérios de avaliação de saídas. Utiliza relatórios de progresso.

#### Análise

Após ter uma base de teste, ela é analisada para saber o que testar de acordo com os critérios definidos.  
A base de teste é o ponto de partida para os testes, que pode ser os requisitos, a arquitetura, um fluxograma, caso de uso, o código fonte... A análise da base de teste avalia os tipos de defeitos que podem ser encontrados e define as condições do teste.

#### Modelagem

Essa etapa define como os testes serão feitos.  
As condições de teste são elaboradas em casos de alto nível, priorizando os casos e conjuntos de casos. Também é verificada a infraestrutura necessária para que o teste seja realizado.

#### Implementação

Desenvolve e prioriza os procedimentos de testes e os scripts automatizados. Cria a suíte de testes, faz a organização lógica e eficiente de execução dos testes. É necessário não apenas pensar nos cenários de testes, mas também como organizá-los. Prepara os dados de entrada para o teste.

#### Execução

Os testes são executados conforme planejado.  
A execução compara os resultados reais com os resultados esperados, analisando anomalias e prováveis causas. As anomalias são reportadas e registradas, para futuramente ser feito o reteste para verificar se os defeitos foram corrigidos.

#### Conclusão

Coleta dados dos testes concluídos, revisando e consolidando a experiência. É criado o relatório de resumo de teste. Os dados e registros de testes são arquivados e a maturidade do processo de teste é analisada.

### Níveis de Teste

Os níveis de testes são grupos de atividades de teste organizados e gerenciados juntos dependendo do nível de desenvolvimento.
- Teste de componentes.
- Teste de integração.
- Teste de sistema.
- Teste de aceite.

#### Teste de Componente / Teste de Unidade

Focam em testar pequenos componentes do código, de forma independente. Esses testes testam uma parte do código sem que ela dependa de outras partes. Os testes de unidade:
- Reduzem riscos.
- Verificam requisitos funcionais e não funcionais.
- Aumentam a confiança do componente.
- Encontram defeitos.
- Evitam que os defeitos sejam refletidos em níveis mais altos de teste.

#### Teste de Integração

Focam na integração entre os componentes ou sistemas. Esses testes testam partes diferentes do sistema que se comunicam, e levam em consideração essa comunicação entre eles. Os testes de integração:
- Reduzem riscos.
- Verificam interfaces.
- Encontram defeitos nas partes envolvidas, para que não sejam refletidos em níveis mais altos.

#### Teste de Sistema

Focam nos requisitos do sistema de ponta a ponta. Os testes de sistema:
- Reduzem riscos.
- Validam o sistema como um todo.
- Encontram defeitos não vistos nos níveis mais baixos.
- Evitam que defeitos reflitam em produção para o cliente.

#### Testes de Aceite

Focam nos requisitos de ponta a ponta do ponto de vista do usuário e das necessidades do cliente. Os testes de aceite:
- Reduzem riscos.
- Validam o sistema como um todo.
- Encontram defeitos não vistos nos níveis mais baixos.
- Evitam que defeitos reflitam em produção para o cliente.

### Tipos de Teste

Os tipos de testes são grupos de atividades destinadas a verificar características específicas do sistema, com um objetivo específico.
- Avaliar características funcionais.
- Avaliar características não funcionais.
- Avaliar estrutura ou arquitetura de componente.
- Avaliar efeitos de alterações de outras partes do código.

#### Teste funcional

Avalia as funções que o sistema deve executar, a partir das especificações de requisitos, histórias de usuário, casos de uso. As técnicas de caixa-preta são as mais utilizadas.  
Ele pode ser realizado em todos os níveis de teste.

#### Teste não funcional

Avalia as características não funcionais, como usabilidade, performance, segurança.  
Ele pode ser realizado em todos os níveis de teste.

#### Teste caixa branca

Foco em testes com base na estrutura do sistema. Testa o código fonte, arquitetura, fluxo de dados.  
Ele é utilizado para testes de unidade ou de integração.

#### Teste de mudança

Teste de confirmação: Feito após uma correção para confirmar que um defeito foi corrigido.  
Teste de regressão: Verifica efeitos colaterais de alterações em um componente do sistema.

### Técnicas de Teste

As técnicas de teste auxiliam na identificação das condições, casos e dados dos testes.

#### Caixa-preta

Fundamentados em documentos de requisitos, focando no comportamento do sistema, sem se considerar como ele foi construído ou sua arquitetura.  O foco é nas entradas e saídas do teste.

Há 5 tipos de testes de caixa-preta:
- Particionamento de equivalência.
- Análise de valor limite.
- Tabela de decisão.
- Transição de estado.
- Teste de Caso de Uso.

##### Particionamento de Equivalência

Divide os dados de entrada em partições ou classes de equivalência, ou seja, em faixas de valores nas quais todos os valores dentro de cada faixa são processados e tratados da mesma maneira, sendo válidos ou inválidos. Para cada faixa de valores, apenas um pode ser escolhido para o teste, pois eles são todos tratados de forma equivalente.

Por exemplo, um sistema que espera um comportamento para pessoas menores de 18 anos terá o mesmo comportamento para qualquer valor entre 0 e 18, portanto esses valores são agrupados em uma faixa, e qualquer um deles pode ser usado no teste.

##### Análise de Valor Limite

Semelhante ao anterior, mas analisa o valor mínimo e máximo permitidos no sistema. Utilizado em sistemas que não possam receber valores acima ou abaixo de um limite específico.

Por exemplo, um sistema que trata com idades não recebe valores abaixo de 0, ou acima de uma idade alta determinada (como 120).

##### Tabela de Decisão

Útil para testar requisitos que especificam condições através de combinação de diferentes resultados.

Por exemplo, para fazer um pagamento, o cartão deve ser válido, a senha deve ser válida e o valor do saldo deve ser maior que o valor da compra. Todas essas condições são analisadas em uma tabela para definir o resultado.

##### Transição de Estado

Situações em que o sistema reage diferentemente a um evento dependendo das condições atuais ou de um histórico de condições.

Por exemplo, um sistema de login que bloqueia a conta caso a senha inserida seja incorreta 3 vezes seguidas. Nas duas primeiras vezes o sistema permite uma nova tentativa, e na terceira ele é bloqueado.

##### Teste de Caso de Uso

Derivam naturalmente dos casos de uso, associando as ações aos atores do caso. Os testes são projetados para casos básicos, alternativos e de erro.

#### Caixa-branca

Baseadas na estrutura interna do objeto de teste. Normalmente usada para testes de integração e de unidade.

Há 2 tipos de testes de caixa-branca:
- Cobertura de Instruções.
- Cobertura de Decisões.

##### Cobertura de Instruções

Testa instruções executáveis do código.  
A cobertura mede a quantidade de instruções executadas em relação com o total.

##### Cobertura de decisões

Testa as estruturas condicionais do código, como if/else e switch. Verifica todas as mudanças de fluxo do código e o que é executado em cada uma delas.  
A cobertura mede o número de resultados de decisão executados em relação ao total. 100% de cobertura de decisão implica em 100% de cobertura de instrução.

#### Por experiência

Baseado na experiência e intuição de quem testa, que pode identificar situações que não são encontradas em métodos mais sistemáticos. Difícil de avaliar e medir.

Esses testes podem ser:
- Suposição de Erro.
- Teste exploratório.
- Baseado em Checklist.

##### Suposição de Erro

Este teste tem como base a experiência do tester com um tipo específico de sistema ou projeto, a partir da qual o tester pode supor uma situação que imagina que possa acontecer nesse sistema e projetar testes para verificar esse erro.

##### Teste Exploratório

Este é um teste informal feito pelo tester através do uso do sistema, interagindo com o sistema de forma a aprender mais sobre o seu funcionamento, seus componentes ou verificar quais áreas precisam de mais testes.

##### Teste Baseado em Checklist

Os testers criam uma lista de testes para serem modelados e executados no sistema. Esta lista é elaborada com base em diversos fatores, como a experiência dos testers, o conhecimento sobre o sistema ou a compreensão de alguma falha existente no software.