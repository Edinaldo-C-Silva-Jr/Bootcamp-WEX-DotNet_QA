# Exceções
Exceções, ou exceptions, são recursos que ajudam a lidar com situações excepcionais ou inesperadas que ocorrem durante a execução de um programa.

Raramente os programas trabalham com a capacidade de prever o que precisam, pois muitas vezes há situações que estão além do controle do desenvolvedor. Como por exemplo, a internet cair enquanto um download é feito. Ou um arquivo que o programa espera acessar não existe na pasta.  
Neste momento ocorre a exceção, que é quando o programa tenta fazer alguma ação que foi programada, mas é impedido por algum fator externo. Com isso, a exceção retorna ao desenvolvedor a responsabilidade de lidar com esta situação, pois sozinho o programa não consegue.

Ao retornar uma exceção, a execução do programa é interrompida, ele não consegue mais prosseguir com a execução e é encerrado. Ele também retorna informações relevantes sobre a causa da exceção, em um caminho conhecido como "Stack trace", que mostra o caminho que o programa tentou percorrer antes de retornar a exceção.

### Tratando uma Exceção

Ao estourar uma exceção, o programa joga a responsabilidade para o desenvolvedor, para que possamos lidar com a exceção.  
Isso é feito através do bloco `Try - Catch`.

Estas são duas cláusulas que englobam um bloco de código, de forma a permitir que algum tratamento seja feito caso ocorra uma exceção. O bloco Try-Catch permite que a execução do programa continue, mesmo que a exceção ocorra.
```
try
{
	int numero = int.Parse(Console.ReadLine());
}
catch(Exception ex)
{
	Console.WriteLine($"Ocorreu uma exceção: {ex.Message}");
}
```

O bloco `Try` define a parte do código na qual se espera que ocorra a exceção, com isso ele vai tentar executar o código, mas estando ciente de que a execução pode falhar.  
O bloco `Catch` é a parte do código que "pega" a execução que é "jogada" pelo código. No momento que uma exceção ocorre em qualquer linha dentro do bloco Try, o código existente no bloco Catch é executado. Com isso, a exceção não interrompe a execução do programa, pois após o tratamento do Catch, o programa continua rodando.  
O bloco Catch recebe uma variável que contém a exceção, assim é possível utilizar as informações da exceção.

### Exceção Genérica x Exceção Específica

As exceções genéricas são exceções definidas pela classe `Exception`. Elas possuem propriedades e métodos comuns a todas as exceções, e simplesmente definem um ponto onde ocorre erro no código e o programa é interrompido.

As exceções específicas são exceções de vários tipos que herdam da classe genérica. Cada tipo específico de exceção ocorre em cenários específicos, e elas possuem propriedades e métodos específicos para aquele tipo de situação.  
Por exemplo, a exceção `FileNotFoundException` ocorre quando o programa tenta ler um arquivo e ele não é encontrado.

Ao colocar o mouse sobre um método, é possível ver todas as exceções que podem ser geradas a partir de sua execução.

É possível ter tratamentos diferentes para diferentes tipos de exceções específicas. Para isso, é possível usar vários blocos Catch em um único bloco Try, sendo que cada bloco Catch recebe um tipo de exceção específica.
```
try
{
	string linhas = File.ReadAllLines("Documents/DocumentoDeTexto.txt");
}
catch(FileNotFoundException ex)
{
	Console.WriteLine($"Ocorreu uma exceção. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
	Console.WriteLine($"Ocorreu uma exceção. Diretório não encontrado. {ex.Message}");
}
catch(Exception ex)
{
	Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
```

Assim, dependendo do tipo de exceção que ocorre no programa, um tratamento diferente será executado. Somente um bloco Catch pode ser executado por vez.

### Bloco Finally

O bloco finally é usado depois do bloco Catch, e serve para executar um bloco de código sempre no final de um Try, independente de ter dado uma exceção ou não.
```
try
{
	int numero = int.Parse(Console.ReadLine());
}
catch(Exception ex)
{
	Console.WriteLine($"Ocorreu uma exceção: {ex.Message}");
}
finally
{
	Console.WriteLine("Execução do bloco finally. O programa chega aqui independente da ");
}
```

### Throw

A palavra Throw é usada para "jogar" uma exceção durante a execução do programa. Ele permite criar e retornar uma exceção manualmente.
```
throw new Exception("Ocorreu uma exceção.");
```