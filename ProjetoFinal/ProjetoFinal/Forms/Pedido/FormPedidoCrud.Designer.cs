namespace ProjetoFinal.Forms.Pedido
{
    partial class FormPedidoCrud
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateVenda = new MetroFramework.Controls.MetroDateTime();
            this.datePagamento = new MetroFramework.Controls.MetroDateTime();
            this.comboCliente = new MetroFramework.Controls.MetroComboBox();
            this.txtMaskValor = new System.Windows.Forms.MaskedTextBox();
            this.comboFormaPagamento = new MetroFramework.Controls.MetroComboBox();
            this.comboStatus = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(449, 278);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(152, 32);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(449, 233);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 32);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(449, 188);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 32);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(206, 325);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Status";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(206, 276);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(139, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Forma de Pagamento";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(206, 233);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Valor";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(206, 186);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Data de Pagamento";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(206, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Data da Venda";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(206, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Cliente";
            // 
            // dateVenda
            // 
            this.dateVenda.Location = new System.Drawing.Point(206, 153);
            this.dateVenda.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateVenda.Name = "dateVenda";
            this.dateVenda.Size = new System.Drawing.Size(200, 29);
            this.dateVenda.TabIndex = 47;
            // 
            // datePagamento
            // 
            this.datePagamento.Location = new System.Drawing.Point(206, 204);
            this.datePagamento.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePagamento.Name = "datePagamento";
            this.datePagamento.Size = new System.Drawing.Size(200, 29);
            this.datePagamento.TabIndex = 48;
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.ItemHeight = 23;
            this.comboCliente.Location = new System.Drawing.Point(206, 101);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(200, 29);
            this.comboCliente.TabIndex = 49;
            this.comboCliente.UseSelectable = true;
            // 
            // txtMaskValor
            // 
            this.txtMaskValor.BackColor = System.Drawing.Color.White;
            this.txtMaskValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaskValor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaskValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskValor.Location = new System.Drawing.Point(206, 252);
            this.txtMaskValor.Mask = "99990,99";
            this.txtMaskValor.Name = "txtMaskValor";
            this.txtMaskValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaskValor.Size = new System.Drawing.Size(200, 23);
            this.txtMaskValor.TabIndex = 46;
            this.txtMaskValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboFormaPagamento
            // 
            this.comboFormaPagamento.FormattingEnabled = true;
            this.comboFormaPagamento.ItemHeight = 23;
            this.comboFormaPagamento.Location = new System.Drawing.Point(206, 298);
            this.comboFormaPagamento.Name = "comboFormaPagamento";
            this.comboFormaPagamento.Size = new System.Drawing.Size(200, 29);
            this.comboFormaPagamento.TabIndex = 50;
            this.comboFormaPagamento.UseSelectable = true;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.ItemHeight = 23;
            this.comboStatus.Location = new System.Drawing.Point(206, 347);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(200, 29);
            this.comboStatus.TabIndex = 51;
            this.comboStatus.UseSelectable = true;
            // 
            // FormPedidoCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboFormaPagamento);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.datePagamento);
            this.Controls.Add(this.dateVenda);
            this.Controls.Add(this.txtMaskValor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormPedidoCrud";
            this.Text = "MinhasVendas - Pedido";
            this.Load += new System.EventHandler(this.FormPedidoCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dateVenda;
        private MetroFramework.Controls.MetroDateTime datePagamento;
        private MetroFramework.Controls.MetroComboBox comboCliente;
        private System.Windows.Forms.MaskedTextBox txtMaskValor;
        private MetroFramework.Controls.MetroComboBox comboFormaPagamento;
        private MetroFramework.Controls.MetroComboBox comboStatus;
    }
}