namespace GestaoEstoque
{
    partial class frmCadForn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFrente = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.padokaBDDataSet = new GestaoEstoque.padokaBDDataSet();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new GestaoEstoque.padokaBDDataSetTableAdapters.FornecedorTableAdapter();
            this.Forn_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forn_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forn_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forn_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forn_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forn_rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forn_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forn_cpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(182, 355);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 35);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(61, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(65, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nacionalidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(74, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "CEP";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(116, 179);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(281, 20);
            this.txtNacionalidade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(77, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(48, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Número";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(25, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Logradouro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(7, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Complemento";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(116, 234);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(281, 20);
            this.txtRua.TabIndex = 5;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(116, 261);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(281, 20);
            this.txtLogradouro.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(116, 287);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(281, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(116, 313);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(281, 20);
            this.txtComplemento.TabIndex = 8;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.White;
            this.btnConfirma.Location = new System.Drawing.Point(292, 355);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(104, 35);
            this.btnConfirma.TabIndex = 10;
            this.btnConfirma.Text = "&Cadastrar";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(116, 150);
            this.mskCNPJ.Mask = "99.999.999/9999-99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(281, 20);
            this.mskCNPJ.TabIndex = 2;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(116, 207);
            this.mskCEP.Mask = "99999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(281, 20);
            this.mskCEP.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVoltar.Location = new System.Drawing.Point(545, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(162, 28);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "&Voltar para cadastros";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.dgvFrente);
            this.panelConteudo.Controls.Add(this.label9);
            this.panelConteudo.Controls.Add(this.btnConsultar);
            this.panelConteudo.Controls.Add(this.txtPesquisa);
            this.panelConteudo.Controls.Add(this.pictureBox2);
            this.panelConteudo.Controls.Add(this.pictureBox1);
            this.panelConteudo.Controls.Add(this.label4);
            this.panelConteudo.Controls.Add(this.txtNome);
            this.panelConteudo.Controls.Add(this.label1);
            this.panelConteudo.Controls.Add(this.label2);
            this.panelConteudo.Controls.Add(this.label3);
            this.panelConteudo.Controls.Add(this.label5);
            this.panelConteudo.Controls.Add(this.label6);
            this.panelConteudo.Controls.Add(this.label8);
            this.panelConteudo.Controls.Add(this.label10);
            this.panelConteudo.Controls.Add(this.label7);
            this.panelConteudo.Controls.Add(this.btnConfirma);
            this.panelConteudo.Controls.Add(this.mskCEP);
            this.panelConteudo.Controls.Add(this.txtComplemento);
            this.panelConteudo.Controls.Add(this.mskCNPJ);
            this.panelConteudo.Controls.Add(this.txtNumero);
            this.panelConteudo.Controls.Add(this.txtNacionalidade);
            this.panelConteudo.Controls.Add(this.txtLogradouro);
            this.panelConteudo.Controls.Add(this.txtRua);
            this.panelConteudo.Controls.Add(this.btnLimpar);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(710, 447);
            this.panelConteudo.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestaoEstoque.Properties.Resources.fornecedor;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(68, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cadastro de fornecedor";
            // 
            // dgvFrente
            // 
            this.dgvFrente.AllowUserToAddRows = false;
            this.dgvFrente.AllowUserToDeleteRows = false;
            this.dgvFrente.AllowUserToOrderColumns = true;
            this.dgvFrente.AutoGenerateColumns = false;
            this.dgvFrente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrente.BackgroundColor = System.Drawing.Color.White;
            this.dgvFrente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Forn_cnpj,
            this.Forn_nome,
            this.Forn_nac,
            this.Forn_cep,
            this.Forn_log,
            this.Forn_rua,
            this.Forn_nro,
            this.Forn_cpl});
            this.dgvFrente.DataSource = this.fornecedorBindingSource;
            this.dgvFrente.Location = new System.Drawing.Point(416, 167);
            this.dgvFrente.Name = "dgvFrente";
            this.dgvFrente.ReadOnly = true;
            this.dgvFrente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrente.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFrente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFrente.Size = new System.Drawing.Size(282, 227);
            this.dgvFrente.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(442, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Consulte aqui";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(613, 124);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 25);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(416, 129);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(191, 20);
            this.txtPesquisa.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GestaoEstoque.Properties.Resources.busca;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(405, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // padokaBDDataSet
            // 
            this.padokaBDDataSet.DataSetName = "padokaBDDataSet";
            this.padokaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.padokaBDDataSet;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // Forn_cnpj
            // 
            this.Forn_cnpj.DataPropertyName = "Forn_cnpj";
            this.Forn_cnpj.HeaderText = "CNPJ";
            this.Forn_cnpj.Name = "Forn_cnpj";
            this.Forn_cnpj.ReadOnly = true;
            // 
            // Forn_nome
            // 
            this.Forn_nome.DataPropertyName = "Forn_nome";
            this.Forn_nome.HeaderText = "Nome";
            this.Forn_nome.Name = "Forn_nome";
            this.Forn_nome.ReadOnly = true;
            // 
            // Forn_nac
            // 
            this.Forn_nac.DataPropertyName = "Forn_nac";
            this.Forn_nac.HeaderText = "Nac";
            this.Forn_nac.Name = "Forn_nac";
            this.Forn_nac.ReadOnly = true;
            // 
            // Forn_cep
            // 
            this.Forn_cep.DataPropertyName = "Forn_cep";
            this.Forn_cep.HeaderText = "CEP";
            this.Forn_cep.Name = "Forn_cep";
            this.Forn_cep.ReadOnly = true;
            // 
            // Forn_log
            // 
            this.Forn_log.DataPropertyName = "Forn_log";
            this.Forn_log.HeaderText = "Logradouro";
            this.Forn_log.Name = "Forn_log";
            this.Forn_log.ReadOnly = true;
            // 
            // Forn_rua
            // 
            this.Forn_rua.DataPropertyName = "Forn_rua";
            this.Forn_rua.HeaderText = "Rua";
            this.Forn_rua.Name = "Forn_rua";
            this.Forn_rua.ReadOnly = true;
            // 
            // Forn_nro
            // 
            this.Forn_nro.DataPropertyName = "Forn_nro";
            this.Forn_nro.HeaderText = "Número";
            this.Forn_nro.Name = "Forn_nro";
            this.Forn_nro.ReadOnly = true;
            // 
            // Forn_cpl
            // 
            this.Forn_cpl.DataPropertyName = "Forn_cpl";
            this.Forn_cpl.HeaderText = "Complemento";
            this.Forn_cpl.Name = "Forn_cpl";
            this.Forn_cpl.ReadOnly = true;
            // 
            // frmCadForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 447);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de fornecedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadForn_FormClosing);
            this.Load += new System.EventHandler(this.frmCadForn_Load);
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvFrente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private padokaBDDataSet padokaBDDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private padokaBDDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forn_cpl;
    }
}