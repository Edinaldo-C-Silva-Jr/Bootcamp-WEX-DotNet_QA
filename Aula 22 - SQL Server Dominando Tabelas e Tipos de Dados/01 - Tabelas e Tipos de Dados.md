# Entendendo o Banco de Dados

### Linguagem SQL

Structured Query Language (SQL) é a linguagem do banco de dados usada para fazer consultas e manipulação de dados.  
Para trabalhar com um banco de dados, é necessário fazer os comandos utilizando a linguagem SQL. Quase todos os bancos de dados relacionais utilizam a linguagem SQL, mesmo que o seu DBMS seja diferente.  
A linguagem SQL é uma linguagem de alto nível, com comandos relativamente intuitivos, escritos em inglês.

Os comandos SQL são divididos em 5 categorias:
- **DDL** (Data Definition Language): Create, Drop, Alter, Truncate
- **DCL** (Data Control Language): Grant, Revoke
- **DML** (Data Manipulation Language): Insert, Update, Delete
- **TCL** (Transaction Control Language): Commit, Rollback, Save Point
- **DQL** (Data Query Language): Select

Os comandos mais utilizados e suas funções são:
- **Create**: Cria uma tabela.
- **Drop**: Apaga uma tabela.
- **Alter**: Altera a estrutura de uma tabela.
- **Insert**: Insere dados em uma tabela.
- **Update**: Atualiza dados em uma tabela, podendo alterar uma ou mais colunas.
- **Delete**: Deleta dados da tabela.
- **Select**: Seleciona alguns dados para serem buscados na tabela, com a possibilidade de passar alguma regra para filtrar os resultados.

### Databases

A database é uma coleção de dados estruturados e agrupados de forma concisa. A database é composta por tabelas, procedures, views, dentre outras estruturas. Cada database é um banco de dados completo e funcional, que possui a sua estrutura, suas tabelas, seus dados armazenados, e pode ser utilizada em sistemas diferentes.

Um DBMS pode abrir e gerenciar várias databases (assim como uma IDE pode abrir vários aplicativos diferentes). Ao se conectar a um banco de dados, é necessário identificar qual database será utilizada para realizar as operações.

### Acessando o Banco de Dados

O SQL Server possui dois programas:
- SQL Server Management Studio (SSMS)
- SQL Server Configuration Manager

O programa Configuration Manager é o responsável por gerenciar o banco de dados e suas configurações.  
O SQL Server, ao ser instalado, é configurado para iniciar automaticamente ao ligar o computador, mas ele pode ser alterado para iniciar manualmente. Com isso, ele pode ser parado e iniciado conforme é utilizado. Ao ser alterado para manual, é necessário ir no Configuration Manager e escolher "Iniciar" ao utilizá-lo (e depois pará-lo ao terminar).

O programa Management Studio é o responsável por acessar e interagir com o banco de dados. Esse programa é necessário para que um usuário possa executar comandos, alterar o banco de dados, inserir ou remover dados, e qualquer outra interação que seja feita diretamente com o banco. Sem o Management Studio, o banco de dados ainda pode ser instalado no computador, mas ele só pode ser acessado através de aplicações, que executam comandos diretamente nele.  
Ao abrir o Management Studio, é necessário conectar ao banco de dados. Em uma instalação local, o usuário atual é definido como administrador, e pode acessar o SSMS usando a autenticação do Windows.

### Criando uma Database

É possível criar uma nova database clicando com o botão direito na pasta "Databases" no Object Explorer do Management Studio, e então em "New Database". Depois só é necessário fornecer um nome para a database.  
Após criá-la, a database aparece na pasta Databases, e todos os seus membros podem ser acessados através dela.

A database atual é exibida numa lista no topo da tela. Deve-se sempre garantir estar conectado à database desejada antes de iniciar uma consulta.

OS comandos SQL não são case sensitive, portanto eles podem ser utilizados independente do case. Porém, no SQL, é uma convenção escrever os comandos reservados em uppercase, e escrever em case normal apenas os nomes de tabelas, colunas e dados.

### O Comando Select

O comando **Select** faz uma pesquisa na tabela, retornando os dados que satisfazem a condição (ou retornando todos os dados caso não haja condição para a pesquisa).  
A sintaxe do comando é:
```
SELECT [Colunas] FROM [Tabela]
SELECT Nome, Email FROM Clientes
SELECT * FROM Clientes
```

Onde `[Colunas]` é o nome das colunas desejadas e `[Tabela]` é a tabela na qual se deseja pesquisar os dados.  
É possível selecionar colunas específicas, passando o nome das colunas separados por vírgula, como visto no segundo comando, que só retornará o nome e o e-mail do cliente. O terceiro comando utiliza um `*` para informar que devem ser retornadas todas as colunas.

Esse comando retorna uma tabela (matriz) com todos os dados encontrados. Essa matriz é apenas uma representação visual dos dados, e não pode ser utilizada para alterar dados ou a tabela diretamente.

Junto com o comando Select, é possível passar diversas cláusulas para alterar a maneira que os dados são exibidos.

#### Ordenando os Dados

A cláusula `Order By` ordena os valores retornados de acordo com uma coluna, que pode ser em ordem crescente `(ASC)` ou decrescente `(DESC)`.
```
SELECT * FROM Clientes ORDER BY Nome
SELECT * FROM Clientes ORDER BY Sobrenome DESC
SELECT * FROM Clientes ORDER BY Nome, Sobrenome
```
O primeiro comando retorna os registros ordenados pelo Nome. O segundo retorna os registros ordenados pelo sobrenome, em ordem decrescente. O terceiro retorna os registros ordenados pelo nome, e depois pelo sobrenome.

#### Filtrar os Dados

A cláusula `Where` pode ser utilizada para passar uma condição de filtro para os dados, com isso são retornados apenas os dados que se encaixam no filtro determinado.
```
SELECT * FROM Clientes WHERE Nome = 'Adam'
SELECT * FROM Clientes WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds'
```
O primeiro comando só retorna registros onde o nome é *Adam*, enquanto que o segundo retorna registros com nome *Adam* e sobrenome *Reynolds*.  
A palavra `AND` retorna apenas os registros que se adequam às duas condições. Também existe a palavra `OR`, que retorna os registros que se adequam a qualquer uma das duas condições.
```
SELECT * FROM Clientes WHERE Nome LIKE 'G%'
SELECT * FROM Clientes WHERE Nome LIKE '%g'
SELECT * FROM Clientes WHERE Nome LIKE '%g%'
```

A palavra `LIKE` faz uma busca parcial, que não precisa ser exatamente igual ao formato indicado. O sinal de `%` é usado para ignorar qualquer caractere naquela posição do texto.  
O primeiro comando retorna nomes que começam com G, o segundo retorna qualquer nome que termine com g, já o terceiro retorna qualquer nome que contenha a letra g.

### O Comando Insert

O comando **Insert** é usado para inserir registros em uma tabela. Ele insere os registros com base nas colunas, sendo necessário passar os dados para inserir em cada coluna.
```
INSERT INTO [Tabela] VALUES ([Valores])
INSERT INTO Clientes VALUES ('João', 'Da Silva', 'exemplo@email.com', 0, '31-12-2023 23-59')
INSERT INTO [Tabela] ([Colunas Desejadas]) VALUES ([Valores])
INSERT INTO Clientes (Nome, Sobrenome) VALUES ('João', 'da Silva')
INSERT INTO Clientes (Sobrenome, Nome) VALUES ('da Silva', 'João')
```

No primeiro comando, a `[Tabela]` representa a tabela em que se deseja inserir os dados. Os valores a ser inseridos são passados para o comando dentro de `[Valores]`, sendo separados por vírgula, seguindo a mesma ordem das colunas da tabela. Como este comando não especifica a coluna, a inserção deve ser feita em todas as colunas da tabela. O segundo comando mostra um exemplo dessa inserção, onde são inseridos dados para todas as colunas.  
O terceiro comando é uma outra maneira de fazer o Insert, que permite escolher quais colunas serão atualizadas. As `[Colunas Desejadas]` são as colunas da tabela nas quais os dados serão inseridos. Ao fazer um Insert, não é necessário inserir dados em todas as colunas. Portanto, ao passar as colunas desejadas, é possível inserir dados em apenas colunas específicas da tabela.  
Quando as colunas são passadas ao comando, elas não precisam estar na ordem em que aparecem na tabela. Os valores passados devem obedecer a ordem definida **no comando**.  
O quarto e quinto comandos mostram duas maneiras de inserir nome e sobrenome na tabela Cliente, invertendo a ordem das colunas.

#### ID

A coluna **ID** é o identificador único do registro da tabela, normalmente utilizado como *Primary Key*. Este é um valor que não pode se repetir, e é utilizado para garantir a unicidade daquele registro na tabela.  
A tabela pode ser configurada para que o ID seja um campo *Identity*, que incrementa automaticamente a cada inserção de dados. A coluna, ao ser configurada como Identity, é gerenciada pelo próprio banco de dados, sem a necessidade de inserir dados nela.

### O Comando Update

O comando **Update** é usado para alterar o valor de um ou mais registros. Ele é utilizado para alterar qualquer um dos valores existentes no registro, podendo alterar várias colunas de uma vez.  
O comando Update funciona fazendo uma pesquisa nos registros, assim como o Select, assim é importante que ele seja feito com uma condição com a cláusula **Where**, assim filtrando apenas os registros em que se deseja realmente fazer alterações.

Para atualizar apenas um registro, a melhor maneira é utilizar o comando com um filtro pelo ID do registro, pois o ID é um valor único, então ele garante que apenas um registro será atualizado.
```
UPDATE [Tabela] SET [Coluna = Valor] WHERE [Condição]

UPDATE Clientes 
SET Email = 'novoemail@email.com', AceitaComunicados = 0
WHERE Id = 1
```
No primeiro exemplo, a `[Tabela]` é a tabela onde se deseja atualizar o registro. Na linha `[Coluna = Valor]`, as colunas devem ser definidas, atribuindo o novo valor desejado. Caso haja mais de uma coluna, elas devem ser separadas por vírgula. E a `[Condição]` é o filtro aplicado para a atualização.  
O segundo comando mostra um exemplo onde as colunas Email e AceitaComunicados foram alteradas para o registro de ID 1.

#### Cuidados com o Update

O Update é aplicado assim que é executado, e ao terminar ele não pode ser desfeito. Com isso, ele pode ser extremamente destrutivo!  
Um Update feito com um filtro incorreto pode acabar alterando registros indesejados, bagunçando completamente os dados de um banco. E caso seja feito sem filtro, ele altera **todos os registros da tabela**.  
Assim é de **extrema importância** que ele seja feito sempre com um filtro adequado!

### O Comando Delete

O comando **Delete** é usado para deletar um registro em uma tabela.  
Assim como o comando Update, ele funciona fazendo uma pesquisa nos registros, deletando todos os registros encontrados. Assim, também é importante que ele seja feito com uma condição com a cláusula **Where**, para filtrar os dados para serem excluídos. 
```
DELETE FROM [Tabela] WHERE [Condição]
DELETE FROM Clientes WHERE Id = 1
```
Nos exemplos acima, `[Tabela]` é a tabela de onde se deseja deletar o registro, e a `[Condição]` é o filtro aplicado para a exclusão.  
No segundo comando, é deletado o registro de ID 1 da tabela de Clientes.

#### Cuidados com o Delete

Assim como o Update, o Delete é aplicado ao executar e não pode ser desfeito. Com isso, ele pode ser ainda mais destrutivo que o Update!  
Um filtro incorreto pode levar a dados sendo apagados erroneamente, e caso o Delete seja feito sem filtro, **todos os dados da tabela são apagados**.  
Assim é de **extrema importância** que ele seja feito sempre com um filtro adequado!

### Criação de Tabela

Para criar uma tabela, é utilizado o comando **Create Table**, junto com o nome da tabela. Dentro do comando, são definidas as colunas da tabela, com o seu nome e tipo de dado.
```
CREATE TABLE [Tabela]
(
	[Nome da Coluna] [Tipo de Dado] [Modificadores]
)
```

No comando acima, `[Tabela]` é o nome da tabela que se deseja criar. `[Nome da Coluna]` é o nome que identifica uma coluna dentro da tabela. `[Tipo de Dado]` é o tipo de dado que poderá ser armazenado naquela coluna. `[Modificadores]` são cláusulas que afetam o comportamento e as validações da coluna. Existem vários tipos de modificadores, alguns dos principais são:
- **Nulidade**: Define se aquela coluna pode ser `Null` ou `Not Null`. Uma coluna não nula deve obrigatoriamente receber algum dado em um Insert.
- **Identity**: O modificador `Identity` indica que essa coluna será uma coluna de identidade da tabela, e o banco de dados irá gerenciá-la, incrementando seu valor automaticamente a cada inserção de registro. Esse modificador recebe dois parâmetros: o valor inicial, e o valor de incremento.

#### Tipos de Dados em SQL

Os tipos de dados mais utilizados no SQL são:

- **Char(n):** Texto com uma quantidade fixa de caracteres. Pode ter até 8000 caracteres.
- **Varchar(n):** Texto com quantidade variável de caracteres. Pode ter até 8000 caracteres.
- **Bit:** Valor inteiro que pode ser 0 ou 1 (valor booleano).
- **Tinyint:** Valor numérico inteiro que pode armazenar de 0 a 255.
- **Smallint:** Valor numérico inteiro que pode armazenar de -2^15 a 2^15.
- **int:** Valor numérico inteiro que pode armazenar de -2^31 a 2^31.
- **Bigint:** Valor numérico inteiro que pode armazenar de -2^63 a 2^63.
- **Decimal(p,s) / Numeric(p,s):** Valor numérico decimal que pode armazenar de -10^38 a 10^38. O parâmetro `p` define a quantidade de dígitos, de 0 a 38, e o parâmetro `s` define a quantidade de dígitos depois da vírgula, de 0 a `p`.
- **Float(n):** Valor numérico decimal que pode armazenar de -1.79 * 10^308 a 1.79 * 10^308.
- **Datetime:** Valor de data que pode armazenar desde `01/01/1753` a `31/12/9999`, com precisão de 3.33 milissegundos.
- **Datetime2:** Valor de data que pode armazenar desde `01/01/0001` a `31/12/9999`, com precisão de 100 nanossegundos.
- **Date:** Valor de data equivalente ao Datetime2, sem armazenar horário.
- **Time:** Valor de horário equivalente ao Datetime2, sem armazenar data.