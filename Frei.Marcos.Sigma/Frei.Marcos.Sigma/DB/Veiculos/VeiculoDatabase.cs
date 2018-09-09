using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Veiculos
{
    class VeiculoDatabase
    {
        public int SalvarVeiculo(VeiculoDTO dto)
        {
            string script = @"INSERT veiculos(placa,marca,modelo,cor,cliente_id_cliente)
                                    VALUES(@placa,@marca,@modelo,@cor,@cliente_id_cliente)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("placa", dto.placa));
            parms.Add(new MySqlParameter("marca", dto.marca));
            parms.Add(new MySqlParameter("modelo", dto.modelo));
            parms.Add(new MySqlParameter("cor", dto.cor));
            parms.Add(new MySqlParameter("cliente_id_cliente", dto.cliente_id_cliente));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarVeiculo(VeiculoDTO dto)
        {
            string script = @"UPDATE veiculos SET placa = @placa,
                                                  marca = @marca,
                                                 modelo = @modelo,
                                                    cor = @cor,
                                     cliente_id_cliente = @cliente_id_cliente

                                      WHERE id_veiculos = @id_veiculos";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("placa", dto.placa));
            parms.Add(new MySqlParameter("marca", dto.marca));
            parms.Add(new MySqlParameter("modelo", dto.modelo));
            parms.Add(new MySqlParameter("cor", dto.cor));
            parms.Add(new MySqlParameter("cliente_id_cliente", dto.cliente_id_cliente));
            parms.Add(new MySqlParameter("id_veiculos", dto.id_veiculo));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverVaiculo(string id)
        {
            string script = @"DELETE FROM veiculos WHERE id_veiculos = @id_veiculos";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_veiculos", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<VeiculoDTO> ConsultarVeiculo()
        {
            string script = @"SELECT * FROM vw_Veiculo";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VeiculoDTO> Veiculo = new List<VeiculoDTO>();
            while (reader.Read())
            {
                VeiculoDTO dados = new VeiculoDTO();
                dados.cliente_id_cliente = reader.GetInt32("Cliente_id_Cliente");
                dados.modelo = reader.GetString("modelo");
                dados.marca = reader.GetString("marca");
                dados.cor = reader.GetString("cor");
                dados.placa = reader.GetString("placa");
                dados.id_veiculo = reader.GetInt32("id_veiculos");
                dados.nome = reader.GetString("nome");
                dados.CPF_CNPJ = reader.GetString("CPF_CNPJ");

                Veiculo.Add(dados);
            }

            reader.Close();
            return Veiculo;
        }



        public void AlterarDados(double placa , string id,int marca,int modelo,int cor,string cliente_id_cliente)
        {
            string script = @"UPDATE orcamento SET  = @ WHERE id_veiculo = @Veiculo";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_orcamento", id));
             parms.Add(new MySqlParameter("placa", placa));
            parms.Add(new MySqlParameter("marca", marca));
            parms.Add(new MySqlParameter("modelo", modelo));
            parms.Add(new MySqlParameter("cor", cor));
            parms.Add(new MySqlParameter("cliente_id_cliente", cliente_id_cliente));
            

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
