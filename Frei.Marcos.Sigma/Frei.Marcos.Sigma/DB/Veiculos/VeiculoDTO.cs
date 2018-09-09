using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Veiculos
{
    class VeiculoDTO
    {
        public int id_veiculo { get; set; }
        public string cor { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int cliente_id_cliente { get; set; }
        public string nome { get; set; }
        public string CPF_CNPJ { get; set; }
    }
}
