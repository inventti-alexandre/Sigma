using System;

public partial class frmAlterar : FROM
{
    public frmAlterar()
    {
        InitializeComponent();

    }
     public void CarregarCampos(int id, string CPFCNPJ,string nome, string end, string bairro, DateTime dt_nasc, string rg,string celular,string telefone,string estado,string cidade,string cep)
    {
        lblId.Text = id.ToString();
        txtCargo.Text = usuario;
        txtComplemento.Text =celular ;
        txtCPF.Text = CPFCNPJ;
        txtEndereco.Text = end;
        txtName.Text = nome;
        txttelefone.Text = telefone;
        txtUsuario.Text = usuario;
        txtRG.Text = rg;
        txtbairro = bairro;
        DateTime.text = dt_nasc;
        txtestado = estado;
        txtcidade = cidade;
        txtcep = cep;
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            lblId.Text = id.ToString();
            txtCargo.Text = usuario;
            txtComplemento.Text = celular;
            txtCPF.Text = CPFCNPJ;
            txtEndereco.Text = end;
            txtName.Text = nome;
            txttelefone.Text = telefone;
            txtUsuario.Text = usuario;
            txtRG.Text = rg;
            txtbairro = bairro;
            DateTime.text = dt_nasc;
            txtestado = estado;
            txtcidade = cidade;
            txtcep = cep;

            ClienteBusiness business = new ClinteBusiness();
            business.AlterarCliente(dto);

            MessageBox.Show("Cliente alterado", "SIGMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
   
         
    



