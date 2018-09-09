using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Atendimento
{
    class AtendimentoBusiness
    {
        public int CadastrarAtendimento(AtendimentoDTO dto)
        {
            AtendimentoDatabase db = new AtendimentoDatabase();
            return db.CadastrarAtendimento(dto);
        }

        public List<vw_AtendimentoDTO> ListarAtendimentos()
        {
            AtendimentoDatabase db = new AtendimentoDatabase();
            return db.ListarAtendimentos();
        }

        public int RemoverAtendimento(string id)
        {
            AtendimentoDatabase db = new AtendimentoDatabase();
            return db.RemoverAtendimento(id);
        }
    }
}
