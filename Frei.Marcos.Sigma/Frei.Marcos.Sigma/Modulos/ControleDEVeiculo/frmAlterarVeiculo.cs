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
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoDTO dto = new VeiculoDTO();
                dto.placa = textBox2.Double;
                dto.modelo = textBox4.Text;
                dto.cor = textBox5.Text;
                dto.marca = textBox3.Text;
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

        private void frmAlterar_Load(object sender, EventArgs e)
        {

        }
    }
}


