namespace CadastroLeitor
{
    partial class FormCadLeitor
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
            this.lblCodLeitor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblNomeLeitor = new System.Windows.Forms.Label();
            this.lblDtNascimentoLeitor = new System.Windows.Forms.Label();
            this.lblSexoLeitor = new System.Windows.Forms.Label();
            this.lblRgLeitor = new System.Windows.Forms.Label();
            this.lblCpfLeitor = new System.Windows.Forms.Label();
            this.lblTelefoneLeitor = new System.Windows.Forms.Label();
            this.lblEmailLeitor = new System.Windows.Forms.Label();
            this.lblEnderecoLeitor = new System.Windows.Forms.Label();
            this.lblCelularLeitor = new System.Windows.Forms.Label();
            this.lblCidadeLeitor = new System.Windows.Forms.Label();
            this.lblBairroLeitor = new System.Windows.Forms.Label();
            this.lblCepLeitor = new System.Windows.Forms.Label();
            this.lblNumeroLeitor = new System.Windows.Forms.Label();
            this.lblUfLeitor = new System.Windows.Forms.Label();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtSexoLeitor = new System.Windows.Forms.TextBox();
            this.txtCidadeLeitor = new System.Windows.Forms.TextBox();
            this.txtBairroLeitor = new System.Windows.Forms.TextBox();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.txtNumeroLeitor = new System.Windows.Forms.TextBox();
            this.txtUfLeitor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgDadosLeitor = new System.Windows.Forms.DataGridView();
            this.txtDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfLeitor = new System.Windows.Forms.MaskedTextBox();
            this.txtRgLeitor = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailleitor = new System.Windows.Forms.TextBox();
            this.txtTelefoneLeitor = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularLeitor = new System.Windows.Forms.MaskedTextBox();
            this.txtCepLeitor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodLeitor
            // 
            this.lblCodLeitor.AutoSize = true;
            this.lblCodLeitor.Location = new System.Drawing.Point(12, 12);
            this.lblCodLeitor.Name = "lblCodLeitor";
            this.lblCodLeitor.Size = new System.Drawing.Size(63, 20);
            this.lblCodLeitor.TabIndex = 0;
            this.lblCodLeitor.Text = "Código:";
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(12, 44);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(55, 20);
            this.lblNomeLeitor.TabIndex = 1;
            this.lblNomeLeitor.Text = "Nome:";
            // 
            // lblDtNascimentoLeitor
            // 
            this.lblDtNascimentoLeitor.AutoSize = true;
            this.lblDtNascimentoLeitor.Location = new System.Drawing.Point(12, 108);
            this.lblDtNascimentoLeitor.Name = "lblDtNascimentoLeitor";
            this.lblDtNascimentoLeitor.Size = new System.Drawing.Size(136, 20);
            this.lblDtNascimentoLeitor.TabIndex = 3;
            this.lblDtNascimentoLeitor.Text = "Data Nascimento:";
            // 
            // lblSexoLeitor
            // 
            this.lblSexoLeitor.AutoSize = true;
            this.lblSexoLeitor.Location = new System.Drawing.Point(12, 76);
            this.lblSexoLeitor.Name = "lblSexoLeitor";
            this.lblSexoLeitor.Size = new System.Drawing.Size(49, 20);
            this.lblSexoLeitor.TabIndex = 2;
            this.lblSexoLeitor.Text = "Sexo:";
            // 
            // lblRgLeitor
            // 
            this.lblRgLeitor.AutoSize = true;
            this.lblRgLeitor.Location = new System.Drawing.Point(12, 172);
            this.lblRgLeitor.Name = "lblRgLeitor";
            this.lblRgLeitor.Size = new System.Drawing.Size(38, 20);
            this.lblRgLeitor.TabIndex = 5;
            this.lblRgLeitor.Text = "RG:";
            // 
            // lblCpfLeitor
            // 
            this.lblCpfLeitor.AutoSize = true;
            this.lblCpfLeitor.Location = new System.Drawing.Point(12, 140);
            this.lblCpfLeitor.Name = "lblCpfLeitor";
            this.lblCpfLeitor.Size = new System.Drawing.Size(44, 20);
            this.lblCpfLeitor.TabIndex = 4;
            this.lblCpfLeitor.Text = "CPF:";
            // 
            // lblTelefoneLeitor
            // 
            this.lblTelefoneLeitor.AutoSize = true;
            this.lblTelefoneLeitor.Location = new System.Drawing.Point(12, 236);
            this.lblTelefoneLeitor.Name = "lblTelefoneLeitor";
            this.lblTelefoneLeitor.Size = new System.Drawing.Size(75, 20);
            this.lblTelefoneLeitor.TabIndex = 7;
            this.lblTelefoneLeitor.Text = "Telefone:";
            // 
            // lblEmailLeitor
            // 
            this.lblEmailLeitor.AutoSize = true;
            this.lblEmailLeitor.Location = new System.Drawing.Point(12, 204);
            this.lblEmailLeitor.Name = "lblEmailLeitor";
            this.lblEmailLeitor.Size = new System.Drawing.Size(57, 20);
            this.lblEmailLeitor.TabIndex = 6;
            this.lblEmailLeitor.Text = "E-mail:";
            // 
            // lblEnderecoLeitor
            // 
            this.lblEnderecoLeitor.AutoSize = true;
            this.lblEnderecoLeitor.Location = new System.Drawing.Point(12, 300);
            this.lblEnderecoLeitor.Name = "lblEnderecoLeitor";
            this.lblEnderecoLeitor.Size = new System.Drawing.Size(82, 20);
            this.lblEnderecoLeitor.TabIndex = 9;
            this.lblEnderecoLeitor.Text = "Endereço:";
            // 
            // lblCelularLeitor
            // 
            this.lblCelularLeitor.AutoSize = true;
            this.lblCelularLeitor.Location = new System.Drawing.Point(12, 268);
            this.lblCelularLeitor.Name = "lblCelularLeitor";
            this.lblCelularLeitor.Size = new System.Drawing.Size(62, 20);
            this.lblCelularLeitor.TabIndex = 8;
            this.lblCelularLeitor.Text = "Celular:";
            // 
            // lblCidadeLeitor
            // 
            this.lblCidadeLeitor.AutoSize = true;
            this.lblCidadeLeitor.Location = new System.Drawing.Point(12, 364);
            this.lblCidadeLeitor.Name = "lblCidadeLeitor";
            this.lblCidadeLeitor.Size = new System.Drawing.Size(63, 20);
            this.lblCidadeLeitor.TabIndex = 11;
            this.lblCidadeLeitor.Text = "Cidade:";
            // 
            // lblBairroLeitor
            // 
            this.lblBairroLeitor.AutoSize = true;
            this.lblBairroLeitor.Location = new System.Drawing.Point(12, 332);
            this.lblBairroLeitor.Name = "lblBairroLeitor";
            this.lblBairroLeitor.Size = new System.Drawing.Size(55, 20);
            this.lblBairroLeitor.TabIndex = 10;
            this.lblBairroLeitor.Text = "Bairro:";
            // 
            // lblCepLeitor
            // 
            this.lblCepLeitor.AutoSize = true;
            this.lblCepLeitor.Location = new System.Drawing.Point(12, 396);
            this.lblCepLeitor.Name = "lblCepLeitor";
            this.lblCepLeitor.Size = new System.Drawing.Size(45, 20);
            this.lblCepLeitor.TabIndex = 12;
            this.lblCepLeitor.Text = "CEP:";
            // 
            // lblNumeroLeitor
            // 
            this.lblNumeroLeitor.AutoSize = true;
            this.lblNumeroLeitor.Location = new System.Drawing.Point(12, 460);
            this.lblNumeroLeitor.Name = "lblNumeroLeitor";
            this.lblNumeroLeitor.Size = new System.Drawing.Size(69, 20);
            this.lblNumeroLeitor.TabIndex = 15;
            this.lblNumeroLeitor.Text = "Numero:";
            // 
            // lblUfLeitor
            // 
            this.lblUfLeitor.AutoSize = true;
            this.lblUfLeitor.Location = new System.Drawing.Point(12, 428);
            this.lblUfLeitor.Name = "lblUfLeitor";
            this.lblUfLeitor.Size = new System.Drawing.Size(35, 20);
            this.lblUfLeitor.TabIndex = 16;
            this.lblUfLeitor.Text = "UF:";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Enabled = false;
            this.txtCodLeitor.Location = new System.Drawing.Point(156, 9);
            this.txtCodLeitor.MaxLength = 3;
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtCodLeitor.TabIndex = 17;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(156, 41);
            this.txtNomeLeitor.MaxLength = 200;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(787, 26);
            this.txtNomeLeitor.TabIndex = 18;
            // 
            // txtSexoLeitor
            // 
            this.txtSexoLeitor.Location = new System.Drawing.Point(156, 73);
            this.txtSexoLeitor.MaxLength = 1;
            this.txtSexoLeitor.Name = "txtSexoLeitor";
            this.txtSexoLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtSexoLeitor.TabIndex = 19;
            // 
            // txtCidadeLeitor
            // 
            this.txtCidadeLeitor.Location = new System.Drawing.Point(156, 361);
            this.txtCidadeLeitor.MaxLength = 100;
            this.txtCidadeLeitor.Name = "txtCidadeLeitor";
            this.txtCidadeLeitor.Size = new System.Drawing.Size(452, 26);
            this.txtCidadeLeitor.TabIndex = 28;
            // 
            // txtBairroLeitor
            // 
            this.txtBairroLeitor.Location = new System.Drawing.Point(156, 329);
            this.txtBairroLeitor.MaxLength = 100;
            this.txtBairroLeitor.Name = "txtBairroLeitor";
            this.txtBairroLeitor.Size = new System.Drawing.Size(452, 26);
            this.txtBairroLeitor.TabIndex = 27;
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(156, 297);
            this.txtEnderecoLeitor.MaxLength = 200;
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(787, 26);
            this.txtEnderecoLeitor.TabIndex = 26;
            // 
            // txtNumeroLeitor
            // 
            this.txtNumeroLeitor.Location = new System.Drawing.Point(156, 457);
            this.txtNumeroLeitor.MaxLength = 10;
            this.txtNumeroLeitor.Name = "txtNumeroLeitor";
            this.txtNumeroLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtNumeroLeitor.TabIndex = 31;
            // 
            // txtUfLeitor
            // 
            this.txtUfLeitor.Location = new System.Drawing.Point(156, 425);
            this.txtUfLeitor.MaxLength = 2;
            this.txtUfLeitor.Name = "txtUfLeitor";
            this.txtUfLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtUfLeitor.TabIndex = 30;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(705, 489);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 34);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(827, 489);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 34);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dtgDadosLeitor
            // 
            this.dtgDadosLeitor.AllowUserToAddRows = false;
            this.dtgDadosLeitor.AllowUserToDeleteRows = false;
            this.dtgDadosLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosLeitor.Location = new System.Drawing.Point(16, 529);
            this.dtgDadosLeitor.Name = "dtgDadosLeitor";
            this.dtgDadosLeitor.ReadOnly = true;
            this.dtgDadosLeitor.RowHeadersWidth = 62;
            this.dtgDadosLeitor.RowTemplate.Height = 28;
            this.dtgDadosLeitor.Size = new System.Drawing.Size(927, 303);
            this.dtgDadosLeitor.TabIndex = 34;
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(156, 105);
            this.txtDtNascimento.Mask = "00/00/0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(296, 26);
            this.txtDtNascimento.TabIndex = 35;
            this.txtDtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpfLeitor
            // 
            this.txtCpfLeitor.Location = new System.Drawing.Point(156, 137);
            this.txtCpfLeitor.Mask = "000.000.000-00";
            this.txtCpfLeitor.Name = "txtCpfLeitor";
            this.txtCpfLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtCpfLeitor.TabIndex = 36;
            // 
            // txtRgLeitor
            // 
            this.txtRgLeitor.Location = new System.Drawing.Point(156, 169);
            this.txtRgLeitor.Mask = "00.000.000-0";
            this.txtRgLeitor.Name = "txtRgLeitor";
            this.txtRgLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtRgLeitor.TabIndex = 37;
            // 
            // txtEmailleitor
            // 
            this.txtEmailleitor.Location = new System.Drawing.Point(156, 201);
            this.txtEmailleitor.MaxLength = 200;
            this.txtEmailleitor.Name = "txtEmailleitor";
            this.txtEmailleitor.Size = new System.Drawing.Size(787, 26);
            this.txtEmailleitor.TabIndex = 38;
            // 
            // txtTelefoneLeitor
            // 
            this.txtTelefoneLeitor.Location = new System.Drawing.Point(156, 233);
            this.txtTelefoneLeitor.Mask = "(00) 0000-0000";
            this.txtTelefoneLeitor.Name = "txtTelefoneLeitor";
            this.txtTelefoneLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtTelefoneLeitor.TabIndex = 39;
            // 
            // txtCelularLeitor
            // 
            this.txtCelularLeitor.Location = new System.Drawing.Point(156, 265);
            this.txtCelularLeitor.Mask = "(00) 00000-0000";
            this.txtCelularLeitor.Name = "txtCelularLeitor";
            this.txtCelularLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtCelularLeitor.TabIndex = 40;
            // 
            // txtCepLeitor
            // 
            this.txtCepLeitor.Location = new System.Drawing.Point(156, 393);
            this.txtCepLeitor.Mask = "00000-000";
            this.txtCepLeitor.Name = "txtCepLeitor";
            this.txtCepLeitor.Size = new System.Drawing.Size(296, 26);
            this.txtCepLeitor.TabIndex = 41;
            // 
            // FormCadLeitor
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 844);
            this.Controls.Add(this.txtCepLeitor);
            this.Controls.Add(this.txtCelularLeitor);
            this.Controls.Add(this.txtTelefoneLeitor);
            this.Controls.Add(this.txtEmailleitor);
            this.Controls.Add(this.txtRgLeitor);
            this.Controls.Add(this.txtCpfLeitor);
            this.Controls.Add(this.txtDtNascimento);
            this.Controls.Add(this.dtgDadosLeitor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNumeroLeitor);
            this.Controls.Add(this.txtUfLeitor);
            this.Controls.Add(this.txtCidadeLeitor);
            this.Controls.Add(this.txtBairroLeitor);
            this.Controls.Add(this.txtEnderecoLeitor);
            this.Controls.Add(this.txtSexoLeitor);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.txtCodLeitor);
            this.Controls.Add(this.lblUfLeitor);
            this.Controls.Add(this.lblNumeroLeitor);
            this.Controls.Add(this.lblCepLeitor);
            this.Controls.Add(this.lblCidadeLeitor);
            this.Controls.Add(this.lblBairroLeitor);
            this.Controls.Add(this.lblEnderecoLeitor);
            this.Controls.Add(this.lblCelularLeitor);
            this.Controls.Add(this.lblTelefoneLeitor);
            this.Controls.Add(this.lblEmailLeitor);
            this.Controls.Add(this.lblRgLeitor);
            this.Controls.Add(this.lblCpfLeitor);
            this.Controls.Add(this.lblDtNascimentoLeitor);
            this.Controls.Add(this.lblSexoLeitor);
            this.Controls.Add(this.lblNomeLeitor);
            this.Controls.Add(this.lblCodLeitor);
            this.Name = "FormCadLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Leitor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodLeitor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblNomeLeitor;
        private System.Windows.Forms.Label lblDtNascimentoLeitor;
        private System.Windows.Forms.Label lblSexoLeitor;
        private System.Windows.Forms.Label lblRgLeitor;
        private System.Windows.Forms.Label lblCpfLeitor;
        private System.Windows.Forms.Label lblTelefoneLeitor;
        private System.Windows.Forms.Label lblEmailLeitor;
        private System.Windows.Forms.Label lblEnderecoLeitor;
        private System.Windows.Forms.Label lblCelularLeitor;
        private System.Windows.Forms.Label lblCidadeLeitor;
        private System.Windows.Forms.Label lblBairroLeitor;
        private System.Windows.Forms.Label lblCepLeitor;
        private System.Windows.Forms.Label lblNumeroLeitor;
        private System.Windows.Forms.Label lblUfLeitor;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtSexoLeitor;
        private System.Windows.Forms.TextBox txtCidadeLeitor;
        private System.Windows.Forms.TextBox txtBairroLeitor;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.TextBox txtNumeroLeitor;
        private System.Windows.Forms.TextBox txtUfLeitor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtgDadosLeitor;
        private System.Windows.Forms.MaskedTextBox txtDtNascimento;
        private System.Windows.Forms.MaskedTextBox txtCpfLeitor;
        private System.Windows.Forms.MaskedTextBox txtRgLeitor;
        private System.Windows.Forms.TextBox txtEmailleitor;
        private System.Windows.Forms.MaskedTextBox txtTelefoneLeitor;
        private System.Windows.Forms.MaskedTextBox txtCelularLeitor;
        private System.Windows.Forms.MaskedTextBox txtCepLeitor;
    }
}

