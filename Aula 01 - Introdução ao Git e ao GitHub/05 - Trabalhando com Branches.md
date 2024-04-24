# Trabalhando com Branches

#### O que é uma branch?

Uma branch é uma "realidade paralela" de um repositório, que permite trabalhar de forma independente da branch principal, de maneira que as alterações feitas nela não afetam o que já existe na branch principal.  
A branch é um ponteiro móvel para um commit do repositório. Ela aponta para um commit específico e tem seu histórico partindo daquele commit. Assim cada branch pode ter seu próprio histórico de commits, de forma que os novos commits gerados dentro de uma branch não afetam as outras branches do repositório.

Quando uma branch é criada a partir de outra existente, ela começa apontando para o último commit da branch usada para criá-la, portando ela possui todo o versionamento feito na branch original até o momento da criação.  
Usando o comando git log, é possível ver para quais commits cada branch está apontando no momento.

#### Criando uma Branch
```
git checkout -b [nome da branch]
```

Cria uma nova branch, com o nome definido em [nome da branch], e troca a área de trabalho para usar a nova branch criada.

#### Trocando de Branch
```
git checkout [nome da branch]
```

Troca a área de trabalho atual para a branch com o nome [nome da branch], aplicando todas as alterações contidas nela nos arquivos.

#### Informações Sobre Branches
```
git branch  
git branch -v
```

O primeiro comando lista todas as branches existentes no repositório atual.  
O segundo comando, com o modificador `-v`, também lista todas as branches do repositório, mas também exibe qual foi o último commit realizado em cada uma delas, mostrando o hash curto e a mensagem do commit.

#### Mesclar Duas Branches
```
git merge [nome da branch]
```

Mescla todo o conteúdo da branch de nome [nome da branch] com a branch atual. Com isso, todos os commits feitos na branch [nome da branch], com seus arquivos e alterações, são aplicados e salvos na branch atual.

#### Deletar uma Branch
```
git branch -d [nome da branch]
```

Este comando deleta a branch com o nome [nome da branch], exclundo todas as alterações contidas que não fazem parte de outras branches.

# Conflitos que podem ocorrer com branches

#### Conflito de Merge

Um conflito de merge acontece quando há alterações concorrentes em duas branches, ou seja, alterações diferentes feitas na mesma linha de código de um arquivo. Ao tentar enviar as alterações de uma branch para a outra, há um conflito pois o Git não sabe quais das alterações devem ser mantidas.  
Quando ocorre um erro de merge, o Git deixa para o usuário a responsabilidade de decidir qual das alterações manter.

Esse tipo de conflito pode ocorrer ao fazer um merge das alterações em branches diferentes, ou ao fazer um git push para o repositório remoto, caso outra alteração tenha sido enviada a ele anteriormente. No momento do merge, o Git aponta que não é possível fazê-lo pois há alterações que não estão presentes no repositório local.

Para reparar o erro, é necessário fazer um git pull para puxar as alterações existentes no repositório remoto, com isso o arquivo afetado será retornado com ambas as alterações conflitantes. Então o usuário pode decidir quais alterações devem ser mantidas, editando o arquivo afetado para indicar ao Git o que deve ser mantido, e depois dando um commit e push para salvar a resolução do conflito.

Ao usar o comando git status, é possível ver algumas informações sobre o conflito de merge, além de algumas sugestões do que deve ser feito.

# Outros comandos úteis

#### Baixar Alterações do Repositório Remoto

O comando git pull é a junção de dois comandos: git fetch, que baixa as alterações, e git merge, que mescla com a branch atual.  
Porém, é possível também realizar esses comandos separadamente.
```
git fetch origin master
```

Este comando baixa as alterações presentes no repositório remoto (origin/master), mas não mescla com a branch atual, apenas as deixa disponíveis no repositório remoto como uma branch separada, assim é possível ver as alterações existentes nele antes de mesclar.

#### Verificar as Diferenças Entre Duas Branches
```
git diff [nome da branch] [nome da outra branch]  
git diff master origin/master
```

Este comando mostra as diferenças entre o conteúdo de duas branches, identificadas pelos valores [nome da branch] e [nome da outra branch].  
O segundo comando é um exemplo, que compara o conteúdo da branch principal local com a branch principal remota.

#### Clonar Apenas uma Branch
```
git clone [URL] --branch [nome da branch] --single-branch
```

Clona o conteúdo do repositório remoto contido na url [URL], mas apenas o conteúdo existente na branch [nome da branch].  
Se o nome da branch não for indicado, o conteúdo será clonado apenas da branch principal