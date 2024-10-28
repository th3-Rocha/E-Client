# E-Client

E-Client é um projeto básico desenvolvido em **ASP.NET WebForms** como parte de uma aplicação para uma vaga de estágio na **TDSA**. A aplicação tem como foco operações CRUD (Criar, Ler, Atualizar, Excluir) para gerenciamento de clientes.

## Estrutura do Projeto

O projeto está organizado nas seguintes páginas principais:

- **CreateUpdate.aspx**: Responsável pela criação e atualização das informações dos clientes.
- **ListDelete.aspx**: Exibe a lista de clientes e permite a exclusão de registros.

## Tecnologias Utilizadas

- **ASP.NET WebForms**
- **C#**
- **SQL Server**
- **Bootstrap** para estilização da interface
### Instruções de Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/th3-Rocha/E-Client.git
2. Limpe o Projeto: Após clonar o repositório, execute um clean no projeto para evitar conflitos com arquivos de compilação antigos. Para fazer isso, vá até o Visual Studio e selecione Build > Clean Solution.

### String de conexeção
- O projeto já inclui um banco de dados **SQL Server** configurado. No entanto, caso queira configurar a sua própria conexão, edite a string de conexão no arquivo `Web.config`