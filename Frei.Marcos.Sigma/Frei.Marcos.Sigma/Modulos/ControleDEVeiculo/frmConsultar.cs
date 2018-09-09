using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frei.Marcos.Sigma.DB.Veiculos;

namespace Frei.Marcos.Sigma.Modulos.ControleDEVeiculo
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            VeiculoBusiness business = new VeiculoBusiness();

            dgvVeiculos.AutoGenerateColumns = false;
            dgvVeiculos.DataSource = business.ConsultarVeiculo();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarVeiculo frm = new frmCadastrarVeiculo();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoDTO dto = dgvVeiculos.CurrentRow.DataBoundItem as VeiculoDTO;

                VeiculoBusiness business = new VeiculoBusiness();
                business.RemoverVaiculo(dto.id_veiculo.ToString());

                MessageBox.Show("Funcionario Removido com Sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um funcionário!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoDTO dto = dgvVeiculos.CurrentRow.DataBoundItem as VeiculoDTO;

                frmAlterarVeiculo alterar = new frmAlterarVeiculo();
                alterar.CarregarCampos(dto.id_veiculo.ToString(), dto.placa, dto.marca, dto.modelo, dto.cor);
                Hide();
                alterar.ShowDialog();
                Show();
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um funcionário!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
