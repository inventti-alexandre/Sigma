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
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(int id, string cpf, string usuario, string nome, string end, string comp, string cargo, string obs, DateTime dt_nasc, string rg)
        {
            lblId.Text = id.ToString();
            txtCargo.Text = cargo;
            txtComplemento.Text = comp;
            txtCPF.Text = cpf;
            txtEndereco.Text = end;
            txtName.Text = nome;
            txtObs.Text = obs;
            txtUsuario.Text = usuario;
            txtRG.Text = rg;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.idFuncionario = Convert.ToInt32(lblId.Text);
                dto.Nome = txtName.Text;
                dto.Usuario = txtUsuario.Text;
                dto.Cargo = txtCargo.Text;
                dto.Complemento = txtComplemento.Text;
                dto.CPF = txtCPF.Text;
                dto.Data_nascimento = dtpNasc.Value;
                dto.Endereco = txtEndereco.Text;
                dto.observacao = txtObs.Text;
                dto.RG = txtRG.Text;

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.AlterarFuncionario(dto);

                MessageBox.Show("Funcionario Alterado", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
