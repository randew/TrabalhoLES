using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestaoEstoque
{
    public partial class frmCadProd : Form
    {
        public frmCadProd()
        {
            InitializeComponent();
        }

        private void frmCadProd_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
<<<<<<< Updated upstream

=======
        private void frmCadProd_Load(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CamadaDeNegocios.Produto prod = new CamadaDeNegocios.Produto();
            if(txtLote.Text == null || txtNome.Text == null || txtID.Text == null || txtPreco.Text == null)
            {
                MessageBox.Show("Nenhum dos campos pode ser nulo");
                txtID.Focus();
            }
            else if (!prod.PROinserirID(txtID.Text)) {
                MessageBox.Show("ID invalido");
                txtID.Focus();
            }
            else if (!prod.PROinserirNome(txtNome.Text))
            {
                MessageBox.Show("Nome invalido");
                txtNome.Focus();
            }
            else if (!prod.PROinserirPreco(txtPreco.Text))
            {
                MessageBox.Show("Preço invalido");
                txtPreco.Focus();
            }
            else if (!prod.PROinserirLote(txtLote.Text))
            {
                MessageBox.Show("Lote invalido (O número do lote deve estar entre 1 à 20)");
                txtLote.Focus();
            }
            else if (!prod.PROinserirQtd(txtQtd.Text))
            {
                MessageBox.Show("Quantidade invalido");
                txtQtd.Focus();
            }
<<<<<<< Updated upstream
            else if (!prod.PROinserirLocal(txtLocal.Text.ToUpper()))
=======
            if (produto.PROinjetar(produto.PROid, produto.PROnome, produto.PROvalor, produto.PROlote, produto.PROqtd, produto.PROlocal))
>>>>>>> Stashed changes
            {
                MessageBox.Show("Local invalido (locais disponíveis: FRENTE e FUNDO");
                txtLocal.Focus();
            }
            else 
            {
                if (prod.PROinjetar(prod.PROid, prod.PROnome, prod.PROvalor, prod.PROlote, prod.PROqtd, prod.PROlocal))
                    MessageBox.Show("Produto inserido com sucesso");
                else
                    MessageBox.Show("O produto não pode ser inserido");
            }
            
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPreco.Text = "";
            txtLote.Text = "";
            txtNome.Text = "";
            txtQtd.Text = "";
            txtLocal.Text = "";
            txtID.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
