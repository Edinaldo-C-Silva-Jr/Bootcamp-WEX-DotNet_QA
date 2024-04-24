# Visualizando e Desfazendo Alterações em um Repositório Local

#### Visualizando os commits recentes
```
git log 
```

Permite visualizar os commits mais recentes realizados neste repositório. O comando exibe o commit, o nome de usuário e email do autor, a data em que ele foi realizado e o comentário adicionado ao commit.
```
git reflog
```

Permite visualizar o histórico de commits no repositório de forma mais sucinta. Também exibe commits que foram alterados ou desfeitos.

# Desfazer Alterações no Repositório Local

#### Deletando um repositório

Caso o repositório esteja iniciado em uma pasta errada, ou caso deseje-se remover o versionamento de uma pasta, basta remover a pasta .git de dentro dela. A pasta .git é a responsável pelo versionamento, sem ela não existe repositório.

#### Desfazendo alterações na Staging Area
```
git restore [nome do arquivo]
```

Restaura um arquivo específico, com o nome [nome do arquivo], ao último estado salvo no repositório. Ele descarta todas as alterações que foram feitas no arquivo, localmente, após a última vez que ele fez parte de um commit. Cuidado ao utilizar para não haver perda de dados ou de trabalho.

#### Alterando um commit
```
git commit --amend -m [mensagem]
```

Altera a mensagem inserida no último commit para a nova mensagem inserida em [mensagem]. Ao usar esse comando, a mensagem anterior é apagada. Só é possível alterar a mensagem do commit mais recente.
```
git reset [tipo] [hashdo commit]
```

Retorna o repositório a um commit anterior, com o hash fornecido. O reporitório retorna ao commit do hash especificado, e todos os commits posteriores são desfeitos. O comportamento do Git em relação aos arquivos depende do tipo de reset definido em [tipo]. Caso o comando seja usado sem um tipo, ele utiliza "mixed" como padrão.  
Os tipos de reset são:
- `--soft` - Desfaz todos os commits posteriores ao commit fornecido, retornando os arquivos e as alterações pertencentes a esses commits para a área de trabalho do repositório, já inseridos na Staging Area e prontos para serem commitados novamente.
- `--mixed` - Desfaz todos os commits posteriores ao commit fornecido, retornando os arquivos e as alterações pertencentes a esses commits para a área de trabalho do repositório, mas como arquivos Untracked, portanto eles não estão prontos para serem commitados novamente.
- `--hard` - Desfaz todos os commits posteriores ao commit fornecido e automaticamente deleta todos os arquivos pertencentes a eles. 

**Atenção:** Alterações em commits anteriores devem ser feitas apenas **antes de enviar as alterações ao repositório remoto**. A partir do momento que outras pessoas têm acesso às alterações, desfazê-las pode gerar diversos conflitos. O ideal, caso haja necessidade de desfazer alterações existentes em um repositório remoto, é fazer isso em um novo commit e enviar ao repositório.