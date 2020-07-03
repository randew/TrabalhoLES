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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(100, Color.DarkGray);
        }

        private void lblFundo_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario1, senha;

            usuario1 = txtNome.Text;
            senha = txtSenha.Text;
            Login usuario = new Login();

            Login userLogado = new Login();
            userLogado = usuario.Autentica(usuario1, senha);

            if (userLogado != null)
            {
                if (userLogado.nivel == "0")
                {
                    Program.globalString = txtNome.Text;
                    this.Hide();
                    frmIncio func = new frmIncio();
                    func.Show();
                }
                else
                {
                    Program.globalString = txtNome.Text;
                    this.Hide();
                    frmIncioFunc func = new frmIncioFunc();
                    func.Show();
                }
            }
            else
            {
                lblErro.Visible = true;
                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();
            }
            /*
            if (txtNome.Text == "admin" && txtSenha.Text == "admin")
            {
                Program.globalString = txtNome.Text;
                this.Hide();
                var inicio = new frmIncio();
                inicio.Closed += (s, args) => this.Close();
                inicio.Show();
            }
            else
            {
                lblErro.Visible = true;
                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();
            }*/
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                btnEntrar.PerformClick();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
           // if (cbMostrar.Checked == true)
                //txtSenha.PasswordChar = '\0';
           // else
               // txtSenha.PasswordChar = '*';
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                btnEntrar.PerformClick();
        }

        private void imgMostra_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            imgMostra.Visible = false;
            imgNao.Visible = true;
        }

        private void imgNao_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            imgNao.Visible = false;
            imgMostra.Visible = true;
        }
    }
}

