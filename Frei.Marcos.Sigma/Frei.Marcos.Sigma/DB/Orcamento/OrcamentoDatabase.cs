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
            string script = @"INSERT orcamento";
            return 0;
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
    }
}
