using Frei.Marcos.Sigma.Modulos.ControleDeFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.Sigma
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar screen = new frmConsultar();
            CarregarScreen(screen);
        }

        private void CarregarScreen (UserControl screen)
        {
            if (pnPrincipal.Controls.Count == 1)
                pnPrincipal.Controls.RemoveAt(0);
            pnPrincipal.Controls.Add(screen);
        }
    }
}
