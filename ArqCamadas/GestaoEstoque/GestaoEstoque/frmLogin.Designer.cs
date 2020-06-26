namespace GestaoEstoque
{ 
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbMostrar = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(284, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(126, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(284, 189);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 18);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(284, 121);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(284, 210);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(297, 26);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(224, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.White;
            this.lblErro.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(251, 331);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(218, 14);
            this.lblErro.TabIndex = 8;
            this.lblErro.Text = "Nome de usuário ou senha incorreto(s)";
            this.lblErro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 378);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestaoEstoque.Properties.Resources.logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbMostrar
            // 
            this.cbMostrar.AutoSize = true;
            this.cbMostrar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrar.Location = new System.Drawing.Point(284, 242);
            this.cbMostrar.Name = "cbMostrar";
            this.cbMostrar.Size = new System.Drawing.Size(99, 17);
            this.cbMostrar.TabIndex = 3;
            this.cbMostrar.Text = "Mostrar senha";
            this.cbMostrar.UseVisualStyleBackColor = true;
            this.cbMostrar.CheckedChanged += new System.EventHandler(this.cbMostrar_CheckedChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(486, 316);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(114, 40);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GestaoEstoque.Properties.Resources.password;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(250, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 26);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GestaoEstoque.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(250, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
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
            this.btnSair.Location = new System.Drawing.Point(575, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 28);
            this.btnSair.TabIndex = 11;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 378);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cbMostrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}