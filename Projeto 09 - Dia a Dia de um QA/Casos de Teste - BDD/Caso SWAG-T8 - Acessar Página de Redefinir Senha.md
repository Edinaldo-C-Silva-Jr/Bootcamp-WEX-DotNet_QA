Feature: Cliente Acessa a Página de Redefinição de Senha  
    @TestCaseKey=SWAG-T8  
    Scenario: Cliente Acessa a Página de Redefinição de Senha
        
        Given que o cliente esteja na tela de login
        
        When clicar em "Esqueci minha Senha"
        
        Then redirecionar para a página de Redefinição de Senha