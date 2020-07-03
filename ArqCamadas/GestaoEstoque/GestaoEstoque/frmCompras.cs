﻿using CamadaDeDados.padokaBDDataSetTableAdapters;
using CamadaDeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEstoque
{
    public partial class frmCompras : Form
    {
        private Produto consulta = new Produto();
        private Fornecedor cons = new Fornecedor();
        private Button btnComprar;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label10;
        private Label label11;
        private ComboBox cbProduto;
        private ComboBox cbFornecedor;
        private GestaoEstoque.padokaBDDataSet padokaBDDataSet;
        private CompraTableAdapter compraTableAdapter;
        private BindingSource produtoBindingSource;
        private ProdutoTableAdapter produtoTableAdapter;
        private BindingSource fornecedorBindingSource;
        private FornecedorTableAdapter fornecedorTableAdapter;
        private Label label1;
        private TextBox txtQtd;
        private Compra compra = new Compra();
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            this.cbProduto.DisplayMember = "Prod_Nome";
            this.cbProduto.DataSource = this.consulta.ConsultaProduta("0");
            this.cbProduto.ValueMember = "ID_Produto";
            this.cbFornecedor.DataSource = this.cons.ConsultaFornos("0");
            this.cbFornecedor.DisplayMember = "Forn_nome";
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (this.txtQtd.Text == "")
            {
                MessageBox.Show("Insira uma quantidade válida!", "Validação");
                this.txtQtd.Focus();
            }
            else if(this.mskFabricacao.Text == String.Empty || !compra.COMvalidaData(int.Parse(this.mskFabricacao.Text.Substring(0, 2)), int.Parse(this.mskFabricacao.Text.Substring(3, 2)), int.Parse(this.mskFabricacao.Text.Substring(6, 4))))
            {
                MessageBox.Show("Insira uma data válida!");
                this.mskFabricacao.Focus();
            }
            else if(this.mskValidade.Text == String.Empty || !compra.COMvalidaData(int.Parse(this.mskValidade.Text.Substring(0,2)), int.Parse(this.mskValidade.Text.Substring(3, 2)), int.Parse(this.mskValidade.Text.Substring(6, 4))))
            {
                MessageBox.Show("Insira uma data váilda!");
                this.mskValidade.Focus();
            }
            else
            {
                DateTime dataFab = new DateTime();
                MessageBox.Show("Comprado com sucesso!", "Compras");
                MessageBox.Show("Pedido sendo processado!\nFavor esperar por atualizaçõees sobre a compra", "Compras");
            }
        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            int result = 1;
            if (!int.TryParse(this.txtQtd.Text, out result))
            {
                MessageBox.Show("Quantidade s\x00f3 aceita n\x00fameros inteiros");
                this.txtQtd.Focus();
            }
        }
    }
}
