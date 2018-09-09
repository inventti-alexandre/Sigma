using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frei.Marcos.Sigma.DB.Atendimento;

namespace Frei.Marcos.Sigma.Modulos.ControleDeAtendimento
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
            AtendimentoBusiness business = new AtendimentoBusiness();

            dgvAtendimento.AutoGenerateColumns = false;
            dgvAtendimento.DataSource = business.ListarAtendimentos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAdicionar frm = new frmAdicionar();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            try
            {
                vw_AtendimentoDTO dto = dgvAtendimento.CurrentRow.DataBoundItem as vw_AtendimentoDTO;

                AtendimentoBusiness business = new AtendimentoBusiness();
                business.RemoverAtendimento(dto.idAtendimento.ToString());

                MessageBox.Show("Atendimento Removido com Sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um atendimento!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            ''
        }

        private void dgvAtendimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
