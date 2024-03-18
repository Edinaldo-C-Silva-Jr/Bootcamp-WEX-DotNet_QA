
# Coleções

Existem diferentes tipos de coleções, que se diferenciam por obedecerem diferentes regras no armazenamento e ordenação dos seus elementos.

### Fila (Queue)

Uma fila é um tipo de coleção FIFO (First in First out), ou seja, o primeiro elemento a entrar na fila é o primeiro a sair. Os novos elementos a serem inseridos vão sempre para o final da fila.  
Ela funciona como uma fila na vida real, onde a ordem em que as pessoas são liberadas (ou atendidas) é a ordem em que elas chegam.  
Uma fila só pode armazenar elementos de mesmo tipo.
```
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Dequeue();
```

O código acima insere os itens na ordem 2 <- 4 <- 6 <- 8.  
Depois ao remover os elementos, o elemento removido é o 2, pois ele foi o primeiro a entrar na fila.

### Pilha (Stack)

Uma pilha é um tipo de coleção LIFO (Last in First Out), ou seja, o último elemento a entrar é o primeiro a sair. Os novos elementos são inseridos no começo da pilha.  
Ela funciona como uma pilha na vida real, como por exemplo uma pilha de cadeiras, as novas cadeiras adicionadas à pilha são encaixadas em cima das outras, então ao retirá-las, é preciso tirar as que estão em cima primeiro.
```
Stack<int> pilha = new Stack<int>
pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Pop();
```

O código acima insere os itens na ordem 8 <- 6 <- 4 <- 2.  
Depois, ao remover os elementos, o elemento removido é o 8, pois ele foi o último a entrar na pilha, então ele se encontra no topo.

### Dicionário (Dictionary)

O dicionário é uma coleção de *Chave - Valor* que armazena valores únicos sem uma ordem específica.  
Os dicionários recebem dois elementos por vez, uma chave e um valor. A chave é o elemento que identifica o valor, e ela garante que os valores sejam únicos. Se a chave se repetir, o programa causa uma exceção.

Diferente da fila e pilha, o dicionário não tem nenhuma ordem para inserir ou remover valores. Os valores podem ser adicionados em qualquer ordem, desde que a chave seja única.
```
Dictionary<string, string> estados = new Dictionary<string, string>
estados.Add("SP", "São Paulo");
estados.Add("SC", "Santa Catarina");
estados.Add("BA", "Bahia");
estados.Add("MT", "Mato Grosso");
estados.Add("AM", "Amazonas");
```

O código acima insere cinco valores ao dicionário de estados, onde a sigla é a chave, que garante que os valores sejam únicos. Ao tentar adicionar um novo elemento com a chave SP, SC, BA, MT ou AM, o programa retorna uma exceção. Porém, os valores podem ser repetidos, então podem existir outros pares com o valor São Paulo no mesmo dicionário, desde que a chave seja diferente.

#### Percorrendo um Dicionário
```
foreach(KeyValuePair<string, string> item in estados)
{
	Console.WriteLine($"Chave: {item.key}, Valor: {item.value}");
}
```

Este código lista todos os valores existentes no dicionário.

#### Verificando se um Valor Existe no Dicionário
```
if (estados.ConstainsKey("SC"))
{
	Console.WriteLine("Existe um estado com esta chave.");
}
else
{
	Console.WriteLine("Não existe um estado com esta chave.");
}
```
O método ConstainsKey verifica se uma chave específica existe dentro do dicionário.

#### Acessando Valores em um Dicionário

Para remover ou alterar um valor no dicionário, é preciso passar a chave, de modo similar a como um índice é usado em um array.
```
estados.Remove("BA");
estados["SP"] = "São Paulo - Novo valor";
```
A primeira linha remove o estado "Bahia", com chave "BA".  
Já o segundo altera o valor do estado com chave "SP".