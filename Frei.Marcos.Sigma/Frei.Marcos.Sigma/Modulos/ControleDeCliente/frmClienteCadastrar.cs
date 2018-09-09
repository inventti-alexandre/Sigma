using Frei.Marcos.Sigma.APIs.Correio;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string CEP = txtCEP.Text;

                CorreioBusiness business = new CorreioBusiness();
                CorreioDTO dto = business.Endereco(CEP);

                if (dto.CEP != string.Empty)
                {
                    txtBairro.Text = dto.Bairro;
                    txtCidade.Text = dto.Localidade;
                    txtLogradouro.Text = dto.Logradouro;
                    txtUF.Text = dto.UF;
                }
                else
                    throw new ArgumentException("CEP Inválido");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchJ_Click(object sender, EventArgs e)
        {
            try
            {
                string CEP = txtCEPj.Text;

                CorreioBusiness business = new CorreioBusiness();
                CorreioDTO dto = business.Endereco(CEP);

                if (dto.CEP != string.Empty)
                {
                    txtBairroJ.Text = dto.Bairro;
                    txtCidadeJ.Text = dto.Localidade;
                    txtLogradouroJ.Text = dto.Logradouro;
                    txtUFj.Text = dto.UF;
                }
                else
                    throw new ArgumentException("CEP Inválido");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO dto = new ClienteDTO();
                dto.bairro = txtBairro.Text;
                dto.celular = txtCelular.Text;
                dto.razao_social = string.Empty;
                dto.cep = txtCEP.Text;
                dto.cidade = txtCidade.Text;
                dto.CPF_CNPJ = txtCPF.Text;
                dto.Data_nascimento = dtpNasc.Value;
                dto.endereco = txtLogradouro.Text;
                dto.estado = txtUF.Text;
                dto.nome = txtNome.Text;
                dto.telefone = txtTelefone.Text;

                ClienteBusiness db = new ClienteBusiness();
                db.Cadastrar(dto);

                MessageBox.Show("Cliente cadastrado com sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
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

        private void btnCadastrarJ_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO dto = new ClienteDTO();
                dto.bairro = txtBairroJ.Text;
                dto.celular = txtCelularJ.Text;
                dto.cep = txtCEPj.Text;
                dto.cidade = txtCidadeJ.Text;
                dto.CPF_CNPJ = txtCNPJ.Text;
                dto.endereco = txtLogradouroJ.Text;
                dto.estado = txtUFj.Text;
                dto.nome = txtNomeJ.Text;
                dto.telefone = txtTelefoneJ.Text;
                dto.razao_social = txtRazaoSocial.Text;

                ClienteBusiness db = new ClienteBusiness();
                db.CadastrarJ(dto);

                MessageBox.Show("Cliente cadastrado com sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
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
