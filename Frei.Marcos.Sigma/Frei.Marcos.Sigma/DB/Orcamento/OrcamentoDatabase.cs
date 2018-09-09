using Frei.Marcos.Sigma.DB.Funcionario;
using Frei.Marcos.Sigma.DB.Pecas;
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
        public int GerarOrcamento()
        {
            string script = @"INSERT orcamento(data, situacao, descricao, valor)
                                        VALUES(@data, @situacao, @descricao, @valor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("data", DateTime.Now));
            parms.Add(new MySqlParameter("situacao", "Reprovado"));
            parms.Add(new MySqlParameter("descricao", string.Empty));
            parms.Add(new MySqlParameter("valor", 1));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int SalvarOrc(OrcamentoDTO dto)
        {
            string script = @"UPDATE orcamento SET descricao = @descricao, 
                                                   valor = @valor,
                                                situacao = @situacao,
                              funcionario_id_funcionario = @funcionario_id_funcionario

                                         WHERE id_orcamento = @id_orcamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_orcamento", dto.id_orcamento));
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
                dados.Nome = reader.GetString("NomeF");
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
                dados.Nome = reader.GetString("NomeF");
                dados.Cargo = reader.GetString("Cargo");

                Orcamentos.Add(dados);
            }

            reader.Close();
            return Orcamentos;
        }

        public double ConsultarValorPecas(string id)
        {
            string script = @"SELECT sum(valor) as valor FROM pecas WHERE orcamento_id_orcamento = @orcamento_id_orcamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("orcamento_id_orcamento", id));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            double Valor = 0;
            if (reader.Read())
            {
                Valor = reader.GetDouble("valor");
            }

            reader.Close();
            return Valor;
        }

        public List<PecasDTO> ConsultarPecas(string id)
        {
            string script = $"SELECT * FROM pecas WHERE orcamento_id_orcamento = {id}";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PecasDTO> Pecas = new List<PecasDTO>();
            while (reader.Read())
            {
                PecasDTO dados = new PecasDTO();
                dados.descricao = reader.GetString("descricao");
                dados.nome = reader.GetString("nome");
                dados.quantidade = reader.GetInt32("quantidade");
                dados.valor = reader.GetDouble("valor");

                Pecas.Add(dados);
            }

            reader.Close();
            return Pecas;
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
