using Frei.Marcos.Sigma.DB.Funcionario;
using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Orcamento
{
    class OrcamentoDatabase
    {
        public int SalvarOrc(OrcamentoDTO dto)
        {
            string script = @"INSERT orcamento(data, descricao, valor, situacao, funcionario_id_funcionario)
                                        VALUES(@data, @descricao, @valor, @situacao, @funcionario_id_funcionario)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("data", dto.data));
            parms.Add(new MySqlParameter("descricao", dto.descricao));
            parms.Add(new MySqlParameter("valor", dto.valor));
            parms.Add(new MySqlParameter("funcionario_id_funcionario", dto.funcionario_id_funcionario));
            parms.Add(new MySqlParameter("situacao", dto.situacao));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<OrcamentoDTO> ConsultarFuncionarios()
        {
            string script = @"SELECT * FROM Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<OrcamentoDTO> Funcionarios = new List<OrcamentoDTO>();
            while (reader.Read())
            {
                OrcamentoDTO dados = new OrcamentoDTO();
                dados.funcionario_id_funcionario = reader.GetInt32("idFuncionario");
                dados.Nome = reader.GetString("Nome");
                dados.Cargo = reader.GetString("Cargo");

                Funcionarios.Add(dados);
            }

            reader.Close();
            return Funcionarios;
        }

        public List<OrcamentoDTO> ConsultarOrc()
        {
            string script = @"Select * From vw_Orcamento_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<OrcamentoDTO> Orcamentos = new List<OrcamentoDTO>();
            while (reader.Read())
            {
                OrcamentoDTO dados = new OrcamentoDTO();
                dados.id_orcamento = reader.GetInt32("id_orcamento");
                dados.data = reader.GetDateTime("data");
                dados.descricao = reader.GetString("descricao");
                dados.valor = reader.GetInt32("valor");
                dados.situacao = reader.GetString("situacao");
                dados.funcionario_id_funcionario = reader.GetInt32("funcionario_id_funcionario");
                dados.Nome = reader.GetString("Nome");
                dados.Cargo = reader.GetString("Cargo");

                Orcamentos.Add(dados);
            }

            reader.Close();
            return Orcamentos;
        }

        public int RemoverOrcamento(string id)
        {
            string script = @"DELETE FROM orcamento WHERE id_orcamento = @id_orcamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_orcamento", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
    }
}
