using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.APIs.CPF
{
    class CPFBusiness
    {
        public CPFDTO Consultar(string CPF)
        {
            CPFModel model = new CPFModel();
            return model.Consultar(CPF);
        }
    }
}
