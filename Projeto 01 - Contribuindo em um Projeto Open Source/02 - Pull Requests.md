# Pull Request

Um pull request é uma solicitação de merge em um repositório. Uma pull request pode ser aberta após fazermos push em uma branch em um repositório remoto. Depois estas alterações podem ser avaliadas, e então é tomada a decisão se elas serão mescladas com a branch principal do repositório.

É através de uma pull request que enviamos alterações realizadas em um projeto Open Source sejam mescladas com o repositório original.

#### Criando uma Fork do Repositório

Para criar uma pull request, é necessário fazer um Fork do repositório. Com isso, é criada uma cópia do repositório original na sua conta do Github, com uma indicação de que ele é um fork de outro repositório. Fazer um fork é necessário caso o usuário não tenha permissão de enviar alterações no repositório original.

Para fazer um fork do repositório, usar o botão **Fork** no canto superior direito da página do repositório. Isso leva à página de customização do fork, onde se pode escolher o nome do repositório de fork (normalmente é usado o mesmo do repositório original), mudar a descrição, e há uma opção para copiar somente a branch principal do repositório

Após criar o fork e entrar na página do repositório, há duas opções disponíveis apenas para forks:

- Sync Fork: Baixa as alterações realizadas no repositório original após o fork ter sido realizado.
- Contribute: Permite enviar as alterações realizadas no repositório de fork de volta para o repositório original, criando uma pull request

#### Trabalhando com o Repositório Fork

Para trabalhar no repositório de fork, é necessário fazer um clone dele para um repositório local (Ou editar dentro do próprio Github, caso possível). Depois disso, pode-se trabalhar normalmente no projeto dentro do repositório local.

Opcionalmente, é possível conectar o repositório local diretamente com o repositório original. Essa conexão seria feita apenas para baixar as alterações diretamente dele, sem precisar atualizar o repositório fork e depois fazer um pull das alterações dele.

`git add remote upstream [URL do Repositório Original]`

Este comando conecta o repositório local ao repositório original, onde "upstream" é o nome dado ao repositório original.   
Caso o repositório original seja alterado, é possível faze o pull direto pelo repositório local, usando o comando:

`git pull upstream main`

Neste caso, o repositório local está conectado a dois repositórios remotos:
- Remote: O repositório de fork. A conexão com esse repositório foi estabelecida no momento em que foi feito o clone. Este é o repositório para onde devem ser enviadas as alterações através do push.
- Upstream:  O repositório original. A conexão foi estabelecida manualmente com o comando git add remote. Este repositório será usado apenas para baixar as alterações através do pull.

#### Criando a Pull Request

Após serem feitas as alterações no repositório local e ser feito o push para o remote (repositório do fork), ao voltar na página do repositório fork no Github, ele já mostra que estamos a frente do repositório original.

A Pull Request pode ser criada usando a opção **Contribute** e **Open Pull Request**. Pode-se também usar a opção que aparece no topo da tela: **Compare & Pull Request**  
Na página de criação da pull request, é possível adicionar o titulo e descrição dela, além de escolher qual repositório e qual branch nós queremos mesclar. Alguns repositórios podem ter templates para pull requests, assim como ocorre para issues.  
Mais abaixo, é possível ver as mudanças feitas na pull request, além de quantos commits foram realizados.

Após criar a pull request, ela fica visível no repositório original, na aba Pull Requests. Ela também mostra se existe algum conflito com a branch original.

#### Lado do Administrador do Repositório

Como administrador, é possível ver a pull request, suas informações, os commits, as alterações, se existe algum conflito... e então, decidir se as alterações serão mescladas com o repositório original, através do botão **Merge Pull Request**. Isso leva a uma página onde se pode editar o commit que vai mesclar essas alterações. Após o merge, as alterações já aparecem no repositório, e a pull request é fechada automaticamente.

Ao visualizar o código dentro do repositório, existe uma opção "Blame", que permite ver quem foi o responsável pelas alterações naquele arquivo.  
Após um merge, o autor do pull request também é creditado como um contribuidor do repositório original.