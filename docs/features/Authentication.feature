#language: pt-br

Funcionalidade: Autenticação
    Autenticação dos usuários na aplicação
    Assim eles poderão usufruir das funcionalidades da aplicação

Cenario: Ao enviar as corretas informações de acesso à aplicação, esta deve retornar um token de acesso
    Dado que sou um usuário da aplicação
    Quando enviar meu login e senha
    Entao a aplicação deve me retornar um token de acesso

Cenario: Ao enviar as corretas informações incorretas de acesso à aplicação, esta deve retornar uma mensagem de erro
    Dado que sou um usuário da aplicação
    Quando enviar login e senha incorretos
    Entao a aplicação deve me retornar uma mensagem de erro
