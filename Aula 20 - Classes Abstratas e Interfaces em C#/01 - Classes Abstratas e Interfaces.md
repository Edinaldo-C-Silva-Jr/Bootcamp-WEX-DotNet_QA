# Classes Abstratas

Uma classe abstrata é uma classe que não pode ser instanciada. A sua função é ser um modelo de classe para ser herdado por outras.  
Uma classe abstrata pode implementar seus próprios métodos, ou deixar a implementação para a classe que a herdará. Para isso, ela utiliza os métodos abstratos, que são métodos declarados com uma assinatura, mas que não possuem corpo de código.

Para criar uma classe abstrata, e para criar métodos abstratos, deve ser utilizada a palavra `abstract`:
```
public abstract class Conta
{
	protected decimal Saldo

	public abstract void Creditar(decimal valor); // Método abstrato, não posusi corpo.

	public void ExibirSaldo() // Método implementado.
	{
		Console.WriteLine($"Saldo: {Saldo}");
	}
}
```
O método Creditar é um método abstrato. Ele não possui corpo de código, ele é apenas declarado. Portanto, qualquer classe que herdar da classe Conta deverá implementá-lo, através de um override, para poder ser utilizada.  
Por outro lado, o método ExibirSaldo possui um corpo de código, portanto ele não precisa ser implementado, e poderá ser utilizado normalmente.
```
public class Conta Corrente
{
	public override void Creditar(decimal valor)
	{
		Saldo += valor;
	}
}
```

A classe ContaCorrente precisa obrigatoriamente implementar o método Creditar, mas ela pode acessar normalmente o atributo Saldo e o método ExibirSaldo.

#### Construtores Por Herança

Quando uma classe herda de outra que possui um construtor customizado, ela precisa retornar os parâmetros necessários para o construtor da classe pai.  
Isso é feito através da utilização da palavra `base`, que referencia a classe pai da classe atual.
```
public class ClassePai
{
	public string Nome { get; set; }

	public ClassePai(string nome)
	{
		Nome = nome;
	}
}

public class ClasseFilha : ClassePai
{
	public ClasseFilha(string nome) : base(nome)
	{
	}
}
```
O construtor da ClasseFilha recebe o parâmetro `nome`, e depois o repassa para o construtor da ClassePai.

### Classe Selada

Uma classe selada é uma classe que não permite que outras classes herdem dela. Ela é uma classe final, que não pode ser estendida por outras classes, portanto os métodos, implementações e atributos existentes nela só podem ser usados da maneira que são apresentados.

A classe selada não pode ter classes filhas, mas ela pode ser uma classe filha. Ela pode herdar de outras classes normalmente.

Além de uma classe selada, existem também os métodos e atributos selados.  
O método selado não permite que outras classes sobrescrevam a sua implementação. Os métodos selados podem existir em classes que não são seladas, assim eles podem ser herdados, mas a sua implementação deve, obrigatoriamente, ser a mesma da classe pai.

Para criar uma classe ou método selado, deve-se usar a palavra `sealed`, que define que essa é a instância final daquele membro.

### Classe Object

A classe `System.Object` é a mãe de todas as classes do .NET.  
Todas as classes existentes no .NET derivam, direta ou indiretamente, da classe Object. A herança da classe Object é feita automaticamente, de forma implícita.  
A classe Object possui alguns métodos padrão de baixo nível que são disponibilizados automaticamente para todas as classes utilizadas no .NET, como o método `ToString`.

# Interfaces

Uma interface é um tipo de contrato que define um molde para a implementação de classes que derivam dela. Ela é parecida com uma classe abstrata, pois ela não pode ser instanciada, e é usada para definir métodos que devem ser implementados pelas classes derivadas.  
Quando se fala de interfaces, a derivação dela é chamada de "implementação", em vez de "herança".

Enquanto, no C#, não é possível herdar de mais de uma classe ao mesmo tempo, com interfaces isso é possível. Uma mesma classe pode implementar várias interfaces.

A convenção de nomenclatura de interfaces no C# define a utilização da letra I antes do nome da interface. Por exemplo, uma interface para uma calculadora pode ser chamada de "ICalculadora".

Para trabalhar com interfaces, é possível instanciar uma classe em uma variável com o tipo da interface:
```
ICalculadora calculadora = new Calculadora();
``` 

#### Métodos Padrão

É possível implementar um corpo de código em um método de uma interface. Com isso, o método possui uma implementação padrão que será utilizada em classes que a implementam.  
A classe que implementa uma interface não é obrigada a implementar um método que possui uma implementação padrão.