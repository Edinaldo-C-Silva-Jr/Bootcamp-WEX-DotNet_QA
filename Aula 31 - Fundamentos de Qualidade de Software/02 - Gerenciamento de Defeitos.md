
# Controle de Qualidade

- Análise estática: Avaliação de documentação do software e do código fonte.  
Analisar a documentação do software também é importante, deve-se garantir que a documentação está de acordo com o que o cliente pediu. Um erro na documentação pode levar a erros no desenvolvimento.  
Essa análise inclui: code review, automação de processos de verificação de código e análise de histórias e modelagens.
- Análise dinâmica: Técnicas de análise com o código em execução. Os testes de execução do software.
- Verificação é garantir que o produto está sendo construído corretamente.
- Validação é garantir que o produto correto está sendo construído.

### Caracterização de Defeitos

Após encontrar um erro, como prosseguir?

#### Rastreamento de Defeitos

- Permite entender os produtos e os tipos de defeitos que podem ser encontrados. Fazendo a análise dos erros, é possível entender melhor as necessidades de qualidade do produto.
- Facilita a correção do processo ou do produto, tanto a nível de código, de requisitos ou de documentação.
- Ajuda a reportar o status do produto.
- Ajuda no alinhamento de revisões pelo time de desenvolvimento. É importante para os desenvolvedores saberem do status dos defeitos e quais partes do produto necessitam de mais atenção.

#### O que é um defeito?

Um defeito significa qualquer tipo de anomalia encontrada no produto.

Há algumas definições diferentes dependendo do tipo de defeito:
- Erro - É uma ação humana que produz um resultado incorreto.
- Defeito - Imperfeição ou deficiência nos requerimentos e especificações do produto.
- Falha de sistema - Evento em que o sistema não executa uma função sob limites específicos.

Motivos principais que causam erros:
- Pressão do tempo.
- Falha humana.
- Inexperiência ou falta de qualificação.
- Falta de comunicação.
- Complexidade de código, modelagem, arquitetura, dentre outros.
- Complexidade da tecnologia.
- Condições de ambiente inesperadas.

### Ciclo de Vida do Bug

Os bugs têm um ciclo de vida, assim como um software.

Existem diversos estados em que um bug pode estar:

- **New:** Defeito identificado e cadastrado pela primeira vez.
- **Assigned:** O defeito é atribuído a um desenvolvedor para avaliar.
- **Open:** O desenvolvedor inicia a análise do defeito e a correção.
- **Fixed:** Desenvolvedor finaliza a correção. Não necessariamente significa que o defeito foi consertado, mas que o desenvolvedor fez as correções que julga necessárias.
- **Pending Retest:** O defeito fica em espera para que o time de teste verifique se foi corrigido.
- **Retest:** Os testes são executados.
- **Verified:** A equipe de testes verifica que o bug foi corrigido.
- **Closed:** Corrigido, testado e aprovado. O bug não existe mais.
- **Reopen:** Caso a equipe de testes verifique que o defeito não foi corrigido.
- **Duplicate:** Este defeito já foi encontrado anteriormente, e já existe outro cadastro dele.
- **Rejected:** Quando o desenvolvedor não vai fazer a correção por algum motivo. O motivo é especificado.
- **Deferred:** O defeito será corrigido em versões futuras.
- **Not a bug:** A anomalia é analisada e definido que não é de fato um erro. Pode ser um falso positivo, ou pode ser uma falha nos próprios requisitos do sistema.

#### Considerações importantes

- Os processos se adequam ao que o time e o produto precisam.
- O time precisa estar de acordo e entender o fluxo de rastreamento de defeitos.
- Os defeitos podem e devem ser rastreados em qualquer momento do ciclo de vida do software. Mesmo que o tratamento não seja feito, o rastreamento e report devem ser feitos.
- Os objetivos do report de defeitos são:
	- Fornecer o máximo de informações possíveis para que as partes interessadas possam isolar, reproduzir e corrigir o problema.
	- Fornecer meios para rastrear a qualidade do produto e o impacto do defeito nos testes e retestes.
	- Fornecer ideias para melhorar o processo de desenvolvimento e testes.
- A comunicação é essencial para todo o time.
- Uso eficiente de ferramentas de rastreio e report de bugs.
- Comprometimento da equipe com o gerenciamento de defeitos. O QA não deve ser o único a se preocupar com os defeitos.