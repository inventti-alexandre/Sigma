namespace Frei.Marcos.Sigma.Modulos.ControleDeOrcamento
{
    partial class frmConsultar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5});
            this.dgvFuncionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFuncionario.Location = new System.Drawing.Point(0, 129);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.Size = new System.Drawing.Size(650, 290);
            this.dgvFuncionario.TabIndex = 7;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(161, 54);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consultar CPF";
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(267, 52);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(75, 23);
            this.btnProc.TabIndex = 8;
            this.btnProc.Text = "Procurar";
            this.btnProc.UseVisualStyleBackColor = true;
            // 
            // btnRem
            // 
            this.btnRem.Location = new System.Drawing.Point(80, 425);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(75, 23);
            this.btnRem.TabIndex = 9;
            this.btnRem.Text = "Remover";
            this.btnRem.UseVisualStyleBackColor = true;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(3, 425);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 10;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(572, 425);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_orcamento";
            this.Column1.HeaderText = "Nº Orc.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "data";
            this.Column2.HeaderText = "Data";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descricao";
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "valor";
            this.Column4.HeaderText = "Valor (R$)";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Nome";
            this.Column6.HeaderText = "Funcionário";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Cargo";
            this.Column7.HeaderText = "Cargo Funcionario";
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "situacao";
            this.Column5.HeaderText = "Situação";
            this.Column5.Name = "Column5";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmConsultar";
            this.Size = new System.Drawing.Size(650, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
