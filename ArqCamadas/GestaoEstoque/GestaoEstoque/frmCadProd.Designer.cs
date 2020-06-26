namespace GestaoEstoque
{
    partial class frmCadProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(94, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(121, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(475, 352);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(82, 29);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(105, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lote";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(161, 228);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(398, 20);
            this.txtLote.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(96, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Preço";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(161, 111);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(398, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(161, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(398, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(161, 189);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(398, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestaoEstoque.Properties.Resources.produtos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(68, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cadastro de produto";
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.label7);
            this.panelConteudo.Controls.Add(this.txtLocal);
            this.panelConteudo.Controls.Add(this.label2);
            this.panelConteudo.Controls.Add(this.txtQtd);
            this.panelConteudo.Controls.Add(this.btnLimpar);
            this.panelConteudo.Controls.Add(this.btnVoltar);
            this.panelConteudo.Controls.Add(this.btnCadastrar);
            this.panelConteudo.Controls.Add(this.label6);
            this.panelConteudo.Controls.Add(this.label5);
            this.panelConteudo.Controls.Add(this.txtPreco);
            this.panelConteudo.Controls.Add(this.txtLote);
            this.panelConteudo.Controls.Add(this.pictureBox1);
            this.panelConteudo.Controls.Add(this.label1);
            this.panelConteudo.Controls.Add(this.label3);
            this.panelConteudo.Controls.Add(this.txtID);
            this.panelConteudo.Controls.Add(this.label4);
            this.panelConteudo.Controls.Add(this.txtNome);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(713, 458);
            this.panelConteudo.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(97, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(161, 306);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(398, 20);
            this.txtLocal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(54, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(161, 267);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(398, 20);
            this.txtQtd.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(397, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(72, 29);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVoltar.Location = new System.Drawing.Point(539, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(162, 28);
            this.btnVoltar.TabIndex = 31;
            this.btnVoltar.Text = "&Voltar para cadastros";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 458);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadProd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtd;
    }
}