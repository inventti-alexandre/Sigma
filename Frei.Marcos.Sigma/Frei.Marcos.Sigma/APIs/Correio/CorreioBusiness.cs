using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.APIs.Correio
{
    class CorreioBusiness
    {
        public CorreioDTO Endereco(string CEP)
        {
            if (CEP.Contains(" "))
                throw new ArgumentException("CEP incompleto");

            CorreioModel model = new CorreioModel();
            return model.Endereco(CEP);
        }
    }
}
