using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEstoque
{
    public partial class frmIncioFunc : Form
    {
        public frmIncioFunc()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            mInicio.Visible = false;
            //mVendas.Visible = false;
            mInventario.Visible = false;
            mCadastros.Visible = true;
            mCompras.Visible = false;
            mConfigurações.Visible = false;
            AbrirFormulario<frmCadastrosFunc>();
        }

        private void frmIncio_Load(object sender, EventArgs e)
        {
            AbrirFormulario<frmSobre>();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            mInicio.Visible = false;
            //mVendas.Visible = false;
            mInventario.Visible = true;
            mCadastros.Visible = false;
            mCompras.Visible = false;
            mConfigurações.Visible = false;
            AbrirFormulario<frmInventario>();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            mInicio.Visible = false;
            //mVendas.Visible = false;
            mInventario.Visible = false;
            mCadastros.Visible = false;
            mCompras.Visible = true;
            mConfigurações.Visible = false;
            AbrirFormulario<frmCompras>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string userName = Program.globalString;
            lblData.Text = "Olá, " + userName + ", seja bem vindo(a)! Hoje é " + DateTime.Now.Date.ToString("dddd, dd MMM yyyy, ") + "são "
                + DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            mInicio.Visible = false;
            //mVendas.Visible = true;
            mInventario.Visible = false;
            mCadastros.Visible = false;
            mCompras.Visible = false;
            mConfigurações.Visible = false;
            AbrirFormulario<frmVendas>();

        }

        private void frmIncio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            mInicio.Visible = true;
            //mVendas.Visible = false;
            mInventario.Visible = false;
            mCadastros.Visible = false;
            mCompras.Visible = false;
            mConfigurações.Visible = false;
            AbrirFormulario<frmSobre>();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("index.html");
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

    }
}
