using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Cliente
{
    class ClienteDTO
    {
        public int idCliente { get; set; }
        public string CPF_CNPJ { get; set; }
        public string razao_social { get; set; }
        public string nome { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
       
    }
}
