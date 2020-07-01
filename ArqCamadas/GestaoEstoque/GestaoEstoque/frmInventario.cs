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
    public partial class frmInventario : Form
    {
        private Produto consulta = new Produto();
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnFrente;
        private Button btnFundo;
        private Panel panelConteudo;
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form objA = this.panelConteudo.Controls.OfType<MiForm>().FirstOrDefault<MiForm>();
            if (!ReferenceEquals(objA, null))
            {
                objA.BringToFront();
            }
            else
            {
                objA = Activator.CreateInstance<MiForm>();
                objA.TopLevel = false;
                objA.FormBorderStyle = FormBorderStyle.None;
                objA.Dock = DockStyle.Fill;
                this.panelConteudo.Controls.Add(objA);
                this.panelConteudo.Tag = objA;
                objA.Show();
                objA.BringToFront();
            }
        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
        }

        private void btnExcluirFundos_Click(object sender, EventArgs e)
        {
        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            this.AbrirFormulario<frmProdFrente>();
        }

        private void btnFundo_Click(object sender, EventArgs e)
        {
            this.AbrirFormulario<frmProdFund>();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvFundos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
