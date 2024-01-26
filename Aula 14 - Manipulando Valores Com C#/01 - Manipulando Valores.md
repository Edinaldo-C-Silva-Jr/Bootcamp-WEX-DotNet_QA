Manipular um valor significa alterar ou transformar o valor existente em um tipo de dados para uma representação diferente. Essa representação pode ser mais amigável, mais legível, ou pode ser feita para ser compatível com diferentes exigências e implementações.

### Concatenação de Strings

Concatenar strings é realizar uma junção de duas ou mais strings diferentes em um único texto, a fim de utilizá-la em um único contexto.
```
string nomePessoa = "João";
int idadePessoa = 30;

string texto = "Olá, meu nome é " + nomePessoa + " e tenho " + idadePessoa + "anos."
Console.WriteLine(texto);
```

A concatenação de strings utiliza o sinal de mais `+` entre duas strings para juntá-las. O sinal de `+`, no contexto em que é utilizado com strings, sempre representa concatenação. Caso haja alguma variável de outro tipo, como a variável idadePessoa, que é um inteiro, ela é convertida implicitamente para string.

Desde que haja ao menos uma string na operação, o sinal de `+` representa a concatenação de textos. Ele representará uma operação de adição somente se todos os valores forem numéricos.

### Interpolação de Strings

Dependendo de sua complexidade, a concatenação pode ser trabalhosa para escrever ou entender, devido à fragmentação do texto e a quantidade de sinais utilizados.

Uma alternativa para a concatenação é a Interporlação de Strings, que consiste em montar um único texto, utilizando uma sintaxe que substitui o nome das variáveis dentro do texto pelo seu valor.
```
string nomePessoa = "João";
int idadePessoa = 30;

string texto = $"Olá, meu nome é {nomePessoa} e tenho {idadePessoa} anos."
Console.WriteLine(texto);
```

A interpolação utiliza o sinal de `&` no início da string para identificar que se trata de uma interpolação. A partir disto, o texto é montado, utilizando as variáveis entre chaves `{ }`, para identificar que o texto deve exibir o valor das expressões entre chaves, em vez de imprimí-las como texto.

### Formatar Valores Monetários

A interpolação de string pode ser usada para representar um valor numérico como um valor monetário.
```
decimal valorMonetario = 50.85M;
Console.WriteLine($"{valorMonetario:C}");
```

Esta expressão utiliza a interpolação, passando uma instrução de formatação para a string. O sinal de dois pontos `:` indica que a string deve ser formatada utilizando alguma regra de formatação. O caractere `C` indica que a formatação deve ser do tipo **Currency** (existem outros tipos de formatação representados por outras letras).  
Com isso, esse valor seria formatado para "R$ 50,85".

### Cultura

A formatação monetária do C# depende da Cultura do sistema utilizado no computador, que define o idioma do computador, e também as regras utilizada para formatar valores como data ou valor monetário.

##### Alterando a Localização do Sistema no Código

Para alterar a localização, é possível alterar a cultura do sistema no código.
```
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"{valorMonetario:C}");
```

Esse código altera a cultura atual do sistema para a cultura definida, neste caso, "en-US" é a cultura do inglês dos Estados Unidos.

##### Alterar a Localização de um Método Específico

Nem sempre é ideal definir uma cultura para todo o sistema, às vezes é necessário mudar de acordo com a necessidade do código.
É possível também alterar a cultura apenas para uma exibição ou método específico:
```
using System.Globalization;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
```

Neste caso, aquele texto sempre será exibido com a cultura passada para o método, independente da cultura do sistema.

### Formatando o tipo DateTime

O tipo DateTime é uma struct que implementa diversas propriedades e métodos para manipular e representar datas em uma aplicação.  
Para formatar um dado DateTime em diferentes formatos, pode-se utilizar os diversos formatos disponibilizados pelo método ToString()
```
Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
```

Esse código imprime a data na tela no formato: 31/12/2023 23:59  
Há várias possibilidades para formatar esse valor, baseado nas letras utilizadas para representar a formatação.

O tipo DateTime também conta com os métodos Parse e TryParse, que convertem um valor de texto em formato de data para um valor de data.  
Ele também conta com o método TryParseExact, que recebe como parâmetro um formato específico que a data deve estar, e só converte se o valor for uma data válida e estiver exatamente naquele formato.
```
string dataString = "2023-12-31";
DateTime dataRecebida;
DateTime.TryParseExact(dataString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataRecebida);
```

Este método recebe como parâmetros:
- A data em string a ser convertida.
- O formato específico da data, a conversão só será válida se a data estiver especificamente neste formato.
- A cultura esperada da data, caso a data recebida seja em um tipo de cultura específico.
- O estilo padrão utilizado para a data.
- A variável para colocar a data convertida caso a conversão seja bem sucedida.