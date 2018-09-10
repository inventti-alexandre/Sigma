namespace Frei.Marcos.Sigma.Modulos.ControleDeOrcamento
{
    partial class frmAdicionar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnAprovado = new System.Windows.Forms.RadioButton();
            this.rbnReprovado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFunc = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorPecas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.txtDesc.Location = new System.Drawing.Point(115, 50);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(208, 60);
            this.txtDesc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(329, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor Serviço";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.txtValor.Location = new System.Drawing.Point(444, 79);
            this.txtValor.MaxLength = 5;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(114, 27);
            this.txtValor.TabIndex = 6;
            this.txtValor.Text = "0";
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(49, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Situação";
            // 
            // rbnAprovado
            // 
            this.rbnAprovado.AutoSize = true;
            this.rbnAprovado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.rbnAprovado.Location = new System.Drawing.Point(25, 15);
            this.rbnAprovado.Name = "rbnAprovado";
            this.rbnAprovado.Size = new System.Drawing.Size(99, 27);
            this.rbnAprovado.TabIndex = 7;
            this.rbnAprovado.TabStop = true;
            this.rbnAprovado.Text = "Aprovado";
            this.rbnAprovado.UseVisualStyleBackColor = true;
            // 
            // rbnReprovado
            // 
            this.rbnReprovado.AutoSize = true;
            this.rbnReprovado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.rbnReprovado.Location = new System.Drawing.Point(25, 38);
            this.rbnReprovado.Name = "rbnReprovado";
            this.rbnReprovado.Size = new System.Drawing.Size(106, 27);
            this.rbnReprovado.TabIndex = 7;
            this.rbnReprovado.TabStop = true;
            this.rbnReprovado.Text = "Reprovado";
            this.rbnReprovado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Funcionário";
            // 
            // cboFunc
            // 
            this.cboFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunc.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.cboFunc.FormattingEnabled = true;
            this.cboFunc.Location = new System.Drawing.Point(115, 116);
            this.cboFunc.Name = "cboFunc";
            this.cboFunc.Size = new System.Drawing.Size(208, 27);
            this.cboFunc.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Red;
            this.btnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(456, 404);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 34);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbnReprovado);
            this.panel1.Controls.Add(this.rbnAprovado);
            this.panel1.Location = new System.Drawing.Point(38, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 80);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(333, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor Total";
            // 
            // lblValorPecas
            // 
            this.lblValorPecas.AutoSize = true;
            this.lblValorPecas.Location = new System.Drawing.Point(441, 53);
            this.lblValorPecas.Name = "lblValorPecas";
            this.lblValorPecas.Size = new System.Drawing.Size(13, 13);
            this.lblValorPecas.TabIndex = 5;
            this.lblValorPecas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(329, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Peças";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(441, 116);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotal.TabIndex = 5;
            this.lblValorTotal.Text = "0";
            // 
            // dgvPecas
            // 
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvPecas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPecas.Location = new System.Drawing.Point(15, 159);
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.RowHeadersVisible = false;
            this.dgvPecas.Size = new System.Drawing.Size(516, 186);
            this.dgvPecas.TabIndex = 18;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "Peça";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "quantidade";
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "valor";
            this.Column4.HeaderText = "Valor";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "descricao";
            this.Column5.HeaderText = "Descrição";
            this.Column5.Name = "Column5";
            // 
            // lblOrc
            // 
            this.lblOrc.AutoSize = true;
            this.lblOrc.Location = new System.Drawing.Point(131, 29);
            this.lblOrc.Name = "lblOrc";
            this.lblOrc.Size = new System.Drawing.Size(13, 13);
            this.lblOrc.TabIndex = 19;
            this.lblOrc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(2, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nº Orçamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Frei.Marcos.Sigma.Properties.Resources.SIGMA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(237, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 42);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frei.Marcos.Sigma.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOrc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvPecas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboFunc);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblValorPecas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmAdicionar";
            this.Text = "frmAdicionar";
            this.Load += new System.EventHandler(this.frmAdicionar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnAprovado;
        private System.Windows.Forms.RadioButton rbnReprovado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFunc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorPecas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblOrc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}