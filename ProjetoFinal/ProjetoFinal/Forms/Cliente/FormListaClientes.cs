using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Forms.Cliente;
using MetroFramework.Forms;
using ProjetoFinal.BancoPds;

namespace ProjetoFinal.Forms
{
    public partial class FormListaClientes : MetroForm
    {
        ContextBancoPds ctx;
        FormClienteCrud formClienteCrud;

        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formClienteCrud = new FormClienteCrud();
            this.Hide();
            formClienteCrud.ShowDialog();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formClienteCrud = new FormClienteCrud();
            this.Hide();
            formClienteCrud.ShowDialog();
            this.Show();
        }

        private void recarregarBinding()
        {
            ctx = new ContextBancoPds();
            cLIENTEBindingSource2.ResetBindings(false);
            cLIENTEBindingSource2.DataSource = ctx.CLIENTE.ToList();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formClienteCrud = new FormClienteCrud();
            formClienteCrud.ShowDialog();
            recarregarBinding();
            this.Show();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formClienteCrud = new FormClienteCrud();
            formClienteCrud.ShowDialog();
            recarregarBinding();
            this.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            recarregarBinding();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet5.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.banco_pdsDataSet5.CLIENTE);

        }
    }
}
