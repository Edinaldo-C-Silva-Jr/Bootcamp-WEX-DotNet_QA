# Banco de Dados

Bancos de dados estão sempre presentes em sistemas, pois são utilizados para armazenar informações.  
Um desenvolvedor precisa saber como manipular e inserir informações em um banco de dados usando a linguagem de programação, fazendo uma integração entre o código e o banco de dados.

### Introdução ao Banco de Dados

Todo sistema precisa armazenar e manipular dados.  
Um banco de dados é o local onde esse armazenamento normalmente é feito. Ele é um software que armazena os dados de forma estruturada, organizando-os de uma forma que eles possam ser recuperados depois, com eficiência e rapidez.

Os dados de um banco de dados são armazenados de forma permanente, diferente da memória de um aplicativo, que é apagada quando o aplicativo se encerra.  
O banco de dados é um repositório central de dados que pode ser acessado por diversos sistemas, como sistemas em Desktop, em Nuvem, Web, APIs, dentro outros.

Os bancos de dados são sistemas muito robustos, que tralham de forma inteligente e segura. Ele deve garantir que todas as requisições feitas de diversas fontes sejam atendidas rapidamente, e ele também possui ferramentas de segurança e controle de acesso, para garantir que somente usuários autorizados acessem as informações.

### Tipos de Banco de Dados

#### Banco de Dados Relacional

O tipo de banco de dados mais usado atualmente.  
Em um banco de dados relacional os dados são armazenados através de tabelas, com colunas e linhas que se relacionam. Uma tabela define uma entidade de dados, um objeto ou entidade da vida real que possui diversas características ou tipos de dados que devem ser armazenados.  
Os dados em um banco de dados relacional são estruturados. Cada tabela possui uma estrutura rígida, predefinida, que deve ser seguida para que se possa armazenar dados dentro dessa tabela.  
Cada registro deve seguir as colunas definidas na estrutura da tabela, e os dados devem seguir o tipo definido para cada coluna.

Os dados são representados em forma de matriz, onde as colunas identificam um tipo de dados, um atributo ou caracterísitca daquela entidade, e as linhas armazenam um registro de dados inserido no banco, com cada célula representando o conteúdo daquele registro para o tipo de dado da coluna correspondente. As tabelas são semelhantes a uma planilha do Excel.

Em um banco de dados relacional, como o próprio nome já diz, as tabelas se relacionam entre si. Duas tabelas que se relacionam representam objetos que pertecem a ou possuem outros objetos. Duas tabelas que se relacionam devem possuir uma coluna de referência que aponta para a outra, o que permite facilitar a consulta dos dados.

Exemplos de bancos de dados relacionais: SQL Server, Oracle, MySQL.

#### Banco de Dados Não Relacional

Um banco de dados não relacional é um banco de dados onde as informações não são armazenadas em tabelas. Os dados são armazenados de forma não estruturada ou semiestruturada:
- Semi-Estruturados: Os dados são armazenados seguindo uma estrutura, mas sem regras rígidas. O valor armazenado em uma mesma coluna pode ser de mais de um tipo, um registro pode armazenar um texto, enquanto outro armazena um dado numérico. As colunas também podem ser adicionadas ou removidas em um registro sem afetar os outros. Um exemplo de dados semi-estruturados é um arquivo JSON.
- Não Estruturados: Os dados são armazenados na sua forma bruta, sem nenhum tipo de regra ou padrão. Os dados são armazenados da forma que se encontram. Como por exemplo, arquivos de texto, arquivos de música, posts de redes sociais.

Os bancos não relacionais, por não terem regras rígidas, podem armazenar e recuperar dados de forma mais rápida que um banco relacional. Eles podem ser usados para armazenar dados em grandes quantidades ou com bastante flexibilidade.

Exemplos de bancos de dados não relacionais: MongoDB

# Database Management System (DBMS)

O DBMS é um software utilizado para acessar, manipular e monitorar um banco de dados de forma visual.

O banco de dados é um software que funciona sozinho, e consegue armazenar, retornar e gerenciar dados de forma independente. Ele é um programa que funciona apenas internamente, não existe uma tela ou uma interface para que um usuário ou administrador possa interagir com ele e manipular suas informações. Ele é feito para interagir apenas com sistemas e aplicações, de forma independente.
 
O DBMS, por sua vez, é um software que permite ao seu usuário acessar um banco de dados. Ele permite que o banco de dados seja acessado de forma direta por uma pessoa, um desenvolvedor, sem que seja acessado através de um sistema ou aplicação.  
O DBMS fornece uma interface visual para interagir com o banco de dados. Ele é o equivalente de uma IDE para os bancos de dados.

Cada banco de dados possui seu próprio DBMS.  
O do SQL Server é conhecido como SQL Server Management Studio.