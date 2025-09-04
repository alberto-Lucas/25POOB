namespace PessoaPOO
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtVisSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVisEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVisNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVisCpf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVisDtNascimento = new System.Windows.Forms.TextBox();
            this.txtVisIdade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(12, 25);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Nascimento:";
            // 
            // dtpDtNascimento
            // 
            this.dtpDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascimento.Location = new System.Drawing.Point(512, 25);
            this.dtpDtNascimento.Name = "dtpDtNascimento";
            this.dtpDtNascimento.Size = new System.Drawing.Size(89, 20);
            this.dtpDtNascimento.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(406, 73);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(195, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Senha:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(607, 71);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lista Usuários:";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(12, 122);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(589, 108);
            this.lstUsuarios.TabIndex = 12;
            this.lstUsuarios.DoubleClick += new System.EventHandler(this.lstUsuarios_DoubleClick);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Location = new System.Drawing.Point(607, 214);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtVisSenha
            // 
            this.txtVisSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVisSenha.Location = new System.Drawing.Point(406, 309);
            this.txtVisSenha.Name = "txtVisSenha";
            this.txtVisSenha.ReadOnly = true;
            this.txtVisSenha.Size = new System.Drawing.Size(195, 20);
            this.txtVisSenha.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Senha:";
            // 
            // txtVisEmail
            // 
            this.txtVisEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVisEmail.Location = new System.Drawing.Point(12, 309);
            this.txtVisEmail.Name = "txtVisEmail";
            this.txtVisEmail.ReadOnly = true;
            this.txtVisEmail.Size = new System.Drawing.Size(388, 20);
            this.txtVisEmail.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Email:";
            // 
            // txtVisNome
            // 
            this.txtVisNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVisNome.Location = new System.Drawing.Point(118, 261);
            this.txtVisNome.Name = "txtVisNome";
            this.txtVisNome.ReadOnly = true;
            this.txtVisNome.Size = new System.Drawing.Size(388, 20);
            this.txtVisNome.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome:";
            // 
            // txtVisCpf
            // 
            this.txtVisCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVisCpf.Location = new System.Drawing.Point(12, 261);
            this.txtVisCpf.Name = "txtVisCpf";
            this.txtVisCpf.ReadOnly = true;
            this.txtVisCpf.Size = new System.Drawing.Size(100, 20);
            this.txtVisCpf.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "CPF:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Data Nascimento:";
            // 
            // txtVisDtNascimento
            // 
            this.txtVisDtNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVisDtNascimento.Location = new System.Drawing.Point(512, 261);
            this.txtVisDtNascimento.Name = "txtVisDtNascimento";
            this.txtVisDtNascimento.ReadOnly = true;
            this.txtVisDtNascimento.Size = new System.Drawing.Size(89, 20);
            this.txtVisDtNascimento.TabIndex = 23;
            // 
            // txtVisIdade
            // 
            this.txtVisIdade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVisIdade.Location = new System.Drawing.Point(607, 261);
            this.txtVisIdade.Name = "txtVisIdade";
            this.txtVisIdade.ReadOnly = true;
            this.txtVisIdade.Size = new System.Drawing.Size(75, 20);
            this.txtVisIdade.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(607, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Idade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 340);
            this.Controls.Add(this.txtVisIdade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVisDtNascimento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVisSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVisEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVisNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVisCpf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDtNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDtNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtVisSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVisEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVisNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVisCpf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVisDtNascimento;
        private System.Windows.Forms.TextBox txtVisIdade;
        private System.Windows.Forms.Label label12;
    }
}

