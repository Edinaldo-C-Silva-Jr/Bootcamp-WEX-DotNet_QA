# Fundamentos da Automação de Testes

### Propósito da Automação no Processo de Teste

#### Ciclo de Vida do Teste

- Planejamento
- Monitoramento e Controle
- Análise
- Design / Projeto
- Implementação
- Execução
- Finalização

#### A Automação como Atividade de Teste

Assim como o teste manual, o projeto de automação está envolvido em todo o ciclo.  
Um projeto de automação de software é conhecido como um "Testware", um kit que deve ser pensado para a implantação da automação. Ele é composto por:
- Software: Deve ser construído para permitir automação.
- Documentação: Para gerenciamento de testes.
- Ambientes de Teste: Os ambientes onde os testes serão executados.
- Dados de Teste: Os dados usados nos testes.

A implementação de testes automatizados é similar aos testes manuais. As atividades de testes relacionadas à implementação de automação são:
- Implementação de casos de testes automatizados.
- Monitoramento e controle de execução.
- Interpretação, relatório e log dos resultados.

#### Objetivos da Automação de Testes

- Melhorar a eficiência dos testes.
- Ampliar a cobertura de testes.
- Reduzir o custo total dos testes .
- Diminuir o tempo de execução dos testes.
- Aumentar a frequência dos testes.

Mesmo que o tempo investido na criação e automação dos testes demore mais do que a criação dos testes manuais, eles começam a fazer diferença com o tempo, pois uma estrutura de testes automatizados bem implementada permite executá-los quantas vezes for preciso.

#### Vantagens da Automação

- Testes que não podem ser feitos de maneira manual podem ser implementados com automação, com ferramentas que auxiliam na sua execução. Com isso o computador fica responsável por executá-los.
- Complexidade pode aumentar. Mesmo que a complexidade de uma funcionalidade aumente muito, o teste feito de forma automática pode ser executado sem dificuldades.
- Reduz erros humanos na validação. Os seres humanos possuem um julgamento bom do ponto de vista subjetivo, mas está sujeito a erros de objetividade. O computador executa sempre as mesmas etapas e gera os mesmos resultados.
- Feedback mais rápido, pois os testes são executados de forma automática.
- Maior confiabilidade, pois a execução dos testes é feita de forma objetiva e rápida pelo computador, sem se sujeitar a erros humanos. Porém, a confiabilidade depende da qualidade dos testes escritos.

#### Desvantagens da Automação

- Custos adicionais necessários para a automação dos testes.
- Investimento inicial para configuração da arquitetura de testes.
- Investimento na arquitetura do software sob teste, para que o sistema esteja de acordo com os testes automatizados.
- Complexidade de codificação, pois o teste deve ser desenvolvido, codificado, e para isso é preciso entender o código.
- Manutenção dos testes, quando o software mudar, os testes também precisam ser alterados.

### Fatores de Sucesso para Automação

- Nem todos os testes podem ou devem ser automatizados. Deve ser feita uma análise do sistema e dos casos de teste para saber o que pode ou deve ser automatizado. É necessário um grande investimento para automatizar testes, por isso é necessário saber o quanto se pode automatizar com os recursos e equipes disponíveis. Alguns cenários também podem não precisar de automação, caso não sejam cenários críticos ou que não deem muito problema.
- A automação de testes não substitui os testes manuais. A primeira coisa a se fazer antes de automatizar um teste é fazer um teste manual, para definir os cenários e regras para o teste automatizado.
- A automação é limitada pela análise do sistema. O script é codificado por uma pessoa, um analista, e o teste será tão bom quando a capacidade da pessoa de desenvolvê-lo com qualidade. Um teste faz apenas e exatamente o que o código manda ele fazer, por isso a subjetividade de um ser humano é importante para poder captar cenários que talvez não sejam cobertos por eles.
- O script de testes automatizados também é um código que precisa ser escrito com código limpo e boas práticas. 

#### Arquitetura do Projeto de Automação

- A arquitetura do projeto de automação deve estar alinhada com a arquitetura do produto de software. Os componentes usados, a infraestrutura, os padrões devem ser pensados para estar de acordo com o software que está sendo testado.
- Os requisitos não funcionais também são importantes para testes.
- O envolvimento dos desenvolvedores do projeto é essencial para que a automação tenha sucesso. É preciso ter contato com pessoas que conhecem o software para fazer a automação dos testes.

#### Testabilidade

- O produto de software deve ser construído pensando no suporte aos testes automatizados. Para que os testes tenham sucesso, o software deve ser feito para facilitar a implementação de testes.
- Um sistema desacoplado entre as camadas facilita que o software seja testado.
- Expor os módulos, funções e classes facilita os testes.
- Identificar e analisar os módulos mais testáveis faz parte do processo para decisão de automação.

### Importância de Ferramentas de Suporte para Testes Automatizados

Critérios para avaliar um bom framework de automação de testes:
- Implementar relatórios de testes.
- Facilitar a resolução de problemas.
- Facilitar a configuração de ambientes.
- Documentar casos de testes.
- Rastrear etapas de casos de teste.
- Facilitar manutenção dos testes.
- Atualização dos testes automatizados.
- Monitorar e restaurar execução de testes em caso de falha.