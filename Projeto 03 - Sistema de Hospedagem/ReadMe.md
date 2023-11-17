# Construindo um Sistema de Hospedagem em um Hotel

Solução do *Desafio de Projeto: "Construindo um Sistema de Hospedagem em um Hotel em C#"* do Bootcamp WEX - Desenvolvimento .NET e QA  
Este desafio propõe a criação de um sistema que permita criar reservas para um determinado hotel.

O sistema deve possibilitar: Cadastrar hóspedes, cadastrar suítes, cadastrar uma reserva, mostrar a quantidade de hóspedes na reserva e mostrar o valor total a ser pago.  
- Ao cadastrar hóspedes, são solicitados o nome e o sobrenome.
- Ao cadastrar a suíte, são necessários o tipo da suíte, a capacidade e o valor da diária.
- A reserva recebe uma lista de hóspedes e uma suíte. O sistema deve devolver uma exceção caso a quantidade de hóspedes seja maior que a capacidade da suíte.
- A quantidade de hóspedes é retornada com base na quantidade de hóspedes da lista.
- O valor a ser pago é calculado com base na diária da suíte e na quantidade de dias reservados. Há também um desconto de 10% no valor caso a reserva seja de 10 dias ou mais.

O código deste desafio foi desenvolvido inteiramente por mim, sem utilizar o fork do repositório original.

Esta solução do desafio também conta com: 
- Um menu para realizar todas as ações necessárias no sistema.
- Um segundo menu para realizar o cadastro da reserva, implementado pela classe MenuReserva. Ele possibilita inserir e remover hóspedes, escolher a suíte e listar os hóspedes/suítes.
- Uma classe Hotel, que permite armazenar hóspedes e suítes para que eles sejam listados e utilizados na criação da reserva.
- A possibilidade de escolher os hóspedes e suíte para a reserva com base nos já cadastrados no hotel.
- Tratamento para as exceções geradas na classe Reserva.
- Validações para todas as entradas de dados, para garantir que elas estejam no formato correto.
- Validações para não permitir duplicidade de hóspedes (comaparação feita pelo nome completo) e suítes (comparação feita pelo nome do tipo)