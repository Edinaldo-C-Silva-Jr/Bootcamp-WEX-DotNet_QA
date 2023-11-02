using Calculadora.Services;

Calcular calcular = new();

int numero1 = 5, numero2 = 10;

Console.WriteLine($"{numero1} + {numero2} = {calcular.Somar(numero1, numero2)}");
