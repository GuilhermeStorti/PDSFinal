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

namespace ProjetoFinal.Forms.Produto
{
    public partial class FormListaProdutos : MetroForm
    {
        FormProdutoCrud formProdutoCrud;

        public FormListaProdutos()
        {
            InitializeComponent();
        }

        private void FormListaProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formProdutoCrud = new FormProdutoCrud();
            this.Hide();
            formProdutoCrud.ShowDialog();
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
            this.Show();
        }
    }
}
