using GestaoEstoque.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoEstoque
{
    partial class frmProdFund
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
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            this.label1 = new Label();
            this.pictureBox1 = new PictureBox();
            this.txtLocal = new TextBox();
            this.label12 = new Label();
            this.btnAlterarFundos = new Button();
            this.btnExcluirFundos = new Button();
            this.txtQuantidadeFundos = new TextBox();
            this.txtIDLFundos = new TextBox();
            this.txtValorFundos = new TextBox();
            this.txtNomeFundos = new TextBox();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.txtIDPFundos = new TextBox();
            this.dgvFundos = new DataGridView();
            this.btnConsultar2 = new Button();
            this.txtPesquisa2 = new TextBox();
            this.btnVoltar = new Button();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            ((ISupportInitialize)this.dgvFundos).BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label1.Location = new Point(0x3d, 0x16);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x10d, 0x21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Invent\x00e1rio - Fundo";
            this.pictureBox1.BackgroundImage = Resources.inventario;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Location = new Point(0x15, 0x16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(40, 0x27);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.txtLocal.BorderStyle = BorderStyle.FixedSingle;
            this.txtLocal.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtLocal.Location = new Point(0xa1, 0x131);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new Size(0x87, 0x18);
            this.txtLocal.TabIndex = 0x44;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label12.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label12.Location = new Point(0x5c, 0x133);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x31, 0x12);
            this.label12.TabIndex = 0x4c;
            this.label12.Text = "Local";
            this.btnAlterarFundos.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnAlterarFundos.FlatAppearance.BorderColor = Color.White;
            this.btnAlterarFundos.FlatStyle = FlatStyle.Flat;
            this.btnAlterarFundos.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnAlterarFundos.ForeColor = Color.White;
            this.btnAlterarFundos.Location = new Point(0xc2, 360);
            this.btnAlterarFundos.Name = "btnAlterarFundos";
            this.btnAlterarFundos.Size = new Size(0x58, 0x1a);
            this.btnAlterarFundos.TabIndex = 0x48;
            this.btnAlterarFundos.Text = "Alterar";
            this.btnAlterarFundos.UseVisualStyleBackColor = false;
            this.btnAlterarFundos.Click += new EventHandler(this.btnAlterarFundos_Click);
            this.btnExcluirFundos.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnExcluirFundos.FlatAppearance.BorderColor = Color.White;
            this.btnExcluirFundos.FlatStyle = FlatStyle.Flat;
            this.btnExcluirFundos.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnExcluirFundos.ForeColor = Color.White;
            this.btnExcluirFundos.Location = new Point(0x49, 360);
            this.btnExcluirFundos.Name = "btnExcluirFundos";
            this.btnExcluirFundos.Size = new Size(0x58, 0x1a);
            this.btnExcluirFundos.TabIndex = 0x47;
            this.btnExcluirFundos.Text = "Excluir";
            this.btnExcluirFundos.UseVisualStyleBackColor = false;
            this.btnExcluirFundos.Click += new EventHandler(this.btnExcluirFundos_Click);
            this.txtQuantidadeFundos.BorderStyle = BorderStyle.FixedSingle;
            this.txtQuantidadeFundos.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtQuantidadeFundos.Location = new Point(0xa1, 0x111);
            this.txtQuantidadeFundos.Name = "txtQuantidadeFundos";
            this.txtQuantidadeFundos.Size = new Size(0x87, 0x18);
            this.txtQuantidadeFundos.TabIndex = 0x42;
            this.txtIDLFundos.BorderStyle = BorderStyle.FixedSingle;
            this.txtIDLFundos.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtIDLFundos.Location = new Point(0xa1, 0xee);
            this.txtIDLFundos.Name = "txtIDLFundos";
            this.txtIDLFundos.Size = new Size(0x87, 0x18);
            this.txtIDLFundos.TabIndex = 0x41;
            this.txtValorFundos.BorderStyle = BorderStyle.FixedSingle;
            this.txtValorFundos.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtValorFundos.Location = new Point(0xa1, 0xcb);
            this.txtValorFundos.Name = "txtValorFundos";
            this.txtValorFundos.Size = new Size(0x87, 0x18);
            this.txtValorFundos.TabIndex = 0x3f;
            this.txtNomeFundos.BorderStyle = BorderStyle.FixedSingle;
            this.txtNomeFundos.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNomeFundos.Location = new Point(0xa1, 0xa8);
            this.txtNomeFundos.Name = "txtNomeFundos";
            this.txtNomeFundos.Size = new Size(0x87, 0x18);
            this.txtNomeFundos.TabIndex = 0x3e;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label6.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label6.Location = new Point(0x39, 0x112);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x5d, 0x12);
            this.label6.TabIndex = 70;
            this.label6.Text = "Quantidade";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label5.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label5.Location = new Point(0x45, 0xef);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x51, 0x12);
            this.label5.TabIndex = 0x45;
            this.label5.Text = "ID do lote";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label4.Location = new Point(0x61, 0xcc);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x2f, 0x12);
            this.label4.TabIndex = 0x43;
            this.label4.Text = "Valor";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label3.Location = new Point(0x5c, 0xa9);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 0x12);
            this.label3.TabIndex = 0x40;
            this.label3.Text = "Nome";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label2.Location = new Point(0x2c, 0x86);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x6f, 0x12);
            this.label2.TabIndex = 60;
            this.label2.Text = "ID do produto";
            this.txtIDPFundos.BorderStyle = BorderStyle.FixedSingle;
            this.txtIDPFundos.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtIDPFundos.Location = new Point(0xa1, 0x84);
            this.txtIDPFundos.Name = "txtIDPFundos";
            this.txtIDPFundos.Size = new Size(0x87, 0x18);
            this.txtIDPFundos.TabIndex = 0x3d;
            this.dgvFundos.AllowUserToOrderColumns = true;
            this.dgvFundos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundos.BackgroundColor = Color.White;
            this.dgvFundos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFundos.Location = new Point(0x148, 0xac);
            this.dgvFundos.Name = "dgvFundos";
            this.dgvFundos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = Color.White;
            style.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.FromArgb(0xc0, 0x40, 0);
            style.SelectionForeColor = Color.White;
            style.WrapMode = DataGridViewTriState.True;
            this.dgvFundos.RowHeadersDefaultCellStyle = style;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = Color.White;
            style2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = Color.Black;
            style2.NullValue = null;
            style2.Padding = new Padding(2);
            style2.SelectionBackColor = Color.FromArgb(0xc0, 0x40, 0);
            style2.SelectionForeColor = Color.White;
            this.dgvFundos.RowsDefaultCellStyle = style2;
            this.dgvFundos.Size = new Size(390, 0xe3);
            this.dgvFundos.TabIndex = 0x4b;
            this.dgvFundos.CellContentClick += new DataGridViewCellEventHandler(this.dgvFundos_CellContentClick);
            this.btnConsultar2.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnConsultar2.FlatAppearance.BorderColor = Color.White;
            this.btnConsultar2.FlatStyle = FlatStyle.Flat;
            this.btnConsultar2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnConsultar2.ForeColor = Color.White;
            this.btnConsultar2.Location = new Point(0x26a, 130);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new Size(100, 0x1a);
            this.btnConsultar2.TabIndex = 0x4a;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = false;
            this.btnConsultar2.Click += new EventHandler(this.btnConsultar2_Click);
            this.txtPesquisa2.BorderStyle = BorderStyle.FixedSingle;
            this.txtPesquisa2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPesquisa2.Location = new Point(0x147, 130);
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.Size = new Size(0x11d, 0x18);
            this.txtPesquisa2.TabIndex = 0x49;
            this.txtPesquisa2.TextChanged += new EventHandler(this.txtPesquisa2_TextChanged);
            this.txtPesquisa2.KeyPress += new KeyPressEventHandler(this.txtPesquisa2_KeyPress);
            this.btnVoltar.BackColor = Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = FlatStyle.Flat;
            this.btnVoltar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnVoltar.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnVoltar.Location = new Point(0x1db, 0x16);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new Size(0x110, 0x1c);
            this.btnVoltar.TabIndex = 0x4d;
            this.btnVoltar.Text = "&Voltar para inventario";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new EventHandler(this.btnVoltar_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(800, 450);
            base.Controls.Add(this.btnVoltar);
            base.Controls.Add(this.txtLocal);
            base.Controls.Add(this.label12);
            base.Controls.Add(this.btnAlterarFundos);
            base.Controls.Add(this.btnExcluirFundos);
            base.Controls.Add(this.txtQuantidadeFundos);
            base.Controls.Add(this.txtIDLFundos);
            base.Controls.Add(this.txtValorFundos);
            base.Controls.Add(this.txtNomeFundos);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.txtIDPFundos);
            base.Controls.Add(this.dgvFundos);
            base.Controls.Add(this.btnConsultar2);
            base.Controls.Add(this.txtPesquisa2);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "frmProdFund";
            this.Text = "frmProdFund";
            base.Load += new EventHandler(this.frmProdFund_Load);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            ((ISupportInitialize)this.dgvFundos).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();

        }

        #endregion
    }
}