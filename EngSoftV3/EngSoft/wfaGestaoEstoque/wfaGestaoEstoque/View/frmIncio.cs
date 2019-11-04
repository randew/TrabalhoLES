using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaGestaoEstoque.View;

namespace wfaGestaoEstoque
{
    public partial class frmIncio : Form
    {
        public frmIncio()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cad = new frmCadastros();
            cad.Closed += (s, args) => this.Close();
            cad.Show();
        }

        private void frmIncio_Load(object sender, EventArgs e)
        { 
            Color mycolor = Color.FromArgb(100, Color.DarkGray);
            //lblBarra.BackColor = mycolor;
            lblFundoMenu.BackColor = mycolor;
            lblSelecione.BackColor = mycolor;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inventario = new frmInventario();
            inventario.Closed += (s, args) => this.Close();
            inventario.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            var compras = new frmCompras();
            compras.Closed += (s, args) => this.Close();
            compras.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new frmLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string userName = Program.globalString;
            lblData.Text = "Olá, " + userName + " seja bem vindo(a)! Hoje é " + DateTime.Now.Date.ToString("dddd , dd MMM yyyy, ") + "são "
                + DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vendas = new frmVendas();
            vendas.Closed += (s, args) => this.Close();
            vendas.Show();
        }

        private void frmIncio_FormClosing(object sender, FormClosingEventArgs e)
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
