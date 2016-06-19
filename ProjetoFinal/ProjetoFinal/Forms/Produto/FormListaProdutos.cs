using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Forms.Produto;
using ProjetoFinal.BancoPds;

namespace ProjetoFinal.Forms.Produto
{
    public partial class FormListaProdutos : MetroForm
    {
        FormProdutoCrud formProdutoCrud;

        ContextBancoPds ctx;

        public FormListaProdutos()
        {
            InitializeComponent();
            atualizarBinding();
        }

        private void atualizarBinding()
        {
            pRODUTOBindingSource1.ResetBindings(false);
            ctx = new ContextBancoPds();
            pRODUTOBindingSource1.DataSource = ctx.PRODUTO.ToList();
        }

        private void FormListaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet4.PRODUTO' table. You can move, or remove it, as needed.
            this.pRODUTOTableAdapter.Fill(this.banco_pdsDataSet4.PRODUTO);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formProdutoCrud = new FormProdutoCrud();
            this.Hide();
            formProdutoCrud.ShowDialog();
            atualizarBinding();
            this.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formProdutoCrud = new FormProdutoCrud();
            this.Hide();
            formProdutoCrud.ShowDialog();
            atualizarBinding();
            this.Show();
        }
    }
}
