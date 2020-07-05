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
    public partial class frmCadastrosFunc : Form
    {
        public frmCadastrosFunc()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnConsumidores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCadConsum>();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCadForn>();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCadProd>();
        }
    }
}
