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
    public partial class frmAlterarVeiculo : Form
    {
        public frmAlterarVeiculo()
        {
            InitializeComponent();
            CarregarClientes();
        }

        public void CarregarCampos(string Codigo, string Placa, string Marca, string Modelo, string Cor)
        {
            txtCor.Text = Cor;
            txtMarca.Text = Marca;
            txtModelo.Text = Modelo;
            txtPlaca.Text = Placa;
            lblid.Text = Codigo;
        }

        private void CarregarClientes()
        {
            ClienteDatabase db = new ClienteDatabase();
            ClienteDTO dto = new ClienteDTO();

            cboCli.DisplayMember = nameof(ClienteDTO.nome);
            cboCli.ValueMember = nameof(ClienteDTO.idCliente);
            cboCli.DataSource = db.ListarClientes("");
        }

        private void frmAlterar_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoDTO dto = new VeiculoDTO();
                dto.cliente_id_cliente = Convert.ToInt32(cboCli.SelectedValue);
                dto.cor = txtCor.Text;
                dto.marca = txtMarca.Text;
                dto.modelo = txtModelo.Text;
                dto.placa = txtPlaca.Text;
                dto.id_veiculo = Convert.ToInt32(lblid.Text);

                VeiculoBusiness business = new VeiculoBusiness();
                business.AlterarVeiculo(dto);

                MessageBox.Show("Veiculo Alterado", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}


