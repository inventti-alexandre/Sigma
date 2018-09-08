using Frei.Marcos.Sigma.DB.Orcamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.Sigma.Modulos.ControleDeOrcamento
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
            CarregarFuncionarios();
        }

        private void CarregarGrid()
        {
            OrcamentoDatabase db = new OrcamentoDatabase();

            dgvPecas.AutoGenerateColumns = false;
            dgvPecas.DataSource = db.ConsultarPecas(lblOrc.Text);
        }

        public void CarregarLabel(string id)
        {
            lblOrc.Text = id;

            OrcamentoDatabase db = new OrcamentoDatabase();
            lblValorPecas.Text = db.ConsultarValorPecas(id).ToString();
            CarregarGrid();
        }

        private void CarregarFuncionarios()
        {
            OrcamentoBusiness business = new OrcamentoBusiness();
            OrcamentoDTO dto = new OrcamentoDTO();

            cboFunc.DisplayMember = nameof(OrcamentoDTO.Nome);
            cboFunc.ValueMember = nameof(OrcamentoDTO.funcionario_id_funcionario);
            cboFunc.DataSource = business.ConsultarFuncionarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OrcamentoDTO dto = new OrcamentoDTO();
            dto.id_orcamento = Convert.ToInt32(lblOrc.Text);
            dto.funcionario_id_funcionario = Convert.ToInt32(cboFunc.SelectedValue);
            dto.valor = Convert.ToDouble(lblValorTotal.Text);
            dto.situacao = rbnAprovado.Checked == true ? "Aprovado" : "Reprovado";
            dto.descricao = txtDesc.Text;

            OrcamentoBusiness business = new OrcamentoBusiness();
            int id = business.SalvarOrc(dto);

            MessageBox.Show("Orçamento guardado com sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            lblValorTotal.Text = (Convert.ToInt32(lblValorPecas.Text) + Convert.ToInt32(txtValor.Text)).ToString();
        }
    }
}
