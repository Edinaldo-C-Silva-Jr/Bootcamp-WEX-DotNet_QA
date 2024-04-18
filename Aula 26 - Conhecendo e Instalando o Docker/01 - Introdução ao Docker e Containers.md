
# O que é o Docker?

Para entender o que é o Docker, primeiro é preciso entender o cenário atual de como funciona o desenvolvimento de software.

### Modelo Cliente-Servidor

O modelo Cliente-Servidor é uma estrutura de aplicação que distribui a carga de trabalho entre os servidores, que fornecem um serviço ou recurso, e os clientes, que requerem os dados ou serviços.

O servidor é um computador, rede de computadores ou sistema centralizado que armazena os dados utilizados por aplicativos e os fornecem para os clientes que os requerem. Ele trabalha na parte de back-end, que processa e fornece os recursos necessários para o uso de aplicativos.

Os clientes podem ser qualquer dispositivo que se conecta à internet e utiliza serviços através dela, como um computador, celular, televisão, dentre outros. O cliente normalmente utiliza um aplicativo de front-end, que recebe as informações do servidor e as exibe de uma maneira que elas podem ser consumidas pelo usuário final.

#### Possíveis Desvantagens

Um servidor atende requisições de vários clientes simultaneamente, para isso ele precisa ter uma infraestrutura robusta para atender a essas demandas.  
Normalmente são necessários vários computadores para balancear a carga de serviço. Essa infraestrutura de vários computadores normalmente é chamada de *DataCenter*.

Um DataCenter precisa de diversos cuidados para ser mantido. Os componentes de hardware devem estar sempre atualizados, ele deve estar a uma temperatura adequada para o funcionamento dos computadores, é necessária uma estrutura que permita disponibilidade, lidando com fatores que podem causar falhas, como quedas de energia, é necessário ter segurança, para manter os dados seguros.  
Tudo isso gera um custo muito alto para manter o DataCenter funcionando.

### Cloud Computing

O conceito de Cloud Computing é o acesso sob demanda a recursos de computação através da internet.  
O cloud computing permite acesso a aplicativos, servidores, armazenamento de dados, ferramentas de desenvolvimento, recursos de rede, dentre outros serviços, que são hospedados em um DataCenter remoto.  
Esses DataCenters são gerenciados por empresas conhecidas como Cloud Solution Providers (CSP), que são provedores de serviço que mantêm um DataCenter para disponibilizar recursos a terceiros, através de modelos de assinatura e pagamento sob demanda.

Algumas das empresas mais conhecidas de Cloud incluem:
- AWS (Amazon Web Services)
- Microsoft Azure
- Google Cloud

### Virtualização

A virtualização é um processo que utiliza um software para dividir um único servidor em vários servidores virtuais, permitindo a utilização de um único computador para realizar diversos serviços, conforme sua necessidade de recursos.

Esse processo permite que computadores robustos tenham toda a sua capacidade aproveitada para diversas tarefas distintas, em vez de ficarem presos a uma tarefa que consome apenas uma parte dos recursos.

A virtualização permite simular vários computadores virtuais em um único computador, assim é possível instalar softwares, recursos ou até mesmo sistemas operacionais diferentes em cada um desses servidores, para suprir diferentes necessidades.

A virtualização ajuda a aproveitar os recursos de um computador e dividir a demanda das requisições em diferentes cargas. Porém, a máquina virtual demora para ser criada e disponibilizada, já que é necessário alocar os recursos do hardware disponível.  
Assim surge a necessidade de abstrair a própria máquina virtual em pequenos serviços, para que eles possam ser alocados de forma rápida.

### Sistema Monolítico

Sistemas monolíticos consistem em uma aplicação ser desenvolvida como um único projeto. Com isso toda a aplicação possui um único código fonte, e a sua execução utiliza os recursos de uma mesma máquina.

Conforme um software cresce, o seu código fonte se torna maior, mais complexo, o que pode levar a uma dificuldade de manter o sistema, ou fazê-lo crescer.

### Microsserviços

O conceito de microsserviços é uma abordagem de arquitetura e organização de desenvolvimento de software que consiste em produzir pequenos serviços independentes que se comunicam através de APIs bem definidas.
 
Na arquitetura de microsserviços, o código fonte monolítico é dividido em pequenos códigos, que lidam com uma funcionalidade específica. Com isso, cada serviço pode pertencer a um time específico, que trabalha com o seu desenvolvimento e manutenção.

A arquitetura de microsserviços permite uma melhor escalabilidade de serviços, pois para aumentar a carga de um serviço específico, não é necessário alterar os recursos de outros serviços. Apenas o serviço que está sendo mais requisitado recebe mais recursos alocados para a sua demanda.

Os microsserviços também permitem utilizar linguagens e tecnologias diferentes, pois cada serviço roda no seu próprio ambiente, e eles se comunicam com os outros através da API.

### Container

Os containers são uma tecnologia usada para reunir um aplicativo e os arquivos necessários para sua execução. O container é um bloco que recebe apenas os recursos que o aplicativo precisa para ser executado. Com isso, a carga necessária para rodar o serviço é muito reduzida, o que permite que ele seja duplicado de forma rápida.

Enquanto a virtualização permite executar sistemas operacionais distintos em um computador, os containers utilizam o mesmo sistema operacional, isolando os processos da aplicação do restante do sistema.

### Docker

O Docker é o software que permite lidar com containers como se fossem máquinas virtuais modulares. Eles permitem bastante flexibilidade para criar, implantar, copiar e migrar os containers.