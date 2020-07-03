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
    public partial class frmCadProd : Form
    {
        private Label label1;
        private Label label3;
        private Button btnCadastrar;
        private Label label6;
        private TextBox txtLote;
        private Label label5;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtPreco;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panelConteudo;
        private Button btnVoltar;
        private Button btnLimpar;
        private Label label7;
        private TextBox txtLocal;
        private Label label2;
        private TextBox txtQtd;
        public frmCadProd()
        {
            InitializeComponent();
        }

        private void frmCadProd_Load(object sender, EventArgs e)
        {

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            if (((this.txtLote.Text == null) || ((this.txtNome.Text == null) || (this.txtID.Text == null))) || ReferenceEquals(this.txtPreco.Text, null))
            {
                MessageBox.Show("Nenhum dos campos pode ser nulo");
                this.txtID.Focus();
            }
            else if (!produto.PROinserirID(this.txtID.Text))
            {
                MessageBox.Show("ID invalido");
                this.txtID.Focus();
            }
            else if (!produto.PROinserirNome(this.txtNome.Text))
            {
                MessageBox.Show("Nome invalido");
                this.txtNome.Focus();
            }
            else if (!produto.PROinserirPreco(this.txtPreco.Text))
            {
                MessageBox.Show("Pre\x00e7o invalido");
                this.txtPreco.Focus();
            }
            else if (!produto.PROinserirLote(this.txtLote.Text))
            {
                MessageBox.Show("Lote invalido (O n\x00famero do lote deve estar entre 1 \x00e0 20)");
                this.txtLote.Focus();
            }
            else if (!produto.PROinserirQtd(this.txtQtd.Text))
            {
                MessageBox.Show("Quantidade invalido");
                this.txtQtd.Focus();
            }
            else if (!produto.PROinserirLocal(this.txtLocal.Text.ToUpper()))
            {
                MessageBox.Show("Local invalido (locais dispon\x00edveis: FRENTE e FUNDO");
                this.txtLocal.Focus();
            }
            else if (produto.PROinjetar(produto.PROid, produto.PROnome, produto.PROvalor, produto.PROlote, produto.PROqtd, produto.PROlocal))
            {
                MessageBox.Show("Produto inserido com sucesso");
                this.txtID.Text = "";
                this.txtPreco.Text = "";
                this.txtLote.Text = "";
                this.txtNome.Text = "";
                this.txtQtd.Text = "";
                this.txtLocal.Text = "";
                this.txtID.Focus();
            }
            else
            {
                MessageBox.Show("O produto n\x00e3o pode ser inserido");
            }
<<<<<<< HEAD
            label8.Text = prod.PROnome;
            
=======
>>>>>>> 8b8d8c668f97fac50c8c1b22e211b8a306846388
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txtPreco.Text = "";
            this.txtLote.Text = "";
            this.txtNome.Text = "";
            this.txtQtd.Text = "";
            this.txtLocal.Text = "";
            this.txtID.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
