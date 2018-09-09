using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Atendimento
{
    class vw_AtendimentoDTO
    {
        public int idAtendimento { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public DateTime Horario { get; set; }
        public string Situacao { get; set; }
        public string NomeF { get; set; }
        public string Cargo { get; set; }
        public string nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public int Funcionario_id_funcionario { get; set; }
        public int Orcamento_id_orcamento { get; set; }
        public int cliente_id_cliente { get; set; }
    }
}
