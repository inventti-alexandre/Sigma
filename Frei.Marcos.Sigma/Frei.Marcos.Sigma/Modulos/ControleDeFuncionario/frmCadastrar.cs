using Frei.Marcos.Sigma.APIs.Correio;
using Frei.Marcos.Sigma.DB.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.Sigma.Modulos.ControleDeFuncionario
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.NomeF = txtName.Text;
                dto.Usuario = txtUsuario.Text;
                dto.Cargo = txtCargo.Text;
                dto.Complemento = txtComplemento.Text;
                dto.CPF = txtCPF.Text;
                dto.Data_nascimento = dtpNasc.Value;
                dto.Endereco = txtEndereco.Text;
                dto.observacao = txtObs.Text;
                dto.RG = txtRG.Text;

                FuncionarioBusiness business = new FuncionarioBusiness();
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

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
