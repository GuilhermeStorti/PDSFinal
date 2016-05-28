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

namespace ProjetoFinal.Forms.Pedido
{
    public partial class FormPedidoCrud : MetroForm
    {
        public FormPedidoCrud()
        {
            InitializeComponent();
        }

        private void FormPedidoCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMaskValor.Text = "";
            comboCliente.Text = "";
            comboFormaPagamento.Text = "";
            comboStatus.Text = "";
            datePagamento.Text = "";
            dateVenda.Text = "";
        }
    }
}
