using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Pecas
{
    class PecasDatabase
    {
        public int SalvarPecas(PecasDTO dto)
        {
            string script = @"INSERT pecas(nome, quantidade, valor, descricao, orcamento_id_orcamento)
                                    VALUES(@nome, @quantidade, @valor, @descricao, @orcamento_id_orcamento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", dto.nome));
            parms.Add(new MySqlParameter("quantidade", dto.quantidade));
            parms.Add(new MySqlParameter("valor", dto.valor));
            parms.Add(new MySqlParameter("descricao", dto.descricao));
            parms.Add(new MySqlParameter("orcamento_id_orcamento", dto.orcamento_id_orcamento));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public double CalcularPreco(string id)
        {
            string script = @"SELECT sum(pecas.valor) as valor FROM pecas WHERE orcamento_id_orcamento = @orcamento_id_orcamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("orcamento_id_orcamento", id));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            double valor = 0;
            if (reader.Read())
            {
                valor = reader.GetDouble("valor");
            }

            return valor;
        }

        public double ValorServico(string id)
        {
            string script = @"SELECT valor FROM orcamento WHERE id_orcamento = @id_orcamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_orcamento", id));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            double valor = 0;
            if (reader.Read())
            {
                valor = reader.GetDouble("valor");
            }

            return valor;
        }

        public void AlterarValorFinal(double valor, string id)
        {
            string script = @"UPDATE orcamento SET valor = @valor WHERE id_orcamento = @id_orcamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_orcamento", id));
            parms.Add(new MySqlParameter("valor", valor));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
