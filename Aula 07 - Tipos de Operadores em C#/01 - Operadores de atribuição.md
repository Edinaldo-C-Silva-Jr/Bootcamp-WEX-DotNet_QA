# Operadores

### Operador de Atribuição

O operador de atribuição é utilizado para atribuir um valor para uma variável. O operador de atribuição é representado pelo sinal de igual `=`  
Ele pode ser utilizado para atribuir ou modificar o valor de uma variável, e ele sempre opera da direita para a esquerda, atribuindo o valor do lado direito à variável fornecida do lado esquerdo.  
Para que uma atribuição ocorra, o valor atribuído e a variável que o recebe devem ser do mesmo tipo.  
O operador de atribuição sempre sobrescreve qualquer valor preexistente na variável.

### Combinando operadores

O operador de atribuição pode também ser combinado com outros operadores para realizar mais operações no momento da atribuição:
- Soma e atribuição: `+=`
Essa combinação soma o valor passado ao valor já existente na variável, com isso o valor existente não é perdido.
- Subtração e atribuição: `-=`
Essa combinação subtrai o valor passado do valor já existente na variável.
- Multiplicação e atribuição: `*=`
Essa combinação multiplica o valor passado com o valor já existente na variável.
- Divisão e atribuição: `/=`
Essa combinação divide o valor existente na variável pelo valor passado.

### Convertendo Tipos de Variáveis

Um valor só pode ser atribuído a uma variável se ele for do mesmo tipo da variável. Ao tentar atribuir um valor de um tipo inválido, o aplicativo dá um erro e acaba sendo encerrado.  
Porém, muitas vezes, ao trabalhar com código, devemos lidar com valores que não são do tipo desejado. Para lidar com isso, é possível converter o valor de um tipo de dado para outro.  
A conversão de tipos de dados é normalmente chamada de casting.

##### Conversão para Valores Numéricos

Há duas maneiras de converter o valor de uma variável em um tipo numérico.
```
Convert.ToInt32("5");
int.Parse("5");
```

Ambos os métodos Parse e Convert fazem a conversão entre tipos de variáveis. A única diferença entre eles é que o Convert trata valores nulos, retornando 0, enquanto o Parse não trata, retornando um erro de argumento nulo.

##### Conversão para String

Da mesma forma que uma variável numérica não pode receber uma cadeia de caracteres, uma variável string não pode receber valores numéricos, portanto é preciso converter o dado ao atribuí-lo a uma variável string.  
O tipo string não possui o método Parse em sua definição, mas ele tem sua própria maneira de fazer uma conversão:
```
int numero = 5
numero.ToString();
```

O método ToString está presente em todos os tipos e elementos no C#, e ele é utilizado para representar o valor como uma cadeia de caracteres.

### Casting Implícito

O casting de um tipo numérico em outro normalmente é feito explicitamente no código, através de comandos como os métodos Parse, Convert ou ToString.  
Porém, existe também o casting implícito, que é uma conversão que acontece no programa sem a necessidade de explicitá-la no código.  
Essa conversão automática é feita quando o C# reconhece que não existe a possibilidade de ter perda de dados durante a conversão, assim sendo seguro fazê-la automaticamente.
```
int a = 5;
long b = a;
```

Neste caso, ambas as variáveis int e long armazenam valores inteiros, porém o long tem capacidade muito maior que um int, assim não importa qual seja o valor de a, ele sempre caberá dentro de b. Assim a conversão é feita de forma automática.  
O contrário, porém, não é válido, pois um long pode ter valores que estão além da capacidade de um int, assim o C# não faz a conversão automática.

### Conversão de maneira segura

Os métodos Convert e Parse sempre esperam que o valor passado para conversão seja um valor válido, e caso o valor seja inválido, eles resultam em uma exceção.  
Para converter valores de forma segura contra erros, existe o método TryParse. Este método trabalha com a possibilidade de o valor passado ser inválido, portanto ele tenta fazer a conversão, e se não der certo ele atribui o valor 0 para a variável.  
O método TryParse retorna um valor booleano, informando se a conversão teve sucesso ou não. O valor numérico é retornado em uma variável passada como parâmetro utilizando a palavra `out`
```
string a = "5";
int.TryParse(a, out int b);
```