using GestaoEstoque.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoEstoque
{
    partial class frmProdFund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAlterarFundos = new System.Windows.Forms.Button();
            this.btnExcluirFundos = new System.Windows.Forms.Button();
            this.txtQuantidadeFundos = new System.Windows.Forms.TextBox();
            this.txtIDLFundos = new System.Windows.Forms.TextBox();
            this.txtValorFundos = new System.Windows.Forms.TextBox();
            this.txtNomeFundos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPFundos = new System.Windows.Forms.TextBox();
            this.dgvFundos = new System.Windows.Forms.DataGridView();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.txtPesquisa2 = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inventário - Fundo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestaoEstoque.Properties.Resources.inventario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtLocal
            // 
            this.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(215, 375);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(179, 29);
            this.txtLocal.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(123, 378);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 24);
            this.label12.TabIndex = 76;
            this.label12.Text = "Local";
            // 
            // btnAlterarFundos
            // 
            this.btnAlterarFundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlterarFundos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterarFundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFundos.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFundos.Location = new System.Drawing.Point(259, 443);
            this.btnAlterarFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterarFundos.Name = "btnAlterarFundos";
            this.btnAlterarFundos.Size = new System.Drawing.Size(117, 32);
            this.btnAlterarFundos.TabIndex = 72;
            this.btnAlterarFundos.Text = "Alterar";
            this.btnAlterarFundos.UseVisualStyleBackColor = false;
            this.btnAlterarFundos.Click += new System.EventHandler(this.btnAlterarFundos_Click);
            // 
            // btnExcluirFundos
            // 
            this.btnExcluirFundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExcluirFundos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirFundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFundos.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFundos.Location = new System.Drawing.Point(97, 443);
            this.btnExcluirFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirFundos.Name = "btnExcluirFundos";
            this.btnExcluirFundos.Size = new System.Drawing.Size(117, 32);
            this.btnExcluirFundos.TabIndex = 71;
            this.btnExcluirFundos.Text = "Excluir";
            this.btnExcluirFundos.UseVisualStyleBackColor = false;
            this.btnExcluirFundos.Click += new System.EventHandler(this.btnExcluirFundos_Click);
            // 
            // txtQuantidadeFundos
            // 
            this.txtQuantidadeFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeFundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeFundos.Location = new System.Drawing.Point(215, 336);
            this.txtQuantidadeFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidadeFundos.Name = "txtQuantidadeFundos";
            this.txtQuantidadeFundos.Size = new System.Drawing.Size(179, 29);
            this.txtQuantidadeFundos.TabIndex = 66;
            // 
            // txtIDLFundos
            // 
            this.txtIDLFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDLFundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLFundos.Location = new System.Drawing.Point(215, 293);
            this.txtIDLFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDLFundos.Name = "txtIDLFundos";
            this.txtIDLFundos.Size = new System.Drawing.Size(179, 29);
            this.txtIDLFundos.TabIndex = 65;
            // 
            // txtValorFundos
            // 
            this.txtValorFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorFundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFundos.Location = new System.Drawing.Point(215, 250);
            this.txtValorFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorFundos.Name = "txtValorFundos";
            this.txtValorFundos.Size = new System.Drawing.Size(179, 29);
            this.txtValorFundos.TabIndex = 63;
            // 
            // txtNomeFundos
            // 
            this.txtNomeFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFundos.Location = new System.Drawing.Point(215, 207);
            this.txtNomeFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeFundos.Name = "txtNomeFundos";
            this.txtNomeFundos.Size = new System.Drawing.Size(179, 29);
            this.txtNomeFundos.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(76, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(92, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "ID do lote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(129, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(123, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(59, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "ID do produto";
            // 
            // txtIDPFundos
            // 
            this.txtIDPFundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPFundos.Enabled = false;
            this.txtIDPFundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPFundos.Location = new System.Drawing.Point(215, 162);
            this.txtIDPFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDPFundos.Name = "txtIDPFundos";
            this.txtIDPFundos.Size = new System.Drawing.Size(179, 29);
            this.txtIDPFundos.TabIndex = 61;
            // 
            // dgvFundos
            // 
            this.dgvFundos.AllowUserToAddRows = false;
            this.dgvFundos.AllowUserToDeleteRows = false;
            this.dgvFundos.AllowUserToOrderColumns = true;
            this.dgvFundos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundos.BackgroundColor = System.Drawing.Color.White;
            this.dgvFundos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFundos.Location = new System.Drawing.Point(437, 212);
            this.dgvFundos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFundos.Name = "dgvFundos";
            this.dgvFundos.ReadOnly = true;
            this.dgvFundos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFundos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFundos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFundos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFundos.Size = new System.Drawing.Size(520, 279);
            this.dgvFundos.TabIndex = 75;
            this.dgvFundos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFundos_CellContentClick);
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultar2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar2.ForeColor = System.Drawing.Color.White;
            this.btnConsultar2.Location = new System.Drawing.Point(824, 160);
            this.btnConsultar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(133, 32);
            this.btnConsultar2.TabIndex = 74;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = false;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click);
            // 
            // txtPesquisa2
            // 
            this.txtPesquisa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa2.Location = new System.Drawing.Point(436, 160);
            this.txtPesquisa2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.Size = new System.Drawing.Size(379, 29);
            this.txtPesquisa2.TabIndex = 73;
            this.txtPesquisa2.TextChanged += new System.EventHandler(this.txtPesquisa2_TextChanged);
            this.txtPesquisa2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa2_KeyPress);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVoltar.Location = new System.Drawing.Point(633, 27);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(363, 34);
            this.btnVoltar.TabIndex = 77;
            this.btnVoltar.Text = "&Voltar para inventario";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmProdFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAlterarFundos);
            this.Controls.Add(this.btnExcluirFundos);
            this.Controls.Add(this.txtQuantidadeFundos);
            this.Controls.Add(this.txtIDLFundos);
            this.Controls.Add(this.txtValorFundos);
            this.Controls.Add(this.txtNomeFundos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDPFundos);
            this.Controls.Add(this.dgvFundos);
            this.Controls.Add(this.btnConsultar2);
            this.Controls.Add(this.txtPesquisa2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProdFund";
            this.Text = "frmProdFund";
            this.Load += new System.EventHandler(this.frmProdFund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}