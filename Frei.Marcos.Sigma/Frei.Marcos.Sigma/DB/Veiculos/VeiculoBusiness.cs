using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Veiculos
{
    class VeiculoBusiness
    {
        public int CadastrarVeiculo(VeiculoDTO dto)
        {
            VeiculoDatabase db = new VeiculoDatabase();
            return db.CadastrarVeiculo(dto);
        }

        public List<VeiculoDTO> ConsultarVeiculo(string placa)
        {
            VeiculoDatabase db = new VeiculoDatabase();
            if (placa != string.Empty)
            {
                return db.ConsultarVeiculoFiltro(placa);
            }
            else
                return db.ConsultarVeiculo();
        }
        public int RemoverVeiculo(string id)
        {
            VeiculoDatabase db = new VeiculoDatabase();
            return db.RemoverVeiculo(id);
        }
        public int AlterarVeiculo(VeiculoDTO dto)
        {
            VeiculoDatabase db = new VeiculoDatabase();
            return db.AlterarVeiculo(dto);
        }
    }
}
