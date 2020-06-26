using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeNegocios;

namespace GestaoEstoque
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }
        Produto consulta = new Produto();

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {/*
            // TODO: esta linha de código carrega dados na tabela 'padokaBDDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.padokaBDDataSet.Produto);

            //CARREGANDO APENAS ITENS DO FUNDO NO DGVFUNDO
            CamadaDeDados.Conexao con = new CamadaDeDados.Conexao();

            var select = "SELECT * FROM Produto WHERE Prod_Local='FUNDO'";

            var c = new OleDbConnection("C:\\Users\\rebeca\\Documents\\FATEC\\4ºSEMESTRE\\ENGENHARIA DE SOFTWARE 3\\PROJETO\\aAaAaAAAAAA\\Corno\\banco/padokaBD.mdb");
            var dataAdapter = new OleDbDataAdapter(select, c);

            var commandBuilder = new OleDbCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvFundos.ReadOnly = true;
            dgvFundos.DataSource = ds.Tables[0];

            //CARREGANDO APENAS ITENS DO FUNDO NO DGVFRENTE
            var select1 = "SELECT * FROM Produto WHERE Prod_Local='FRENTE'";

            var c1 = new OleDbConnection("C:\\Users\\rebeca\\Documents\\FATEC\\4ºSEMESTRE\\ENGENHARIA DE SOFTWARE 3\\PROJETO\\aAaAaAAAAAA\\Corno\\banco/padokaBD.mdb");
            var dataAdapter1 = new OleDbDataAdapter(select1, c1);

            var commandBuilder1 = new OleDbCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dgvFrente.ReadOnly = true;
            dgvFrente.DataSource = ds1.Tables[0];

            con.fecharConexao();*/
        }

        private void dgvFundos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFundos.Rows[e.RowIndex];

                txtIDPFundos.Text = row.Cells["ID_produtoF"].Value.ToString();
                txtNomeFundos.Text = row.Cells["Prod_NomeF"].Value.ToString();
                txtValorFundos.Text = row.Cells["Prod_ValorF"].Value.ToString();
                txtQuantidadeFundos.Text = row.Cells["Prod_QtdF"].Value.ToString();
                txtIDLFundos.Text = row.Cells["ID_LoteF"].Value.ToString();
            }
        }

        CamadaDeNegocios.Produto prod = new CamadaDeNegocios.Produto();
        
        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluirFundos_Click(object sender, EventArgs e)
        {
            if (txtIDProd.Text == "")
                MessageBox.Show("Digite o ID!");
            else
            {
                long id = Convert.ToInt32(txtIDProd.Text);
                if (prod.PROexcluir(id))
                {
                    MessageBox.Show("Produto excluido com sucesso");
                    dgvFrente.Refresh();
                }
                else
                    MessageBox.Show("Produto não pode ser excluido");
            }
        }

        private void dgvFrente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFrente.Rows[e.RowIndex];

                txtIDProd.Text = row.Cells["ID_Produto"].Value.ToString();
                txtNome.Text = row.Cells["Prod_Nome"].Value.ToString();
                txtValor.Text = row.Cells["Prod_Valor"].Value.ToString();
                txtQtd.Text = row.Cells["Prod_Qtd"].Value.ToString();
                txtIDLote.Text = row.Cells["ID_Lote"].Value.ToString();
                txtLocal.Text = row.Cells["Prod_Local"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CamadaDeNegocios.Produto prod = new CamadaDeNegocios.Produto();
            if (txtIDLote.Text == null || txtNome.Text == null || txtIDProd.Text == null || txtValor.Text == null || txtQtd == null || txtLocal == null)
            {
                MessageBox.Show("Nenhum dos campos pode ser nulo");
                txtIDProd.Focus();
            }
            else if (!prod.PROinserirID2(txtIDProd.Text))
            {
                MessageBox.Show("ID invalido");
                txtIDProd.Focus();
            }
            else if (!prod.PROinserirNome(txtNome.Text))
            {
                MessageBox.Show("Nome invalido");
                txtNome.Focus();
            }
            else if (!prod.PROinserirPreco(txtValor.Text))
            {
                MessageBox.Show("Preço invalido");
                txtValor.Focus();
            }
            else if (!prod.PROinserirLote(txtIDLote.Text))
            {
                MessageBox.Show("Lote invalido (O número do lote deve estar entre 1 à 20)");
                txtIDLote.Focus();
            }
            else if (!prod.PROinserirQtd(txtQtd.Text))
            {
                MessageBox.Show("Quantidade invalido");
                txtQtd.Focus();
            }
            else if (!prod.PROinserirLocal(txtLocal.Text.ToUpper()))
            {
                MessageBox.Show("Local invalido (locais disponíveis: FRENTE e FUNDO");
                txtLocal.Focus();
            }
            else
            {
                if (prod.PROalterar(prod.PROid, prod.PROnome, prod.PROvalor, prod.PROlote, prod.PROqtd, prod.PROlocal))
                { 
                    MessageBox.Show("Produto alterado com sucesso");
                    dgvFrente.Refresh();
                }
                else
                    MessageBox.Show("O produto não pode ser alterado");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (txtIDProd.Text == "")
                MessageBox.Show("Digite o ID!");
            else
            {
                long id = Convert.ToInt32(txtIDProd.Text);
                if (prod.PROexcluir(id))
                {
                    MessageBox.Show("Produto excluido com sucesso");
                    dgvFrente.Refresh();
                }
                else
                    MessageBox.Show("Produto não pode ser excluido");
            }

        }
    }
}
