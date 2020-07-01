using CamadaDeDados.padokaBDDataSetTableAdapters;
using GestaoEstoque.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoEstoque
{
    partial class frmCompras
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
            this.components = new Container();
            this.btnComprar = new Button();
            this.label6 = new Label();
            this.pictureBox2 = new PictureBox();
            this.label10 = new Label();
            this.label11 = new Label();
            this.cbProduto = new ComboBox();
            this.cbFornecedor = new ComboBox();
            this.padokaBDDataSet = new GestaoEstoque.padokaBDDataSet();
            this.compraTableAdapter = new CompraTableAdapter();
            this.produtoBindingSource = new BindingSource(this.components);
            this.produtoTableAdapter = new ProdutoTableAdapter();
            this.fornecedorBindingSource = new BindingSource(this.components);
            this.fornecedorTableAdapter = new FornecedorTableAdapter();
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            ((ISupportInitialize)this.pictureBox2).BeginInit();
            this.padokaBDDataSet.BeginInit();
            ((ISupportInitialize)this.produtoBindingSource).BeginInit();
            ((ISupportInitialize)this.fornecedorBindingSource).BeginInit();
            base.SuspendLayout();
            this.btnComprar.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnComprar.FlatStyle = FlatStyle.Flat;
            this.btnComprar.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnComprar.ForeColor = Color.White;
            this.btnComprar.Location = new Point(0x192, 310);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new Size(110, 0x1f);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new EventHandler(this.btnComprar_Click);
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label6.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label6.Location = new Point(0x43, 0x18);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x8d, 0x21);
            this.label6.TabIndex = 0x23;
            this.label6.Text = "Compras";
            this.pictureBox2.BackgroundImage = Resources.compras;
            this.pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox2.Location = new Point(0x15, 0x15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(40, 0x27);
            this.pictureBox2.TabIndex = 0x24;
            this.pictureBox2.TabStop = false;
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label10.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label10.Location = new Point(0x87, 0xe9);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x5f, 0x12);
            this.label10.TabIndex = 0x27;
            this.label10.Text = "Fornecedor";
            this.label11.AutoSize = true;
            this.label11.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label11.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label11.Location = new Point(0xa2, 0xc5);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x44, 0x12);
            this.label11.TabIndex = 0x25;
            this.label11.Text = "Produto";
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new Point(0xec, 0xc5);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new Size(0x114, 0x15);
            this.cbProduto.TabIndex = 40;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new Point(0xec, 0xea);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new Size(0x114, 0x15);
            this.cbFornecedor.TabIndex = 0x29;
            this.padokaBDDataSet.DataSetName = "padokaBDDataSet";
            this.padokaBDDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.compraTableAdapter.ClearBeforeFill = true;
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.padokaBDDataSet;
            this.produtoTableAdapter.ClearBeforeFill = true;
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.padokaBDDataSet;
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label1.Location = new Point(0x87, 0x114);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x5d, 0x12);
            this.label1.TabIndex = 0x2a;
            this.label1.Text = "Quantidade";
            this.textBox1.Location = new Point(0xec, 0x114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x114, 20);
            this.textBox1.TabIndex = 0x2b;
            this.textBox1.Validated += new EventHandler(this.textBox1_Validated);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x2ca, 0x1cb);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.cbFornecedor);
            base.Controls.Add(this.cbProduto);
            base.Controls.Add(this.label10);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.btnComprar);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "frmCompras";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Compras";
            base.Load += new EventHandler(this.frmCompras_Load);
            ((ISupportInitialize)this.pictureBox2).EndInit();
            this.padokaBDDataSet.EndInit();
            ((ISupportInitialize)this.produtoBindingSource).EndInit();
            ((ISupportInitialize)this.fornecedorBindingSource).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();

        }

        #endregion
    }
}