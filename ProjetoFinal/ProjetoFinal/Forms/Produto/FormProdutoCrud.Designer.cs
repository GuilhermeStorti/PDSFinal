﻿namespace ProjetoFinal.Forms.Produto
{
    partial class FormProdutoCrud
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
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.comboTipo = new MetroFramework.Controls.MetroComboBox();
            this.comboFabricante = new MetroFramework.Controls.MetroComboBox();
            this.txtMaskValor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(442, 281);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(152, 32);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(442, 236);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 32);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(442, 191);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 32);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(200, 321);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Fabricante";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(200, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Quantidade";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(200, 218);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Tipo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(200, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Valor";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(200, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(200, 132);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.Size = new System.Drawing.Size(200, 29);
            this.txtDescricao.TabIndex = 24;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantidade
            // 
            // 
            // 
            // 
            this.txtQuantidade.CustomButton.Image = null;
            this.txtQuantidade.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtQuantidade.CustomButton.Name = "";
            this.txtQuantidade.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantidade.CustomButton.TabIndex = 1;
            this.txtQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantidade.CustomButton.UseSelectable = true;
            this.txtQuantidade.CustomButton.Visible = false;
            this.txtQuantidade.Lines = new string[0];
            this.txtQuantidade.Location = new System.Drawing.Point(200, 291);
            this.txtQuantidade.MaxLength = 50;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(200, 29);
            this.txtQuantidade.TabIndex = 50;
            this.txtQuantidade.UseSelectable = true;
            this.txtQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.ItemHeight = 23;
            this.comboTipo.Location = new System.Drawing.Point(200, 240);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(200, 29);
            this.comboTipo.TabIndex = 51;
            this.comboTipo.UseSelectable = true;
            // 
            // comboFabricante
            // 
            this.comboFabricante.FormattingEnabled = true;
            this.comboFabricante.ItemHeight = 23;
            this.comboFabricante.Location = new System.Drawing.Point(200, 341);
            this.comboFabricante.Name = "comboFabricante";
            this.comboFabricante.Size = new System.Drawing.Size(200, 29);
            this.comboFabricante.TabIndex = 52;
            this.comboFabricante.UseSelectable = true;
            // 
            // txtMaskValor
            // 
            this.txtMaskValor.BackColor = System.Drawing.Color.White;
            this.txtMaskValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaskValor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaskValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskValor.Location = new System.Drawing.Point(200, 191);
            this.txtMaskValor.Mask = "9900.00";
            this.txtMaskValor.Name = "txtMaskValor";
            this.txtMaskValor.Size = new System.Drawing.Size(200, 23);
            this.txtMaskValor.TabIndex = 54;
            this.txtMaskValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormProdutoCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtMaskValor);
            this.Controls.Add(this.comboFabricante);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDescricao);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormProdutoCrud";
            this.Text = "MinhasVendas-Cadastro de Produto";
            this.Load += new System.EventHandler(this.FormProdutoCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroTextBox txtQuantidade;
        private MetroFramework.Controls.MetroComboBox comboTipo;
        private MetroFramework.Controls.MetroComboBox comboFabricante;
        private System.Windows.Forms.MaskedTextBox txtMaskValor;
    }
}