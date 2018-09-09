using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Cliente
{
    class ClienteBusiness
    {
        public int Cadastrar(ClienteDTO dto)
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.CadastrarCliente(dto);
        }
        public int Alterar(ClienteDTO dto)
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.Alterar(dto);
        }
        public int CadastrarJ(ClienteDTO dto)
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.CadastrarCliente(dto);
        }
        public int AlterarJ(ClienteDTO dto)
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.Alterar(dto);
        }
        public List<ClienteDTO> listarClientes(string nome)
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.ListarClientes(nome);
        }
        public int RemoverCliente(string id)
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.RemoverCliente(id);
        }
    }
}
