using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Models;
using ProjetoFinal.Forms;
using ProjetoFinal.Forms.Cliente;
using MetroFramework.Forms;

namespace ProjetoFinal.Forms
{
    public partial class FormPrincipal : MetroForm
    {
        Usuario usuario = new Usuario();

        FormListaClientes formListaClientes;
        FormClienteCrud formClienteCrud;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListaClientes = new FormListaClientes();
            this.Hide();
            formListaClientes.ShowDialog();
            this.Show();
        }

        private void adicionarEditarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formClienteCrud = new FormClienteCrud();
            this.Hide();
            formClienteCrud.ShowDialog();
            this.Show();
        }
    }
}
