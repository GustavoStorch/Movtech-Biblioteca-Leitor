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
            this.colCodigoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodLeitor
            // 
            this.lblCodLeitor.AutoSize = true;
            this.lblCodLeitor.Location = new System.Drawing.Point(8, 8);
            this.lblCodLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodLeitor.Name = "lblCodLeitor";
            this.lblCodLeitor.Size = new System.Drawing.Size(43, 13);
            this.lblCodLeitor.TabIndex = 0;
            this.lblCodLeitor.Text = "Código:";
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(8, 29);
            this.lblNomeLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(38, 13);
            this.lblNomeLeitor.TabIndex = 1;
            this.lblNomeLeitor.Text = "Nome:";
            // 
            // lblDtNascimentoLeitor
            // 
            this.lblDtNascimentoLeitor.AutoSize = true;
            this.lblDtNascimentoLeitor.Location = new System.Drawing.Point(8, 70);
            this.lblDtNascimentoLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtNascimentoLeitor.Name = "lblDtNascimentoLeitor";
            this.lblDtNascimentoLeitor.Size = new System.Drawing.Size(92, 13);
            this.lblDtNascimentoLeitor.TabIndex = 3;
            this.lblDtNascimentoLeitor.Text = "Data Nascimento:";
            // 
            // lblSexoLeitor
            // 
            this.lblSexoLeitor.AutoSize = true;
            this.lblSexoLeitor.Location = new System.Drawing.Point(8, 49);
            this.lblSexoLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexoLeitor.Name = "lblSexoLeitor";
            this.lblSexoLeitor.Size = new System.Drawing.Size(34, 13);
            this.lblSexoLeitor.TabIndex = 2;
            this.lblSexoLeitor.Text = "Sexo:";
            // 
            // lblRgLeitor
            // 
            this.lblRgLeitor.AutoSize = true;
            this.lblRgLeitor.Location = new System.Drawing.Point(8, 112);
            this.lblRgLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRgLeitor.Name = "lblRgLeitor";
            this.lblRgLeitor.Size = new System.Drawing.Size(26, 13);
            this.lblRgLeitor.TabIndex = 5;
            this.lblRgLeitor.Text = "RG:";
            // 
            // lblCpfLeitor
            // 
            this.lblCpfLeitor.AutoSize = true;
            this.lblCpfLeitor.Location = new System.Drawing.Point(8, 91);
            this.lblCpfLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfLeitor.Name = "lblCpfLeitor";
            this.lblCpfLeitor.Size = new System.Drawing.Size(30, 13);
            this.lblCpfLeitor.TabIndex = 4;
            this.lblCpfLeitor.Text = "CPF:";
            // 
            // lblTelefoneLeitor
            // 
            this.lblTelefoneLeitor.AutoSize = true;
            this.lblTelefoneLeitor.Location = new System.Drawing.Point(8, 153);
            this.lblTelefoneLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneLeitor.Name = "lblTelefoneLeitor";
            this.lblTelefoneLeitor.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneLeitor.TabIndex = 7;
            this.lblTelefoneLeitor.Text = "Telefone:";
            // 
            // lblEmailLeitor
            // 
            this.lblEmailLeitor.AutoSize = true;
            this.lblEmailLeitor.Location = new System.Drawing.Point(8, 133);
            this.lblEmailLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailLeitor.Name = "lblEmailLeitor";
            this.lblEmailLeitor.Size = new System.Drawing.Size(38, 13);
            this.lblEmailLeitor.TabIndex = 6;
            this.lblEmailLeitor.Text = "E-mail:";
            // 
            // lblEnderecoLeitor
            // 
            this.lblEnderecoLeitor.AutoSize = true;
            this.lblEnderecoLeitor.Location = new System.Drawing.Point(8, 195);
            this.lblEnderecoLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnderecoLeitor.Name = "lblEnderecoLeitor";
            this.lblEnderecoLeitor.Size = new System.Drawing.Size(56, 13);
            this.lblEnderecoLeitor.TabIndex = 9;
            this.lblEnderecoLeitor.Text = "Endereço:";
            // 
            // lblCelularLeitor
            // 
            this.lblCelularLeitor.AutoSize = true;
            this.lblCelularLeitor.Location = new System.Drawing.Point(8, 174);
            this.lblCelularLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelularLeitor.Name = "lblCelularLeitor";
            this.lblCelularLeitor.Size = new System.Drawing.Size(42, 13);
            this.lblCelularLeitor.TabIndex = 8;
            this.lblCelularLeitor.Text = "Celular:";
            // 
            // lblCidadeLeitor
            // 
            this.lblCidadeLeitor.AutoSize = true;
            this.lblCidadeLeitor.Location = new System.Drawing.Point(8, 237);
            this.lblCidadeLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidadeLeitor.Name = "lblCidadeLeitor";
            this.lblCidadeLeitor.Size = new System.Drawing.Size(43, 13);
            this.lblCidadeLeitor.TabIndex = 11;
            this.lblCidadeLeitor.Text = "Cidade:";
            // 
            // lblBairroLeitor
            // 
            this.lblBairroLeitor.AutoSize = true;
            this.lblBairroLeitor.Location = new System.Drawing.Point(8, 216);
            this.lblBairroLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairroLeitor.Name = "lblBairroLeitor";
            this.lblBairroLeitor.Size = new System.Drawing.Size(37, 13);
            this.lblBairroLeitor.TabIndex = 10;
            this.lblBairroLeitor.Text = "Bairro:";
            // 
            // lblCepLeitor
            // 
            this.lblCepLeitor.AutoSize = true;
            this.lblCepLeitor.Location = new System.Drawing.Point(8, 257);
            this.lblCepLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCepLeitor.Name = "lblCepLeitor";
            this.lblCepLeitor.Size = new System.Drawing.Size(31, 13);
            this.lblCepLeitor.TabIndex = 12;
            this.lblCepLeitor.Text = "CEP:";
            // 
            // lblNumeroLeitor
            // 
            this.lblNumeroLeitor.AutoSize = true;
            this.lblNumeroLeitor.Location = new System.Drawing.Point(8, 299);
            this.lblNumeroLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroLeitor.Name = "lblNumeroLeitor";
            this.lblNumeroLeitor.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroLeitor.TabIndex = 15;
            this.lblNumeroLeitor.Text = "Numero:";
            // 
            // lblUfLeitor
            // 
            this.lblUfLeitor.AutoSize = true;
            this.lblUfLeitor.Location = new System.Drawing.Point(8, 278);
            this.lblUfLeitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUfLeitor.Name = "lblUfLeitor";
            this.lblUfLeitor.Size = new System.Drawing.Size(24, 13);
            this.lblUfLeitor.TabIndex = 16;
            this.lblUfLeitor.Text = "UF:";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Enabled = false;
            this.txtCodLeitor.Location = new System.Drawing.Point(104, 6);
            this.txtCodLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodLeitor.MaxLength = 3;
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtCodLeitor.TabIndex = 17;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(104, 27);
            this.txtNomeLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeLeitor.MaxLength = 200;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(526, 20);
            this.txtNomeLeitor.TabIndex = 18;
            // 
            // txtSexoLeitor
            // 
            this.txtSexoLeitor.Location = new System.Drawing.Point(104, 47);
            this.txtSexoLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSexoLeitor.MaxLength = 1;
            this.txtSexoLeitor.Name = "txtSexoLeitor";
            this.txtSexoLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtSexoLeitor.TabIndex = 19;
            // 
            // txtCidadeLeitor
            // 
            this.txtCidadeLeitor.Location = new System.Drawing.Point(104, 235);
            this.txtCidadeLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCidadeLeitor.MaxLength = 100;
            this.txtCidadeLeitor.Name = "txtCidadeLeitor";
            this.txtCidadeLeitor.Size = new System.Drawing.Size(303, 20);
            this.txtCidadeLeitor.TabIndex = 28;
            // 
            // txtBairroLeitor
            // 
            this.txtBairroLeitor.Location = new System.Drawing.Point(104, 214);
            this.txtBairroLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBairroLeitor.MaxLength = 100;
            this.txtBairroLeitor.Name = "txtBairroLeitor";
            this.txtBairroLeitor.Size = new System.Drawing.Size(303, 20);
            this.txtBairroLeitor.TabIndex = 27;
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(104, 193);
            this.txtEnderecoLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnderecoLeitor.MaxLength = 200;
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(526, 20);
            this.txtEnderecoLeitor.TabIndex = 26;
            // 
            // txtNumeroLeitor
            // 
            this.txtNumeroLeitor.Location = new System.Drawing.Point(104, 297);
            this.txtNumeroLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroLeitor.MaxLength = 10;
            this.txtNumeroLeitor.Name = "txtNumeroLeitor";
            this.txtNumeroLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtNumeroLeitor.TabIndex = 31;
            // 
            // txtUfLeitor
            // 
            this.txtUfLeitor.Location = new System.Drawing.Point(104, 276);
            this.txtUfLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUfLeitor.MaxLength = 2;
            this.txtUfLeitor.Name = "txtUfLeitor";
            this.txtUfLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtUfLeitor.TabIndex = 30;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(470, 318);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 22);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(551, 318);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 22);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtgDadosLeitor
            // 
            this.dtgDadosLeitor.AllowUserToAddRows = false;
            this.dtgDadosLeitor.AllowUserToDeleteRows = false;
            this.dtgDadosLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosLeitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoLeitor,
            this.colNomeLeitor,
            this.colCpfLeitor});
            this.dtgDadosLeitor.Location = new System.Drawing.Point(11, 344);
            this.dtgDadosLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgDadosLeitor.Name = "dtgDadosLeitor";
            this.dtgDadosLeitor.ReadOnly = true;
            this.dtgDadosLeitor.RowHeadersWidth = 62;
            this.dtgDadosLeitor.RowTemplate.Height = 28;
            this.dtgDadosLeitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLeitor.Size = new System.Drawing.Size(618, 197);
            this.dtgDadosLeitor.TabIndex = 34;
            this.dtgDadosLeitor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLeitor_CellDoubleClick);
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(104, 68);
            this.txtDtNascimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDtNascimento.Mask = "00/00/0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(199, 20);
            this.txtDtNascimento.TabIndex = 35;
            this.txtDtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpfLeitor
            // 
            this.txtCpfLeitor.Location = new System.Drawing.Point(104, 89);
            this.txtCpfLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpfLeitor.Mask = "000.000.000-00";
            this.txtCpfLeitor.Name = "txtCpfLeitor";
            this.txtCpfLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtCpfLeitor.TabIndex = 36;
            // 
            // txtRgLeitor
            // 
            this.txtRgLeitor.Location = new System.Drawing.Point(104, 110);
            this.txtRgLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRgLeitor.Mask = "00.000.000-0";
            this.txtRgLeitor.Name = "txtRgLeitor";
            this.txtRgLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtRgLeitor.TabIndex = 37;
            // 
            // txtEmailleitor
            // 
            this.txtEmailleitor.Location = new System.Drawing.Point(104, 131);
            this.txtEmailleitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailleitor.MaxLength = 200;
            this.txtEmailleitor.Name = "txtEmailleitor";
            this.txtEmailleitor.Size = new System.Drawing.Size(526, 20);
            this.txtEmailleitor.TabIndex = 38;
            // 
            // txtTelefoneLeitor
            // 
            this.txtTelefoneLeitor.Location = new System.Drawing.Point(104, 151);
            this.txtTelefoneLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefoneLeitor.Mask = "(00) 0000-0000";
            this.txtTelefoneLeitor.Name = "txtTelefoneLeitor";
            this.txtTelefoneLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtTelefoneLeitor.TabIndex = 39;
            // 
            // txtCelularLeitor
            // 
            this.txtCelularLeitor.Location = new System.Drawing.Point(104, 172);
            this.txtCelularLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelularLeitor.Mask = "(00) 00000-0000";
            this.txtCelularLeitor.Name = "txtCelularLeitor";
            this.txtCelularLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtCelularLeitor.TabIndex = 40;
            // 
            // txtCepLeitor
            // 
            this.txtCepLeitor.Location = new System.Drawing.Point(104, 255);
            this.txtCepLeitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCepLeitor.Mask = "00000-000";
            this.txtCepLeitor.Name = "txtCepLeitor";
            this.txtCepLeitor.Size = new System.Drawing.Size(199, 20);
            this.txtCepLeitor.TabIndex = 41;
            // 
            // colCodigoLeitor
            // 
            this.colCodigoLeitor.HeaderText = "Código";
            this.colCodigoLeitor.Name = "colCodigoLeitor";
            this.colCodigoLeitor.ReadOnly = true;
            // 
            // colNomeLeitor
            // 
            this.colNomeLeitor.HeaderText = "Leitor";
            this.colNomeLeitor.Name = "colNomeLeitor";
            this.colNomeLeitor.ReadOnly = true;
            // 
            // colCpfLeitor
            // 
            this.colCpfLeitor.HeaderText = "CPF";
            this.colCpfLeitor.Name = "colCpfLeitor";
            this.colCpfLeitor.ReadOnly = true;
            // 
            // FormCadLeitor
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 487);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCadLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Leitor";
            this.Load += new System.EventHandler(this.FormCadLeitor_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfLeitor;
    }
}

