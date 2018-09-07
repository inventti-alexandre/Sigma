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
            cboFunc.DataSource = business.ConsultarOrc();
        }
    }
}
