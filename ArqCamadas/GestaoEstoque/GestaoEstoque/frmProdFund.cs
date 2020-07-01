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
    public partial class frmProdFund : Form
    {
        private string ab = "1";
        private Produto consulta = new Produto();
        private Produto prod = new Produto();
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtLocal;
        private Label label12;
        private Button btnAlterarFundos;
        private Button btnExcluirFundos;
        private TextBox txtQuantidadeFundos;
        private TextBox txtIDLFundos;
        private TextBox txtValorFundos;
        private TextBox txtNomeFundos;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIDPFundos;
        private DataGridView dgvFundos;
        private Button btnConsultar2;
        private TextBox txtPesquisa2;
        private Button btnVoltar;
        public frmProdFund()
        {
            InitializeComponent();
        }

        private void frmProdFund_Load(object sender, EventArgs e)
        {
            this.dgvFundos.DataSource = this.consulta.FrenteFund(this.ab);
            this.dgvFundos.Columns[0].HeaderText = "ID";
            this.dgvFundos.Columns[1].HeaderText = "Nome";
            this.dgvFundos.Columns[2].HeaderText = "Pre\x00e7o";
            this.dgvFundos.Columns[3].HeaderText = "Lote";
            this.dgvFundos.Columns[4].HeaderText = "Quantidade";
            this.dgvFundos.Columns["Prod_Local"].Visible = false;
        }
        private void btnAlterarFundos_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            if (((this.txtIDLFundos.Text == null) || ((this.txtNomeFundos.Text == null) || ((this.txtIDPFundos.Text == null) || ((this.txtValorFundos.Text == null) || (this.txtQuantidadeFundos.Text == null))))) || ReferenceEquals(this.txtLocal.Text, null))
            {
                MessageBox.Show("Nenhum dos campos pode ser nulo");
                this.txtIDPFundos.Focus();
            }
            else if (!produto.PROinserirID2(this.txtIDPFundos.Text))
            {
                MessageBox.Show("ID invalido");
                this.txtIDPFundos.Focus();
            }
            else if (!produto.PROinserirNome(this.txtNomeFundos.Text))
            {
                MessageBox.Show("Nome invalido");
                this.txtNomeFundos.Focus();
            }
            else if (!produto.PROinserirPreco(this.txtValorFundos.Text))
            {
                MessageBox.Show("Pre\x00e7o invalido");
                this.txtValorFundos.Focus();
            }
            else if (!produto.PROinserirLote(this.txtIDLFundos.Text))
            {
                MessageBox.Show("Lote invalido (O n\x00famero do lote deve estar entre 1 \x00e0 20)");
                this.txtIDLFundos.Focus();
            }
            else if (!produto.PROinserirQtd(this.txtQuantidadeFundos.Text))
            {
                MessageBox.Show("Quantidade invalido");
                this.txtQuantidadeFundos.Focus();
            }
            else if (!produto.PROinserirLocal(this.txtLocal.Text.ToUpper()))
            {
                MessageBox.Show("Local invalido (locais dispon\x00edveis: FRENTE e FUNDO");
                this.txtLocal.Focus();
            }
            else if (!produto.PROalterar(produto.PROnome, produto.PROvalor, produto.PROlote, produto.PROqtd, produto.PROlocal, produto.PROid))
            {
                MessageBox.Show("O produto n\x00e3o pode ser alterado");
            }
            else
            {
                MessageBox.Show("Produto alterado com sucesso");
                this.dgvFundos.DataSource = this.consulta.FrenteFund(this.ab);
            }
        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            string text = this.txtPesquisa2.Text;
            this.dgvFundos.DataSource = this.consulta.ConsultaProduta(text);
        }

        private void btnExcluirFundos_Click(object sender, EventArgs e)
        {
            if (this.txtIDPFundos.Text == "")
            {
                MessageBox.Show("Digite o ID!");
            }
            else
            {
                long id = Convert.ToInt32(this.txtIDPFundos.Text);
                if (!this.prod.PROexcluir(id))
                {
                    MessageBox.Show("Produto n\x00e3o pode ser excluido");
                }
                else
                {
                    MessageBox.Show("Produto excluido com sucesso");
                    this.dgvFundos.Refresh();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dgvFundos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFundos.Rows[e.RowIndex];
                this.txtIDPFundos.Text = row.Cells["ID_Produto"].Value.ToString();
                this.txtNomeFundos.Text = row.Cells["Prod_Nome"].Value.ToString();
                this.txtValorFundos.Text = row.Cells["Prod_Valor"].Value.ToString();
                this.txtQuantidadeFundos.Text = row.Cells["Prod_Qtd"].Value.ToString();
                this.txtIDLFundos.Text = row.Cells["ID_Lote"].Value.ToString();
                this.txtLocal.Text = row.Cells["Prod_Local"].Value.ToString();
            }
        }
        private void txtPesquisa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.btnConsultar2.PerformClick();
            }
        }

        private void txtPesquisa2_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPesquisa2.Text == "")
            {
                string inv = "1";
                this.dgvFundos.DataSource = this.consulta.ConsultaProduta(inv);
            }
        }
    }
}
