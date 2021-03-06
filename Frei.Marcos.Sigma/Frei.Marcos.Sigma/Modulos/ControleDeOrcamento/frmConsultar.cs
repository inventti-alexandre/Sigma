﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frei.Marcos.Sigma.DB.Orcamento;

namespace Frei.Marcos.Sigma.Modulos.ControleDeOrcamento
{
    public partial class frmConsultar : UserControl
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            OrcamentoBusiness business = new OrcamentoBusiness();
            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = business.ConsultarOrc();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            OrcamentoBusiness db = new OrcamentoBusiness();
            int id = db.GerarOrcamento();

            frmAddPecas frm = new frmAddPecas();
            Hide();
            frm.CarregarLabel(id.ToString());
            frm.ShowDialog();
            Show();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            try
            {
                OrcamentoDTO dto = dgvFuncionario.CurrentRow.DataBoundItem as OrcamentoDTO;

                OrcamentoBusiness business = new OrcamentoBusiness();
                business.RemoverOrcamento(dto.id_orcamento.ToString());

                MessageBox.Show("Orçamento Removido com Sucesso!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CarregarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Orcamento!", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
