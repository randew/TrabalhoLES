using CamadaDeDados.padokaBDDataSetTableAdapters;
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
        private TextBox textBox1;
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
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Valida\x00e7\x00e3o");
                this.textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Comprado com sucesso!", "Compras");
                MessageBox.Show("Pedido sendo processado!\nFavor esperar por atualiza\x00e7\x00f5es sobre a compra", "Compras");
            }
        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            int result = 1;
            if (!int.TryParse(this.textBox1.Text, out result))
            {
                MessageBox.Show("Quantidade s\x00f3 aceita n\x00fameros inteiros");
                this.textBox1.Focus();
            }
        }
    }
}
