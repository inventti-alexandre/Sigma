using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Atendimento
{
    class AtendimentoDatabase
    {
        public int CadastrarAtendimento(AtendimentoDTO dto)
        {
            string script = @"INSERT Atendimento(Data, Descricao, Horario, Situacao, Funcionario_id_funcionario, Orcamento_id_orcamento, cliente_id_cliente)
                                          VALUES(@Data, @Descricao, @Horario, @Situacao, @Funcionario_id_funcionario, @Orcamento_id_orcamento, @cliente_id_cliente)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Data", DateTime.Now));
            parms.Add(new MySqlParameter("Descricao", dto.Descricao));
            parms.Add(new MySqlParameter("Horario", DateTime.Now));
            parms.Add(new MySqlParameter("Situacao", dto.Situacao));
            parms.Add(new MySqlParameter("Funcionario_id_funcionario", dto.Funcionario_id_funcionario));
            parms.Add(new MySqlParameter("Orcamento_id_orcamento", dto.Orcamento_id_orcamento));
            parms.Add(new MySqlParameter("cliente_id_cliente", dto.cliente_id_cliente));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<vw_AtendimentoDTO> ListarAtendimentos()
        {
            string script = @"SELECT * FROM vw_Atendimento";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vw_AtendimentoDTO> atendimentos = new List<vw_AtendimentoDTO>();
            while (reader.Read())
            {
                vw_AtendimentoDTO dto = new vw_AtendimentoDTO();
                dto.Data = reader.GetDateTime("Data");
                dto.Descricao = reader.GetString("Descricao");
                dto.idAtendimento = reader.GetInt32("idAtendimento");
                dto.Horario = reader.GetDateTime("Horario");
                dto.Situacao = reader.GetString("Situacao");
                dto.nome = reader.GetString("nome");
                dto.CPF_CNPJ = reader.GetString("CPF_CNPJ");
                dto.NomeF = reader.GetString("NomeF");
                dto.Cargo = reader.GetString("Cargo");
                dto.Orcamento_id_orcamento = reader.GetInt32("Orcamento_id_orcamento");

                atendimentos.Add(dto);
            }

            reader.Close();
            return atendimentos;
        }

        public int RemoverAtendimento(string id)
        {
            string script = @"DELETE FROM Atendimento WHERE idAtendimento = @idAtendimento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idAtendimento", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
    }
}
