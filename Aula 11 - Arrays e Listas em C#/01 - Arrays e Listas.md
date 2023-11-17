Arrays e listas são maneiras de manipular uma coleção de elementos do mesmo tipo.

### Array

O Array, também conhecido como vetor (unidimensional) ou matriz (bidimensional) é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo. Ele é uma única variável declarada que contém diversos valores armazenados.  
O array deve ter o seu tamanho (quantidade de posições) definido ao ser inicializado, e não há como alterar esse tamanho depois de definido. O tamanho pode ser definido explicitamente, ou através de atribuição de valores ao inicializar.  
Os arrays são identificados por colchetes [] na frente do nome do tipo da variável. Ao definir o tamanho, ele deve ser passado dentro dos colchetes. Os arrays podem ser atribuídos uma coleção de valores, definida por uma lista de valores entre chaves {}, separados por vírgula.  

> int[] arrayDeTamanhoPredefinido = new int[4];  
> int[] arrayDefinidoPorAtribuicao = new int[] {10, 20, 30, 40, 50, 60}  
> int[] arrayDeAtribuicaoDireta = {100, 200, 300}

Para utilizar o array, deve-se utilizar o nome da variável passando o índice. O índice identifica a posição do elemento dentro do array, começando da posição 0. Se o array possui um tamanho de 4 elementos, então eles teriam as posições 0, 1, 2 e 3

> Console.WriteLine(arrayDefinidoPorAtribuicao[1]); // Retorna 20  
> arrayDeAtribuicaoDireta[2] = 500;  
> Console.WriteLine(arrayDeAtribuicaoDireta[2]); // Retorna 500

Se o índice passado ao array for um índice que não existe, o programa encerra em uma exceção. Como o array começa na posição 0, a última posição é sempre o tamanho do array menos 1.

#### Redimensionando um Array

Os arrays são estruturas de tamanho fixo. A partir do momento que o tamanho do array é definido, ele não pode ser alterado, o mesmo array trabalhará sempre com o mesmo tamanho.

Porém, existe um método dentro da classe Array chamado Resize. Com esse método, é possível "redimensionar" um array durante a execução do código.  
Para utilizar o método Resize, é preciso passar a referência de memória do array, utilizando a palavra "ref", e o novo tamanho desejado.

> int[] arrayNumeros = int[4];  
> Array.Resize(ref arrayNumeros, 8);

Como os arrays não podem ser redimensionados, o método Resize, internamente, cria um novo array, com o novo tamanho desejado, e depois copia os valores do array antigo para o novo. Então ele substitui o array antigo pelo novo na memória, utilizando a referência de memória passada.

#### Copiando um Array para outro

Para copiar os elementos de um array para outro, existe o método Copy, dentro da classe Array.  
O método Copy recebe um array de origem, um array de destino e a quantidade de elementos que serão copiados.

> int[] arrayAntigo = int[4];  
> int[] arrayNovo = int[8];  
> Array.Copy(arrayAntigo, arrayNovo, 4);

### Listas

Uma lista é uma coleção de elementos de mesmo tipo, mas trabalha de maneira mais simples e dinâmica que o array. A lista não precisa ter sua capacidade máxima declarada, ela pode ser redimensionada ao ser utilizada. A lista implementa maneiras mais fáceis de trabalhar com uma coleção comparado ao array.  
Para declarar uma lista, deve-se usar a palavra List passando o tipo de elemento que se deseja armazenar.

> List<*int*> listaNumeros = new List<*int*>();

O método Add é usado para adicionar um elemento a uma lista, ele recebe um parâmetro do mesmo tipo dos elementos da lista.  
Há também o método AddRange, que adiciona uma coleção de elementos à lista. Ele recebe uma coleção de elementos do mesmo tipo dos elementos da lista.

> listaNumeros.Add(1); // Recebe um Int  
> listaNumeros.AddRange(new {2, 3, 4}); // Recebe uma lista de Ints

Para acessar os elementos de uma lista, é possível passar um índice através do colchete, da mesma forma que se faz com um array.

> Console.WriteLine(listaNumeros[0]); // Retorna 1

A lista trabalha com um array internamente, mas ela faz todo o trabalho de manipulação do array. A vantagem da utilização da lista é a variedade de métodos que permitem manipulá-la de diversas maneiras, sem precisar lidar com as limitações técnicas do array.

A lista possui duas propriedades importantes relacionadas à sua capacidade de armazenamento:
- Count: A quantidade de elementos na lista.
- Capacity: A capacidade interna do array com o qual a lista está trabalhando.

A lista gerencia internamente o tamanho e as posições do array. Quando a capacidade é excedida ao adicionar elementos, a lista redimensiona o array automaticamente. Quando um elemento é removido, a lista gerencia os índices dos elementos automaticamente. Isso permite trabalhar com uma coleção sem se preocupar constantemente com o gerenciamento do tamanho. 