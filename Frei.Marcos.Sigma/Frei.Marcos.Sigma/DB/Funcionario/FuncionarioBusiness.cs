using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public int CadastrarFuncionario(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.CadastrarFuncionario(dto);
        }

        public List<FuncionarioDTO> ConsultarFuncionarios(string CPF)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            if (CPF != string.Empty)
            {
                return db.ConsultarFuncionariosFiltro(CPF); 
            }
            else
                return db.ConsultarFuncionarios();
        }
        public int RemoverFuncionario(string id)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.RemoverFuncionario(id);
        }
        public int AlterarFuncionario(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.AlterarFuncionario(dto);
        }
    }
}
