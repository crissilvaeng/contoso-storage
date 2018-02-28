#language: pt-br

Funcionalidade: Armazenamento de Arquivos
    Armazenar arquivos dos usuários
    Assim eles poderão recuperar os arquivos e suas informações

Cenario: Ao enviar um arquivo com sucesso o sistema devolve uma URL para recupera-lo
    Dado que sou um usuário
    Quando eu enviar um arquivo
    Entao a aplicação deve me devolver URL para recuperação do arquivo com suas informações

Cenario: Ao acessar o URL do arquivo deve-se ser capaz de recuperar o arquivo original
    Dado que sou um usuário
    Quando eu enviar um arquivo
    E obtiver o endereço do arquivo no armazenamento
    Quando acessar o endereço do arquivo no armazenamento
    Entao a aplicação deve me devolver o arquivo original

Cenario: Ao enviar arquivo de tamanho superior a cota do usuário o sistema deve retornar um erro
    Dado que sou um usuário
    Quando eu enviar um arquivo
    E ele for de um tamanho superior a minha cota
    Entao a aplicação deve me retornar uma mensagem de erro

Cenario: Ao enviar arquivo de tamanho superior a cota do restante da organização o sistema deve retornar um erro
    Dado que sou um usuário
    Quando eu enviar um arquivo
    E ele for de um tamanho superior ao armazenamento restante da organização
    Entao a aplicação deve me retornar uma mensagem de erro
