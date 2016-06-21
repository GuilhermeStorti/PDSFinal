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
using ProjetoFinal.BancoPds;

namespace ProjetoFinal.Forms.Pedido
{
    public partial class FormPedidoCrud : MetroForm
    {
        private ContextBancoPds ctx;
        private PEDIDO pedido;

        public FormPedidoCrud()
        {
            InitializeComponent();
        }

        private void FormPedidoCrud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet8.STATUS' table. You can move, or remove it, as needed.
            this.sTATUSTableAdapter.Fill(this.banco_pdsDataSet8.STATUS);
            // TODO: This line of code loads data into the 'banco_pdsDataSet7.FORMA_PAGAMENTO' table. You can move, or remove it, as needed.
            this.fORMA_PAGAMENTOTableAdapter.Fill(this.banco_pdsDataSet7.FORMA_PAGAMENTO);
            // TODO: This line of code loads data into the 'banco_pdsDataSet6.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.banco_pdsDataSet6.CLIENTE);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtValor.Text = "";
            comboCliente.Text = "";
            comboFormaPagamento.Text = "";
            comboStatus.Text = "";
            datePagamento.Text = "";
            dateVenda.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ctx = new ContextBancoPds();
            pedido = new PEDIDO();
            pedido.data_pagamento = datePagamento.Value.Date;
            pedido.data_venda = dateVenda.Value.Date;
            pedido.id_cliente = (long) comboCliente.SelectedValue;
            pedido.id_status = (long) comboCliente.SelectedValue;
            pedido.id_forma_pagamento = (long) comboFormaPagamento.SelectedValue;
            pedido.valor = Convert.ToDouble(txtValor.Text);
            ctx.PEDIDO.Add(pedido);
            ctx.SaveChanges();
            DialogResult dialogResult = MessageBox.Show("Pedido adicionado com sucesso! Deseja voltar a lista?", "Sucesso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                limpar();
            }
        }
    }
}
