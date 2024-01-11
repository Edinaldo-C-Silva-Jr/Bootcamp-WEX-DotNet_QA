
# Estrutura de um Projeto Console no .NET

Um projeto em C# é composto por uma estrutura de pastas e arquivos.  
Ao criar um novo projeto de console, são criados *duas pastas* e *dois arquivos*.

Os arquivos são:
- **Program.cs:** Um arquivo .cs é um arquivo de classe do C#, onde se escreve o código dos aplicativos. O nome do arquivo normalmente corresponde ao nome da classe implementada dentro dele. O nome "Program" é o nome padrão da classe que inicia a execução do programa em .NET, essa classe sempre possui um método *public static void main*, que é o ponto de entrada da aplicação.  
- **[Nome do projeto].csproj:** Um arquivo .csproj é o arquivo de projeto do C#, que contém informações descritivas do projeto (metadados). Esse arquivo utiliza a linguagem XML para armazenar esses metadados.
Os metadados do projeto incluem: o SDK usado, o tipo de saída do projeto (um arquivo .exe ou .dll), a versão do .NET sendo utilizada, dentre outros.

As pastas são:
- **obj**: Pasta que contém os arquivos referentes ao debug do projeto, contendo diversas informações sobre a compilação do projeto.  
- **bin**: A pasta de arquivos binários, onde ficam os arquivos compilados do projeto.

Há também a **solution**, que é um agrupamento de projetos, e pode ser criada automaticamente dependendo da IDE utilizada.

As pastas obj e bin são pastas de configuração e binários. Elas são geradas automaticamente pelo .NET ao compilar o projeto, portanto elas não precisam ser salvas com o projeto para guardá-lo. Apenas os arquivos são necessários.

# Classe

Uma classe é um conceito fundamental da programação orientada a objetos.

A classe é uma abstração de um objeto. Ela representa um objeto do mundo real dentro da programação, para que se possa usar seus atributos (características) e métodos (ações) na aplicação.  
A classe representa a construção do objeto. Ela é um molde que define os dados necessários para que aquele objeto exista, além das ações que aquele objeto pode executar. O objeto é uma implementação daquela classe, com seus dados especificados para que possa ser utilizado no programa.

Ao criar uma abstração de um objeto, é importante representar apenas o que será utilizado no sistema, para não poluir o software.  

**Exemplo**: Ao utilizar uma pessoa em um sistema, podemos abstrair a pessoa em uma classe.
> Classe: Pessoa
> Atributos: Nome, Idade
> Métodos: Apresentar

# Entendendo a Estrutura do Código

### Classes

Uma **classe** no C# é representada pela palavra "class", seguida do nome da classe. Por convenção, o nome da classe começa sempre com letra maiúscula.

```
public class Pessoa
```

O C# define o escopo do código através de chaves { }  
O código de uma classe, método ou estrutura sempre começa ao abrir chaves e termina ao fechar estas mesmas chaves. Um programa pode conter diversas estruturas de chaves, umas dentro das outras, então é importante saber quais chaves correspondem umas com as outras. O Visual Studio mostra uma linha que define qual parte do código está dentro de uma estrutura de chaves.

Os **atributos** são variáveis definidas no escopo da classe, que ficam disponíveis por toda a estrutura da classe. Esses atributos são definidos como uma variável, e devem ter o seu tipo definido na sua declaração. Por convenção, o nome de atributos de uma classe começa com letra maiúscula.

```
public string Nome
public int Idade
```

Os **métodos**, ou funções, são uma estrutura de código que realiza uma ação dentro da classe. Os métodos sempre possuem parêntesis () na frente de seu nome, tanto ao serem definidos como ao serem usados. Esses parêntesis representam que esse método é uma ação, e também servem para passar parâmetros (valores) para ele.

```
public void Apresentar()
{
	Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
}
```

### Namespaces

Um namespace é um agrupamento de classes. O namespace é uma maneira de organizar o projeto, colocando classes similares dentro de um mesmo grupo.  
Toda classe é identificada pelo nome da namespace à qual ela pertence junto do nome da própria classe. Para poder usar uma classe, o código atual deve estar dentro da namespace onde aquela classe está contida, ou ter uma referência à namespace que contém a classe no código.  
Esta referência pode ser feita de duas maneiras:
- No nome da própria classe. Esse tipo de referência é feito utilizando um ponto entre o nome da namespace e o nome da classe. A referência deve ser utilizada toda vez que a classe for usada no código:  
```
NamespacePessoa.ClassePessoa objetoPessoa = new NamespacePessoa.ClassePessoa();
```
- No topo do código com a palavra "using".
```
using NamespacePessoa;
ClassePessoa objetoPessoa = new ClassePessoa();
```

### Objeto - Instância de uma Classe

Uma classe é um molde para a criação de um objeto.  
O objeto é uma implementação física da pessoa, que possui dados definidos dentro do programa e ocupa espaço na memória. O objeto é criado na memória do computador ao instanciar a classe, seguindo o molde definido pela classe.  
Para instanciar uma classe, é necessário criar uma variável com o tipo da própria classe, então chamar o método construtor da classe, que cria os dados necessários para o objeto. O método construtor deve ser um método com o mesmo nome da classe.
```
	Pessoa pessoa1 = new Pessoa();
```

A partir do momento que o objeto é instanciado e existe na memória, ele pode ter suas informações manipuladas. Como por exemplo, é possível atribuir ou resgatar os valores dos seus atributos, ou utilizar os seus métodos.
```
pessoa1.Nome = "João";
pessoa1.Idade = 30;
	
pessoa1.Apresentar();
```

# Convenções

Convenções são regras de utilização e nomenclatura definidas pela comunidade de uma tecnologia. Elas são regras que existem para facilitar a escrita, o entendimento e a manutenção do código.
As convenções não são regras definidas na própria linguagem, portanto não utilizá-las não impede que o programa funcione. Um código escrito sem nenhuma convenção ainda roda sem problemas, porém é mais difícil de entender.

Cada linguagem de programação tem sua própria comunidade e suas próprias convenções. É importante conhecer as convenções de cada linguagem ao programar nelas.

### Convenções Case

Os cases são padrões de escrita usados nas nomenclaturas de vários elementos da programação, como classes, métodos, atributos e variáveis. Estes padrões são usados para tornar o código mais legível e fácil de entender.

Segue alguns exemplos de cases utilizados em programação:
- **camelCase**: a primeira palavra do nome começa com letra minúscula, e depois as demais palavras começam com letra maiúscula.
- **PascalCase**: Todas as palavras começam com maiúscula
- **snake_case**: Todas as palavras começam com minúscula, mas há um underline _ entre cada palavra
- **spinal-case**: Similar ao snake case, mas utiliza um traço - em vez de um underline

Os cases mais utilizados em C# são o camel case e o pascal case.

#### Cases no Código

Essas são as convenções de código utilizadas no C#:
- Nomes de classe sempre utilizam o PascalCase
- Nomes de propriedade utilizam PascalCase
- Nomes de métodos utilizam o PascalCase
- Nomes de variáveis utilizam o camelCase

### Convenções de Escrita em Classes e Variáveis

- Uma convenção do C# é não abreviar o nome de classes, atributos ou variáveis. Os nomes devem ser escritos por extenso, mesmo que sejam nomes grandes. Isso facilita o entendimento do código.
- Outra convenção é que um arquivo de classe tenha sempre o mesmo nome da classe que ele implementa
- O C# não aceita caracteres especiais dentro do nome de variáveis. A única exceção é o underline _
