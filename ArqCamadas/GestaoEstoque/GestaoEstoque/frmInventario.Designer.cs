namespace GestaoEstoque
{
    partial class frmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtIDLote = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.dgvFrente = new System.Windows.Forms.DataGridView();
            this.ID_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padokaBDDataSet = new GestaoEstoque.padokaBDDataSet();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAlterarFundos = new System.Windows.Forms.Button();
            this.btnExcluirFundos = new System.Windows.Forms.Button();
            this.txtQuantidadeFundos = new System.Windows.Forms.TextBox();
            this.txtIDLFundos = new System.Windows.Forms.TextBox();
            this.txtValorFundos = new System.Windows.Forms.TextBox();
            this.txtNomeFundos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPFundos = new System.Windows.Forms.TextBox();
            this.dgvFundos = new System.Windows.Forms.DataGridView();
            this.ID_ProdutoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_NomeF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_ValorF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LoteF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_QtdF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.txtPesquisa2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produtoTableAdapter = new GestaoEstoque.padokaBDDataSetTableAdapters.ProdutoTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventário";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 374);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLocal);
            this.tabPage1.Controls.Add(this.lblLocal);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.txtQtd);
            this.tabPage1.Controls.Add(this.txtIDLote);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtIDProd);
            this.tabPage1.Controls.Add(this.dgvFrente);
            this.tabPage1.Controls.Add(this.btnConsulta);
            this.tabPage1.Controls.Add(this.txtPesquisa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Frente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLocal
            // 
            this.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocal.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(135, 227);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(135, 26);
            this.txtLocal.TabIndex = 6;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLocal.Location = new System.Drawing.Point(80, 234);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(45, 19);
            this.lblLocal.TabIndex = 40;
            this.lblLocal.Text = "Local";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(174, 287);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 26);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(53, 287);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 26);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(135, 195);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(135, 26);
            this.txtQtd.TabIndex = 5;
            // 
            // txtIDLote
            // 
            this.txtIDLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDLote.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLote.Location = new System.Drawing.Point(135, 160);
            this.txtIDLote.Name = "txtIDLote";
            this.txtIDLote.Size = new System.Drawing.Size(135, 26);
            this.txtIDLote.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(135, 125);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(135, 26);
            this.txtValor.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(135, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 26);
            this.txtNome.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(45, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(57, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID do lote";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(85, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(80, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(32, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "ID do produto";
            // 
            // txtIDProd
            // 
            this.txtIDProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDProd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProd.Location = new System.Drawing.Point(135, 54);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(135, 26);
            this.txtIDProd.TabIndex = 1;
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
            this.ID_Produto,
            this.Prod_Nome,
            this.Prod_Valor,
            this.ID_Lote,
            this.Prod_Qtd,
            this.Prod_Local});
            this.dgvFrente.DataSource = this.produtoBindingSource;
            this.dgvFrente.Location = new System.Drawing.Point(301, 77);
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
            this.dgvFrente.Size = new System.Drawing.Size(356, 227);
            this.dgvFrente.TabIndex = 11;
            this.dgvFrente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrente_CellContentClick);
            // 
            // ID_Produto
            // 
            this.ID_Produto.DataPropertyName = "ID_Produto";
            this.ID_Produto.HeaderText = "ID do produto";
            this.ID_Produto.Name = "ID_Produto";
            this.ID_Produto.ReadOnly = true;
            // 
            // Prod_Nome
            // 
            this.Prod_Nome.DataPropertyName = "Prod_Nome";
            this.Prod_Nome.HeaderText = "Nome";
            this.Prod_Nome.Name = "Prod_Nome";
            this.Prod_Nome.ReadOnly = true;
            // 
            // Prod_Valor
            // 
            this.Prod_Valor.DataPropertyName = "Prod_Valor";
            this.Prod_Valor.HeaderText = "Valor";
            this.Prod_Valor.Name = "Prod_Valor";
            this.Prod_Valor.ReadOnly = true;
            // 
            // ID_Lote
            // 
            this.ID_Lote.DataPropertyName = "ID_Lote";
            this.ID_Lote.HeaderText = "ID do lote";
            this.ID_Lote.Name = "ID_Lote";
            this.ID_Lote.ReadOnly = true;
            // 
            // Prod_Qtd
            // 
            this.Prod_Qtd.DataPropertyName = "Prod_Qtd";
            this.Prod_Qtd.HeaderText = "Quantidade";
            this.Prod_Qtd.Name = "Prod_Qtd";
            this.Prod_Qtd.ReadOnly = true;
            // 
            // Prod_Local
            // 
            this.Prod_Local.DataPropertyName = "Prod_Local";
            this.Prod_Local.HeaderText = "Local";
            this.Prod_Local.Name = "Prod_Local";
            this.Prod_Local.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.padokaBDDataSet;
            // 
            // padokaBDDataSet
            // 
            this.padokaBDDataSet.DataSetName = "padokaBDDataSet";
            this.padokaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(569, 35);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(88, 26);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(300, 35);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(263, 26);
            this.txtPesquisa.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnAlterarFundos);
            this.tabPage2.Controls.Add(this.btnExcluirFundos);
            this.tabPage2.Controls.Add(this.txtQuantidadeFundos);
            this.tabPage2.Controls.Add(this.txtIDLFundos);
            this.tabPage2.Controls.Add(this.txtValorFundos);
            this.tabPage2.Controls.Add(this.txtNomeFundos);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtIDPFundos);
            this.tabPage2.Controls.Add(this.dgvFundos);
            this.tabPage2.Controls.Add(this.btnConsultar2);
            this.tabPage2.Controls.Add(this.txtPesquisa2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fundos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 26);
            this.textBox1.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(66, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 42;
            this.label12.Text = "Local";
            // 
            // btnAlterarFundos
            // 
            this.btnAlterarFundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlterarFundos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterarFundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFundos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFundos.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFundos.Location = new System.Drawing.Point(168, 296);
            this.btnAlterarFundos.Name = "btnAlterarFundos";
            this.btnAlterarFundos.Size = new System.Drawing.Size(88, 26);
            this.btnAlterarFundos.TabIndex = 19;
            this.btnAlterarFundos.Text = "Alterar";
            this.btnAlterarFundos.UseVisualStyleBackColor = false;
            // 
            // btnExcluirFundos
            // 
            this.btnExcluirFundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExcluirFundos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirFundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFundos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFundos.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFundos.Location = new System.Drawing.Point(47, 296);
            this.btnExcluirFundos.Name = "btnExcluirFundos";
            this.btnExcluirFundos.Size = new System.Drawing.Size(88, 26);
            this.btnExcluirFundos.TabIndex = 18;
            this.btnExcluirFundos.Text = "Excluir";
            this.btnExcluirFundos.UseVisualStyleBackColor = false;
            this.btnExcluirFundos.Click += new System.EventHandler(this.btnExcluirFundos_Click);
            // 
            // txtQuantidadeFundos
            // 
            this.txtQuantidadeFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeFundos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeFundos.Location = new System.Drawing.Point(121, 204);
            this.txtQuantidadeFundos.Name = "txtQuantidadeFundos";
            this.txtQuantidadeFundos.Size = new System.Drawing.Size(135, 26);
            this.txtQuantidadeFundos.TabIndex = 16;
            // 
            // txtIDLFundos
            // 
            this.txtIDLFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDLFundos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLFundos.Location = new System.Drawing.Point(121, 169);
            this.txtIDLFundos.Name = "txtIDLFundos";
            this.txtIDLFundos.Size = new System.Drawing.Size(135, 26);
            this.txtIDLFundos.TabIndex = 15;
            // 
            // txtValorFundos
            // 
            this.txtValorFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorFundos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFundos.Location = new System.Drawing.Point(121, 134);
            this.txtValorFundos.Name = "txtValorFundos";
            this.txtValorFundos.Size = new System.Drawing.Size(135, 26);
            this.txtValorFundos.TabIndex = 14;
            // 
            // txtNomeFundos
            // 
            this.txtNomeFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFundos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFundos.Location = new System.Drawing.Point(121, 99);
            this.txtNomeFundos.Name = "txtNomeFundos";
            this.txtNomeFundos.Size = new System.Drawing.Size(135, 26);
            this.txtNomeFundos.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(31, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(43, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID do lote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(71, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(66, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID do produto";
            // 
            // txtIDPFundos
            // 
            this.txtIDPFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPFundos.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPFundos.Location = new System.Drawing.Point(121, 63);
            this.txtIDPFundos.Name = "txtIDPFundos";
            this.txtIDPFundos.Size = new System.Drawing.Size(135, 26);
            this.txtIDPFundos.TabIndex = 12;
            // 
            // dgvFundos
            // 
            this.dgvFundos.AllowUserToAddRows = false;
            this.dgvFundos.AllowUserToDeleteRows = false;
            this.dgvFundos.AllowUserToOrderColumns = true;
            this.dgvFundos.AutoGenerateColumns = false;
            this.dgvFundos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundos.BackgroundColor = System.Drawing.Color.White;
            this.dgvFundos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFundos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ProdutoF,
            this.Prod_NomeF,
            this.Prod_ValorF,
            this.ID_LoteF,
            this.Prod_QtdF});
            this.dgvFundos.DataSource = this.produtoBindingSource;
            this.dgvFundos.Location = new System.Drawing.Point(301, 83);
            this.dgvFundos.Name = "dgvFundos";
            this.dgvFundos.ReadOnly = true;
            this.dgvFundos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFundos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFundos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFundos.Size = new System.Drawing.Size(356, 227);
            this.dgvFundos.TabIndex = 22;
            this.dgvFundos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFundos_CellClick);
            // 
            // ID_ProdutoF
            // 
            this.ID_ProdutoF.DataPropertyName = "ID_Produto";
            this.ID_ProdutoF.HeaderText = "ID do produto";
            this.ID_ProdutoF.Name = "ID_ProdutoF";
            this.ID_ProdutoF.ReadOnly = true;
            // 
            // Prod_NomeF
            // 
            this.Prod_NomeF.DataPropertyName = "Prod_Nome";
            this.Prod_NomeF.HeaderText = "Nome";
            this.Prod_NomeF.Name = "Prod_NomeF";
            this.Prod_NomeF.ReadOnly = true;
            // 
            // Prod_ValorF
            // 
            this.Prod_ValorF.DataPropertyName = "Prod_Valor";
            this.Prod_ValorF.HeaderText = "Valor";
            this.Prod_ValorF.Name = "Prod_ValorF";
            this.Prod_ValorF.ReadOnly = true;
            // 
            // ID_LoteF
            // 
            this.ID_LoteF.DataPropertyName = "ID_Lote";
            this.ID_LoteF.HeaderText = "ID do lote";
            this.ID_LoteF.Name = "ID_LoteF";
            this.ID_LoteF.ReadOnly = true;
            // 
            // Prod_QtdF
            // 
            this.Prod_QtdF.DataPropertyName = "Prod_Qtd";
            this.Prod_QtdF.HeaderText = "Quantidade";
            this.Prod_QtdF.Name = "Prod_QtdF";
            this.Prod_QtdF.ReadOnly = true;
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultar2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar2.ForeColor = System.Drawing.Color.White;
            this.btnConsultar2.Location = new System.Drawing.Point(569, 41);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(88, 26);
            this.btnConsultar2.TabIndex = 21;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = false;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click);
            // 
            // txtPesquisa2
            // 
            this.txtPesquisa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa2.Location = new System.Drawing.Point(300, 41);
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.Size = new System.Drawing.Size(263, 26);
            this.txtPesquisa2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestaoEstoque.Properties.Resources.inventario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventário";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQuantidadeFundos;
        private System.Windows.Forms.TextBox txtIDLFundos;
        private System.Windows.Forms.TextBox txtValorFundos;
        private System.Windows.Forms.TextBox txtNomeFundos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDPFundos;
        private System.Windows.Forms.DataGridView dgvFundos;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.TextBox txtPesquisa2;
        private System.Windows.Forms.Button btnAlterarFundos;
        private System.Windows.Forms.Button btnExcluirFundos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtIDLote;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.DataGridView dgvFrente;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ProdutoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_NomeF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_ValorF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LoteF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_QtdF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private padokaBDDataSet padokaBDDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private padokaBDDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
    }
}