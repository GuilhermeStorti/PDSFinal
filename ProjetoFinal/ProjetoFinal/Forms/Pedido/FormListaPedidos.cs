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
using ProjetoFinal.BancoPds;

namespace ProjetoFinal.Forms.Pedido
{

    public partial class FormListaPedidos : MetroForm
    {
        FormPedidoCrud formPedidoCrud;

        private ContextBancoPds ctx;

        public FormListaPedidos()
        {
            InitializeComponent();
        }

        private void FormListaPedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet9.PEDIDO' table. You can move, or remove it, as needed.
            this.pEDIDOTableAdapter.Fill(this.banco_pdsDataSet9.PEDIDO);

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
            resetarBinding();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formPedidoCrud = new FormPedidoCrud();
            this.Hide();
            formPedidoCrud.ShowDialog();
            resetarBinding();
            this.Show();
        }

        private void resetarBinding()
        {
            ctx = new ContextBancoPds();
            pEDIDOBindingSource1.ResetBindings(false);
            pEDIDOBindingSource1.DataSource = ctx.PEDIDO.ToList();
        }
        private void filtrarBinding(List<PEDIDO> lista)
        {
            ctx = new ContextBancoPds();
            pEDIDOBindingSource1.ResetBindings(false);
            pEDIDOBindingSource1.DataSource = lista;
        }

        private void btnFiltrarStatus_Click(object sender, EventArgs e)
        {
            ctx = new ContextBancoPds();
            int status = Convert.ToInt32(txtFiltrarStatus.Text);
            List<PEDIDO> lista = ctx.PEDIDO.Where(p => p.id_status == status).ToList();
            filtrarBinding(lista);
        }

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {
            ctx = new ContextBancoPds();
            int cliente = Convert.ToInt32(txtFiltrarCliente.Text);
            List<PEDIDO> lista = ctx.PEDIDO.Where(p => p.id_cliente == cliente).ToList();
            filtrarBinding(lista);
        }
    }
}
