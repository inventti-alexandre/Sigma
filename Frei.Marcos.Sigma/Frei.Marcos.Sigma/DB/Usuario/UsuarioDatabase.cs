using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Usuario
{
    class UsuarioDatabase
    {
        public bool AutenticarUsuario(UsuarioDTO dto)
        {
            string script = @"SELECT * FROM Funcionario WHERE Usuario = @Usuario AND Senha = @Senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Usuario", dto.Usuario));
            parms.Add(new MySqlParameter("Senha", dto.Senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if (reader.Read())
                return true;
            else
                return false;
        }
    }
}
