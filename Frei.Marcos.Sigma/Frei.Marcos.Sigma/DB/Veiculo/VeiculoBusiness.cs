using System;


class VeiculoBusiness
{
    public int CadastrarVeiculo(VeiculoDTO dto)
    {
        VeiculoDatabase db = new VeiculoDatabase();
        return db.CadastrarFuncionario(dto);
    }

    public List<VeiculoDTO> ConsultarVeiculo(string Modelo)
    {
        VeiculoDatabase db = new VeiculoDatabase();
        if (Modelo != string.Empty)
        {
            return db.ConsultarVeiculoFiltro(Modelo);
        }
        else
            return db.ConsultaVeiculo();
    }
    public int RemoverVeiculo(string id)
    {
        VeiculoDatabase db = new VeiculoDatabase();
        return db.RemoverFuncionario(id);
    }
    public int AlterarVeiculo(VeiculoDTO dto)
    {
        VeiculoDatabase db = new VeiculoDatabase();
        return db.AlterarVeiculo(dto);
    }
}
