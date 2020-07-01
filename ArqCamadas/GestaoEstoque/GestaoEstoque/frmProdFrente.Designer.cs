using GestaoEstoque.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoEstoque
{
    partial class frmProdFrente
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
            this.lblLocal = new Label();
            this.btnAlterar = new Button();
            this.btnExcluir = new Button();
            this.txtQtd = new TextBox();
            this.txtIDLote = new TextBox();
            this.txtValor = new TextBox();
            this.txtNome = new TextBox();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label11 = new Label();
            this.txtIDProd = new TextBox();
            this.dgvFrente = new DataGridView();
            this.btnConsulta = new Button();
            this.txtPesquisa = new TextBox();
            this.btnVoltar = new Button();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            ((ISupportInitialize)this.dgvFrente).BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label1.Location = new Point(0x40, 0x16);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x110, 0x21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Invent\x00e1rio - Frente";
            this.pictureBox1.BackgroundImage = Resources.inventario;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Location = new Point(0x18, 0x16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(40, 0x27);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.txtLocal.BorderStyle = BorderStyle.FixedSingle;
            this.txtLocal.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtLocal.Location = new Point(0xb9, 0x130);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new Size(0x87, 0x18);
            this.txtLocal.TabIndex = 0x2e;
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblLocal.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.lblLocal.Location = new Point(0x7d, 310);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new Size(0x31, 0x12);
            this.lblLocal.TabIndex = 0x39;
            this.lblLocal.Text = "Local";
            this.btnAlterar.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnAlterar.FlatAppearance.BorderColor = Color.White;
            this.btnAlterar.FlatStyle = FlatStyle.Flat;
            this.btnAlterar.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnAlterar.ForeColor = Color.White;
            this.btnAlterar.Location = new Point(0xe0, 0x16c);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new Size(0x58, 0x1a);
            this.btnAlterar.TabIndex = 0x30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new EventHandler(this.btnAlterar_Click);
            this.btnExcluir.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnExcluir.FlatAppearance.BorderColor = Color.White;
            this.btnExcluir.FlatStyle = FlatStyle.Flat;
            this.btnExcluir.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnExcluir.ForeColor = Color.White;
            this.btnExcluir.Location = new Point(0x67, 0x16c);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new Size(0x58, 0x1a);
            this.btnExcluir.TabIndex = 0x2f;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);
            this.txtQtd.BorderStyle = BorderStyle.FixedSingle;
            this.txtQtd.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtQtd.Location = new Point(0xb9, 0x110);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new Size(0x87, 0x18);
            this.txtQtd.TabIndex = 0x2d;
            this.txtIDLote.BorderStyle = BorderStyle.FixedSingle;
            this.txtIDLote.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtIDLote.Location = new Point(0xb9, 0xed);
            this.txtIDLote.Name = "txtIDLote";
            this.txtIDLote.Size = new Size(0x87, 0x18);
            this.txtIDLote.TabIndex = 0x2c;
            this.txtValor.BorderStyle = BorderStyle.FixedSingle;
            this.txtValor.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtValor.Location = new Point(0xb9, 0xca);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new Size(0x87, 0x18);
            this.txtValor.TabIndex = 0x2b;
            this.txtNome.BorderStyle = BorderStyle.FixedSingle;
            this.txtNome.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNome.Location = new Point(0xb9, 0xa7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(0x87, 0x18);
            this.txtNome.TabIndex = 0x2a;
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label7.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label7.Location = new Point(0x51, 0x115);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x5d, 0x12);
            this.label7.TabIndex = 0x38;
            this.label7.Text = "Quantidade";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label8.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label8.Location = new Point(0x5d, 0xf2);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x51, 0x12);
            this.label8.TabIndex = 0x37;
            this.label8.Text = "ID do lote";
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label9.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label9.Location = new Point(0x79, 0xcf);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x2f, 0x12);
            this.label9.TabIndex = 0x36;
            this.label9.Text = "Valor";
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label10.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label10.Location = new Point(0x74, 0xac);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x35, 0x12);
            this.label10.TabIndex = 0x35;
            this.label10.Text = "Nome";
            this.label11.AutoSize = true;
            this.label11.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label11.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label11.Location = new Point(0x44, 0x89);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x6f, 0x12);
            this.label11.TabIndex = 0x34;
            this.label11.Text = "ID do produto";
            this.txtIDProd.BorderStyle = BorderStyle.FixedSingle;
            this.txtIDProd.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtIDProd.Location = new Point(0xb9, 0x83);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new Size(0x87, 0x18);
            this.txtIDProd.TabIndex = 0x29;
            this.dgvFrente.AllowUserToOrderColumns = true;
            this.dgvFrente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrente.BackgroundColor = Color.White;
            this.dgvFrente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrente.Location = new Point(0x160, 0xab);
            this.dgvFrente.Name = "dgvFrente";
            this.dgvFrente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = Color.White;
            style.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.FromArgb(0xc0, 0x40, 0);
            style.SelectionForeColor = Color.White;
            style.WrapMode = DataGridViewTriState.True;
            this.dgvFrente.RowHeadersDefaultCellStyle = style;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = Color.White;
            style2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = Color.Black;
            style2.NullValue = null;
            style2.Padding = new Padding(2);
            style2.SelectionBackColor = Color.FromArgb(0xc0, 0x40, 0);
            style2.SelectionForeColor = Color.White;
            this.dgvFrente.RowsDefaultCellStyle = style2;
            this.dgvFrente.Size = new Size(0x159, 0xe3);
            this.dgvFrente.TabIndex = 0x33;
            this.dgvFrente.CellContentClick += new DataGridViewCellEventHandler(this.dgvFrente_CellContentClick);
            this.btnConsulta.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnConsulta.FlatAppearance.BorderColor = Color.White;
            this.btnConsulta.FlatStyle = FlatStyle.Flat;
            this.btnConsulta.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnConsulta.ForeColor = Color.White;
            this.btnConsulta.Location = new Point(0x261, 0x81);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new Size(0x58, 0x1a);
            this.btnConsulta.TabIndex = 50;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new EventHandler(this.btnConsulta_Click);
            this.txtPesquisa.BorderStyle = BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPesquisa.Location = new Point(0x15f, 0x81);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new Size(0xfc, 0x18);
            this.txtPesquisa.TabIndex = 0x31;
            this.txtPesquisa.TextChanged += new EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new KeyPressEventHandler(this.txtPesquisa_KeyPress);
            this.btnVoltar.BackColor = Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = FlatStyle.Flat;
            this.btnVoltar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnVoltar.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnVoltar.Location = new Point(0x1e2, 0x16);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new Size(0x110, 0x1c);
            this.btnVoltar.TabIndex = 0x4e;
            this.btnVoltar.Text = "&Voltar para inventario";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new EventHandler(this.btnVoltar_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(800, 450);
            base.Controls.Add(this.btnVoltar);
            base.Controls.Add(this.txtLocal);
            base.Controls.Add(this.lblLocal);
            base.Controls.Add(this.btnAlterar);
            base.Controls.Add(this.btnExcluir);
            base.Controls.Add(this.txtQtd);
            base.Controls.Add(this.txtIDLote);
            base.Controls.Add(this.txtValor);
            base.Controls.Add(this.txtNome);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.label10);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.txtIDProd);
            base.Controls.Add(this.dgvFrente);
            base.Controls.Add(this.btnConsulta);
            base.Controls.Add(this.txtPesquisa);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "frmProdFrente";
            this.Text = "frmProdFrente";
            base.Load += new EventHandler(this.frmProdFrente_Load);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            ((ISupportInitialize)this.dgvFrente).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();

        }

        #endregion
    }
}