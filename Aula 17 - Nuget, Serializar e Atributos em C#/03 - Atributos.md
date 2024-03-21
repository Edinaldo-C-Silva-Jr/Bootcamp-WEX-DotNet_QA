### Atributos

Atributos são metadados no C#. Eles são informações adicionadas em uma propriedade, método ou classe, com o objetivo de passar um comportamento específico adicional para aquele membro.  
Os atributos são adicionados logo acima do membro ao qual eles se referem, e são identificados por colchetes `[ ]`. Eles podem identificar comportamentos que se deseja ter para membros de uma classe que são diferentes do padrão esperado.

Por exemplo, como a deserialização é feita comparando o nome exato do campo em JSON com a propriedade, ela não poderia ser feita caso os nomes fossem diferentes.  
Se o arquivo JSON vem com a chave do campo "Nome_Produto", e a classe em C# usar a propriedade "NomeProduto" (para manter a convenção de nomenclatura da linguagem), a deserialização não seria feita corretamente.

Com isso, é possível utilizar os atributos para lidar com esse problema:
```
public class Venda
{
	public int Id { get; set; }
	
	[JsonProperty("Nome_Produto")]
 	public string NomeProduto { get; set; }

	public decimal Preco { get; set; }

	public DateTime DataVenda { get; set; }
}
```
O atributo `JsonProperty` informa ao deserializador que a propriedade `NomeProduto` deve receber os dados do campo `Nome_Produto` do arquivo JSON. O atributo define explicitamente o campo para mapear naquela propriedade.