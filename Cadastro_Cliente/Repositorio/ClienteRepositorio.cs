using Cadastro_Cliente.Data;
using Cadastro_Cliente.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace Cadastro_Cliente.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ClienteRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public ClienteModel ListarPorId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        } 
        
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);

            if (clienteDB == null) throw new Exception("Houve um erro na atualização do cliente");
            
            clienteDB.Nome = cliente.Nome;
            clienteDB.CPF = cliente.CPF;
            clienteDB.Telefone = cliente.Telefone;
            clienteDB.Email = cliente.Email;
            clienteDB.Endereco = cliente.Endereco;
            clienteDB.Numero = cliente.Numero;
            clienteDB.Complemento = cliente.Complemento;
            clienteDB.Bairro = cliente.Bairro;
            clienteDB.Municipio = cliente.Municipio;
            clienteDB.UF = cliente.UF;
            clienteDB.CEP = cliente.CEP;
            clienteDB.Data_Cadastro = cliente.Data_Cadastro;

            _bancoContext.Clientes.Update(clienteDB);
            _bancoContext.SaveChanges();
            return clienteDB;            
        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPorId(id);

            if (clienteDB == null) throw new Exception("Houve um erro na deleção do cliente");

            _bancoContext.Clientes.Remove(clienteDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
