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
    public partial class frmProdFrente : Form
    {
        private Produto consulta = new Produto();
        private Produto prod = new Produto();
        private string debiano = "0";
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtLocal;
        private Label lblLocal;
        private Button btnAlterar;
        private Button btnExcluir;
        private TextBox txtQtd;
        private TextBox txtIDLote;
        private TextBox txtValor;
        private TextBox txtNome;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtIDProd;
        private DataGridView dgvFrente;
        private Button btnConsulta;
        private TextBox txtPesquisa;
        private Button btnVoltar;
        public frmProdFrente()
        {
            InitializeComponent();
        }

        private void frmProdFrente_Load(object sender, EventArgs e)
        {
            this.dgvFrente.DataSource = this.consulta.FrenteFund(this.debiano);
            this.dgvFrente.Columns[0].HeaderText = "ID";
            this.dgvFrente.Columns[1].HeaderText = "Nome";
            this.dgvFrente.Columns[2].HeaderText = "Pre\x00e7o";
            this.dgvFrente.Columns[3].HeaderText = "Lote";
            this.dgvFrente.Columns[4].HeaderText = "Quantidade";
            this.dgvFrente.Columns["Prod_Local"].Visible = false;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            if (((this.txtIDLote.Text == null) || ((this.txtNome.Text == null) || ((this.txtIDProd.Text == null) || ((this.txtValor.Text == null) || (this.txtQtd == null))))) || ReferenceEquals(this.txtLocal, null))
            {
                MessageBox.Show("Nenhum dos campos pode ser nulo");
                this.txtIDProd.Focus();
            }
            else if (!produto.PROinserirID2(this.txtIDProd.Text))
            {
                MessageBox.Show("ID invalido");
                this.txtIDProd.Focus();
            }
            else if (!produto.PROinserirNome(this.txtNome.Text))
            {
                MessageBox.Show("Nome invalido");
                this.txtNome.Focus();
            }
            else if (!produto.PROinserirPreco(this.txtValor.Text))
            {
                MessageBox.Show("Pre\x00e7o invalido");
                this.txtValor.Focus();
            }
            else if (!produto.PROinserirLote(this.txtIDLote.Text))
            {
                MessageBox.Show("Lote invalido (O n\x00famero do lote deve estar entre 1 \x00e0 20)");
                this.txtIDLote.Focus();
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
            else if (!produto.PROalterar(produto.PROid, produto.PROnome, produto.PROvalor, produto.PROlote, produto.PROqtd, produto.PROlocal))
            {
                MessageBox.Show("O produto n\x00e3o pode ser alterado");
            }
            else
            {
                MessageBox.Show("Produto alterado com sucesso");
                this.dgvFrente.DataSource = this.consulta.FrenteFund(this.debiano);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string text = this.txtPesquisa.Text;
            this.dgvFrente.DataSource = this.consulta.ConsultaProduta(text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.txtIDProd.Text == "")
            {
                MessageBox.Show("Digite o ID!");
            }
            else
            {
                try
                {
                    long id = Convert.ToInt32(this.txtIDProd.Text);
                    if (!this.prod.PROexcluir(id))
                    {
                        MessageBox.Show("Produto n\x00e3o pode ser excluido");
                    }
                    else
                    {
                        MessageBox.Show("Produto excluido com sucesso");
                        this.dgvFrente.DataSource = this.consulta.FrenteFund(this.debiano);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dgvFrente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvFrente.Rows[e.RowIndex];
                    this.txtIDProd.Text = row.Cells["ID_Produto"].Value.ToString();
                    this.txtNome.Text = row.Cells["Prod_Nome"].Value.ToString();
                    this.txtValor.Text = row.Cells["Prod_Valor"].Value.ToString();
                    this.txtQtd.Text = row.Cells["Prod_Qtd"].Value.ToString();
                    this.txtIDLote.Text = row.Cells["ID_Lote"].Value.ToString();
                    this.txtLocal.Text = row.Cells["Prod_Local"].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.btnConsulta.PerformClick();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPesquisa.Text == "")
            {
                this.dgvFrente.DataSource = this.consulta.FrenteFund(this.debiano);
            }
        }
    }
}
