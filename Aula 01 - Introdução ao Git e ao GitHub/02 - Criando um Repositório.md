# Criando um Repositório Local

A criação de um repositório pode ser feita de duas formas: criando um novo repositório local ou clonando um repositório remoto existente.

#### Criando um novo repositório 
```
git init
```

Este comando transforma a pasta atual em um repositório local do Git.  
Ao usá-lo, uma pasta chamada `.git` é criada dentro da pasta atual. Esta pasta é responsável por gerenciar o versionamento de código.

#### Clonando um repositório
```
git clone [URL]  
git clone [URL] [nome]
```

Estes comandos clonam um repositório remoto existente, que se encontra na URL informada em [URL], e o transformam em um repositório local pronto para trabalho.  
O primeiro comando clona o repositório remoto mantendo seu nome, enquanto o segundo clona e altera, localmente, o nome da pasta raiz para o inserido em [nome].

# Criando um Repositório Remoto no Github

Aqui já fica implícito que o usuário tem uma conta no GitHub.

Na página do perfil de usuário do Github, clicar em `➕🔽`, depois em "New Repository" para criar um novo repositório.  
A seguir, há algumas informações que podem ser preenchidas:

- **Repository name:** Nome do projeto. Precisa ser um nome no formato válido, e não pode ser um nome que já foi utilizado em outro repositório do mesmo usuário.
- **Description:** Uma breve descrição do projeto.
- **Access:**
  - **Public:** Todos os usuários podem ver e clonar o repositório, mas o dono dele pode escolher quem possui permissão para fazer commits.
  - **Private:** O dono do repositório pode escolher quem pode ver e utilizar o repositório.
- **Add Readme:** Adiciona um arquivo ReadMe ao criar o repositório. O ReadMe é onde se pode colocar informações mais detalhadas sobre o projeto, que serão exibidas diretamente na página do projeto no GitHub.
- **Add .gitignore:** Adiciona um arquivo `.gitignore` ao criar o repositório. O .gitignore é um arquivo que permite identificar arquivos, extensões ou pastas que o git deve ignorar durante o versionamento.
- **Choose a license:** Permite adicionar uma licença que informa o que outras pessoas podem fazer com seu código