using Celular.Models;

Nokia celularNokia = new("12345678", "Nokia 1", "1234", 16);
Iphone celularIphone = new("87654321", "Iphone 1", "4321", 16);

Console.WriteLine($"Celular Nokia. Número: {celularNokia.Numero} \n");
celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine($"\nCelular Iphone. Número: {celularIphone.Numero} \n");
celularIphone.Ligar();
celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Youtube");