# Manipulando Dados

### Alterando uma Tabela

O comando para alterar uma tabela é o comando **Alter Table**. Ele pode ser utilizado para realizar diversas alterações em uma tabela.

#### Adicionar uma Nova Coluna

Para adicionar uma coluna em uma tabela, o comando utilizado, dentro do Alter Table, é o comando `Add`.
```
ALTER TABLE [Tabela] ADD [Nome coluna] [Tipo Coluna]
ALTER TABLE Produtos ADD DataCadastro DATETIME2
```

No primeiro exemplo, `[Tabela]` é o nome da tabela que se deseja alterar, `[Nome Coluna]` é o nome da nova coluna a ser criada, e `[Tipo Coluna]` é o tipo de dado que será usado para a nova coluna.  
O segundo exemplo cria uma coluna DataCadastro para uma tabela de Produtos.

#### Apagar uma Coluna

O comando usado para apagar uma coluna em uma tabela é o `Drop Column`.
```
ALTER TABLE [Tabela] DROP COLUMN [Coluna]
ALTER TABLE Produtos DROP COLUMN DataCadastro
```

No exemplo acima, a `[Coluna]` deve ser uma coluna existente na tabela.

### Constraints

As **constraints** são restrições usadas para especificar regras para os dados de uma tabela. Essas regras podem ser usadas para limitar os tipos de dados que podem ser inseridos em uma tabela.  
As constraints podem ser adicionadas ao criar ou alterar uma tabela.

As constraints podem ser usadas para definir vários tipos de regras, dentre elas:
- **Not Null:** Não permite que o valor de uma coluna seja nulo.
- **Unique:** Garante que todos os valores da coluna sejam diferentes.
- **Primary Key:** Define a chave primária da tabela.
- **Foreign Key:** Define uma chave estrangeira para a tabela.

#### Primary Key

Define uma ou mais colunas como a **chave primária** da tabela. A chave primária é um valor exclusivo que identifica um registro de uma tabela, garantindo que aquele registro seja único dentro daquela tabela.  
Uma tabela pode possuir apenas uma Primary Key, que pode ser composta por uma ou mais colunas. Cada uma das colunas que a compõem são definidas como Not Null e Unique ao mesmo tempo.

O comando para definir uma Primary Key é:
```
CONSTRAINT [Nome da Constraint] PRIMARY KEY ([Colunas])
CONSTRAINT PK_Cliente PRIMARY KEY (Id)
CONSTRAINT PK_Venda PRIMARY KEY (IdCliente, IdProduto, DataVenda)
```

Onde `[Nome da Constraint]` é um nome usado para identificar a constraint no banco. Por convenção, o nome de uma Constraint de Primary Key é definido na forma "PK_Tabela". E as `[Colunas]` são todas as colunas que fazem parte da chave primária.  
O segundo exemplo cria uma chave primária para a tabela de cliente com o ID como identificador do cliente.  
O terceiro exemplo mostra uma tabela Venda com uma chave primária de 3 colunas: IdCliente, IdProduto e DataVenda. A chave primária pode conter quantas colunas forem necessárias para garantir a unicidade dos registros. (No caso, para que uma venda seja única, deve-se saber o seu cliente, o produto comprado e a data. Todos esses dados são necessários, caso contrário haveria registros com chaves duplicadas).

#### Foreign Key: 

A Foreign Key é uma **chave estrangeira**, que define uma coluna que é uma referência a outra tabela. Ela é usada para fazer o relacionamento entre tabelas.  
As colunas da Foreign Key possuem um valor que faz referência à Primary Key de outra tabela. A tabela que possui a Foreign Key é chamada de tabela filha, enquanto a que possui a Primary Key correspondente é a tabela pai.

O comando para definir uma Foreign Key é:
```
CONSTRAINT [Nome da Constraint] FOREIGN KEY ([Colunas da Tabela Filha])
REFERENCES [Tabela Pai]([Colunas da Tabela Pai])

CONSTRAINT FK_PessoaEndereco FOREIGN KEY (IdPessoa) 
REFERENCES Pessoa(Id)
```

Onde `[Nome da Constraint]` é um nome usado para identificar a constraint no banco. Por convenção, o nome de uma Constraint de Foreign Key é definido na forma "FK_TabelaPai_TabelaFilha". As `[Colunas da Tabela Filha]` são todas as colunas que fazem parte da chave estrangeira na tabela filha, enquanto `[Colunas da Tabela Pai]` são as colunas correspondentes na tabela pai.  
O segundo exemplo Define uma Foreign Key para uma tabela de Endereço, que faz referência a uma tabela de Pessoa.

### Built in Functinos

Essas são funções do sistema que já existem no banco de dados, e podem ser usadas para manipular os dados em uma tabela, realizando ações como contar, somar, tirar a média, e mais.

#### Função Count

A função **Count** conta quantas linhas existem na tabela baseado em uma condição. Ele é utilizado junto com o comando Select para retornar a quantidade de linhas baseado na condição.
```
SELECT COUNT([Coluna]) FROM [Tabela]
SELECT COUNT(*) FROM Produtos
SELECT COUNT(*) AS QuantidadeProdutos FROM Produtos
SELECT COUNT(*) AS QuantidadeProdutos FROM Produtos WHERE Tamanho = 'M'
```

No comando acima, `[Coluna]` se refere à coluna que se deseja contar na tabela `[Tabela]`. É possível passar uma coluna específica (que só é contada caso ela não seja nula), ou passar * para contar todos os registros, independente de terem colunas nulas.  
O segundo exemplo conta todos os registros da tabela Produtos, enquanto o terceiro faz a mesma operação, mas atribui um nome de exibição ao resultado, e o quarto retorna apenas os produtos que têm o valor "M" no tamanho.

#### Função Sum

A função **Sum** soma o valor numérico de todos os dados de uma coluna específica da tabela. Ele é utilizado junto com o comando Select, e precisa ter uma coluna especificada.
```
SELECT SUM([Coluna]) FROM [Tabela]
SELECT SUM(Preco) FROM Produtos
SELECT SUM(Preco) FROM Produtos WHERE Tamanho = 'M'
```

A `[Coluna]` se refere à coluna que se deseja somar os valores. O comando Sum não aceita o valor `*`, é obrigatório definir a coluna, e ela deve ser de um tipo de dados numérico.  
O segundo exemplo soma o valor do preço de todos os produtos, enquanto o terceiro soma o valor do preço dos produtos que têm tamanho "M".

#### Funções Min e Max

Essas funções são usadas para encontrar o valor máximo e mínimo de uma coluna em uma tabela. Elas são usadas junto com o Select, e devem receber uma coluna.
```
SELECT MAX([Coluna]) FROM [Tabela]
SELECT MIN([Coluna]) FROM [Tabela]
SELECT MAX(Preco) FROM Produtos
SELECT MIN(Preco) FROM Produtos
```

A `[Coluna]` é a coluna da qual se deseja retornar o valor. Assim como Sum, esses comandos não aceitam `*`. Porém, diferentemente do Sum, eles aceitam valores em texto. A função Max retorna o último texto da coluna, em ordem alfabética, enquanto a Min retorna o primeiro.  
O terceiro e quarto exemplos retornam o maior e menor preço, respectivamente.

#### Função Avg

Essa função é usada para encontrar o valor médio dos dados de uma coluna em uma tabela. Ela é usada junto com o Select, e deve receber uma coluna.
```
SELECT AVG([Coluna]) FROM [Tabela]
SELECT AVG(Preco) FROM Produtos
```
A `[Coluna]` é a coluna da qual se deseja retornar a média. Assim como Sum, o Avg não aceita `*`, e aceita apenas colunas com valores numéricos.

#### Concatenando Colunas

As colunas com valores de texto podem ser concatenadas de forma similar a como é feito na programação, utilizando o operador `+`.
```
SELECT Nome, Sobrenome FROM Cliente
SELECT Nome + ' ' + Sobrenome AS NomeCompleto FROM Cliente
```

O primeiro exemplo retorna o nome e o sobrenome separados, em colunas diferentes. O segundo exemplo retorna o nome e sobrenome como uma única coluna, contendo os dados das duas, separados por uma string `' '`.

#### Funções Upper e Lower

Essas funções são usadas com dados em texto, deixando-os em uppercase ou lowercase. 
```
SELECT UPPER([Coluna]) FROM [Tabela]
SELECT LOWER([Coluna]) FROM [Tabela]
SELECT UPPER(Nome) FROM Produtos
SELECT LOWER(Nome) FROM Produtos
```
A `[Coluna]` é a coluna na qual se deseja formatar os valores. Estas funções também não aceitam `*`. Mesmo que elas se apliquem apenas a tipos de texto, elas podem receber colunas de outros tipos, como números ou datas. O retorno nesse caso é o próprio valor da coluna sem alteração, já que números e símbolos não possuem maiúscula/minúscula.  
O terceiro e quarto exemplos retornam o nome do produto em uppercase e lowercase, respectivamente.

#### Função Format

A função **Format** pode ser usada para formatar datas, de forma muito semelhante à formatação de datas no C#.
```
SELECT FORMAT([Coluna], [Formato Desejadp]) FROM [Tabela]
SELECT FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm') FROM Produtos
```
No exemplo acima, a `[Coluna]` é a coluna de data que se deseja formatar, e o `[Formato Desejado]` é uma string de exemplo do formato desejado para a data, utilizando caracteres que representam os valores da data.  
O formato retornado pelo segundo comando é: `31/12/2023 23:59`

### Group By

O **Group By** é uma cláusula de agrupamento usada no comando Select. Ao utilizá-la, ela agrupa os registros pela coluna especificada, retornando uma linha por grupo de registros.  
Ele normalmente é utilizado junto de funções como Count, Sum, Avg, Min e Max para agrupar os dados.
```
SELECT [Colunas] FROM [Tabela] GROUP BY [Coluna]
SELECT Tamanho, COUNT(*) FROM Produtos GROUP BY Tamanho
```
No exemplo acima, as `[Colunas]` são as colunas que devem ser exibidas da `[Tabela]`, já a `[Coluna]` no final é a coluna pela qual os resultados devem ser agrupados.  
O segundo exemplo agrupa os produtos pelo tamanho, e conta quantos produtos há de cada tamanho.

### Ordem das Cláusulas

Uma instrução Select pode conter diversas cláusulas opcionais: Where, Group By e Order By. Essas cláusulas devem seguir uma ordem específica no comando:
```
SELECT [colunas]
FROM [Tabela]
WHERE [Condição]
GROUP BY [Coluna]
ORDER BY [Coluna]
```

### Join

Os **Joins** são comandos que permitem juntar tabelas diferentes em uma consulta, de forma a permitir retornar dados de várias tabelas em uma única consulta, utilizando as relações entre as tabelas, com base nas Foreign Keys.
```
SELECT [Colunas] FROM [Tabela]
INNER JOIN [Outra Tabela] ON [Foreign Key] = [Primary Key Correspondente]

SELECT * FROM Pessoas
INNER JOIN Enderecos ON Pessoas.Id = Enderecos.IdPessoa

SELECT Pessoas.Id, Pessoas.Nome, Endereco.Id FROM Pessoas
INNER JOIN Enderecos ON Pessoas.Id = Enderecos.IdPessoa

SELECT P.Id, P.Nome, E.Id FROM Pessoas P
INNER JOIN Enderecos E ON Pessoas.Id = Enderecos.IdPessoa
```

Onde `[Outra Tabela]` é uma tabela diferente da `[Tabela]` definida no Select. As tabelas utilizadas no Join *devem* ter algum tipo de relação, pois o Join utiliza a Foreign Key.  
Após o ON, a `[Foreign Key]` é a chave estrangeira da tabela filha e `[Primary Key Correspondente]` é a chave primária da tabela pai.

O segundo exemplo faz um join entre as tabelas de Pessoa e Endereço, retornando todas as colunas.  
O terceiro exemplo faz um join entre as mesmas tabelas, mas retorna apenas os IDs e o nome da pessoa. Ao definir as colunas para serem retornadas, é necessário identificar a tabela à qual cada coluna pertence, pois agora estamos trabalhando com mais de uma tabela.  
O quarto exemplo faz o mesmo Join do terceiro, mas define um apelido para as tabelas para facilitar a escrita do Join.