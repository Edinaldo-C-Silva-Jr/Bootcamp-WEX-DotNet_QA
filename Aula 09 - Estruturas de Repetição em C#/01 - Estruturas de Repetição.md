# Estruturas de Repetição

Estruturas de repetição, ou laços de repetição, são blocos de código que se repetem com base em uma condição.  
Ele checa a condição de execução, e caso ela seja verdadeira, executa o bloco de código correspondente. Ao terminar a execução do bloco, ele volta a checar a condição, e caso ainda seja verdadeira, ele executa o bloco novamente. Esta estrutura se repete até que a condição de execução seja falsa, que é quando o programa sai do laço e continua a executar o código seguinte.  
Também é possível parar um laço de repetição com a palavra "break", que imediatamente sai do bloco de código do laço de repetição atual.

Existem 4 tipos de laços de repetição.

### For

O **For** é um tipo de laço de repetição específico, que é usado para repetir o código uma quantidade predeterminada de vezes. Ele utiliza uma variável de contador, que incrementa a cada execução, e a condição de execução dele é baseada em comparar um valor de saída ao valor do contador.  
A sintaxe do for possui 3 fases para sua execução:
- A definição da variável de contador, onde a variável é declarada e o seu valor inicial é definido.
- A condição de execução, onde se define o valor de saída, que é o valor que será comparado ao contador.
- O incremento, que define o quanto a variável contador incrementa a cada iteração.

O laço For gerencia automaticamente a variável de contador, com base no incremento especificado, e com isso ele também gerencia a sua condição de execução, por isso já fica predefinido quantas vezes ele irá executar.
O exemplo abaixo executa um total de 10 vezes.
```
for (int contador = 0; contador <= 10; contador++)
{
	Console.WriteLine($"5 x {contador} = {5 * contador}");
}
```

### While

O **While** é um laço de repetição que depende apenas de uma condição de execução. A condição pode ser qualquer variável, expressão ou comparação que possa retornar um valor booleano. 
O while é mais simples que o for em relação à sua implementação, pois ele não faz nenhum gerenciamento de variável para sua condição, a condição deve ser gerenciada no código.
```
int contador = 0;
while (contador <= 10)
{
	Console.WriteLine($"5 x {contador} = {5 * contador}");
	contador++;
}
```

Porém, o While também é mais versátil que o For, pois ele pode lidar com qualquer condição que resulte em um booleano, não dependendo de um contador.  
No exemplo abaixo, o programa continua executando até que o usuário digite a tecla `a`. Esta implementação não seria possível utilizando um For pois não há como prever quantas vezes o usuário digitará até que uma delas seja `a`.
```
while (Console.ReadKey() != "a")
{
	Console.WriteLine("Digite a tecla A");
}
Console.WriteLine("Tecla A apertada");
```

Note que, caso o usuário digite a tecla A na primeira tentativa, a condição já seria falsa, e o bloco de código interno não seria executado, então o programa não escreveria "Digite a tecla A" na tela.

### Do While

O **Do While** é um laço bem parecido com o While, com a única diferença sendo que a condição de execução é checada apenas no final da execução, não no começo. Com isso, o Do While garante que o código sempre seja executado ao menos uma vez.
```
do
{
	Console.WriteLine("Digite a tecla A");
}
while(Console.ReadKey() != "a");
Console.WriteLine("Tecla A apertada");
```

Neste caso, o texto "Digite a tecla A" sempre será executado, e somente depois ele checa se a tecla apertada é a tecla A.

### Foreach

O **Foreach** é um tipo específico de For que trabalha com uma coleção de dados, em vez de um contador. O Foreach recebe uma coleção de um certo tipo de elementos, e declara  uma variável com o mesmo tipo dos elementos da coleção. Então ela executa o bloco de código para cada item existente dentro daquela coleção, colocando o elemento dentro da variável para que ela possa ser acessada no código.
```
List<int> listaNumeros = new List<int> {0, 1, 2, 3}
foreach (int numero in listaNumeros)
{
	Console.WriteLine(numero);
}
```