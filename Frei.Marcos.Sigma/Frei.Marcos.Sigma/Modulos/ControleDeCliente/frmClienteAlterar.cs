using Frei.Marcos.Sigma.DB.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.Sigma.Modulos.ControleDeCliente
{
    public partial class frmClienteAlterar : Form
    {
        public frmClienteAlterar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO dto = new ClienteDTO();
                dto.idCliente = Convert.ToInt32(textBox1.Text);
                dto.CPF_CNPJ = textBox3.Text;
                dto.razao_social = textBox5.Text;
                dto.nome = textBox2.Text;
                dto.cep = textBox6.Text;
                dto.Data_nascimento = dtpNasc.Value;
                dto.estado = textBox7.Text;
                dto.cidade = textBox8.Text;
                dto.bairro = textBox9.Text;
                dto.endereco = textBox10.Text;
                dto.telefone = textBox12.Text;
                dto.celular = textBox13.Text;


                ClienteBusiness business = new ClienteBusiness();
                business.AlterarCliente(dto);

                MessageBox.Show("Cliente Alterado", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmAlterar_Load(object sender, EventArgs e)
        {

        }

        private void frmClienteAlterar_Load(object sender, EventArgs e)
        {

        }
    }
}
