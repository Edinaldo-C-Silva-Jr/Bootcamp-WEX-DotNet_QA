# Propriedades

Uma propriedade é um campo que representa um atributo dentro de uma classe, que então poderá ser atribuído, lido e manipulado pelos objetos que implementarem essa classe. A propriedade permite encapsular e proteger o valor deste atributo dentro da classe, aplicando validações para não permitir manipulação irrestrita do valor do atributo.  
```
public class Pessoa
{
	public string Nome { get; set; }
}
```
No Intellisense, as propriedades são representadas por um ícone de chave inglesa `🔧`.

### Métodos Get e Set

As propriedades possuem duas ações: Get e Set.  
- **Get**: É um método que obtém o valor atualmente armazenado naquela propriedade. O método Get é utilizado implicitamente ao chamar a propriedade no código.  
- **Set**: É um método que atribui um novo valor àquela propriedade. O método Set é utilizado implicitamente ao utilizar o operador de atribuição `=` na propriedade.

##### Validações no Get e Set

Muitas vezes, as propriedades não devem aceitar qualquer valor. Deve haver algum tipo de validação dos dados para garantir que os valores atribuídos à propriedade sejam válidos.  
Para isso, é possível criar validações nos métodos Get e Set, para limitar os valores que podem ser atribuídos.
```
private string nome;
public string Nome
{
	get
	{
		return nome.ToUpper();
	}
	set
	{
		if (value != null)
		{
			nome = value;
		}
	}
}
```

A validação do código acima para o método Get sempre recebe o valor da propriedade em maiúscula. Já para o método Set, a validação só atribui o valor caso ele não seja vazio.

##### Body Expressions

Body expressions são uma maneira concisa e legível de representar expressões simples em uma única linha de código.  
Elas podem ser usadas sempre que uma propriedade ou método possui uma lógica de apenas uma linha.  
Uma body expression é usada através de um sinal de igual e maior `=>` apontando da propriedade/método para a expressão lógica correspondente.
```
private string nome;
public string Nome
{
	get => return nome.ToUpper();
	set => nome = value;
}
```

### Modificadores de Acesso

Modificadores de acesso são palavras reservadas que definem o escopo no qual aquele membro da classe pode ser acessado. Esses modificadores permitem bloquear o acesso ao membro para partes do código que não deveriam acessá-los.

Os modificadores de acesso mais comuns são:
- Public: Permite que qualquer classe do projeto acesse esse membro.
- Private: Somente a própria classe dona desse membro pode acessá-lo.
- Protected: Somente a classe dona do membro e classes derivadas dela podem acessar o membro.
- Internal: Somente classes que pertencem ao mesmo assembly da classe dona do membro podem acessá-lo.

### Propriedades somente leitura

É possível criar uma propriedade que seja somente para leitura, sem permitir atribuir um valor a ela. Para isso, a propriedade deve ser criada somente com o método Get, sem ter um Set definido.  
Propriedades somente leitura podem ter um valor atribuído a elas no momento de sua inicialização, ou no construtor da classe.

# Métodos

Métodos são ações existentes dentro de uma classe, que podem ser executados e reaproveitados a qualquer momento.  
Eles são representados por uma assinatura de método, uma identificação que torna o método único. A assinatura é a estrutura principal do método que contém o tipo de retorno do método, depois o seu nome, e depois parêntesis (), que podem, opcionalmente, conter parâmetros de entrada.  
Após a assinatura há um bloco de código, onde está contido todo o código que será executado ao chamar este método.
```
private List<string> Pessoas { get; set; }

public void AdicionaPessoa(string pessoa)
{
	Pessoas.Add(pessoa);
}

public int ExibirQuantidadePessoas()
{
	return Pessoas.Count;
}
```

O primeiro método AdicionarPessoa tem tipo de retorno void, ou seja, não retorna nada. Ele recebe um parâmetro, uma string pessoa, e o utiliza durante a execução do bloco de código.
O segundo método ExibirQuantidadePessoas retorna int, portanto ele precisa retornar um valor, passado através da instrução "return". Ele não recebe nenhum parâmetro, mas ainda precisa utilizar os parêntesis para identificar que ele é um método.

No Intellisense, os métodos são representados por um ícone de cubo `🧊`.

### Construtores

Os construtores são métodos que permitem instanciar uma classe e adicionar valores padrão à classe instanciada. Isso permite inserir valores na classe sem precisar criar novas linhas de instrução para manipular as propriedades.  
Ele também permite maior controle da manipulação dos atributos, pois é possível criar uma classe que só aceite novos valores no momento que ela é instanciada.

O construtor é um método que obrigatoriamente possui o mesmo nome da classe. Ele também não tem um tipo de retorno.  
O construtor pode ou não receber parâmetros. Normalmente, estes parâmetros serão relacionados às propriedades da classe que se deseja inserir valores por padrão.

Uma classe pode ter mais de um método construtor, sendo que eles diferem pela quantidade e tipo de parâmetros que eles recebem. Cada um deles representa uma maneira diferente de instanciar a classe.

Ao receber os parâmetros, o construtor pode inserí-los como valores dentro das propriedades da classe. Também é possível fazer qualquer tipo de tratamento necessário neste valores antes de inserí-los. Este tratamento é todo feito dentro da classe, e somente no momento que ela é instanciada.