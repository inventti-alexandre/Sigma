using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Funcionario
{
    class FuncionarioDatabase
    {
        public int CadastrarFuncionario(FuncionarioDTO dto)
        {
            string script = @"INSERT Funcionario(Usuario, NomeF, Data_nascimento, CPF, RG, Endereco, Complemento, Cargo, observacao)
                                          VALUES(@Usuario, @NomeF, @Data_nascimento, @CPF, @RG, @Endereco, @Complemento, @Cargo, @observacao)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Usuario", dto.Usuario));
            parms.Add(new MySqlParameter("NomeF", dto.NomeF));
            parms.Add(new MySqlParameter("Data_nascimento", dto.Data_nascimento));
            parms.Add(new MySqlParameter("CPF", dto.CPF));
            parms.Add(new MySqlParameter("RG", dto.RG));
            parms.Add(new MySqlParameter("Endereco", dto.Endereco));
            parms.Add(new MySqlParameter("Complemento", dto.Complemento));
            parms.Add(new MySqlParameter("Cargo", dto.Cargo));
            parms.Add(new MySqlParameter("observacao", dto.observacao));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<FuncionarioDTO> ConsultarFuncionariosFiltro(string CPF)
        {
            string script = $"SELECT * FROM Funcionario WHERE CPF like '%{CPF}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> Funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dados = new FuncionarioDTO();
                dados.idFuncionario = reader.GetInt32("idFuncionario");
                dados.Usuario = reader.GetString("Usuario");
                dados.NomeF = reader.GetString("NomeF");
                dados.Data_nascimento = reader.GetDateTime("Data_nascimento");
                dados.CPF = reader.GetString("CPF");
                dados.RG = reader.GetString("RG");
                dados.Endereco = reader.GetString("Endereco");
                dados.Complemento = reader.GetString("Complemento");
                dados.Cargo = reader.GetString("Cargo");
                dados.observacao = reader.GetString("observacao");

                Funcionarios.Add(dados);
            }

            reader.Close();
            return Funcionarios;
        }

        public int RemoverFuncionario(string id)
        {
            string script = @"DELETE FROM Funcionario WHERE idFuncionario = @idFuncionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idFuncionario", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarFuncionario(FuncionarioDTO dto)
        {
            string script = @"UPDATE Funcionario SET Usuario = @Usuario,
                                                       NomeF = @NomeF,
                                             Data_nascimento = @Data_nascimento,
                                                         CPF = @CPF,
                                                          RG = @RG,
                                                    Endereco = @Endereco,
                                                 Complemento = @Complemento,
                                                       Cargo = @Cargo,
                                                  observacao = @observacao

                                         WHERE idFuncionario = @idFuncionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idFuncionario", dto.idFuncionario));
            parms.Add(new MySqlParameter("Usuario", dto.Usuario));
            parms.Add(new MySqlParameter("NomeF", dto.NomeF));
            parms.Add(new MySqlParameter("Data_nascimento", dto.Data_nascimento));
            parms.Add(new MySqlParameter("CPF", dto.CPF));
            parms.Add(new MySqlParameter("RG", dto.RG));
            parms.Add(new MySqlParameter("Endereco", dto.Endereco));
            parms.Add(new MySqlParameter("Complemento", dto.Complemento));
            parms.Add(new MySqlParameter("Cargo", dto.Cargo));
            parms.Add(new MySqlParameter("observacao", dto.observacao));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<FuncionarioDTO> ConsultarFuncionarios()
        {
            string script = @"SELECT * FROM Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> Funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dados = new FuncionarioDTO();
                dados.idFuncionario = reader.GetInt32("idFuncionario");
                dados.Usuario = reader.GetString("Usuario");
                dados.NomeF = reader.GetString("NomeF");
                dados.Data_nascimento = reader.GetDateTime("Data_nascimento");
                dados.CPF = reader.GetString("CPF");
                dados.RG = reader.GetString("RG");
                dados.Endereco = reader.GetString("Endereco");
                dados.Complemento = reader.GetString("Complemento");
                dados.Cargo = reader.GetString("Cargo");
                dados.observacao = reader.GetString("observacao");

                Funcionarios.Add(dados);
            }

            reader.Close();
            return Funcionarios;
        }
    }
}
