#language: pt-br

Funcionalidade: Cadastro de Organizações e Usuários
    Cadastrar organizações e seus usuários
    Assim os usuários poderão usufruir das funcionalidades do sistema

Cenario: Ao enviar as informações de uma organização a mesma deve ser armazenada
    Dado que sou um administrador
    Quando eu enviar as informações de uma organização
    Entao a aplicação deve me devolver os dados da organização com o código do armazenamento

Cenario: Ao enviar as informações de um usuário a mesmo deve ser armazenada
    Dado que sou um dono
    Quando eu enviar as informações de um usuário
    Entao a aplicação deve me devolver os dados do usuário com o código do armazenamento

Cenario: Ao editar as configurações de uma organização as mesmas devem ser armazenadas
    Dado que sou um administrador
    Quando eu alterar as informações de limite de upload ou de limite de armazenamento
    Entao a aplicação deve me devolver os dados atualizados
