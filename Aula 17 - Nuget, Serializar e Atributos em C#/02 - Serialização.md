# Serialização

A serialização de dados é uma maneira de transformar um objeto que existe em uma aplicação em um fluxo de bytes para que ele possa ser transmitido ou armazenado em outro local.  
Normalmente, um objeto só existe na memória durante a execução de uma aplicação. Ao finalizar a execução, todos os dados relacionados àquele objeto são perdidos.  
A serialização é o processo que permite transformar os dados desse objeto em um formato que permita que eles sejam armazenados em uma outra fonte, como um banco de dados ou um arquivo. Com isso, os dados do objeto ficam em um formato que essa outra fonte reconhece e aceita.

### Deserialização

É o processo inverso à serialização, através do qual os dados do objeto que estão em uma outra fonte são traduzidos para um formato em que ele possa ser usar em uma aplicação.

### Formato JSON

JSON (JavaScript Notation Object) é um formato de texto usado para transmitir dados entre aplicações. Ele é um formato comum de representação de dados que visa padronizar a representação de dados, de forma a permitir que duas aplicações ou linguagens diferentes se comuniquem.  
O JSON segue a sintaxe do Javascript, mas ele pode ser usado em qualquer linguagem.

Um exemplo de representação de dados em JSON:
```
{
	"Id": 1,
	"Produto": "P1",
	"Preco": 10.50
}
```

### Biblioteca Newtonsoft.Json

Essa biblioteca é disponibilizada através de um pacote externo, que pode ser baixado pelo Nuget. Ela fornece códigos que lidam com a serialização de dados em JSON.  
Para usá-lo, é necessário utilizar a diretiva using para definir o uso da biblioteca:
```
using Newtonsoft.Json;
```
Com isso, é possível utilizar classes de serialização que transformam um objeto em formato JSON, sem que haja a necessidade de fazer a serialização manualmente.
```
class Venda
{
	public int Id { get; set; }
	public string Produto { get; set; }
	public decimal Preco { get; set; }
}

Venda v1 = new Venda(1, "Tesoura", 10.00M);
string objetoSerializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
```

Com esse método, o objeto `v1` é passado para o formato JSON, sendo retornado em uma string. O parâmetro Formatting.Indented retorna a string com quebras de linhas para facilitar a visualização.

Para utilizar uma biblioteca disponibilizada em um pacote, é importante ler a documentação do pacote, para que se possa ver informações de como utilizá-lo, além de quais métodos são disponibilizados.

### Escrevendo um Arquivo JSON

Após serializar os dados do objeto em formato JSON, é possível escrevê-los em um arquivo.
```
File.WriteAllText("Arquivos/vendas.json"), objetoSerializado);
```
### Serializando uma Coleção

Muitas vezes, é necessário serializar vários objetos de uma vez. Para isso, é possível serializar uma lista de objetos, em vez de serializar um de cada vez.  
Após os objetos serem agrupados em uma lista, é possível utilizar o mesmo método de serialização de objetos para serializar a lista.
```
List<Venda> listaVendas = new List<Venda>(); {(1, "Tesoura", 10.00M), (2, "Cola", 8.00M)}
string objetoSerializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
```

Com isso, os objetos são representados em uma única variável de texto, em formato JSON.
```
[
	{
		"Id": 1,
		"Produto": "Tesoura",
		"Preco": 10.00
	},
	{
		"Id": 2,
		"Produto": "Cola",
		"Preco": 8.00
	}
]
```

### DateTime em JSON

O tipo DateTime é uma struct, dentro do C#, que define como a linguagem lida com a representação de datas. Porém, em outras linguagens, a representação de datas é diferente.  
Portanto, ao serializar uma data, o formato JSON tem um formato que é independente de qualquer linguagem. Esse formato do JSON segue um padrão conhecido como ISO 8601, que faz uma padronização de como datas são representadas em sistemas.

O formato data em JSON é:
```
"Data" : "2023-12-31T23:59:59.9999999-03:00"
```

- `2023-12-31` é a data, no formato `yyyy-MM-dd`
- `T23:59:59:9999999` é a hora, no formato `T HH:mm:ss:fffffff`
- `-03:00` e o fuso horário utilizado pela hora especificada

### Deserializando um Objeto

A deserialização é o processo inverso da serialização: receber um arquivo JSON, e importá-lo no sistema, fazendo o mapeamento dos dados no arquivo para objetos na aplicação.

Para isso, ao receber o arquivo, é necessário estudar o conteúdo do arquivo, para identificar a quantidade de objetos, a quantidade de propriedades, seus nomes e seus tipos.  
Depois disso, é necessário criar uma classe, que represente o formato dos objetos recebidos no arquivo JSON, definindo nela as mesmas propriedades, os mesmos nomes e os mesmos tipos de dados dos objetos no arquivo JSON. Isso permitirá mapear os dados existentes no arquivo nas propriedades existentes na classe.
```
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
foreach (Venda venda in listaVenda)
{
	Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}
```
O código acima lê o arquivo em uma string. Depois deserializa o conteúdo da string em uma lista de Vendas. Então ele acessa a lista de vendas para mostrar uma venda de cada vez na tela.

O método DeserializeObject faz a deserialização com base no nome das propriedades, ele compara o nome exato que existe no dado em JSON com o nome que existe na classe que vai receber esse objeto.