
# Tupla

A tupla permite agrupar vários elementos de dados de tipos diferentes em uma única variável. A tupla não é uma coleção em si, mas ela pode conter uma coleção.

A tupla pode ser declarada utilizando o struct `ValueTuple`, passando para ele os tipos de dados que se deseja armazenar:
```
ValueTuple<int, string, string> variavelTupla = (1, "João", "da Silva");
```

Outra maneira de declarar uma tupla é declarando os tipos de dados desejados entre parêntesis:
```
(int, string, string) variavelTupla = (1, "João", "da Silva");
```

Para utilizar a tupla, pode-se utilizar o nome da variável, e então definir, através do operador ponto `.`, qual dos itens deve ser acessado.
```
Console.WriteLine($"ID: {variavelTupla.item1}");
Console.WriteLine($"Nome: {variavelTupla.item2}");
Console.WriteLine($"Sobrenome: {variavelTupla.item3}");
```
A declaração entre parêntesis possui a vantagem de permitir nomear os itens da tupla, assim ao acessá-los, podemos identificar o dado através do nome:
```
(int Id, string Nome, string Sobrenome) variavelTupla = (1, "João", "da Silva");
Console.WriteLine($"ID: {variavelTupla.Id}");
Console.WriteLine($"Nome: {variavelTupla.Nome}");
Console.WriteLine($"Sobrenome: {variavelTupla.Sobrenome}");
```

### Tuplas em Métodos

Um método normalmente só retorna um tipo de informação, que é definido na assinatura do método.  
Para retornar mais de um tipo de informação, é possível utilizar uma tupla, definida na própria assinatura do método, para que ela seja retornada no método através da instrução Return.
```
> public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
{
	try
	{
		string[] linhas = File.ReadallLines(caminho);
		return (true, linhas, linhas.Count());
	}
 	catch (Exception)
	{
		return (false, new string[0], 0);
	}
}
```

### Descartes

Ao utilizar uma tupla, nem sempre precismaos utilizar todos os valores que ela retorna.  
Nesta situação onde uma informação não é utilizada, é possível descartar essa informação, utilizando um underline `_` no lugar dessa informação no retorno.
```
LeituraArquivo arquivo = new LeituraArquivo();
(bool Sucesso, string[] Linhas, _) = arquivo.LerArquivo("Arquivos/Texto.txt");
```
Neste exemplo, a informação QuantidadeLinhas foi descartada, portanto o método não a retorna.

### Desconstrutor

O desconstrutor é um método que separa as informações contidas em um objeto em variáveis distintas. Ele "desconstrói" o objeto, transformando ele em informações separadas.  
O desconstrutor é uma operação inversa ao construtor: enquanto o construtor recebe parâmetros e os encapsula em uma classe, o desconstrutor pega as propriedades da classe e as retorna em parâmetros de saída.

O desconstrutor é declarado dentro de uma classe, nomeando o método como "Deconstruct". Cada um dos parâmetros dele devem ser declarados com a palavra "out" antes do tipo do dado.
```
public class Pessoa
{
	private string Nome; { get; set; }
	private string Sobrenome; { get; set; }
	
	public Pessoa(string nome, string sobrenome)
	{
		this.Nome = nome;
		this.Sobrenome = sobrenome;
	}
	
	public void Deconstruct(out string nome, out string sobrenome)
	{
		nome = this.Nome;
		sobrenome = this.Sobrenome;
	}
}
```
O desconstrutor pode ser chamado de forma semelhante à declaração de uma tupla:
```
Pessoa p1 = new Pessoa("João", "da Silva"); // Construtor
(string nome, string sobrenome) = p1; // Desconstrutor
```

# If Ternário

O If Ternário é uma sintaxe alternativa para fazer um if, que obrigatoriamente precisa ser um if - else.  
Esse é um tipo de sintaxe para if mais concisa, e pode ser utilizada em ifs com expressões e blocos de instruções simples. O If Ternário pode representar um if em menos linhas de código, pois ele não utiliza a estrutura padrão de chaves.  
A sintaxe do if ternário é `[condição] ? [resultado do if] : [resultado do else]`
```
Console.WriteLine($"O número {numero} é " + (numero % 2 ? "par" : "ímpar"));
```