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
            FuncionarioDTO dto = new FuncionarioDTO();
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
            business.CadastrarFuncionario(dto);

            MessageBox.Show("Funcionario Cadastrado", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
