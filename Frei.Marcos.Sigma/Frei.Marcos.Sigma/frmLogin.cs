using Frei.Marcos.Sigma.DB.Usuario;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.Senha = txtSenha.Text;
                dto.Usuario = txtLogin.Text;

                UsuarioDatabase db = new UsuarioDatabase();
                bool usuario = db.AutenticarUsuario(dto);

                if (usuario == true)
                {
                    frmPrincipal frm = new frmPrincipal();
                    Hide();
                    frm.ShowDialog();
                    Close();
                }
                else
                    throw new ArgumentException("Usuário ou senha incorreto!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inexperado: " + ex.Message, "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
