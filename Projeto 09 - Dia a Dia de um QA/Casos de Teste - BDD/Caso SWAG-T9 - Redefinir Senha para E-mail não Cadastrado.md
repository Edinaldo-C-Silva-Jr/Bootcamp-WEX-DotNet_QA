Feature: Cliente Tenta Redefinir Senha para um E-mail não Cadastrado  
    @TestCaseKey=SWAG-T9  
    Scenario: Cliente Tenta Redefinir Senha para um E-mail não Cadastrado
        
        Given que o cliente esteja na tela de Redefinição de Senha
        
        And insira um e-mail que não esteja cadastrado no sistema
        
        When clicar em "Redefinir Senha"
        
        Then informar que não existe uma conta vinculada àquele e-mail