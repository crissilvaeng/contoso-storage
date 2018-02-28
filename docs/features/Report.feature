#language: pt-br

Funcionalidade: Relatórios
    Autenticação dos usuários na aplicação
    Assim eles poderão usufruir das funcionalidades da aplicação

Cenario: Ao acessar os relatórios de arquivos deve-se ser capaz de realizar filtros nas listas de arquivos das organizações
    Dado que sou um administrador
    Quando acessar a listagem de arquivos das organizações
    E aplicar filtros
    Entao o sistema me trará a listagem filtrada

Cenario: Ao enviar um arquivo suas informações devem ser armazenadas
    Dado que sou um usuário
    Quando eu enviar um arquivo
    E acessar o endereço do das informações do arquivo
    Entao a aplicação deve retornar nome, tamanho, tipo e data de upload do arquivo

Cenario: Ao acessar a organização deve-se poder visualizar as informações dos arquivos enviados pelos usuários
    Dado que sou um dono
    Quando acessar o sistema
    E navegar até os arquivos hospedados
    Entao a aplicação retornara as informações dos arquivos com usuário, nome, tamanho, tipo e data de upload
