namespace Frei.Marcos.Sigma.Modulos.ControleDeAtendimento
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
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvAtendimento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAtendimento.Location = new System.Drawing.Point(0, 151);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.RowHeadersVisible = false;
            this.dgvAtendimento.Size = new System.Drawing.Size(650, 290);
            this.dgvAtendimento.TabIndex = 8;
            this.dgvAtendimento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtendimento_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Data";
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Descricao";
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Situacao";
            this.Column4.HeaderText = "Situação";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NomeF";
            this.Column5.HeaderText = "Nome do Funcionário";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cargo";
            this.Column6.HeaderText = "Cargo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Orcamento_id_orcamento";
            this.Column7.HeaderText = "Nº Orçamento";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "nome";
            this.Column8.HeaderText = "Nome do Cliente";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "CPF_CNPJ";
            this.Column9.HeaderText = "CPF/CNPJ";
            this.Column9.Name = "Column9";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Red;
            this.btnNovo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(572, 447);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 38);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnRem
            // 
            this.btnRem.BackColor = System.Drawing.Color.Red;
            this.btnRem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.Location = new System.Drawing.Point(3, 447);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(145, 38);
            this.btnRem.TabIndex = 9;
            this.btnRem.Text = "Remover Selecionado";
            this.btnRem.UseVisualStyleBackColor = false;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consulta Atendimento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(115, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 65);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvAtendimento);
            this.Name = "frmConsultar";
            this.Size = new System.Drawing.Size(650, 500);
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtendimento;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
