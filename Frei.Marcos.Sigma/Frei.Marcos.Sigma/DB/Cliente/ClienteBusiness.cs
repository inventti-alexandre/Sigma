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
            if (dto.CPF_CNPJ == string.Empty)
                throw new ArgumentException("O campo CPF e CNPF não pode ser vázio!");

            if (dto.razao_social == string.Empty)
                throw new ArgumentException("O campo razão social não pode ser vázio!");

            if (dto.nome == string.Empty)
                throw new ArgumentException("O campo nome não pode ser vázio!");

            if (dto.cep == string.Empty)
                throw new ArgumentException("O campo cep está incompleto!");

            if (dto.estado == string.Empty)
                throw new ArgumentException("O campo Estado não pode ser vázio!");

            if (dto.cidade == string.Empty)
                throw new ArgumentException("O campo Cidade não pode ser vázio!");

            if (dto.bairro == string.Empty)
                throw new ArgumentException("O campo bairro não pode ser vázio!");

            if (dto.endereco == string.Empty)
                throw new ArgumentException("O campo Endereço não pode ser vázio!");

            if (dto.telefone == string.Empty)
                throw new ArgumentException("O campo Telefone não pode ser vázio!");

            if (dto.celular == string.Empty)
                throw new ArgumentException("O campo Celular não pode ser vázio!");

            ClienteDatabase db = new ClienteDatabase();
                   return db.CadastrarCliente(dto);

        }
        public int Alterar(ClienteDTO dto)
        {

            if (dto.CPF_CNPJ == string.Empty)
                throw new ArgumentException("O campo cpf e cnpj não pode ser vázio!");

            if (dto.razao_social == string.Empty)
                throw new ArgumentException("O campo razão social não pode ser vázio!");

            if (dto.nome == string.Empty)
                throw new ArgumentException("O campo nome não pode ser vázio!");



            if (dto.cep == string.Empty)
                throw new ArgumentException("O campo cep está incompleto!");

            if (dto.estado == string.Empty)
                throw new ArgumentException("O campo Estado não pode ser vázio!");

            if (dto.cidade == string.Empty)
                throw new ArgumentException("O campo Cidade não pode ser vázio!");

            if (dto.bairro == string.Empty)
                throw new ArgumentException("O campo bairro não pode ser vázio!");

            if (dto.endereco == string.Empty)
                throw new ArgumentException("O campo Endereço não pode ser vázio!");

            if (dto.telefone == string.Empty)
                throw new ArgumentException("O campo Telefone não pode ser vázio!");

            if (dto.celular == string.Empty)
                throw new ArgumentException("O campo Celular não pode ser vázio!");

            ClienteDatabase db = new ClienteDatabase();
                return db.Alterar(dto);
        }
        public List<ClienteDTO> listarClientes()
        {
            ClienteDatabase db = new ClienteDatabase();
                return db.ListarClientes();
        }
    }
}
