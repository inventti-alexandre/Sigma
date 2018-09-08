using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Pecas
{
    class PecasDTO
    {
        public int id_pecas { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public double valor { get; set; }
        public string descricao { get; set; }
        public int orcamento_id_orcamento { get; set; }
    }
}
