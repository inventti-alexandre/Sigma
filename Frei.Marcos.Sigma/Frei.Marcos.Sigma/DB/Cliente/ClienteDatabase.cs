using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Cliente
{
    class ClienteDatabase
    {
        public int CadastrarCliente(ClienteDTO dto)
        {
            string script = @"INSERT INTO Cliente(CPF_CNPJ, razao_social, nome, Data_nascimento, cep, estado, cidade, bairro, endereco, telefone, celular)
                            VALUES(@CPF_CNPJ, @razao_social, @nome, @Data_nascimento, @cep, @estado, @cidade, @bairro, @endereco, @telefone, @celular)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("CPF_CNPJ", dto.CPF_CNPJ));
            parms.Add(new MySqlParameter("razao_social", dto.razao_social));
            parms.Add(new MySqlParameter("nome", dto.nome));
            parms.Add(new MySqlParameter("Data_nascimento", dto.Data_nascimento));
            parms.Add(new MySqlParameter("cep", dto.cep));
            parms.Add(new MySqlParameter("estado", dto.estado));
            parms.Add(new MySqlParameter("cidade", dto.cidade));
            parms.Add(new MySqlParameter("bairro", dto.bairro));
            parms.Add(new MySqlParameter("endereco", dto.endereco));
            parms.Add(new MySqlParameter("telefone", dto. telefone));
            parms.Add(new MySqlParameter("celular", dto.celular));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int Alterar(ClienteDTO dto)
        {
            string script = @"UPDATE Cliente SET CPF_CNPJ = @CPF_CNPJ, razao_social = @razao_social, nome = @nome, Data_nascimento = @Data_nascimento, cep = @cep, estado = @estado, cidade = @cidade, bairro = @bairro, endereco = @endereco,  telefone = @telefone, celular = @celular";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("CPF_CNPJ", dto.CPF_CNPJ));
            parms.Add(new MySqlParameter("razao_social", dto.razao_social));
            parms.Add(new MySqlParameter("nome", dto.nome));
            parms.Add(new MySqlParameter("Data_nascimento", dto.Data_nascimento));
            parms.Add(new MySqlParameter("cep", dto.cep));
            parms.Add(new MySqlParameter("estado", dto.estado));
            parms.Add(new MySqlParameter("cidade", dto.cidade));
            parms.Add(new MySqlParameter("bairro", dto.bairro));
            parms.Add(new MySqlParameter("endereco", dto.endereco));
            parms.Add(new MySqlParameter("telefone", dto.telefone));
            parms.Add(new MySqlParameter("celular", dto.celular));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ClienteDTO> ListarClientes()
        {
            string script = @"SELECT * FROM Cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> DTO = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.idCliente = reader.GetInt32("idCliente");
                dto.CPF_CNPJ = reader.GetString("CPF_CNPJ");
                dto.razao_social = reader.GetString("razao_social");
                dto.nome = reader.GetString("nome");
                dto.Data_nascimento = reader.GetDateTime("Data_nascimento");
                dto.cep = reader.GetString("cep");
                dto.estado = reader.GetString("estado");
                dto.cidade = reader.GetString("cidade");
                dto.bairro = reader.GetString("bairro");
                dto.endereco = reader.GetString("endereco");
                dto.telefone = reader.GetString("telefone");
                dto.celular = reader.GetString("celular");

                DTO.Add(dto);
            }
            reader.Close();
            return DTO;
            
        }
    }
}
