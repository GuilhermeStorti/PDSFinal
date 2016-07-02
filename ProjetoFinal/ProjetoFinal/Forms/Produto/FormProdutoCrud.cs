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

namespace ProjetoFinal.Forms.Produto
{
    public partial class FormProdutoCrud : MetroForm
    {
        private ContextBancoPds ctx;
        private PRODUTO produto;

        public FormProdutoCrud()
        {
            InitializeComponent();
        }

        private void FormProdutoCrud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet3.TIPO_PRODUTO' table. You can move, or remove it, as needed.
            this.tIPO_PRODUTOTableAdapter.Fill(this.banco_pdsDataSet3.TIPO_PRODUTO);
            // TODO: This line of code loads data into the 'banco_pdsDataSet2.FABRICANTE' table. You can move, or remove it, as needed.
            this.fABRICANTETableAdapter.Fill(this.banco_pdsDataSet2.FABRICANTE);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            produto = new PRODUTO();
            produto.descricao = txtDescricao.Text;
            produto.estoque = txtQuantidade.Text;
            produto.id_fabricante = (long) comboFabricante.SelectedValue;
            produto.id_tipo_produto = (long) comboTipo.SelectedValue;
            String valor = txtValor.Text;
            if(valor.Contains(".") || valor.Contains(","))
            {
                valor.Replace(".", ",");
            }            
            produto.valor = (valor == "" ? 0 : Convert.ToDouble(valor));
            ctx = new ContextBancoPds();
            ctx.PRODUTO.Add(produto);
            ctx.SaveChanges();
            DialogResult dialogResult = MessageBox.Show("Produto Adicionado com sucesso! Deseja voltar a lista?", "Sucesso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                limpar();
            }
        }

        private void limpar()
        {
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            comboFabricante.Text = "";
            comboTipo.Text = "";
        }
    }
}
