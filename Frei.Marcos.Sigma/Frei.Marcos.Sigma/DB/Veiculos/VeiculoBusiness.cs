using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.Sigma.DB.Veiculos
{
    class VeiculoBusiness
    {
        public int SalvarVeiculo(VeiculoDTO dto)
        {
            VeiculoDatabase db = new VeiculoDatabase();
            return db.SalvarVeiculo(dto);
        }

        public int AlterarVeiculo(VeiculoDTO dto)
        {
            VeiculoDatabase db = new VeiculoDatabase();
            return db.AlterarVeiculo(dto);
        }

        public int RemoverVaiculo(string id)
        {
            VeiculoDatabase db = new VeiculoDatabase();
            return db.RemoverVaiculo(id);
        }

        public List<VeiculoDTO> ConsultarVeiculo()
        {
            VeiculoDatabase db = new VeiculoDatabase();
            return db.ConsultarVeiculo();
        }
    }
}
