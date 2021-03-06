﻿using System;
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
        public string Descricao { get; set; }
        public decimal Horario { get; set; }
        public string Situacao { get; set; }
        public int Funcionario_id_funcionario { get; set; }
        public int Orcamento_id_orcamento { get; set; }
        public int cliente_id_cliente { get; set; }
    }
}
