using Frei.Marcos.Sigma.DB.Cliente;
using Frei.Marcos.Sigma.DB.Veiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.Sigma.Modulos.ControleDEVeiculo
{
    public partial class frmCadastrarVeiculo : Form
    {
        public frmCadastrarVeiculo()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            ClienteDatabase db = new ClienteDatabase();
            ClienteDTO dto = new ClienteDTO();

            cboCli.DisplayMember = nameof(ClienteDTO.nome);
            cboCli.ValueMember = nameof(ClienteDTO.idCliente);
            cboCli.DataSource = db.ListarClientes("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoDTO dto = new VeiculoDTO();
                dto.cliente_id_cliente = Convert.ToInt32(cboCli.SelectedValue);
                dto.cor = txtCor.Text;
                dto.marca = txtMarca.Text;
                dto.modelo = txtModelo.Text;
                dto.placa = txtPlaca.Text;

                VeiculoBusiness business = new VeiculoBusiness();
                business.SalvarVeiculo(dto);

                MessageBox.Show("Veiculo Cadastrado", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmCadastrarVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboCli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
