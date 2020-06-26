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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comprado com sucesso!");
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'padokaBDDataSet.Compra'. Você pode movê-la ou removê-la conforme necessário.
            this.compraTableAdapter.Fill(this.padokaBDDataSet.Compra);
        }
    }
}
