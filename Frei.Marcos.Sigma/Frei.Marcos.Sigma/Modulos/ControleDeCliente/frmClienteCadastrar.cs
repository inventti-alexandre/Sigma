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
    public partial class frmClienteCadastrar : Form
    {
        public frmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO dto = new ClienteDTO();
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

                VeiculoBusiness business = new VeiculoBusiness();
                business.CadastrarFuncionario(dto);

                MessageBox.Show("Funcionario Cadastrado", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string CEP = txtCEP.Text;

                CorreioBusiness business = new CorreioBusiness();
                CorreioDTO dto = business.Endereco(CEP);

                if (dto.CEP != string.Empty)
                {
                    txtComplemento.Text = dto.Complemento;
                    txtEndereco.Text = $"Logradouro: {dto.Logradouro}, Cidade: {dto.Localidade}, Bairro: {dto.Bairro}, UF: {dto.UF}";
                }
                else
                    throw new ArgumentException("CEP Inválido");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
