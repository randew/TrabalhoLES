namespace GestaoEstoque
{
    partial class frmIncioFunc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mConfigurações = new System.Windows.Forms.Label();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.mCompras = new System.Windows.Forms.Label();
            this.mCadastros = new System.Windows.Forms.Label();
            this.mInventario = new System.Windows.Forms.Label();
            this.mVendas = new System.Windows.Forms.Label();
            this.mInicio = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.Transparent;
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.ForeColor = System.Drawing.Color.White;
            this.btnCad.Location = new System.Drawing.Point(30, 202);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(148, 40);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "C&adastros";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(30, 266);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(148, 40);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "&Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(30, 74);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(148, 40);
            this.btnVendas.TabIndex = 4;
            this.btnVendas.Text = "&Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(30, 138);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(148, 40);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "&Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblData.Location = new System.Drawing.Point(6, 7);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(485, 22);
            this.lblData.TabIndex = 17;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.mConfigurações);
            this.panel1.Controls.Add(this.btnConfiguracoes);
            this.panel1.Controls.Add(this.mCompras);
            this.panel1.Controls.Add(this.mCadastros);
            this.panel1.Controls.Add(this.mInventario);
            this.panel1.Controls.Add(this.mVendas);
            this.panel1.Controls.Add(this.mInicio);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.btnVendas);
            this.panel1.Controls.Add(this.btnCad);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 502);
            this.panel1.TabIndex = 22;
            // 
            // mConfigurações
            // 
            this.mConfigurações.BackColor = System.Drawing.Color.Transparent;
            this.mConfigurações.Image = global::GestaoEstoque.Properties.Resources.linha_menu;
            this.mConfigurações.Location = new System.Drawing.Point(18, 333);
            this.mConfigurações.Name = "mConfigurações";
            this.mConfigurações.Size = new System.Drawing.Size(10, 38);
            this.mConfigurações.TabIndex = 12;
            this.mConfigurações.Visible = false;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Location = new System.Drawing.Point(30, 333);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(148, 40);
            this.btnConfiguracoes.TabIndex = 11;
            this.btnConfiguracoes.Text = "A&juda";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // mCompras
            // 
            this.mCompras.BackColor = System.Drawing.Color.Transparent;
            this.mCompras.Image = global::GestaoEstoque.Properties.Resources.linha_menu;
            this.mCompras.Location = new System.Drawing.Point(18, 266);
            this.mCompras.Name = "mCompras";
            this.mCompras.Size = new System.Drawing.Size(10, 38);
            this.mCompras.TabIndex = 10;
            this.mCompras.Visible = false;
            // 
            // mCadastros
            // 
            this.mCadastros.BackColor = System.Drawing.Color.Transparent;
            this.mCadastros.Image = global::GestaoEstoque.Properties.Resources.linha_menu;
            this.mCadastros.Location = new System.Drawing.Point(18, 202);
            this.mCadastros.Name = "mCadastros";
            this.mCadastros.Size = new System.Drawing.Size(10, 38);
            this.mCadastros.TabIndex = 9;
            this.mCadastros.Visible = false;
            // 
            // mInventario
            // 
            this.mInventario.BackColor = System.Drawing.Color.Transparent;
            this.mInventario.Image = global::GestaoEstoque.Properties.Resources.linha_menu;
            this.mInventario.Location = new System.Drawing.Point(18, 140);
            this.mInventario.Name = "mInventario";
            this.mInventario.Size = new System.Drawing.Size(10, 38);
            this.mInventario.TabIndex = 8;
            this.mInventario.Visible = false;
            // 
            // mVendas
            // 
            this.mVendas.BackColor = System.Drawing.Color.Transparent;
            this.mVendas.Image = global::GestaoEstoque.Properties.Resources.linha_menu;
            this.mVendas.Location = new System.Drawing.Point(18, 76);
            this.mVendas.Name = "mVendas";
            this.mVendas.Size = new System.Drawing.Size(10, 38);
            this.mVendas.TabIndex = 7;
            this.mVendas.Visible = false;
            // 
            // mInicio
            // 
            this.mInicio.BackColor = System.Drawing.Color.Transparent;
            this.mInicio.Image = global::GestaoEstoque.Properties.Resources.linha_menu;
            this.mInicio.Location = new System.Drawing.Point(18, 12);
            this.mInicio.Name = "mInicio";
            this.mInicio.Size = new System.Drawing.Size(10, 38);
            this.mInicio.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(30, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(148, 38);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "&Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.btnRestaurar);
            this.panelBarra.Controls.Add(this.btnMaximizar);
            this.panelBarra.Controls.Add(this.btnMinimizar);
            this.panelBarra.Controls.Add(this.lblData);
            this.panelBarra.Controls.Add(this.btnLogout);
            this.panelBarra.Controls.Add(this.btnSair);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(199, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(744, 38);
            this.panelBarra.TabIndex = 24;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.White;
            this.btnMaximizar.BackgroundImage = global::GestaoEstoque.Properties.Resources.maximizar;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(685, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 28);
            this.btnMaximizar.TabIndex = 26;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.BackgroundImage = global::GestaoEstoque.Properties.Resources.minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(654, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 28);
            this.btnMinimizar.TabIndex = 25;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImage = global::GestaoEstoque.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(623, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(25, 28);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = global::GestaoEstoque.Properties.Resources.close;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(716, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 28);
            this.btnSair.TabIndex = 23;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.White;
            this.btnRestaurar.BackgroundImage = global::GestaoEstoque.Properties.Resources.maximizada;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(685, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 28);
            this.btnRestaurar.TabIndex = 27;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(199, 38);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(744, 464);
            this.panelConteudo.TabIndex = 25;
            // 
            // frmIncioFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 502);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncioFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIncio_FormClosing);
            this.Load += new System.EventHandler(this.frmIncio_Load);
            this.panel1.ResumeLayout(false);
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label mCompras;
        private System.Windows.Forms.Label mCadastros;
        private System.Windows.Forms.Label mInventario;
        private System.Windows.Forms.Label mVendas;
        private System.Windows.Forms.Label mInicio;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label mConfigurações;
        private System.Windows.Forms.Button btnConfiguracoes;
    }
}

