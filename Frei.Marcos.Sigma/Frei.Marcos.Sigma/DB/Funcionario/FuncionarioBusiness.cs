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
    }
}
