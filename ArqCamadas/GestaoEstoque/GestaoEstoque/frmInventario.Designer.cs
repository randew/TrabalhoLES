using GestaoEstoque.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoEstoque
{
    partial class frmInventario
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmInventario));
            this.label1 = new Label();
            this.pictureBox1 = new PictureBox();
            this.btnFrente = new Button();
            this.btnFundo = new Button();
            this.panelConteudo = new Panel();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.panelConteudo.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.label1.Location = new Point(0x3e, 0x1a);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x99, 0x21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invent\x00e1rio";
            this.pictureBox1.BackgroundImage = Resources.inventario;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Location = new Point(0x10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(40, 0x27);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.btnFrente.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnFrente.FlatAppearance.BorderColor = Color.White;
            this.btnFrente.FlatStyle = FlatStyle.Flat;
            this.btnFrente.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnFrente.ForeColor = Color.White;
            this.btnFrente.Location = new Point(0x77, 0xb3);
            this.btnFrente.Name = "btnFrente";
            this.btnFrente.Size = new Size(0xec, 0x8a);
            this.btnFrente.TabIndex = 0x49;
            this.btnFrente.Text = "Frente";
            this.btnFrente.UseVisualStyleBackColor = false;
            this.btnFrente.Click += new EventHandler(this.btnFrente_Click);
            this.btnFundo.BackColor = Color.FromArgb(0xc0, 0x40, 0);
            this.btnFundo.FlatAppearance.BorderColor = Color.White;
            this.btnFundo.FlatStyle = FlatStyle.Flat;
            this.btnFundo.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnFundo.ForeColor = Color.White;
            this.btnFundo.Location = new Point(0x17f, 0xb3);
            this.btnFundo.Name = "btnFundo";
            this.btnFundo.Size = new Size(0xec, 0x8a);
            this.btnFundo.TabIndex = 0x4a;
            this.btnFundo.Text = "Fundo";
            this.btnFundo.UseVisualStyleBackColor = false;
            this.btnFundo.Click += new EventHandler(this.btnFundo_Click);
            this.panelConteudo.Controls.Add(this.btnFundo);
            this.panelConteudo.Controls.Add(this.pictureBox1);
            this.panelConteudo.Controls.Add(this.btnFrente);
            this.panelConteudo.Controls.Add(this.label1);
            this.panelConteudo.Dock = DockStyle.Fill;
            this.panelConteudo.Location = new Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new Size(0x2d7, 0x1d9);
            this.panelConteudo.TabIndex = 0x4b;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x2d7, 0x1d9);
            base.Controls.Add(this.panelConteudo);
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmInventario";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Invent\x00e1rio";
            base.Load += new EventHandler(this.frmInventario_Load);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            base.ResumeLayout(false);

        }

        #endregion
    }
}