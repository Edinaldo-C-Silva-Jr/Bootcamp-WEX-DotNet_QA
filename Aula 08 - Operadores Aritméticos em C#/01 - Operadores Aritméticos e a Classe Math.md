# Operadores Aritméticos

Os operadores aritméticos são os operadores que permitem fazer operações matemáticas na programação.  
Os símbolos de aritmética no C# costumam ser semelhantes a como eles são representados na matemática, embora em alguns casos eles possam ser um pouco diferentes.  
Os operadores aritméticos principais são:

- `+` - Sinal de adição, que soma dois valores.
- `-` - Sinal de subtração, que subtrai um valor de outro.
- `*` - Sinal de multiplicação, que multiplica dois valores.
- `/` - Sinal de divisão, que divide um valor por outro.
- `%` - Sinal de módulo, que retorna o resto da divisão de um valor por outro.
- `++` - Sinal de incremento. Este operador incrementa em 1 um valor. Ele é equivalente a utilizar + 1
- `--` - Sinal de decremento. Este operador decrementa em 1 um valor. Ele é equivalente a utilizar - 1

### Classe Math

A classe **Math** é uma classe já implementada do C# que pode ser utilizada para realizar diversas operações matemáticas, sem precisar implementá-las manualmente.  
Para utilizar a classe Math, basta chamar o seu nome, diretamente, e depois especificar o método desejado.
```
double resultado = Math.Pow(3, 5);
double resultado = Math.Sqrt(49);
```

O primeiro código retorna o valor da potenciação de 3, com expoente 5.  
O segundo retorna o valor da raiz quadrada de 49.