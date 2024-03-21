# Pacotes

### O que é um pacote?

Um pacote é um conjunto de códigos que resolvem um determinado problema específico, e podem ser distribuídos e reutilizados no desenvolvimento de uma aplicação.  
Os pacotes normalmente lidam com problemas comuns e repetitivos, que normalmente não mudam muito de uma implementação para a outra, como por exemplo, o envio de um e-mail.  
O pacote é um pequeno projeto, que trabalha apenas naquele problema, e oferece uma solução, assim podendo ser distribuído e reutilizado. Pacotes também ajudam a fazer a integração com outros aplicativos.

### Gerenciador de Pacotes

Os pacotes de código podem ser disponibilizados para outras pessoas. O gerenciador de pacotes é o local onde estes pacotes são compartilhados, ele permite que desenvolvedores compartilhem pacotes de bibliotecas. Com isso, outros desenvolvedores podem encontrá-los e baixá-los para utilizar em seus projetos. O gerenciador de pacotes também cuida do download dos pacotes para que sejam utilizados.

### Nuget

O Nuget é o gerenciador de pacotes oficial do .NET, ele é utilizado para disponibilizar e utilizar pacotes de códigos em C#. O Nuget aceita somente códigos de linguagens do .NET.

### Instalando um Pacote pelo Visual Studio Code

No Visual Studio Code, a instalação de pacotes é feita pelo .NET CLI.  
Ao entrar na página de um pacote no site do Nuget, cada pacote já disponibiliza o comando para instalá-lo através do .NET CLI.  
Para verificar se o pacote realmente existe no projeto, basta verificar o arquivo .csproj, que informa todas as referências de pacotes existentes no projeto.

### Instalando um Pacote pelo Visual Studio

Ao abrir o projeto no Visual Studio, os arquivos do projeto ficam visíveis no Solution Explorer.  
Para instalar um pacote, basta clicar com o botão direito no nome do projeto, depois em "Manage Nuget Packages". Isso abre uma aba onde é possível pesquisar novos pacotes, além de visualizar os pacotes já instalados no projeto.  
Após selecionar um pacote, basta clicar em "Install", e o pacote será instalado no projeto.  
Também é possível instalar um pacote pelo Package Manager Console, para isso, é necessário pegar o comando de instalação na página do pacote no site do Nuget, depois inserir o comando no console.