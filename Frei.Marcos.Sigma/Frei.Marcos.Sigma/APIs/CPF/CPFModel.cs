using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.APIs.CPF
{
    class CPFModel
    {
        public CPFDTO Consultar(string CPF)
        {
            //Prepara URL
            string URL = $"https://umdominio.gov.br/consulta-cpf/{CPF}/json";

            // Prepara cliente REST para fazer chamada
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            //Chamada Rest
            string data = rest.DownloadString(URL);
            var dados = JsonConvert.DeserializeObject<CPFDTO>(data);
            return dados;
        }
    }
}
