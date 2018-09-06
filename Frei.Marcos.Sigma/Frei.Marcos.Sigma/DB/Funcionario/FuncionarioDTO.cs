using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Funcionario
{
    class FuncionarioDTO
    {
        public int idFuncionario { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Cargo { get; set; }
        public string observacao { get; set; }
    }
}
