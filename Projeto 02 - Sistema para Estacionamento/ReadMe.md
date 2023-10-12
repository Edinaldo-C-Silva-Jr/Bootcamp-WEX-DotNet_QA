# Construindo um Sistema para um Estacionamento

Solução do *Desafio de Projeto: "Construindo um Sistema para um Estacionamento Com C#"* do Bootcamp WEX - Desenvolvimento .NET e QA
Este desafio porpõe a criação de um sistema que permita gerenciar os veículos em um estacionamento.

O sistema deve possibilitar: Cadastrar veículos, Listar veículos e Remover veículos, utilizando como identificador o valor da sua placa.
Ao iniciar a execução do sistema, é perguntado o preço inicial de estacionamento, e também o preço por hora estacionada.
Ao remover o veículo, é perguntada a quantidade de horas que ele ficou estacionado, e o valor total a ser pago é calculado e exibido.

O código deste desafio foi desenvolvido inteiramente por mim, sem utilizar o fork do repositório original.

Esta solução do desafio também conta com: 
- Validações para a entrada de valores numéricos, a fim de impedir que haja uma exceção por valores inválidos.
- Informa ao usuário que o veículo já está estacionado caso o valor da placa já exista na lista de veículos.
- Validação da entrada de placas dos veículos, fornecendo uma máscara para garantir que o valor esteja no formato correto. Também exibe a máscara na tela para mostrar a quantidade de caracteres.