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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(334, 113);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(208, 60);
            this.txtDesc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(334, 202);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(208, 20);
            this.txtValor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Situação";
            // 
            // rbnAprovado
            // 
            this.rbnAprovado.AutoSize = true;
            this.rbnAprovado.Location = new System.Drawing.Point(334, 243);
            this.rbnAprovado.Name = "rbnAprovado";
            this.rbnAprovado.Size = new System.Drawing.Size(71, 17);
            this.rbnAprovado.TabIndex = 7;
            this.rbnAprovado.TabStop = true;
            this.rbnAprovado.Text = "Aprovado";
            this.rbnAprovado.UseVisualStyleBackColor = true;
            // 
            // rbnReprovado
            // 
            this.rbnReprovado.AutoSize = true;
            this.rbnReprovado.Location = new System.Drawing.Point(425, 243);
            this.rbnReprovado.Name = "rbnReprovado";
            this.rbnReprovado.Size = new System.Drawing.Size(78, 17);
            this.rbnReprovado.TabIndex = 7;
            this.rbnReprovado.TabStop = true;
            this.rbnReprovado.Text = "Reprovado";
            this.rbnReprovado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Funcionário";
            // 
            // cboFunc
            // 
            this.cboFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunc.FormattingEnabled = true;
            this.cboFunc.Location = new System.Drawing.Point(337, 280);
            this.cboFunc.Name = "cboFunc";
            this.cboFunc.Size = new System.Drawing.Size(205, 21);
            this.cboFunc.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(396, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboFunc);
            this.Controls.Add(this.rbnReprovado);
            this.Controls.Add(this.rbnAprovado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmAdicionar";
            this.Text = "frmAdicionar";
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
    }
}