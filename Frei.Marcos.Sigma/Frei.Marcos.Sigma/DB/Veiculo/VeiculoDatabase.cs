using System;

class VeiculoDatabase
{
	
        public int CadastrarVeiculo(VeiculoDTO dto)
        {
            string script = @"INSERT Veiculo(placa,marca,modelo,cor)
                                          VALUES(@placa,@marca,@modelo,@cor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("placa", dto.placa));
            parms.Add(new MySqlParameter("marca", dto.marca));
            parms.Add(new MySqlParameter("modelo", dto.modelo));
            parms.Add(new MySqlParameter("cor", dto.cor));
           
            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<VeiculoDTO> ConsultarVeiculoFiltro(string placa)
        {
            string script = $"SELECT * FROM Veiculo WHERE CPF like '%{placa}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VeiculoDTO> Veiculo = new List<VeiculoDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dados = new FuncionarioDTO();
                dados.idBVeiculo = reader.GetInt32("idVeiculo");
                dados.modelo = reader.GetString("modelo");
                dados.marca = reader.GetString("marca");
                dados.cor = reader.GetInt("placa");
                
                Veiculo.Add(dados);
            }

            reader.Close();
            return Veiculo;
        }

        public int RemoverVeiculo(string id)
        {
            string script = @"DELETE FROM Funcionario WHERE idVeiculo = @idVeiculo";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idVeiculo", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarVeiculo(Veiculo dto)
        {
            string script = @"UPDATE Veiculo SET placa = @placa
                                                 marca = @marca
                                                 modelo = @modelo
                                                  cor = @cor

                                         WHERE idVeiculo = @idVeiculo";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idVeiculo", dto.idVeiculo));
            parms.Add(new MySqlParameter("placa", dto.placa));
            parms.Add(new MySqlParameter("marca", dto.marca));
            parms.Add(new MySqlParameter("cor", dto.cor));
            parms.Add(new MySqlParameter("modelo", dto.modelo));
           
            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<VeiculoDatabase> ConsultarVeiculo()
        {
            string script = @"SELECT * FROM Veiculo";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VeiculoDTO> Veiculo = new List<VeiculoDTO>();
            while (reader.Read())
            {
            parms.Add(new MySqlParameter("idVeiculo", dto.idVeiculo));
            parms.Add(new MySqlParameter("placa", dto.placa));
            parms.Add(new MySqlParameter("marca", dto.marca));
            parms.Add(new MySqlParameter("cor", dto.cor));
            parms.Add(new MySqlParameter("modelo", dto.modelo));

            Veiculo.Add(dados);
            }

            reader.Close();
            return Veiculo;
        }
    }

