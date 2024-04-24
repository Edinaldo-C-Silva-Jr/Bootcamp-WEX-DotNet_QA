# Operadores Condicionais

Os operadores condicionais permitem mudar o fluxo de execução do código, indicando um caminho a ser seguido dependendo do resultado de uma decisão. Esses operadores permitem ao software operar com base em decisões e condições.

### If - Else

O operador condicional mais conhecido é o **if**. Este comando indica uma estrutura de decisão em um código.  
O if desvia o fluxo de execução do código dependendo de uma condição, e ele escolhe sempre um dentre dois caminhos, não sendo possível seguir os dois ao mesmo tempo.  
No código em C# (e na maioria das linguagens) o bloco do if é executado quando a condição for verdadeira, e um outro bloco, conhecido como **else**, é executado quando a condição for falsa.
```
if (condição)
{
    Código que executa somente se a condição for verdadeira
}
else
{
    Código que executa somente se a condição for falsa
}

Código que se encontra depois da estrutura de repetição. Este código não faz parte do if, portanto ele sempre é executado independente da condição.
```

##### If encadeado

O if sempre divide apenas dois caminhos, o caminho verdadeiro e o caminho falso. Não é possível colocar mais que dois caminhos dentro de um if. Porém, é possível encadear os ifs, colocando outros ifs dentro dele, para tratar mais condições em uma única estrutura.
```
if (condição)
{
    Código que executa somente se a primeira condição for verdadeira
}
else if (condição 2)
{
    Código que executa somente se a segunda condição for verdadeira
}
else
{
    Código que executa somente se as duas condições forem falsas
}
```

### Operadores de comparação

As condições do if normalmente funcionam através de uma avaliação de comparações. Essa avaliação compara dois valores, utilizando algum operador de comparação, e dá um resultado baseado no resultado da comparação: retornando um valor booleano verdadeiro, caso a comparação seja verdadeira, ou um valor booleano falso, caso a comparação seja falsa.  
Os operadores de comparação são:

- `==` - Operador de comparação de igualdade. 
- `>` - Operador de comparação de maior.
- `<` - Operador de comparação de menor.
- `>=` - Operador de comparação de maior ou igual.
- `<=` - Operador de comparação de menor ou igual.

### Switch - Case

O **switch - case** é uma estrutura condicional que avalia vários caminhos possíveis de uma vez, baseado em uma comparação de uma variável com vários valores possíveis.  
A estrutura Switch avalia apenas uma comparação de igualdade. A variável que será avaliada é passada ao bloco no comando `switch`, e as comparações são executadas nos blocos `case`, onde cada bloco lida com um caso possível para o valor da variável.
```
switch (letra)
{ 
	case 'a':
	case 'e':
	case 'i':
	case 'o':
	case 'u':
	Console.WriteLine("Vogal");
	break;
default:
	Console.WriteLine("Não é vogal");
	break;
}
```
Os blocos `a', 'e', 'i', 'o' e 'u' são os diferentes casos possíveis para a variável letra, enquanto o bloco "default" é o bloco a ser executado caso nenhum deles seja verdadeiro.  
A instrução "break" é necessária para sair da condição switch após a execução do código desejado. Caso não haja um break, a estrutura passaria de um bloco para o seguinte.

# Operadores Lógicos

Os operadores lógicos são usados nas avaliações de condição para realizar verificações mais variadas ou complexas, através da junção de várias condições.

Os operadores lógicos são:
- `||` - Operador lógico **OU**, também chamado de *pipe*. Avalia duas ou mais condições, e retorna verdadeiro caso uma das condições seja verdadeira. Para ele ser verdadeiro, ao menos uma condição precisa ser verdadeira, somente se todas forem falsas ele retorna falso.
- `&&` - Operador lógico **E**. Avalia duas ou mais condições, e retorna verdadeiro somente se todas as condições sejam verdadeiras. Se qualquer uma das condições for falsa, ele retorna falso.
- `!` - Operador lógico **NOT**. Este operador nega um valor booleano. Se o valor for verdadeiro, ele deixa falso, e vice-versa.