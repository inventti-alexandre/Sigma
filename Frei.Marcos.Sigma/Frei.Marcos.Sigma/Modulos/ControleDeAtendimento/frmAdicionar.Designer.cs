namespace Frei.Marcos.Sigma.Modulos.ControleDeAtendimento
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnReprovado = new System.Windows.Forms.RadioButton();
            this.rbnAprovado = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrcN = new System.Windows.Forms.TextBox();
            this.cboFunc = new System.Windows.Forms.ComboBox();
            this.cboCli = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Situação";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnReprovado);
            this.panel1.Controls.Add(this.rbnAprovado);
            this.panel1.Location = new System.Drawing.Point(241, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 45);
            this.panel1.TabIndex = 33;
            // 
            // rbnReprovado
            // 
            this.rbnReprovado.AutoSize = true;
            this.rbnReprovado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnReprovado.Location = new System.Drawing.Point(102, 12);
            this.rbnReprovado.Name = "rbnReprovado";
            this.rbnReprovado.Size = new System.Drawing.Size(105, 27);
            this.rbnReprovado.TabIndex = 7;
            this.rbnReprovado.TabStop = true;
            this.rbnReprovado.Text = "Reprovado";
            this.rbnReprovado.UseVisualStyleBackColor = true;
            // 
            // rbnAprovado
            // 
            this.rbnAprovado.AutoSize = true;
            this.rbnAprovado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAprovado.Location = new System.Drawing.Point(3, 12);
            this.rbnAprovado.Name = "rbnAprovado";
            this.rbnAprovado.Size = new System.Drawing.Size(98, 27);
            this.rbnAprovado.TabIndex = 7;
            this.rbnAprovado.TabStop = true;
            this.rbnAprovado.Text = "Aprovado";
            this.rbnAprovado.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Red;
            this.btnSalvar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(527, 391);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Funcionário";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(241, 295);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(346, 60);
            this.txtDesc.TabIndex = 30;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nº Orçamento";
            // 
            // txtOrcN
            // 
            this.txtOrcN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrcN.Location = new System.Drawing.Point(241, 266);
            this.txtOrcN.Multiline = true;
            this.txtOrcN.Name = "txtOrcN";
            this.txtOrcN.Size = new System.Drawing.Size(346, 23);
            this.txtOrcN.TabIndex = 30;
            // 
            // cboFunc
            // 
            this.cboFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFunc.FormattingEnabled = true;
            this.cboFunc.Location = new System.Drawing.Point(241, 198);
            this.cboFunc.Name = "cboFunc";
            this.cboFunc.Size = new System.Drawing.Size(346, 28);
            this.cboFunc.TabIndex = 34;
            // 
            // cboCli
            // 
            this.cboCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCli.FormattingEnabled = true;
            this.cboCli.Location = new System.Drawing.Point(241, 232);
            this.cboCli.Name = "cboCli";
            this.cboCli.Size = new System.Drawing.Size(346, 28);
            this.cboCli.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Controle de Atendimento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 72);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCli);
            this.Controls.Add(this.cboFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrcN);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Name = "frmAdicionar";
            this.Text = "frmAdicionar";
            this.Load += new System.EventHandler(this.frmAdicionar_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnReprovado;
        private System.Windows.Forms.RadioButton rbnAprovado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrcN;
        private System.Windows.Forms.ComboBox cboFunc;
        private System.Windows.Forms.ComboBox cboCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}