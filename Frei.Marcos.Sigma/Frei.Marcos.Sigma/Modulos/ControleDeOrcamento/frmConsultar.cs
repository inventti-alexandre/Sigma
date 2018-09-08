using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frei.Marcos.Sigma.DB.Orcamento;

namespace Frei.Marcos.Sigma.Modulos.ControleDeOrcamento
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
            OrcamentoBusiness business = new OrcamentoBusiness();
            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = business.ConsultarOrc();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAdicionar frm = new frmAdicionar();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                OrcamentoDTO dto = dgvFuncionario.CurrentRow.DataBoundItem as OrcamentoDTO;
                bool aprovado = dto.situacao == "Aprovado" ? true : false;

                frmAlterar alterar = new frmAlterar();
                alterar.CarregarCampos(dto.descricao, dto.valor.ToString(), aprovado);
                alterar.ShowDialog();
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Orçamento!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            try
            {
                OrcamentoDTO dto = dgvFuncionario.CurrentRow.DataBoundItem as OrcamentoDTO;

                OrcamentoBusiness business = new OrcamentoBusiness();
                business.RemoverOrcamento(dto.id_orcamento.ToString());

                MessageBox.Show("Orçamento Removido com Sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Orcamento!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
