using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeNegocios;

namespace GestaoEstoque
{
    public partial class frmCadConsum : Form
    {
        public frmCadConsum()
        {
            InitializeComponent();
        }
        CamadaDeNegocios.Consumidor FCCconsumidor = new CamadaDeNegocios.Consumidor(); //FCC = frmCadConsum

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!FCCconsumidor.CONinsereNome(txtNome.Text)) //validação do campo txtNome
            {
                MessageBox.Show("Nome inválido!");
                txtNome.Focus();
            }
            else
            {
                if (!FCCconsumidor.CONinsereCPF(mskCPF.Text)) //validação do campo mskCPF
                {
                    MessageBox.Show("CPF inválido!");
                    mskCPF.Focus();
                }
                else //caso todos os campos estejam preenchidos corretamente
                {
                    string name, CPF;
                    name = txtNome.Text;
                    CPF = mskCPF.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", ""); ;

                    Consumidor NovoUsuario = new Consumidor();
                    if (NovoUsuario.CONcadastraConsum(name, CPF))
                    {
                        MessageBox.Show("Cadastro realizado!");
                        txtNome.Text = "";
                        mskCPF.Text = "";
                        txtNome.Focus();
                    }
                    else
                        MessageBox.Show("Erro ao cadastrar!");
                    //FCCconsumidor.CONvalidaNome(txtNome.Text);
                    //lblSucesso.Visible = true;
                }
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e) //verificação letra por letra do campo nome
        {
            if (FCCconsumidor.CONvalidaLetraNome(e.KeyChar) == 0)
            {
                e.KeyChar = (Char)0;
            }
        }


        private void frmCadConsum_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padokaBDDataSet.Consumidor'. Você pode movê-la ou removê-la conforme necessário.
            this.consumidorTableAdapter.Fill(this.padokaBDDataSet.Consumidor);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mskCPF.Text = "";
            txtNome.Focus();
        }

        private void frmCadConsum_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
