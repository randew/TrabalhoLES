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
                    FCCconsumidor.CONvalidaNome(txtNome.Text);
                    lblSucesso.Visible = true;
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inicio = new frmIncio();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void lblFundo_Click(object sender, EventArgs e)
        {

        }

        private void frmCadConsum_Load(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(180, Color.LightGray);
            lblFundo.BackColor = mycolor;
            lblTitulo.BackColor = mycolor;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSucesso.Visible = false;
            txtNome.Text = "";
            mskCPF.Text = "";
            txtNome.Focus();
        }

        private void frmCadConsum_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Environment.Exit(0);
        }
    }
}
