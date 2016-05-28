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

namespace ProjetoFinal.Forms
{
    public partial class FormListaClientes : MetroForm
    {

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

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formClienteCrud = new FormClienteCrud();
            formClienteCrud.ShowDialog();
            this.Show();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formClienteCrud = new FormClienteCrud();
            formClienteCrud.ShowDialog();
            this.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
