
# Paradigmas de Programação

Um paradigma é um modelo de técnicas e formas de solucionar um problema.  
O paradigma de programação é diferente de uma linguagem. O paradigma define as regras e técnicas que devem ser seguidos, enquanto a linguagem de programação implementa os paradigmas em sua estruturação.

Existem vários paradigmas de programação:
- Programação Orientada a Objetos
- Programação Estruturada
- Programação Imperativa
- Programação Procedural
- Programação Orientada a Eventos
- Programação Lógica
- Dentre outras

Cada paradigma de programação é pensado para se aplicar a tipos específicos de problemas. Cada um deles se sai melhor ou pior dependendo da situação na qual eles são utilizados. Não existe um paradigma que seja melhor ou pior.

# Programação Orientada a Objetos

A Programação Orientada a Objetos (POO) é um paradigma de programação que tem como principal conceito as classes e os objetos.
- Uma **classe** é uma representação de um objeto da vida real, como um molde usado para montar um objeto real. Por exemplo, uma classe Pessoa fornece um molde para criar uma pessoa. As classes possuem propriedades (características) e métodos (ações).
- Um **objeto** é a classe concretizada. Ele utiliza a classe como molde para fazer uma implementação física daquele objeto do mundo real, que pode ser manipulada na memória do programa, e terá valores palpáveis para suas características.

A programação orientada a objetos é um dos paradigmas mais utilizados atualmente, por conta da sua facilidade de trabalhar, pois ele se aproxima muito dos conceitos da vida real, utilizando classes e objetos para se relacionar diretamente com objetos do mundo real.

Existem 4 pilares na Orientação a Objetos:
- Abstração
- Encapsulamento
- Herança
- Polimorfismo

Estes pilares são os conceitos principais que suportam o paradigma.

### Abstração

A abstração é o conceito de representar um objeto do mundo real utilizando apenas as características importantes para um contexto específico. Um objeto real sempre tem muitas características e ações, pois eles estão inseridos em diversos contextos, mas o contexto de um sistema é sempre mais específico, portanto o conceito de abstração define que apenas os atributos e métodos que serão realmente utilizados no contexto daquele sistema devem ser representados.

Por exemplo, uma pessoa possui muitas características: nome, idade, cor do cabelo, cor dos olhos, cor da pele, altura, peso, tamanho da roupa, número do calçado...  
Para o contexto de um sistema de loja de calçado, o número do calçado é um dado relevante. Porém, para um sistema de barbearia, esse dado não importa. Portanto ele só deve ser representado em contextos nos quais ele pode ser utilizado.

### Encapsulamento

O encapsulamento é o conceito de definir diferentes níveis de acesso para os membros de uma classe. Ele é usado para proteger uma classe, definindo limites para a alteração de suas propriedades e para a utilização de seus métodos. O encapsulamento permite que cada classe exponha apenas os membros necessários para que ela seja utilizada, ocultando os demais.

Por exemplo, uma classe Conta Bancária possui o valor do saldo, e esse valor precisa ser protegido de acesso externo, caso contrário qualquer pessoa poderia definir o valor que quiser para o saldo da sua conta.
Então a Conta Bancária oculta o valor do saldo, e disponibiliza os métodos Depositar e Sacar, que fornecem um escopo limitado para alterar o valor do saldo.

Existem diversos tipos de modificadores de acesso que podem ser usados para encapsular uma classe, os mais comuns são:
- `Public`: Qualquer classe pode acessar esse membro da classe.
- `Private`: Apenas a própria classe pode acessar esse membro.
- `Protected`: Apenas a própria classe e suas classes filhas podem acessar o membro.

### Herança

A herança permite reutilizar atributos, métodos e comportamentos de uma classe em outras, sendo utilizada para agrupar objetos que têm um tipo em comum, mas possuem características diferentes.

A herança consiste em implementar uma classe mais genérica (Classe pai), que representa um tipo comum entre as classes mais específicas (classes filhas), e "herdar" todos os membros da classe pai nas classes filhas. Ao herdar, as classes filhas possuirão todos os atributos e métodos existentes na classe pai.

Por exemplo, um aluno e um professor são objetos diferentes. O aluno possui um registro de matrícula e uma nota, e o professor possui um salário. Porém, ambos também possuem as propriedades nome e idade, e se cada uma delas implementasse essas propriedades, haveria duplicidade de código.  
Com isso, é possível usar a herança para solucionar esse problema: É criada uma classe Pessoa, que possui nome e idade, e ambos o Aluno e o Professor herdam da classe Pessoa. Assim eles só precisam implementar as propriedades únicas a cada classe.

No C#, é possível ter heranças em cascata, com uma classe herdando de uma outra classe que já é uma classe filha. Porém não é possível fazer herança múltipla, que seria uma única classe herdar de duas ou mais classes ao mesmo tempo.

O uso de herança exige um certo cuidado, pois ela pode deixar o código muito complexo (para conseguir entender todos os atributos e métodos existentes em uma classe quando ela herda em vários níveis) e acoplado (pois as classes filhas dependem da implementação das classes pai).  
É importante também ter a certeza se a herança faz sentido ao utilizá-la. Embora ambos uma pessoa e um filme tenham um atributo chamado "Nome", não faria sentido um filme herdar da classe pessoa. A herança deve sempre lidar com classes que têm uma relação de alguma forma, em que a classe pai seja um tipo que pode ser aplicado à classe filha.

### Polimorfismo

O polimorfismo é uma palavra de origem grega, que significa "muitas formas".  
Ele permite sobrescrever um método, para que ele se comporte de forma diferente em relação à implementação original. 

Existem dois tipos de polimorfismo:

#### Overload / Early Binding (Polimorfismo em tempo de compilação)

O Overload é o polimorfismo feito dentro da mesma classe, sem necessidade de herança. Ele consiste em implementar o mesmo método mais de uma vez dentro da mesma classe, utilizando o mesmo nome para o método, mas recebendo parâmetros diferentes.

Por exemplo, uma classe calculadora pode ter duas implementações para um método Somar:
- Uma implementação que permite apenas números inteiros
- Outra que permite números decimais

Para realizar essa implementação, é possível usar o Overload, apenas alterando os parâmetros que o método recebe:
```
public int Somar (int numero1, int numero2)
{
	return numero1 + numero2;
}

public double Somar (double numero1, double numero2)
{
	return numero1 + numero2;
}
```

#### Override / Late Binding (Polimorfismo em tempo de execução)

O Override é o polimorfismo que depende de herança. Ele permite ter implementações diferentes para um mesmo método em classes diferentes, onde a classe pai possui um método genérico, e as classes filhas podem alterá-lo para que ele seja mais adaptado para o contexto delas.

Por exemplo, a classe Pessoa pode ter um método Apresentar, que exibe "Olá, sou {nome} e tenho {idade} anos". Mas para as classes Professor e Aluno, que herdam dela, é possível sobrescrever esse método para exibir uma mensagem diferente, como por exemplo:
- Aluno: "Olá, meu nome é {nome}. Sou um aluno, e tenho nota {nota}"
- Professor: "Olá, meu nome é {nome}. Sou um professor, e meu salário é {salario}"

Para utilizar o polimorfismo com override, é necessário dois passos:
- Na classe pai, declarar o método como `virtual`, que indica que esse método pode ser sobrescrito por classes que o herdam.
- Na classe filha, declarar um método com o mesmo nome, utilizando a palavra `override`, que indica que essa implementação substitui a do método virtual da classe pai.