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

namespace wfaGestaoEstoque.View
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inicio = new frmIncio();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(100, Color.DarkGray);
            lblFundo.BackColor = mycolor;
            lblMenu.BackColor = mycolor;
        }

        private void frmInventario_FormClosing(object sender, FormClosingEventArgs e)
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
