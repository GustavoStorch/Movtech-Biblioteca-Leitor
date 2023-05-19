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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadLeitor));
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
            this.txtCidadeLeitor = new System.Windows.Forms.TextBox();
            this.txtBairroLeitor = new System.Windows.Forms.TextBox();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.txtNumeroLeitor = new System.Windows.Forms.TextBox();
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
            this.cbxSexoLeitor = new System.Windows.Forms.ComboBox();
            this.gpxDadosLeitor = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpxEnderecoLeitor = new System.Windows.Forms.GroupBox();
            this.cbxUfLeitor = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.colCodigoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtNascimentoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRgLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefoneLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colCelularLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEnderecoLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colBairroLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colCidadeLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colCepLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colUfLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colNumeroLeitor = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).BeginInit();
            this.gpxDadosLeitor.SuspendLayout();
            this.gpxEnderecoLeitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodLeitor
            // 
            this.lblCodLeitor.AutoSize = true;
            this.lblCodLeitor.Location = new System.Drawing.Point(6, 31);
            this.lblCodLeitor.Name = "lblCodLeitor";
            this.lblCodLeitor.Size = new System.Drawing.Size(63, 20);
            this.lblCodLeitor.TabIndex = 0;
            this.lblCodLeitor.Text = "Código:";
            // 
            // lblNomeLeitor
            // 
            this.lblNomeLeitor.AutoSize = true;
            this.lblNomeLeitor.Location = new System.Drawing.Point(225, 30);
            this.lblNomeLeitor.Name = "lblNomeLeitor";
            this.lblNomeLeitor.Size = new System.Drawing.Size(55, 20);
            this.lblNomeLeitor.TabIndex = 1;
            this.lblNomeLeitor.Text = "Nome:";
            // 
            // lblDtNascimentoLeitor
            // 
            this.lblDtNascimentoLeitor.AutoSize = true;
            this.lblDtNascimentoLeitor.Location = new System.Drawing.Point(401, 99);
            this.lblDtNascimentoLeitor.Name = "lblDtNascimentoLeitor";
            this.lblDtNascimentoLeitor.Size = new System.Drawing.Size(136, 20);
            this.lblDtNascimentoLeitor.TabIndex = 3;
            this.lblDtNascimentoLeitor.Text = "Data Nascimento:";
            // 
            // lblSexoLeitor
            // 
            this.lblSexoLeitor.AutoSize = true;
            this.lblSexoLeitor.Location = new System.Drawing.Point(225, 98);
            this.lblSexoLeitor.Name = "lblSexoLeitor";
            this.lblSexoLeitor.Size = new System.Drawing.Size(49, 20);
            this.lblSexoLeitor.TabIndex = 2;
            this.lblSexoLeitor.Text = "Sexo:";
            // 
            // lblRgLeitor
            // 
            this.lblRgLeitor.AutoSize = true;
            this.lblRgLeitor.Location = new System.Drawing.Point(6, 95);
            this.lblRgLeitor.Name = "lblRgLeitor";
            this.lblRgLeitor.Size = new System.Drawing.Size(38, 20);
            this.lblRgLeitor.TabIndex = 5;
            this.lblRgLeitor.Text = "RG:";
            // 
            // lblCpfLeitor
            // 
            this.lblCpfLeitor.AutoSize = true;
            this.lblCpfLeitor.Location = new System.Drawing.Point(6, 64);
            this.lblCpfLeitor.Name = "lblCpfLeitor";
            this.lblCpfLeitor.Size = new System.Drawing.Size(44, 20);
            this.lblCpfLeitor.TabIndex = 4;
            this.lblCpfLeitor.Text = "CPF:";
            // 
            // lblTelefoneLeitor
            // 
            this.lblTelefoneLeitor.AutoSize = true;
            this.lblTelefoneLeitor.Location = new System.Drawing.Point(641, 99);
            this.lblTelefoneLeitor.Name = "lblTelefoneLeitor";
            this.lblTelefoneLeitor.Size = new System.Drawing.Size(75, 20);
            this.lblTelefoneLeitor.TabIndex = 7;
            this.lblTelefoneLeitor.Text = "Telefone:";
            // 
            // lblEmailLeitor
            // 
            this.lblEmailLeitor.AutoSize = true;
            this.lblEmailLeitor.Location = new System.Drawing.Point(225, 64);
            this.lblEmailLeitor.Name = "lblEmailLeitor";
            this.lblEmailLeitor.Size = new System.Drawing.Size(57, 20);
            this.lblEmailLeitor.TabIndex = 6;
            this.lblEmailLeitor.Text = "E-mail:";
            // 
            // lblEnderecoLeitor
            // 
            this.lblEnderecoLeitor.AutoSize = true;
            this.lblEnderecoLeitor.Location = new System.Drawing.Point(6, 28);
            this.lblEnderecoLeitor.Name = "lblEnderecoLeitor";
            this.lblEnderecoLeitor.Size = new System.Drawing.Size(82, 20);
            this.lblEnderecoLeitor.TabIndex = 9;
            this.lblEnderecoLeitor.Text = "Endereço:";
            // 
            // lblCelularLeitor
            // 
            this.lblCelularLeitor.AutoSize = true;
            this.lblCelularLeitor.Location = new System.Drawing.Point(848, 98);
            this.lblCelularLeitor.Name = "lblCelularLeitor";
            this.lblCelularLeitor.Size = new System.Drawing.Size(62, 20);
            this.lblCelularLeitor.TabIndex = 8;
            this.lblCelularLeitor.Text = "Celular:";
            // 
            // lblCidadeLeitor
            // 
            this.lblCidadeLeitor.AutoSize = true;
            this.lblCidadeLeitor.Location = new System.Drawing.Point(6, 60);
            this.lblCidadeLeitor.Name = "lblCidadeLeitor";
            this.lblCidadeLeitor.Size = new System.Drawing.Size(63, 20);
            this.lblCidadeLeitor.TabIndex = 11;
            this.lblCidadeLeitor.Text = "Cidade:";
            // 
            // lblBairroLeitor
            // 
            this.lblBairroLeitor.AutoSize = true;
            this.lblBairroLeitor.Location = new System.Drawing.Point(552, 28);
            this.lblBairroLeitor.Name = "lblBairroLeitor";
            this.lblBairroLeitor.Size = new System.Drawing.Size(55, 20);
            this.lblBairroLeitor.TabIndex = 10;
            this.lblBairroLeitor.Text = "Bairro:";
            // 
            // lblCepLeitor
            // 
            this.lblCepLeitor.AutoSize = true;
            this.lblCepLeitor.Location = new System.Drawing.Point(552, 63);
            this.lblCepLeitor.Name = "lblCepLeitor";
            this.lblCepLeitor.Size = new System.Drawing.Size(45, 20);
            this.lblCepLeitor.TabIndex = 12;
            this.lblCepLeitor.Text = "CEP:";
            // 
            // lblNumeroLeitor
            // 
            this.lblNumeroLeitor.AutoSize = true;
            this.lblNumeroLeitor.Location = new System.Drawing.Point(829, 60);
            this.lblNumeroLeitor.Name = "lblNumeroLeitor";
            this.lblNumeroLeitor.Size = new System.Drawing.Size(69, 20);
            this.lblNumeroLeitor.TabIndex = 15;
            this.lblNumeroLeitor.Text = "Numero:";
            // 
            // lblUfLeitor
            // 
            this.lblUfLeitor.AutoSize = true;
            this.lblUfLeitor.Location = new System.Drawing.Point(705, 60);
            this.lblUfLeitor.Name = "lblUfLeitor";
            this.lblUfLeitor.Size = new System.Drawing.Size(35, 20);
            this.lblUfLeitor.TabIndex = 16;
            this.lblUfLeitor.Text = "UF:";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Enabled = false;
            this.txtCodLeitor.Location = new System.Drawing.Point(75, 28);
            this.txtCodLeitor.MaxLength = 3;
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(144, 26);
            this.txtCodLeitor.TabIndex = 1;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLeitor.Location = new System.Drawing.Point(290, 28);
            this.txtNomeLeitor.MaxLength = 200;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(753, 26);
            this.txtNomeLeitor.TabIndex = 2;
            // 
            // txtCidadeLeitor
            // 
            this.txtCidadeLeitor.Location = new System.Drawing.Point(94, 57);
            this.txtCidadeLeitor.MaxLength = 100;
            this.txtCidadeLeitor.Name = "txtCidadeLeitor";
            this.txtCidadeLeitor.Size = new System.Drawing.Size(452, 26);
            this.txtCidadeLeitor.TabIndex = 12;
            // 
            // txtBairroLeitor
            // 
            this.txtBairroLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairroLeitor.Location = new System.Drawing.Point(613, 25);
            this.txtBairroLeitor.MaxLength = 100;
            this.txtBairroLeitor.Name = "txtBairroLeitor";
            this.txtBairroLeitor.Size = new System.Drawing.Size(430, 26);
            this.txtBairroLeitor.TabIndex = 11;
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(94, 25);
            this.txtEnderecoLeitor.MaxLength = 200;
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(452, 26);
            this.txtEnderecoLeitor.TabIndex = 10;
            // 
            // txtNumeroLeitor
            // 
            this.txtNumeroLeitor.Location = new System.Drawing.Point(904, 57);
            this.txtNumeroLeitor.MaxLength = 10;
            this.txtNumeroLeitor.Name = "txtNumeroLeitor";
            this.txtNumeroLeitor.Size = new System.Drawing.Size(139, 26);
            this.txtNumeroLeitor.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(824, 254);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 34);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(947, 254);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 34);
            this.btnExcluir.TabIndex = 17;
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
            this.colCpfLeitor,
            this.colEmailLeitor,
            this.colSexoLeitor,
            this.colDtNascimentoLeitor,
            this.colRgLeitor,
            this.colTelefoneLeitor,
            this.colCelularLeitor,
            this.colEnderecoLeitor,
            this.colBairroLeitor,
            this.colCidadeLeitor,
            this.colCepLeitor,
            this.colUfLeitor,
            this.colNumeroLeitor});
            this.dtgDadosLeitor.Location = new System.Drawing.Point(12, 294);
            this.dtgDadosLeitor.Name = "dtgDadosLeitor";
            this.dtgDadosLeitor.ReadOnly = true;
            this.dtgDadosLeitor.RowHeadersWidth = 62;
            this.dtgDadosLeitor.RowTemplate.Height = 28;
            this.dtgDadosLeitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosLeitor.Size = new System.Drawing.Size(1051, 325);
            this.dtgDadosLeitor.TabIndex = 18;
            this.dtgDadosLeitor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosLeitor_CellDoubleClick);
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(543, 96);
            this.txtDtNascimento.Mask = "00/00/0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(92, 26);
            this.txtDtNascimento.TabIndex = 7;
            this.txtDtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpfLeitor
            // 
            this.txtCpfLeitor.Location = new System.Drawing.Point(75, 60);
            this.txtCpfLeitor.Mask = "000.000.000-00";
            this.txtCpfLeitor.Name = "txtCpfLeitor";
            this.txtCpfLeitor.Size = new System.Drawing.Size(144, 26);
            this.txtCpfLeitor.TabIndex = 3;
            // 
            // txtRgLeitor
            // 
            this.txtRgLeitor.Location = new System.Drawing.Point(75, 92);
            this.txtRgLeitor.Mask = "0.000.000";
            this.txtRgLeitor.Name = "txtRgLeitor";
            this.txtRgLeitor.Size = new System.Drawing.Size(144, 26);
            this.txtRgLeitor.TabIndex = 5;
            // 
            // txtEmailleitor
            // 
            this.txtEmailleitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailleitor.Location = new System.Drawing.Point(290, 61);
            this.txtEmailleitor.MaxLength = 200;
            this.txtEmailleitor.Name = "txtEmailleitor";
            this.txtEmailleitor.Size = new System.Drawing.Size(753, 26);
            this.txtEmailleitor.TabIndex = 4;
            // 
            // txtTelefoneLeitor
            // 
            this.txtTelefoneLeitor.Location = new System.Drawing.Point(722, 96);
            this.txtTelefoneLeitor.Mask = "(00) 0000-0000";
            this.txtTelefoneLeitor.Name = "txtTelefoneLeitor";
            this.txtTelefoneLeitor.Size = new System.Drawing.Size(120, 26);
            this.txtTelefoneLeitor.TabIndex = 8;
            // 
            // txtCelularLeitor
            // 
            this.txtCelularLeitor.Location = new System.Drawing.Point(916, 96);
            this.txtCelularLeitor.Mask = "(00) 00000-0000";
            this.txtCelularLeitor.Name = "txtCelularLeitor";
            this.txtCelularLeitor.Size = new System.Drawing.Size(127, 26);
            this.txtCelularLeitor.TabIndex = 9;
            // 
            // txtCepLeitor
            // 
            this.txtCepLeitor.Location = new System.Drawing.Point(613, 57);
            this.txtCepLeitor.Mask = "00000-000";
            this.txtCepLeitor.Name = "txtCepLeitor";
            this.txtCepLeitor.Size = new System.Drawing.Size(86, 26);
            this.txtCepLeitor.TabIndex = 13;
            // 
            // cbxSexoLeitor
            // 
            this.cbxSexoLeitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoLeitor.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxSexoLeitor.Location = new System.Drawing.Point(290, 96);
            this.cbxSexoLeitor.Name = "cbxSexoLeitor";
            this.cbxSexoLeitor.Size = new System.Drawing.Size(105, 28);
            this.cbxSexoLeitor.TabIndex = 6;
            // 
            // gpxDadosLeitor
            // 
            this.gpxDadosLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxDadosLeitor.Controls.Add(this.lblCodLeitor);
            this.gpxDadosLeitor.Controls.Add(this.cbxSexoLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtCelularLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtCodLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtTelefoneLeitor);
            this.gpxDadosLeitor.Controls.Add(this.lblNomeLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtDtNascimento);
            this.gpxDadosLeitor.Controls.Add(this.lblSexoLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtRgLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtEmailleitor);
            this.gpxDadosLeitor.Controls.Add(this.lblDtNascimentoLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtCpfLeitor);
            this.gpxDadosLeitor.Controls.Add(this.txtNomeLeitor);
            this.gpxDadosLeitor.Controls.Add(this.lblRgLeitor);
            this.gpxDadosLeitor.Controls.Add(this.lblEmailLeitor);
            this.gpxDadosLeitor.Controls.Add(this.lblCpfLeitor);
            this.gpxDadosLeitor.Controls.Add(this.lblTelefoneLeitor);
            this.gpxDadosLeitor.Controls.Add(this.lblCelularLeitor);
            this.gpxDadosLeitor.Location = new System.Drawing.Point(12, 12);
            this.gpxDadosLeitor.Name = "gpxDadosLeitor";
            this.gpxDadosLeitor.Size = new System.Drawing.Size(1051, 132);
            this.gpxDadosLeitor.TabIndex = 42;
            this.gpxDadosLeitor.TabStop = false;
            this.gpxDadosLeitor.Text = "Dados Pessoais";
            // 
            // gpxEnderecoLeitor
            // 
            this.gpxEnderecoLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxEnderecoLeitor.Controls.Add(this.cbxUfLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.lblEnderecoLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.txtEnderecoLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.txtCepLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.lblBairroLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.txtBairroLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.txtNumeroLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.lblCidadeLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.lblNumeroLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.txtCidadeLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.lblUfLeitor);
            this.gpxEnderecoLeitor.Controls.Add(this.lblCepLeitor);
            this.gpxEnderecoLeitor.Location = new System.Drawing.Point(12, 150);
            this.gpxEnderecoLeitor.Name = "gpxEnderecoLeitor";
            this.gpxEnderecoLeitor.Size = new System.Drawing.Size(1051, 98);
            this.gpxEnderecoLeitor.TabIndex = 43;
            this.gpxEnderecoLeitor.TabStop = false;
            this.gpxEnderecoLeitor.Text = "Endereço Pessoal";
            // 
            // cbxUfLeitor
            // 
            this.cbxUfLeitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUfLeitor.FormattingEnabled = true;
            this.cbxUfLeitor.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUfLeitor.Location = new System.Drawing.Point(746, 57);
            this.cbxUfLeitor.Name = "cbxUfLeitor";
            this.cbxUfLeitor.Size = new System.Drawing.Size(77, 28);
            this.cbxUfLeitor.TabIndex = 14;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(433, 254);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(200, 26);
            this.dtpDataNascimento.TabIndex = 44;
            // 
            // colCodigoLeitor
            // 
            this.colCodigoLeitor.FillWeight = 35F;
            this.colCodigoLeitor.HeaderText = "Código";
            this.colCodigoLeitor.MinimumWidth = 8;
            this.colCodigoLeitor.Name = "colCodigoLeitor";
            this.colCodigoLeitor.ReadOnly = true;
            // 
            // colNomeLeitor
            // 
            this.colNomeLeitor.HeaderText = "Leitor";
            this.colNomeLeitor.MinimumWidth = 8;
            this.colNomeLeitor.Name = "colNomeLeitor";
            this.colNomeLeitor.ReadOnly = true;
            // 
            // colCpfLeitor
            // 
            this.colCpfLeitor.HeaderText = "CPF";
            this.colCpfLeitor.MinimumWidth = 8;
            this.colCpfLeitor.Name = "colCpfLeitor";
            this.colCpfLeitor.ReadOnly = true;
            // 
            // colEmailLeitor
            // 
            this.colEmailLeitor.HeaderText = "E-mail";
            this.colEmailLeitor.MinimumWidth = 8;
            this.colEmailLeitor.Name = "colEmailLeitor";
            this.colEmailLeitor.ReadOnly = true;
            // 
            // colSexoLeitor
            // 
            this.colSexoLeitor.HeaderText = "Sexo";
            this.colSexoLeitor.MinimumWidth = 8;
            this.colSexoLeitor.Name = "colSexoLeitor";
            this.colSexoLeitor.ReadOnly = true;
            this.colSexoLeitor.Visible = false;
            // 
            // colDtNascimentoLeitor
            // 
            this.colDtNascimentoLeitor.HeaderText = "Data.Nascimento";
            this.colDtNascimentoLeitor.MinimumWidth = 8;
            this.colDtNascimentoLeitor.Name = "colDtNascimentoLeitor";
            this.colDtNascimentoLeitor.ReadOnly = true;
            this.colDtNascimentoLeitor.Visible = false;
            // 
            // colRgLeitor
            // 
            this.colRgLeitor.HeaderText = "RG";
            this.colRgLeitor.MinimumWidth = 8;
            this.colRgLeitor.Name = "colRgLeitor";
            this.colRgLeitor.ReadOnly = true;
            this.colRgLeitor.Visible = false;
            // 
            // colTelefoneLeitor
            // 
            this.colTelefoneLeitor.HeaderText = "Telefone";
            this.colTelefoneLeitor.MinimumWidth = 8;
            this.colTelefoneLeitor.Name = "colTelefoneLeitor";
            this.colTelefoneLeitor.ReadOnly = true;
            this.colTelefoneLeitor.Visible = false;
            // 
            // colCelularLeitor
            // 
            this.colCelularLeitor.HeaderText = "Celular";
            this.colCelularLeitor.MinimumWidth = 8;
            this.colCelularLeitor.Name = "colCelularLeitor";
            this.colCelularLeitor.ReadOnly = true;
            this.colCelularLeitor.Visible = false;
            // 
            // colEnderecoLeitor
            // 
            this.colEnderecoLeitor.HeaderText = "Endereço";
            this.colEnderecoLeitor.MinimumWidth = 8;
            this.colEnderecoLeitor.Name = "colEnderecoLeitor";
            this.colEnderecoLeitor.ReadOnly = true;
            this.colEnderecoLeitor.Visible = false;
            // 
            // colBairroLeitor
            // 
            this.colBairroLeitor.HeaderText = "Bairro";
            this.colBairroLeitor.MinimumWidth = 8;
            this.colBairroLeitor.Name = "colBairroLeitor";
            this.colBairroLeitor.ReadOnly = true;
            this.colBairroLeitor.Visible = false;
            // 
            // colCidadeLeitor
            // 
            this.colCidadeLeitor.HeaderText = "Cidade";
            this.colCidadeLeitor.MinimumWidth = 8;
            this.colCidadeLeitor.Name = "colCidadeLeitor";
            this.colCidadeLeitor.ReadOnly = true;
            this.colCidadeLeitor.Visible = false;
            // 
            // colCepLeitor
            // 
            this.colCepLeitor.HeaderText = "CEP";
            this.colCepLeitor.MinimumWidth = 8;
            this.colCepLeitor.Name = "colCepLeitor";
            this.colCepLeitor.ReadOnly = true;
            this.colCepLeitor.Visible = false;
            // 
            // colUfLeitor
            // 
            this.colUfLeitor.HeaderText = "UF";
            this.colUfLeitor.MinimumWidth = 8;
            this.colUfLeitor.Name = "colUfLeitor";
            this.colUfLeitor.ReadOnly = true;
            this.colUfLeitor.Visible = false;
            // 
            // colNumeroLeitor
            // 
            this.colNumeroLeitor.HeaderText = "Número";
            this.colNumeroLeitor.MinimumWidth = 8;
            this.colNumeroLeitor.Name = "colNumeroLeitor";
            this.colNumeroLeitor.ReadOnly = true;
            this.colNumeroLeitor.Visible = false;
            // 
            // FormCadLeitor
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 626);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.gpxEnderecoLeitor);
            this.Controls.Add(this.gpxDadosLeitor);
            this.Controls.Add(this.dtgDadosLeitor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Leitor";
            this.Load += new System.EventHandler(this.FormCadLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosLeitor)).EndInit();
            this.gpxDadosLeitor.ResumeLayout(false);
            this.gpxDadosLeitor.PerformLayout();
            this.gpxEnderecoLeitor.ResumeLayout(false);
            this.gpxEnderecoLeitor.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtCidadeLeitor;
        private System.Windows.Forms.TextBox txtBairroLeitor;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.TextBox txtNumeroLeitor;
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
        private System.Windows.Forms.ComboBox cbxSexoLeitor;
        private System.Windows.Forms.GroupBox gpxDadosLeitor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpxEnderecoLeitor;
        private System.Windows.Forms.ComboBox cbxUfLeitor;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtNascimentoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRgLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colTelefoneLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colCelularLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colEnderecoLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colBairroLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colCidadeLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colCepLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colUfLeitor;
        private System.Windows.Forms.DataGridViewLinkColumn colNumeroLeitor;
    }
}

