namespace ProjetoFinal.Forms
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEditarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEditarRemoverToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEditarRemoverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fabricantesToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripMenuItem,
            this.adicionarEditarRemoverToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar Todos";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // adicionarEditarRemoverToolStripMenuItem
            // 
            this.adicionarEditarRemoverToolStripMenuItem.Name = "adicionarEditarRemoverToolStripMenuItem";
            this.adicionarEditarRemoverToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.adicionarEditarRemoverToolStripMenuItem.Text = "Adicionar/Editar/Remover";
            this.adicionarEditarRemoverToolStripMenuItem.Click += new System.EventHandler(this.adicionarEditarRemoverToolStripMenuItem_Click);
            // 
            // fabricantesToolStripMenuItem
            // 
            this.fabricantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem,
            this.adicionarEditarRemoverToolStripMenuItem2});
            this.fabricantesToolStripMenuItem.Name = "fabricantesToolStripMenuItem";
            this.fabricantesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fabricantesToolStripMenuItem.Text = "Fabricantes";
            // 
            // listarTodosToolStripMenuItem
            // 
            this.listarTodosToolStripMenuItem.Name = "listarTodosToolStripMenuItem";
            this.listarTodosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.listarTodosToolStripMenuItem.Text = "Listar Todos";
            // 
            // adicionarEditarRemoverToolStripMenuItem2
            // 
            this.adicionarEditarRemoverToolStripMenuItem2.Name = "adicionarEditarRemoverToolStripMenuItem2";
            this.adicionarEditarRemoverToolStripMenuItem2.Size = new System.Drawing.Size(212, 22);
            this.adicionarEditarRemoverToolStripMenuItem2.Text = "Adicionar/Editar/Remover";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem3,
            this.adicionarEditarRemoverToolStripMenuItem1});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // listarTodosToolStripMenuItem3
            // 
            this.listarTodosToolStripMenuItem3.Name = "listarTodosToolStripMenuItem3";
            this.listarTodosToolStripMenuItem3.Size = new System.Drawing.Size(212, 22);
            this.listarTodosToolStripMenuItem3.Text = "Listar Todos";
            // 
            // adicionarEditarRemoverToolStripMenuItem1
            // 
            this.adicionarEditarRemoverToolStripMenuItem1.Name = "adicionarEditarRemoverToolStripMenuItem1";
            this.adicionarEditarRemoverToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.adicionarEditarRemoverToolStripMenuItem1.Text = "Adicionar/Editar/Remover";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MinhasVendas ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarEditarRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarEditarRemoverToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem adicionarEditarRemoverToolStripMenuItem1;

    }
}