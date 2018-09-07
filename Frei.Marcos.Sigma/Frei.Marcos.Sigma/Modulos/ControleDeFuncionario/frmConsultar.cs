using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frei.Marcos.Sigma.DB.Funcionario;

namespace Frei.Marcos.Sigma.Modulos.ControleDeFuncionario
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            frm.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO dto = dgvFuncionario.CurrentRow.DataBoundItem as FuncionarioDTO;

                frmAlterar alterar = new frmAlterar();
                alterar.CarregarCampos(dto.idFuncionario, dto.CPF, dto.Usuario, dto.Nome, dto.Endereco, dto.Complemento, dto.Cargo, dto.observacao, dto.Data_nascimento, dto.RG);
                alterar.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um funcionário!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            string CPF = txtCPF.Text;

            FuncionarioBusiness business = new FuncionarioBusiness();
            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = business.ConsultarFuncionarios(CPF);
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO dto = dgvFuncionario.CurrentRow.DataBoundItem as FuncionarioDTO;

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.RemoverFuncionario(dto.idFuncionario.ToString());

                MessageBox.Show("Funcionario Removido com Sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um funcionário!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
