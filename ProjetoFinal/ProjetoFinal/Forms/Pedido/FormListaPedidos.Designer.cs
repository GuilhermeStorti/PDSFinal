namespace ProjetoFinal.Forms.Pedido
{
    partial class FormListaPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnDeletar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.banco_pdsDataSet9 = new ProjetoFinal.banco_pdsDataSet9();
            this.pEDIDOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pEDIDOTableAdapter = new ProjetoFinal.banco_pdsDataSet9TableAdapters.PEDIDOTableAdapter();
            this.txtFiltrarStatus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnFiltrarStatus = new MetroFramework.Controls.MetroButton();
            this.btnFiltrarCliente = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrarCliente = new MetroFramework.Controls.MetroTextBox();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_forma_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(568, 71);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 35);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(418, 71);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(96, 35);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseSelectable = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(274, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 35);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(134, 71);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 35);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.data_venda,
            this.data_pagamento,
            this.id_forma_pagamento,
            this.valor,
            this.id_status,
            this.id_cliente});
            this.metroGrid1.DataSource = this.pEDIDOBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 166);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(754, 307);
            this.metroGrid1.TabIndex = 10;
            // 
            // banco_pdsDataSet9
            // 
            this.banco_pdsDataSet9.DataSetName = "banco_pdsDataSet9";
            this.banco_pdsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pEDIDOBindingSource1
            // 
            this.pEDIDOBindingSource1.DataMember = "PEDIDO";
            this.pEDIDOBindingSource1.DataSource = this.banco_pdsDataSet9;
            // 
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // txtFiltrarStatus
            // 
            // 
            // 
            // 
            this.txtFiltrarStatus.CustomButton.Image = null;
            this.txtFiltrarStatus.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtFiltrarStatus.CustomButton.Name = "";
            this.txtFiltrarStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltrarStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrarStatus.CustomButton.TabIndex = 1;
            this.txtFiltrarStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrarStatus.CustomButton.UseSelectable = true;
            this.txtFiltrarStatus.CustomButton.Visible = false;
            this.txtFiltrarStatus.Lines = new string[0];
            this.txtFiltrarStatus.Location = new System.Drawing.Point(254, 134);
            this.txtFiltrarStatus.MaxLength = 32767;
            this.txtFiltrarStatus.Name = "txtFiltrarStatus";
            this.txtFiltrarStatus.PasswordChar = '\0';
            this.txtFiltrarStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrarStatus.SelectedText = "";
            this.txtFiltrarStatus.SelectionLength = 0;
            this.txtFiltrarStatus.SelectionStart = 0;
            this.txtFiltrarStatus.Size = new System.Drawing.Size(91, 23);
            this.txtFiltrarStatus.TabIndex = 15;
            this.txtFiltrarStatus.UseSelectable = true;
            this.txtFiltrarStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(197, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Filtrar por Status";
            // 
            // btnFiltrarStatus
            // 
            this.btnFiltrarStatus.Location = new System.Drawing.Point(156, 134);
            this.btnFiltrarStatus.Name = "btnFiltrarStatus";
            this.btnFiltrarStatus.Size = new System.Drawing.Size(91, 23);
            this.btnFiltrarStatus.TabIndex = 19;
            this.btnFiltrarStatus.Text = "Filtrar";
            this.btnFiltrarStatus.UseSelectable = true;
            this.btnFiltrarStatus.Click += new System.EventHandler(this.btnFiltrarStatus_Click);
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.Location = new System.Drawing.Point(447, 134);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(91, 23);
            this.btnFiltrarCliente.TabIndex = 22;
            this.btnFiltrarCliente.Text = "Filtrar";
            this.btnFiltrarCliente.UseSelectable = true;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(488, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Filtrar por Cliente";
            // 
            // txtFiltrarCliente
            // 
            // 
            // 
            // 
            this.txtFiltrarCliente.CustomButton.Image = null;
            this.txtFiltrarCliente.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtFiltrarCliente.CustomButton.Name = "";
            this.txtFiltrarCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltrarCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrarCliente.CustomButton.TabIndex = 1;
            this.txtFiltrarCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrarCliente.CustomButton.UseSelectable = true;
            this.txtFiltrarCliente.CustomButton.Visible = false;
            this.txtFiltrarCliente.Lines = new string[0];
            this.txtFiltrarCliente.Location = new System.Drawing.Point(545, 134);
            this.txtFiltrarCliente.MaxLength = 32767;
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.PasswordChar = '\0';
            this.txtFiltrarCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrarCliente.SelectedText = "";
            this.txtFiltrarCliente.SelectionLength = 0;
            this.txtFiltrarCliente.SelectionStart = 0;
            this.txtFiltrarCliente.Size = new System.Drawing.Size(91, 23);
            this.txtFiltrarCliente.TabIndex = 20;
            this.txtFiltrarCliente.UseSelectable = true;
            this.txtFiltrarCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(ProjetoFinal.Models.Pedido);
            // 
            // id_pedido
            // 
            this.id_pedido.DataPropertyName = "id_pedido";
            this.id_pedido.HeaderText = "Código";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.ReadOnly = true;
            // 
            // data_venda
            // 
            this.data_venda.DataPropertyName = "data_venda";
            this.data_venda.HeaderText = "Data de Venda";
            this.data_venda.Name = "data_venda";
            this.data_venda.ReadOnly = true;
            // 
            // data_pagamento
            // 
            this.data_pagamento.DataPropertyName = "data_pagamento";
            this.data_pagamento.HeaderText = "Data de pagamento";
            this.data_pagamento.Name = "data_pagamento";
            this.data_pagamento.ReadOnly = true;
            // 
            // id_forma_pagamento
            // 
            this.id_forma_pagamento.DataPropertyName = "id_forma_pagamento";
            this.id_forma_pagamento.HeaderText = "Forma de pagamento";
            this.id_forma_pagamento.Name = "id_forma_pagamento";
            this.id_forma_pagamento.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // id_status
            // 
            this.id_status.DataPropertyName = "id_status";
            this.id_status.HeaderText = "Status";
            this.id_status.Name = "id_status";
            this.id_status.ReadOnly = true;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "Cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // FormListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnFiltrarCliente);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.btnFiltrarStatus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtFiltrarStatus);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.metroGrid1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormListaPedidos";
            this.Text = "MinhasVendas - Lista de Pedidos";
            this.Load += new System.EventHandler(this.FormListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnDeletar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private banco_pdsDataSet9 banco_pdsDataSet9;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource1;
        private banco_pdsDataSet9TableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtFiltrarStatus;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnFiltrarStatus;
        private MetroFramework.Controls.MetroButton btnFiltrarCliente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFiltrarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_forma_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
    }
}