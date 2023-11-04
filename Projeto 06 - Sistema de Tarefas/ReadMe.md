# Construindo um Sistema de Agendamento de Tarefas

Solução do *Desafio de Projeto: "Construindo um Sistema de Agendamento de Tarefas com Entity Framework"* do Bootcamp WEX - Desenvolvimento .NET e QA
Este desafio propõe a criação de um sistema que permita fazer um CRUD de tarefas utilizando Entity Framework para salvar os registros no banco de dados.

O sistema deve possibilitar: Cadastrar, obter, atualizar e deletar tarefas através de uma API.
A classe de Tarefa deve conter as propriedades Id, Título, Descrição, Data e Status.
O tipo Status deve ser um Enum.
As operações de obter tarefas devem possibilitar obter: 
- Todas as Tarefas
- Uma tarefa pelo Id
- Todas as tarefas pelo Título
- Todas as tarefas pela Data
- Todas as tarefas pelo Status

O código deste desafio foi desenvolvido inteiramente por mim, sem utilizar o fork do repositório original.

Esta solução do desafio também conta com: 
- Validações para os casos de dados inválidos ou nulos em todos os endpoints.
- Criação de uma classe TarefaDTO para fazer o cadastro e atualização sem passar o ID
- Documentação extensa através de comentários XML utilizando o Swagger