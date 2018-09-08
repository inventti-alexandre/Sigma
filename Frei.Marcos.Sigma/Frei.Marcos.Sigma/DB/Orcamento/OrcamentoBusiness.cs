using Frei.Marcos.Sigma.DB.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Orcamento
{
    class OrcamentoBusiness
    {
        public int SalvarOrc(OrcamentoDTO dto)
        {
            OrcamentoDatabase db = new OrcamentoDatabase();
            return db.SalvarOrc(dto);
        }
        public int RemoverOrcamento(string id)
        {
            OrcamentoDatabase db = new OrcamentoDatabase();
            return db.RemoverOrcamento(id);
        }
        public List<OrcamentoDTO> ConsultarFuncionarios()
        {
            OrcamentoDatabase db = new OrcamentoDatabase();
            return db.ConsultarFuncionarios();
        }
        public List<OrcamentoDTO> ConsultarOrc()
        {
            OrcamentoDatabase db = new OrcamentoDatabase();
            return db.ConsultarOrc();
        }
    }
}
