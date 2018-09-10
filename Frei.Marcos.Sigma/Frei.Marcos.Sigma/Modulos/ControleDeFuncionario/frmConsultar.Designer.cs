namespace Frei.Marcos.Sigma.Modulos.ControleDeFuncionario
{
    partial class frmConsultar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRem = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvFuncionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFuncionario.Location = new System.Drawing.Point(0, 165);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.Size = new System.Drawing.Size(650, 290);
            this.dgvFuncionario.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Usuario";
            this.Column2.HeaderText = "Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "NomeF";
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 150;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Data_nascimento";
            this.Column3.HeaderText = "Data de Nascimento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CPF";
            this.Column4.HeaderText = "CPF";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RG";
            this.Column5.HeaderText = "RG";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Endereco";
            this.Column6.HeaderText = "Endereco";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Complemento";
            this.Column7.HeaderText = "Complemento";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Cargo";
            this.Column8.HeaderText = "Cargo";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "observacao";
            this.Column9.HeaderText = "Observação";
            this.Column9.Name = "Column9";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Red;
            this.btnNovo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnNovo.Location = new System.Drawing.Point(572, 461);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.Red;
            this.btnAlter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlter.Location = new System.Drawing.Point(3, 461);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(86, 36);
            this.btnAlter.TabIndex = 1;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnProc
            // 
            this.btnProc.BackColor = System.Drawing.Color.Red;
            this.btnProc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnProc.Location = new System.Drawing.Point(255, 127);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(94, 35);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "Procurar";
            this.btnProc.UseVisualStyleBackColor = false;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar CPF";
            // 
            // btnRem
            // 
            this.btnRem.BackColor = System.Drawing.Color.Red;
            this.btnRem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnRem.Location = new System.Drawing.Point(95, 461);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(84, 36);
            this.btnRem.TabIndex = 1;
            this.btnRem.Text = "Remover";
            this.btnRem.UseVisualStyleBackColor = false;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.txtCPF.Location = new System.Drawing.Point(149, 129);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 27);
            this.txtCPF.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Frei.Marcos.Sigma.Properties.Resources.SIGMA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(173, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 73);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(172, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Consultar Funcionario";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frei.Marcos.Sigma.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "frmConsultar";
            this.Size = new System.Drawing.Size(650, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}
