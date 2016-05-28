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
using ProjetoFinal.Forms.Produto;
using ProjetoFinal.Forms.Fabricante;
using ProjetoFinal.Forms.Tipo;
using ProjetoFinal.Forms.Pedido;
using MetroFramework.Forms;

namespace ProjetoFinal.Forms
{
    public partial class FormPrincipal : MetroForm
    {
        Usuario usuario = new Usuario();

        FormListaClientes formListaClientes;
        FormListaProdutos formListaProdutos;
        FormListaFabricante formListaFabricante;
        FormListaTipos formListaTipos;
        FormListaPedidos formListaPedidos;

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            formListaClientes = new FormListaClientes();
            this.Hide();
            formListaClientes.ShowDialog();
            this.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            formListaProdutos = new FormListaProdutos();
            this.Hide();
            formListaProdutos.ShowDialog();
            this.Show();
        }

        private void btnFabricantes_Click(object sender, EventArgs e)
        {
            formListaFabricante = new FormListaFabricante();
            this.Hide();
            formListaFabricante.ShowDialog();
            this.Show();
        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            formListaTipos = new FormListaTipos();
            this.Hide();
            formListaTipos.ShowDialog();
            this.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            formListaPedidos = new FormListaPedidos();
            this.Hide();
            formListaPedidos.ShowDialog();
            this.Show();
        }
    }
}
