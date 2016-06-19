namespace ProjetoFinal.Forms.Produto
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
            this.components = new System.ComponentModel.Container();
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
            this.banco_pdsDataSet2 = new ProjetoFinal.banco_pdsDataSet2();
            this.fABRICANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fABRICANTETableAdapter = new ProjetoFinal.banco_pdsDataSet2TableAdapters.FABRICANTETableAdapter();
            this.banco_pdsDataSet3 = new ProjetoFinal.banco_pdsDataSet3();
            this.tIPOPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPO_PRODUTOTableAdapter = new ProjetoFinal.banco_pdsDataSet3TableAdapters.TIPO_PRODUTOTableAdapter();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fABRICANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOPRODUTOBindingSource)).BeginInit();
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
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(200, 321);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
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
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
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
            this.comboTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tIPOPRODUTOBindingSource, "id_tipo_produto", true));
            this.comboTipo.DataSource = this.tIPOPRODUTOBindingSource;
            this.comboTipo.DisplayMember = "descricao";
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.ItemHeight = 23;
            this.comboTipo.Location = new System.Drawing.Point(200, 240);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(200, 29);
            this.comboTipo.TabIndex = 51;
            this.comboTipo.UseSelectable = true;
            this.comboTipo.ValueMember = "id_tipo_produto";
            // 
            // comboFabricante
            // 
            this.comboFabricante.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fABRICANTEBindingSource, "id_fabricante", true));
            this.comboFabricante.DataSource = this.fABRICANTEBindingSource;
            this.comboFabricante.DisplayMember = "nome";
            this.comboFabricante.FormattingEnabled = true;
            this.comboFabricante.ItemHeight = 23;
            this.comboFabricante.Location = new System.Drawing.Point(200, 341);
            this.comboFabricante.Name = "comboFabricante";
            this.comboFabricante.Size = new System.Drawing.Size(200, 29);
            this.comboFabricante.TabIndex = 52;
            this.comboFabricante.UseSelectable = true;
            this.comboFabricante.ValueMember = "id_fabricante";
            // 
            // banco_pdsDataSet2
            // 
            this.banco_pdsDataSet2.DataSetName = "banco_pdsDataSet2";
            this.banco_pdsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fABRICANTEBindingSource
            // 
            this.fABRICANTEBindingSource.DataMember = "FABRICANTE";
            this.fABRICANTEBindingSource.DataSource = this.banco_pdsDataSet2;
            // 
            // fABRICANTETableAdapter
            // 
            this.fABRICANTETableAdapter.ClearBeforeFill = true;
            // 
            // banco_pdsDataSet3
            // 
            this.banco_pdsDataSet3.DataSetName = "banco_pdsDataSet3";
            this.banco_pdsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOPRODUTOBindingSource
            // 
            this.tIPOPRODUTOBindingSource.DataMember = "TIPO_PRODUTO";
            this.tIPOPRODUTOBindingSource.DataSource = this.banco_pdsDataSet3;
            // 
            // tIPO_PRODUTOTableAdapter
            // 
            this.tIPO_PRODUTOTableAdapter.ClearBeforeFill = true;
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
            this.txtValor.Location = new System.Drawing.Point(200, 186);
            this.txtValor.MaxLength = 50;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(200, 29);
            this.txtValor.TabIndex = 55;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormProdutoCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtValor);
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
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fABRICANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_pdsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOPRODUTOBindingSource)).EndInit();
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
        private banco_pdsDataSet2 banco_pdsDataSet2;
        private System.Windows.Forms.BindingSource fABRICANTEBindingSource;
        private banco_pdsDataSet2TableAdapters.FABRICANTETableAdapter fABRICANTETableAdapter;
        private banco_pdsDataSet3 banco_pdsDataSet3;
        private System.Windows.Forms.BindingSource tIPOPRODUTOBindingSource;
        private banco_pdsDataSet3TableAdapters.TIPO_PRODUTOTableAdapter tIPO_PRODUTOTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtValor;
    }
}