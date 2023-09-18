# Configurando o Git
Todos os comandos devem ser utilizados no Git Bash.
### git config
Mostra informações e permite alterar configurações no Git.
O comando git config pode ser utilizado com três locais diferentes, que decidem onde as configurações serão aplicadas: 
- "-- system" - A configuração se aplica a todos os usuários do sistema
- "-- global" - A configugação se aplica a todos os repositórios do usuário atual
- "-- local" - A configuração se aplica ao repositório atual

#### Username e email
> git config --global user.name [nome]
> git config --global user.email [email]

Estes comandos configuram o nome de usuário e o email que aparecerão nos commits feitos pelo usuário, utilizando os valores inseridos em [nome] e [email]
> git config user.name
> git config user.email

Estes comandos retornam o valor configurado do nome e do email
> git config init.defaultBranch
> git config --global init.defaultBranch [nome da branch]

O primeiro comando retorna o nome da branch padrão criada pelo Git ao iniciar um novo repositório. O segundo muda o nome da branch padrão para o nome inserido em [nome da branch], ele foi utilizado com o local "--global", portanto se aplica a todos os repositório do usuário atual.
> git config --list
> git config --global --list

Mostra todas as configurações atuais. O primeiro comando mostra para todos os locais, o segundo apenas as configurações globais.