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
using ProjetoFinal.Forms.Pedido;

namespace ProjetoFinal.Forms.Pedido
{
    public partial class FormListaPedidos : MetroForm
    {
        FormPedidoCrud formPedidoCrud;

        public FormListaPedidos()
        {
            InitializeComponent();
        }

        private void FormListaPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formPedidoCrud = new FormPedidoCrud();
            this.Hide();
            formPedidoCrud.ShowDialog();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formPedidoCrud = new FormPedidoCrud();
            this.Hide();
            formPedidoCrud.ShowDialog();
            this.Show();
        }
    }
}
