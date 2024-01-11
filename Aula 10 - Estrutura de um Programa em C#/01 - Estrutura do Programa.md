# Estrutura do Projeto

Um projeto .NET é composto por vários arquivos:

- **.csproj**: Arquivo que contém informações referentes ao projeto. Build, debug, versão.
- **.sln**: Arquivo que contém informações sobre um agrupamento de projetos. O grupo de projetos é denominado solução.

Uma solução pode ter muitos projetos agrupados dentro dela, inclusive dando a possibilidade deles se relacionarem entre si e se comunicarem para compartilhar informações.  
Ao ter dois ou mais projetos dentro de uma solução, é possível adicionar uma referência de um projeto para outro para que eles se conheçam, assim sendo possível utilizar classes de um projeto dentro do outro.

### Método Principal (main)

O método main é o método principal de qualquer projeto do .NET  
O arquivo **Program.cs** é o ponto de entrada para o projeto, ao rodar o projeto, o código sempre inicia a execução neste arquivo. O arquivo Program.cs possui um método padrão representado como "static void main", e é por este método que o programa inicia a sua execução.

O .NET 6 simplificou o início do programa deixando o método main implícito no programa, portanto o código pode ser escrito direto no arquivo Program.cs