# Contextualizar a Atividade de Teste

Para cada atividade de desenvolvimento, existe uma atividade de teste. Há diferentes níveis e tipos de testes, presentes em todos os tipos de ciclo de vida. Há diferentes maneiras como os testes se encaixam no ciclo de vida, mas eles devem estar sempre presentes.
A atividade de teste deve ser completa, desde o planejamento do projeto até o desenvolvimento do código.

#### História de Usuário - Conceito 3C

- **Cartão**: As histórias de usuário geralmente são escritas em cartões, que descrevem brevemente a história e as regras. Os cartões possuem um usuário, uma atividade que deve ser feita e um resultado esperado desta atividade.
- **Conversação**: Os detalhes da história do usuário são comunicados através de uma conversa com o cliente, que expressa as suas necessidades e resultados esperados neste requisito.
- **Confirmação**: Confirma que a história do usuário foi concluída corretamente através do teste de aceitação, utilizando os critérios de aceite, que são meios de confirmar que o comportamento da funcionalidade está sendo atendido com o desenvolvimento.

#### Atividades Envolvidas no Planejamento

- Fazer uma análise detalhada das histórias de usuário.
- Determinar a "testabilidade" da história: Fazer uma previsão de se ela pode ser testada ou não, e se pode ser testada automaticamente. Definir o quão fácil ou difícil seria a implementação dos testes.
- Criar os testes de aceite, que provêm diretamente da história do usuário.
- Criar as tarefas de teste.
- Estimar o esforço necessário para essas atividades.
- Identificar os aspectos funcionais e não funcionais que serão avaliados, definir qual o foco do teste para a funcionalidade, onde se deve preocupar mais com a funcionalidade e onde serão feitos mais testes.
- Participar do processo de automação, mesmo que não se esteja diretamente envolvido com os testes, é necessário garantir que os testes estão ocorrendo corretamente.

#### Detalhando a abordagem de teste

- Determinar o escopo do teste, a extensão que o teste terá no projeto, os objetivos que o teste deseja alcançar e os motivos para ser feito esse teste.
- Definir os membros que irão atuar com os testes, dependendo de sua capacidade técnica e o tipo de teste a ser feito.
- Definir os ambientes e os dados necessários, a estrutura que será utilizada para fazer o teste, se existem dados suficientes para o teste.
- Definindo o tempo do teste, as dependências necessárias e os pré-requisitos para o teste ser realizado.
- Definindo os riscos envolvidos no teste.

# Testes nas Abordagens Ágeis

### Diferenças na Abordagem de Testes Ágil

As atividades de testes estão sempre relacionadas com o desenvolvimento, portanto é importante conhecer os processos e ciclos de vida e como os testes se inserem neles. Customização e adaptação são importantes.

As atividades de qualidade estão embutidas em cada iteração, podendo ocorrer de forma paralela com outras atividades. A cada iteração, a atividade de testes começa assim que começa o Planejamento do projeto, com o planejamento dos testes, sua abordagem, cenários, casos de teste, dados utilizados. São atividades que devem ser feitas durante toda a iteração, em concorrência com os processos do desenvolvimento.

Nas abordagens ágeis, o foco dos testes é maior na questão de segurança, de performance e exploratórios. É preciso garantir que os sistemas atuam com segurança e que entregam uma boa performance. Os testes exploratórios são mais utilizados em entregas emergenciais, pois nem sempre é possível fazer uma documentação detalhada do software.

Também há um foco maior no uso de automação para testes de regressão, pois é importante ter um processo que lide rapidamente com estes testes no mundo ágil, onde há vários incrementos sendo entregues com rapidez. É preciso ter certeza de que os novos incrementos não afetam o que já estava funcionando anteriormente.

É necessário que se tenha uma documentação suficiente para poder garantir a qualidade e manutenção do software.

### Produtos de Trabalho Comuns

- Resultados de testes, manuais ou automatizados. Nas metodologias ágeis, esses resultados são mais rápidos para a visualização, sem muita burocracia ou muitos detalhes. É necessário ir direto ao ponto e mostrar qual o problema e quais os resultados.
- Planos de testes, que podem ter um escopo de tamanho variado dependendo do tempo disponível
- Análise de Risco, é necessário conversar com o Product Owner e os desenvolvedores para ver quais são os riscos para o sistema e o usuário. 
- Relatórios de defeitos, que fornecem informações sobre os defeitos relacionados a um plano de teste, incluindo sua descoberta e planos para correção.

### Níveis de Teste no Modelo Ágil

O nível de teste varia de acordo com o estágio do desenvolvimento.
Cada teste é definido para validar uma funcionalidade ou parte específica do sistema, e estes testes devem ser feitos sobrepostos, para achar os problemas em partes diferentes do sistema.
No modelo ágil, os testes com maior foco são os testes de unidade e os testes de aceite. Os testes de unidade conseguem pegar os problemas mais simples rapidamente, com um custo baixo e maior facilidade para corrigir o problema, e os testes de aceite garantem que o sistema está sendo desenvolvido conforme solicitado.

### Status de Testes no Modelo Ágil

Assim como ocorre nos projetos no modelo ágil, onde a transparência é passada diariamente para a equipe, o status dos testes também deve ser atualizado com frequência, para que a equipe esteja por dentro dos resultados, dos problemas, do que foi feito, de quais são os impedimentos e do que de fato foi concluído.
Também é necessário monitorar o status de todas as atividades da equipe, o foco deve ser sempre no feedback da equipe, para garantir que a comunicação seja feita. Às vezes é necessário acompanhar de perto a equipe para conseguir evoluir os testes.

### Atitudes e Habilidade para Agilidade

- Positividade e pensamento na solução
- Pensamento crítico
- Foco em qualidade
- Comunicação constante com o cliente
- Feedbacks constantes
- Avaliação de cenários para critérios de aceite
- Colaboração em tempo integral
- Adaptação a mudanças
- Organização e planejamento

### Outras Atividades na Equipe Ágil

- Compreender e atualizar estratégias de teste
- Medir e informar a cobertura dos testes
- Garantir o uso adequado de ferramentas
- Gerenciar ambientes de teste
- Relatar defeitos
- Assegurar tarefas de forma adequada
- Esclarecimento contínuo de requisitos com a equipe
- Sugerir melhorias

