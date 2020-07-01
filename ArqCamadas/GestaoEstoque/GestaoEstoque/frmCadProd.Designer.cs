using GestaoEstoque.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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
            this.label1 = new Label();
            this.label3 = new Label();
            this.btnCadastrar = new Button();
            this.label6 = new Label();
            this.txtLote = new TextBox();
            this.label5 = new Label();
            this.txtID = new TextBox();
            this.txtNome = new TextBox();
            this.txtPreco = new TextBox();
            this.pictureBox1 = new PictureBox();
            this.label4 = new Label();
            this.panelConteudo = new Panel();
            this.label7 = new Label();
            this.txtLocal = new TextBox();
            this.label2 = new Label();
            this.txtQtd = new TextBox();
            this.btnLimpar = new Button();
            this.btnVoltar = new Button();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.panelConteudo.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.White;
            this.label1.Font = new Font("Roboto", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label1.Location = new Point(0x5e, 0x95);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x33, 0x13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.White;
            this.label3.Font = new Font("Roboto", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label3.Location = new Point(0x79, 110);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x18, 0x13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            this.btnCadastrar.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = FlatStyle.Flat;
            this.btnCadastrar.Font = new Font("Roboto", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCadastrar.ForeColor = Color.White;
            this.btnCadastrar.Location = new Point(0x1db, 0x160);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new Size(0x52, 0x1d);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new EventHandler(this.btnCadastrar_Click);
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.White;
            this.label6.Font = new Font("Roboto", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label6.Location = new Point(0x69, 0xe3);
            this.label6.Name = "label6";
            this.label6.Size = new Size(40, 0x13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lote";
            this.txtLote.Location = new Point(0xa1, 0xe4);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new Size(0x18e, 20);
            this.txtLote.TabIndex = 4;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.White;
            this.label5.Font = new Font("Roboto", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label5.Location = new Point(0x60, 0xbc);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x31, 0x13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pre\x00e7o";
            this.txtID.Location = new Point(0xa1, 0x6f);
            this.txtID.Name = "txtID";
            this.txtID.Size = new Size(0x18e, 20);
            this.txtID.TabIndex = 1;
            this.txtNome.Location = new Point(0xa1, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(0x18e, 20);
            this.txtNome.TabIndex = 2;
            this.txtPreco.Location = new Point(0xa1, 0xbd);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new Size(0x18e, 20);
            this.txtPreco.TabIndex = 3;
            this.pictureBox1.BackgroundImage = Resources.produtos;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Location = new Point(0x16, 0x1b);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(40, 0x27);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Roboto", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label4.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label4.Location = new Point(0x44, 30);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x119, 0x24);
            this.label4.TabIndex = 0x1d;
            this.label4.Text = "Cadastro de produto";
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
            this.panelConteudo.Dock = DockStyle.Fill;
            this.panelConteudo.Location = new Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new Size(0x2c9, 0x1ca);
            this.panelConteudo.TabIndex = 0x1f;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.White;
            this.label7.Font = new Font("Roboto", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label7.Location = new Point(0x61, 0x131);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x30, 0x13);
            this.label7.TabIndex = 0x23;
            this.label7.Text = "Local";
            this.txtLocal.Location = new Point(0xa1, 0x132);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new Size(0x18e, 20);
            this.txtLocal.TabIndex = 6;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.White;
            this.label2.Font = new Font("Roboto", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label2.Location = new Point(0x36, 0x10a);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x5b, 0x13);
            this.label2.TabIndex = 0x21;
            this.label2.Text = "Quantidade";
            this.txtQtd.Location = new Point(0xa1, 0x10b);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new Size(0x18e, 20);
            this.txtQtd.TabIndex = 5;
            this.btnLimpar.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnLimpar.FlatStyle = FlatStyle.Flat;
            this.btnLimpar.Font = new Font("Roboto", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnLimpar.ForeColor = Color.White;
            this.btnLimpar.Location = new Point(0x18d, 0x160);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new Size(0x48, 0x1d);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new EventHandler(this.btnLimpar_Click);
            this.btnVoltar.BackColor = Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = FlatStyle.Flat;
            this.btnVoltar.Font = new Font("Roboto", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnVoltar.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnVoltar.Location = new Point(0x21b, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new Size(0xa2, 0x1c);
            this.btnVoltar.TabIndex = 0x1f;
            this.btnVoltar.Text = "&Voltar para cadastros";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new EventHandler(this.btnVoltar_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x2c9, 0x1ca);
            base.Controls.Add(this.panelConteudo);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "frmCadProd";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produto";
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            base.ResumeLayout(false);

        }

        #endregion
    }
}