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
            dto.funcionario_id_funcionario = Convert.ToInt32(cboFunc.SelectedValue);
            dto.valor = Convert.ToDouble(txtValor.Text);
            dto.situacao = rbnAprovado.Checked == true ? "Aprovado" : "Reprovado";
            dto.descricao = txtDesc.Text;
            dto.data = DateTime.Now;

            OrcamentoBusiness business = new OrcamentoBusiness();
            business.SalvarOrc(dto);

            MessageBox.Show("Orçamento salvo com sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
