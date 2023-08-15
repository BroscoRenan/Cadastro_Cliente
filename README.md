# Projeto de Cadastro de Clientes

Este é um projeto de sistema de cadastro de clientes com funcionalidades de inclusão, alteração, exclusão e pesquisa de informações. O sistema é baseado em um banco de dados chamado "Cadastros" com uma tabela chamada "clientes".

## SGBD MySQL = ConnectionString "database":"server=localhost;database=cadastros;port=3306;uid=root;pwd=R1e2n3a4n5!"
## Estrutura do Banco de Dados

### Base de dados: Cadastros

#### Tabela: clientes = Tabela onde serão armazenados os dados dos clientes cadastrados para que possam ser recuperados e manipulados.

| Coluna         | Tipo           | Restrições                       |
| -------------- | -------------- | -------------------------------- |
| Id             | int            | Chave primária de identificação unica, tipo inteiro, Auto-incremento|
| Nome           | varchar(50)    | Armazena o nome do cliente, tipo varchar - 50 caracteres|                         
| Email          | varchar(100)   | Armazena o email do cliente, tipo varchar - 100 caracteres|  
| CPF            | varchar(14)    | Armazena o CPF do cliente, tipo varchar - 14 caracteres|  
| Telefone       | longtext       | Armazena o telefone do cliente, longtext|  
| Endereco       | varchar(100)   | Armazena o endereço do cliente, tipo varchar - 100 caracteres|  
| Numero         | varchar(10)    | Armazena o numero da residencia do cliente, tipo varchar - 10 caracteres|  
| Complemento    | varchar(50)    | Armazena o complemento do cliente, tipo varchar - 50 caracteres|  
| Bairro         | varchar(50)    | Armazena o bairro do cliente, tipo varchar - 50 caracteres|  
| Municipio      | varchar(50)    | Armazena o municipio do cliente, tipo varchar - 50 caracteres|  
| UF             | varchar(2)     | Armazena o Estado(Sigla) do cliente, tipo varchar - 2 caracteres|  
| CEP            | varchar(10)    | Armazena o CEP do cliente, tipo varchar - 50 caracteres|  
| Data_Cadastro  | datetime(6)    | Armazena a data do cadastro do cliente, tipo data "AAAA-MM-DD"|  

