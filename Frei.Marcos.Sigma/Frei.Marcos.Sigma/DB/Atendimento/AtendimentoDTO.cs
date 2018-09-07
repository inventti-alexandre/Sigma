using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Atendimento
{
    class AtendimentoDTO
    {
        public int idAtendimento { get; set; }
        public DateTime Data { get; set; }
        public string Descricaoo { get; set; }
        public decimal Horario { get; set; }
        public int Situacao { get; set; }


    }
}
