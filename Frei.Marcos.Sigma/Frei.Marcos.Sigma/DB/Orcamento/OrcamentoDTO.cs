using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Orcamento
{
    class OrcamentoDTO
    {
        public int id_orcamento { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }
        public double valor { get; set; }
        public string situacao { get; set; }
        public int funcionario_id_funcionario { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
    }
}
