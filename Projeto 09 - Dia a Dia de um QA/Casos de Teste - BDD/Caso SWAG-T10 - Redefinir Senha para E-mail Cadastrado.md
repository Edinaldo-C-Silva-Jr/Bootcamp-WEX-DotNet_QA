Feature: Cliente Utiliza um E-mail Válido e Redefine a Senha
    @TestCaseKey=SWAG-T10
    Scenario: Cliente Utiliza um E-mail Válido e Redefine a Senha
        
        Given que o cliente esteja na tela de Redefinição de Senha
        
        And insira um e-mail já cadastrado no sistema
        
        When clicar em "Redefinir Senha"
        
        Then enviar um e-mail para o cliente contendo um link que permite redefinir a senha