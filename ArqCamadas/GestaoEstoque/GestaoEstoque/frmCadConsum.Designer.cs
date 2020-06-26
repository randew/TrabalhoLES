namespace GestaoEstoque
{ 
    partial class frmCadConsum
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFrente = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.padokaBDDataSet = new GestaoEstoque.padokaBDDataSet();
            this.consumidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumidorTableAdapter = new GestaoEstoque.padokaBDDataSetTableAdapters.ConsumidorTableAdapter();
            this.ID_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumidorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(226, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(509, 147);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(86, 35);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(226, 155);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(91, 20);
            this.mskCPF.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVoltar.Location = new System.Drawing.Point(544, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(162, 28);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "&Voltar para cadastros";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(412, 147);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 35);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.dgvFrente);
            this.panelConteudo.Controls.Add(this.label7);
            this.panelConteudo.Controls.Add(this.btnConsultar);
            this.panelConteudo.Controls.Add(this.txtPesquisa);
            this.panelConteudo.Controls.Add(this.pictureBox2);
            this.panelConteudo.Controls.Add(this.label1);
            this.panelConteudo.Controls.Add(this.lblNome);
            this.panelConteudo.Controls.Add(this.pictureBox1);
            this.panelConteudo.Controls.Add(this.label3);
            this.panelConteudo.Controls.Add(this.btnVoltar);
            this.panelConteudo.Controls.Add(this.btnLimpar);
            this.panelConteudo.Controls.Add(this.txtNome);
            this.panelConteudo.Controls.Add(this.mskCPF);
            this.panelConteudo.Controls.Add(this.btnCadastrar);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(709, 433);
            this.panelConteudo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(103, 112);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 18);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome completo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestaoEstoque.Properties.Resources.consumidor;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(67, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cadastro de consumidor";
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
            this.ID_CPF,
            this.Cons_Nome});
            this.dgvFrente.DataSource = this.consumidorBindingSource;
            this.dgvFrente.Location = new System.Drawing.Point(43, 256);
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
            this.dgvFrente.Size = new System.Drawing.Size(591, 154);
            this.dgvFrente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(80, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Consulte aqui";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(549, 221);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 25);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(241, 224);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(302, 20);
            this.txtPesquisa.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GestaoEstoque.Properties.Resources.busca;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(43, 219);
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
            // consumidorBindingSource
            // 
            this.consumidorBindingSource.DataMember = "Consumidor";
            this.consumidorBindingSource.DataSource = this.padokaBDDataSet;
            // 
            // consumidorTableAdapter
            // 
            this.consumidorTableAdapter.ClearBeforeFill = true;
            // 
            // ID_CPF
            // 
            this.ID_CPF.DataPropertyName = "ID_CPF";
            this.ID_CPF.HeaderText = "CPF";
            this.ID_CPF.Name = "ID_CPF";
            this.ID_CPF.ReadOnly = true;
            // 
            // Cons_Nome
            // 
            this.Cons_Nome.DataPropertyName = "Cons_Nome";
            this.Cons_Nome.HeaderText = "Nome";
            this.Cons_Nome.Name = "Cons_Nome";
            this.Cons_Nome.ReadOnly = true;
            // 
            // frmCadConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 433);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadConsum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de consumidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadConsum_FormClosing);
            this.Load += new System.EventHandler(this.frmCadConsum_Load);
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padokaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumidorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvFrente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private padokaBDDataSet padokaBDDataSet;
        private System.Windows.Forms.BindingSource consumidorBindingSource;
        private padokaBDDataSetTableAdapters.ConsumidorTableAdapter consumidorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_Nome;
    }
}