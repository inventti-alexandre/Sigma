using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frei.Marcos.Sigma.DB.Cliente;

namespace Frei.Marcos.Sigma.Modulos.ControleDeCliente
{
    public partial class frmClienteConsultar : UserControl
    {
        public frmClienteConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmClienteCadastrar frm = new frmClienteCadastrar();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ClienteBusiness business = new ClienteBusiness();

            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = business.listarClientes(txtNome.Text);
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO dto = dgvCliente.CurrentRow.DataBoundItem as ClienteDTO;

                ClienteBusiness business = new ClienteBusiness();
                business.RemoverCliente(dto.idCliente.ToString());

                MessageBox.Show("Cliente Removido com Sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Cliente!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
