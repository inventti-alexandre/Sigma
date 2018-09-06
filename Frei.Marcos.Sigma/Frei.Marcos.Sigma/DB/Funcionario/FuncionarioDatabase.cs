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
            string script = @"INSERT Funcionario(Usuario, Nome, Data_nascimento, CPF, RG, Endereco, Complemento, Cargo, observacao)
                                          VALUES(@Usuario, @Nome, @Data_nascimento, @CPF, @RG, @Endereco, @Complemento, @Cargo, @observacao)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Usuario", dto.Usuario));
            parms.Add(new MySqlParameter("Nome", dto.Nome));
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
    }
}
