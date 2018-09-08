using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Pecas
{
    class PecasBusiness
    {
        PecasDatabase db = new PecasDatabase();
        string id = string.Empty;

        public void Gravar(List<PecasDTO> dto)
        {
            foreach (PecasDTO item in dto)
            {
                db.SalvarPecas(item);
                id = item.orcamento_id_orcamento.ToString();
            }

            db.AlterarValorFinal(db.CalcularPreco(id), id);
        }
    }
}
