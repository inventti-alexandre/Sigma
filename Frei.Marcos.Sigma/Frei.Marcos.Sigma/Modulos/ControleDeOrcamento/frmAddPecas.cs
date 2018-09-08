using Frei.Marcos.Sigma.DB.Pecas;
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
    public partial class frmAddPecas : Form
    {
        public frmAddPecas()
        {
            InitializeComponent();
            CarregarGrid();
        }

        BindingList<PecasDTO> produtosCarrinho = new BindingList<PecasDTO>();

        void CarregarGrid()
        {
            dgvPecas.AutoGenerateColumns = false;
            dgvPecas.DataSource = produtosCarrinho;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void CarregarLabel(string id)
        {
            lblOrc.Text = id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PecasDTO dto = new PecasDTO();
            dto.descricao = txtDesc.Text;
            dto.nome = txtNome.Text;
            dto.quantidade = Convert.ToInt32(nudQuantidade.Value);
            dto.valor = Convert.ToDouble(txtValor.Text) * dto.quantidade;
            dto.orcamento_id_orcamento = Convert.ToInt32(lblOrc.Text);

            produtosCarrinho.Add(dto);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PecasBusiness business = new PecasBusiness();
            business.Gravar(produtosCarrinho.ToList());

            frmAdicionar frm = new frmAdicionar();
            Hide();
            frm.CarregarLabel(lblOrc.Text);
            frm.ShowDialog();
            Close();
        }
    }
}
