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
        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var inicio = new frmIncio();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void frmCadForn_Load(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(100, Color.Black);
            lblFundo.BackColor = mycolor;
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
        }

        private void frmCadForn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Environment.Exit(0);
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
                else if (!dante.FORinsereCNPJ(mskCNPJ.Text)) {
                    MessageBox.Show("CNPJ invalido!");
                    mskCNPJ.Focus();
                }
                else if (!dante.FORinsereCEP(mskCEP.Text))
                {
                    MessageBox.Show("CEP invalido");
                    mskCEP.Focus();
                }
                else if (!dante.FORinsereNacio(txtNacionalidade.Text)) {
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
                    MessageBox.Show("Novo fornecedor inserido!!");
                }
            }

        }
    }
}
