# Conectando os Repositórios
Para salvar o versionamento de um repositório local do Git para um repositório remoto, como o Github, primeiro é preciso conectar os repositórios.
Note que, para que os repositórios sejam conectados, ambos já devem existir: o repositório local no computador, e o repositório remoto no Github.

> git remote add origin [URL]
> git remote -v - 

O primeiro comando é o responsável por conectar os repositórios. Ele conecta o repositório local atual ao repositório remoto que se encontra em [URL].
A URL do repositório remoto pode ser encontrada ao acessar a página do repositório no Github, depois em **[ <> Code ]**, então a URL ficará visível em uma caixa abaixo da aba HTTPS.
Nota: "Origin" é o nome dado ao repositório remoto, para que seja referenciado dentro do Git. Este nome pode ser qualquer valor, mas por padrão é usado "origin".

O segundo comando mostra a URL do repositório remoto conectado ao repositório atual.

# Salvando Alterações em um Repositório Local

Após um repositório ser clonado ou criado em uma pasta no computador, qualquer alteração dentro desta pasta será detectada pelo Git, e a partir daí, é possível adicioná-las ao versionamento através de alguns comandos.

#### Verificando o status das alterações

> git status

Mostra o status dos arquivos no repositório local. Este comando exibe quais arquivos estão na Staging Area ou não.
- Staging Area: A área de preparação do versionamento, onde os arquivos são adicionados para que possam então serem salvos em uma versão. Arquivos que não estão na Staging Area são chamados Untracked Files.
- Untracked files: Arquivos não rastreados pelo git, que estão na pasta local mas ainda não foram salvos em uma versão no repositório. Há várias maneiras que um arquivo pode ser considerado untracked: Um novo arquivo que foi criado, um arquivo existente que foi renomeado, um arquivo que foi alterado, um arquivo que foi deletado... Qualquer alteração realizada dentro da pasta onde o repositório se encontra é considerada Untracked até que seja adicionada na Staging Area.

#### Preparando as alterações para salvar

> git add [nome do arquivo]
> git add .

Comando responsável por adicionar arquivos à Staging Area do repositório. 
O primeiro comando adiciona o arquivo com o nome indicado em [nome do arquivo] para a Staging Area, enquanto o segundo adiciona todas as alterações existentes.

#### Salvando as alterações no repositório local

> git commit -m "[mensagem]" 

Rastreia os arquivos que se encontram atualmente na Staging Area, incluindo-os no repositório local como parte de uma nova versão. 
O modificador "-m" permite adicionar uma mensagem de descrição do commit, que é inserida em [mensagem] (entre aspas). Esta mensagem é exibida na página do Github ao acessar o commit, e também no próprio Git.

#### Casos especiais do rastreamento de alterações

O Git não reconhece pastas vazias dentro de um repositório. Caso uma pasta seja criada e não tenha arquivos dentro, ela não aparecerá no comando git status, nem será adicionada como parte das alterações.
Há uma convenção usada entre desenvolvedores para lidar com este caso, que consiste em criar um arquivo chamado .gitkeep dentro de pastas vazias, de modo que elas sejam reconhecidas e rastreadas pelo Git.

O arquivo .gitignore pode ser usado dentro de um repositório para informar ao Git uma lista de arquivos, extensões ou pastas que devem ser ignorados. Quaisquer arquivos ou pastas que coincidirem com algum item desta lista serão automaticamente ignorados pelo Git, não aparecendo no git status, nem sendo adicionados pelo git add.
Este arquivo é útil para impedir que o Git salve arquivos potencialmente indesejados publicamente, como arquivos que contém informações sensíveis.