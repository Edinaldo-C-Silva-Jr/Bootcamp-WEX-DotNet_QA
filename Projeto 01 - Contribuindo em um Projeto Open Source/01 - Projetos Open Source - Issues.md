# O que é um projeto Open Source

Um projeto Open Source é um projeto de código aberto, que pode ser acessado abertamente pelo público, e qualquer pessoa pode utilizá-lo, modificá-lo e distribuí-lo. Projetos Open Source são desenvolvidos de forma colaborativa e decentralizada, em que toda uma comunidade pode trabalhar junta no desenvolvimento, em vez de apenas um autor ou empresa.  
Normalmente, projetos Open Source são gratuítos. É sempre importante consultar a licença sob a qual o software está sendo disponibilizado para saber o que se pode fazer com ele.

#### Contribuindo em um projeto Open Source

Há várias formas de se contribuir em um projeto Open Source, dentre elas:
- Relatar algum problema ou bug
- Sugerir melhorias ou adição de novos recursos
- Escrever ou atualizar a documentação
- Contribuir com o desenvolvimento de código
- Divulgar ou doar para o projeto

Alguns projetos podem possuir, dentro de seu repositório, um *Guia de Contribuição*, que é um arquivo MarkDown com o nome `CONTRIBUTING.md`. Este arquivo pode ser disponibilizado na raiz do repositório, dentro da pasta docs ou dentro da pasta .github.  
Ao ser configurado corretamente, esse arquivo é reconhecido pelo Github automaticamente, com isso, o Gihub informa no topo da tela da aba de Issues e na aba de Pull Requests que o repositório possui um guia de contribuição.

# Issues

Issues são tópicos de discussão que podem ser criados dentro de um repositório para relatar bugs ou problemas, sugerir novas funcionalidades e melhorias, ou fazer perguntas e discutir sobre qualquer assunto relacionado ao projeto.

#### Aba de Issues

No Github, ao entrar em um repositório, há diversas abas localizadas no topo da tela, abaixo do nome do repositório. Dentre elas, existe a aba Issues, que é a aba onde se envia as sugestões de melhoria ou se reporta um problema.  
Esta aba exibe todas as issues existentes no projeto. Por padrão, apenas as issues abertas são exibidas, mas há a opção de ver as issues fechadas. Esta aba também permite pesquisar e filtrar as issues.

#### Criar uma Issue

Para criar uma issue, utilizar o botão **[New Issue]**.  
Alguns repositórios possuem templates de criação de issues, que foram definidos pelo dono do repositório, e ficam disponíveis para serem usados ao criar uma issue. Esses templates preencher algumas informações automaticamente, e podem indicar o formato preferível para issues criadas naquele repositório.

Após escolher um template, ou criar uma issue vazia (na qual não é aplicado nenhum template), é aberta a página de edição da Issue. É nesta página onde se pode escrever sobre o que se trata a issue (seguindo o formato do template, se existir), além de escolher as etiquetas relacionadas à issue (se é uma nova funcionalidade, um problema, ou outros tipos)  
Após terminar, é só clicar em Submit New Issue e ela será adicionada ao repositório, e ficará visível na aba Issues para qualquer pessoa que acessá-la.

#### Lado do Administrador do Repositório

##### Fechando uma Issue

Como administrador do repositório, é possível responder às issues e escolher quem vai resolvê-la. A pessoa que resolverá a issue pode ser o próprio administrador, ou ele pode delegar a resolução para alguém (podendo inclusive ser a própria pessoa que abriu a issue).

Após solucionar a issue, fazendo quaisquer alterações necessárias no repositório para que o problema seja resolvido ou a funcionalidade implementada, ela pode ser fechada direto pelo commit da alteração. Para isso, basta colocar uma palavra chave (como "fix", "close" ou "resolve") e o número da issue (que pode ser encontrado na página da issue). Com isso, após o commit ser feito, o Github a fecha automaticamente.

##### Templates de Issues

Os templates de issues ficam dentro da pasta .github  
Para criar um template, entrar na aba Settings do repositório, depois ir até a seção de Issues e clicar em **[Set Up Templates]**. Nessa página é possível criar e editar templates.  
Com isso pode ser definido um título, o corpo da mensagem e as etiquetas padrão desse tipo de issue.  
Depois de editar, usar o botão **[Propose changes]** para preparar e fazer o commit que salvará as alterações no template.
