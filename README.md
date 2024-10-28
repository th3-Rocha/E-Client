# E-Client

E-Client é um projeto básico desenvolvido em **ASP.NET WebForms** como parte de uma aplicação para uma vaga de estágio na **TDSA**. A aplicação tem como foco operações CRUD (Criar, Ler, Atualizar, Excluir) para gerenciamento de clientes.

## Estrutura do Projeto

O projeto está organizado nas seguintes páginas principais:

- **CreateUpdate.aspx**: Responsável pela criação e atualização das informações dos clientes.
- **ListDelete.aspx**: Exibe a lista de clientes e permite a exclusão de registros.

## Funcionalidades Principais

- **Gerenciamento de Clientes**: Permite criar, listar, atualizar e excluir clientes.
- **Validação de Dados**: Utiliza validadores do ASP.NET para garantir a integridade dos dados.
- **Integração com SQL Server**: Utiliza o SQL Server para armazenar e recuperar dados de clientes.
- **ASP.NET UpdatePanel**: Habilita atualizações parciais da página para uma experiência mais suave.
- **Estilo com Bootstrap**: Aplica classes do Bootstrap para um design de UI moderno e responsivo.

## Tecnologias Utilizadas

- **ASP.NET WebForms**
- **C#**
- **SQL Server**
- **Bootstrap** para estilização da interface
### Instruções de Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/th3-Rocha/E-Client.git


### String de conexeção
- O projeto já inclui um banco de dados **SQL Server** configurado. No entanto, caso queira configurar a sua própria conexão, edite a string de conexão no arquivo `Web.config` conforme o exemplo abaixo:
<connectionStrings>
    <add name="EClientDbConnection" connectionString="sua_string_de_conexao_aqui" providerName="System.Data.SqlClient" />
</connectionStrings>