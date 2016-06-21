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
            this.components = new System.ComponentModel.Container();
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
            this.comboFormaPagamento = new MetroFramework.Controls.MetroComboBox();
            this.comboStatus = new MetroFramework.Controls.MetroComboBox();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.banco_pdsDataSet6 = new ProjetoFinal.banco_pdsDataSet6();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new ProjetoFinal.banco_pdsDataSet6TableAdapters.CLIENTETableAdapter();
            this.banco_pdsDataSet7 = new ProjetoFinal.banco_pdsDataSet7();
            this.fORMAPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORMA_PAGAMENTOTableAdapter = new ProjetoFinal.banco_pdsDataSet7TableAdapters.FORMA_PAGAMENTOTableAdapter();
            this.banco_pdsDataSet8 = new ProjetoFinal.banco_pdsDataSet8();
            this.sTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTATUSTableAdapter = new ProjetoFinal.banco_pdsDataSet8TableAdapters.STATUSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMAPAGAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).BeginInit();
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
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(206, 330);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Status";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(206, 281);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(138, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Forma de Pagamento";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(206, 233);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Valor";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(206, 186);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(126, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Data de Pagamento";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(206, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
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
            this.comboCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "id_cliente", true));
            this.comboCliente.DataSource = this.cLIENTEBindingSource;
            this.comboCliente.DisplayMember = "nome";
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.ItemHeight = 23;
            this.comboCliente.Location = new System.Drawing.Point(206, 101);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(200, 29);
            this.comboCliente.TabIndex = 49;
            this.comboCliente.UseSelectable = true;
            this.comboCliente.ValueMember = "id_cliente";
            // 
            // comboFormaPagamento
            // 
            this.comboFormaPagamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fORMAPAGAMENTOBindingSource, "id_forma_pagamento", true));
            this.comboFormaPagamento.DataSource = this.fORMAPAGAMENTOBindingSource;
            this.comboFormaPagamento.DisplayMember = "descricao";
            this.comboFormaPagamento.FormattingEnabled = true;
            this.comboFormaPagamento.ItemHeight = 23;
            this.comboFormaPagamento.Location = new System.Drawing.Point(206, 303);
            this.comboFormaPagamento.Name = "comboFormaPagamento";
            this.comboFormaPagamento.Size = new System.Drawing.Size(200, 29);
            this.comboFormaPagamento.TabIndex = 50;
            this.comboFormaPagamento.UseSelectable = true;
            this.comboFormaPagamento.ValueMember = "id_forma_pagamento";
            // 
            // comboStatus
            // 
            this.comboStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sTATUSBindingSource, "id_status", true));
            this.comboStatus.DataSource = this.sTATUSBindingSource;
            this.comboStatus.DisplayMember = "descricao";
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.ItemHeight = 23;
            this.comboStatus.Location = new System.Drawing.Point(206, 352);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(200, 29);
            this.comboStatus.TabIndex = 51;
            this.comboStatus.UseSelectable = true;
            this.comboStatus.ValueMember = "id_status";
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(206, 255);
            this.txtValor.MaxLength = 50;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(200, 29);
            this.txtValor.TabIndex = 52;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // banco_pdsDataSet6
            // 
            this.banco_pdsDataSet6.DataSetName = "banco_pdsDataSet6";
            this.banco_pdsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.banco_pdsDataSet6;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // banco_pdsDataSet7
            // 
            this.banco_pdsDataSet7.DataSetName = "banco_pdsDataSet7";
            this.banco_pdsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORMAPAGAMENTOBindingSource
            // 
            this.fORMAPAGAMENTOBindingSource.DataMember = "FORMA_PAGAMENTO";
            this.fORMAPAGAMENTOBindingSource.DataSource = this.banco_pdsDataSet7;
            // 
            // fORMA_PAGAMENTOTableAdapter
            // 
            this.fORMA_PAGAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // banco_pdsDataSet8
            // 
            this.banco_pdsDataSet8.DataSetName = "banco_pdsDataSet8";
            this.banco_pdsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTATUSBindingSource
            // 
            this.sTATUSBindingSource.DataMember = "STATUS";
            this.sTATUSBindingSource.DataSource = this.banco_pdsDataSet8;
            // 
            // sTATUSTableAdapter
            // 
            this.sTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // FormPedidoCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboFormaPagamento);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.datePagamento);
            this.Controls.Add(this.dateVenda);
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
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMAPAGAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox comboFormaPagamento;
        private MetroFramework.Controls.MetroComboBox comboStatus;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private banco_pdsDataSet6 banco_pdsDataSet6;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private banco_pdsDataSet6TableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private banco_pdsDataSet7 banco_pdsDataSet7;
        private System.Windows.Forms.BindingSource fORMAPAGAMENTOBindingSource;
        private banco_pdsDataSet7TableAdapters.FORMA_PAGAMENTOTableAdapter fORMA_PAGAMENTOTableAdapter;
        private banco_pdsDataSet8 banco_pdsDataSet8;
        private System.Windows.Forms.BindingSource sTATUSBindingSource;
        private banco_pdsDataSet8TableAdapters.STATUSTableAdapter sTATUSTableAdapter;
    }
}