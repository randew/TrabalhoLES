using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDeNegocios;
using System.Windows.Forms;

namespace GestaoEstoque
{
    public partial class frmCadForn : Form
    {
        public frmCadForn()
        {
            InitializeComponent();
            // Fornecedor fake = new Fornecedor();
             
        }
        CamadaDeNegocios.Fornecedor dante = new CamadaDeNegocios.Fornecedor();

        private void frmCadForn_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padokaBDDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.padokaBDDataSet.Fornecedor);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mskCNPJ.Text = "";
            txtNacionalidade.Text = "";
            mskCEP.Text = "";
            txtRua.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtNome.Focus();
        }
        private void LimparTela()
        {
            txtNome.Text = "";
            mskCNPJ.Text = "";
            txtNacionalidade.Text = "";
            mskCEP.Text = "";
            txtRua.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtNome.Focus();
        }

        private void frmCadForn_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || mskCNPJ.Text == "" || txtNacionalidade.Text == "" ||
                txtRua.Text == "" || txtNumero.Text == "" || txtLogradouro.Text == "")
            {
                MessageBox.Show("Há campos importantes vazios!");
                txtNome.Focus();
            }
            else
            {
                if (!dante.FORinsereNome(txtNome.Text)) {
                    MessageBox.Show("Nome invalido!");
                    txtNome.Focus();
                }
                else if (!dante.FORvalidaCNPJ(mskCNPJ.Text)) {
                    MessageBox.Show("CNPJ invalido!");
                    mskCNPJ.Focus();
                }
                else if (!dante.FORinsereCEP(mskCEP.Text))
                {
                    MessageBox.Show("CEP invalido");
                    mskCEP.Focus();
                }
                else if (!dante.FORvalidaNacio(txtNacionalidade.Text)) {
                    MessageBox.Show("Nacionalidade invalido!");
                    txtNacionalidade.Focus();
                }
                else if (!dante.FORinsereRua(txtRua.Text)) {
                    MessageBox.Show("Rua invalido!");
                    txtRua.Focus();
                }
                else if (!dante.FORinsereNum(txtNumero.Text)) {
                    MessageBox.Show("Numero invalido!");
                    txtNumero.Focus();
                }
                else if (!dante.FORinsereLog(txtLogradouro.Text)) {
                    MessageBox.Show("Logradouro invalido!");
                    txtLogradouro.Focus();
                }
                else
                {
                    string name, cnpj, nac, cep, rua, log, cpl;
                    int num;
                    name = txtNome.Text;
                    cnpj = mskCNPJ.Text.Replace(".","").Replace("-", "").Replace(",", "").Replace("/", "");
                    nac = txtNacionalidade.Text;
                    cep = mskCEP.Text;
                    rua = txtRua.Text;
                    log = txtLogradouro.Text;
                    num = int.Parse(txtNumero.Text);
                    cpl = txtComplemento.Text;

                    Fornecedor NovoUsuario = new Fornecedor();
                    if (NovoUsuario.FORcadastraForn(name, cnpj, nac, cep, rua, log, num, cpl))
                    {
                        MessageBox.Show("Cadastro realizado!");
                        LimparTela();
                    }
                    else
                        MessageBox.Show("Erro ao cadastrar!");
                }
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string text = this.txtPesquisa.Text;
            this.dgvFrente.DataSource = this.dante.FORconsultaForno(text);
        }
    }
}
