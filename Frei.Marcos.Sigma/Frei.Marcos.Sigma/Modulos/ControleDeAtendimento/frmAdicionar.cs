using Frei.Marcos.Sigma.DB.Atendimento;
using Frei.Marcos.Sigma.DB.Cliente;
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

namespace Frei.Marcos.Sigma.Modulos.ControleDeAtendimento
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarFuncionarios();
        }

        private void CarregarClientes()
        {
            ClienteDatabase db = new ClienteDatabase();
            ClienteDTO dto = new ClienteDTO();

            cboCli.DisplayMember = nameof(ClienteDTO.nome);
            cboCli.ValueMember = nameof(ClienteDTO.idCliente);
            cboCli.DataSource = db.ListarClientes("");
        }

        private void CarregarFuncionarios()
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            FuncionarioDTO dto = new FuncionarioDTO();

            cboFunc.DisplayMember = nameof(FuncionarioDTO.NomeF);
            cboFunc.ValueMember = nameof(FuncionarioDTO.idFuncionario);
            cboFunc.DataSource = db.ConsultarFuncionarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AtendimentoDTO dto = new AtendimentoDTO();
            dto.cliente_id_cliente = Convert.ToInt32(cboCli.SelectedValue);
            dto.Descricao = txtDesc.Text;
            dto.Funcionario_id_funcionario = Convert.ToInt32(cboFunc.SelectedValue);
            dto.Orcamento_id_orcamento = Convert.ToInt32(txtOrcN.Text);
            dto.Situacao = rbnAprovado.Checked == true ? "Aprovado" : "Reprovado";

            AtendimentoBusiness business = new AtendimentoBusiness();
            business.CadastrarAtendimento(dto);

            MessageBox.Show("Atendimento cadastrado com sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
