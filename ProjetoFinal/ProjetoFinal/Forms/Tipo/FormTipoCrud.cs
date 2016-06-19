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

namespace ProjetoFinal.Forms.Tipo
{
    public partial class FormTipoCrud : MetroForm
    {
        private int condicao = 0;
        private ContextBancoPds ctx;
        private TIPO_PRODUTO tipoProduto;
        public FormTipoCrud()
        {
            InitializeComponent();
        }

        public FormTipoCrud(TIPO_PRODUTO tipoProduto, int condicao)
        {
            this.tipoProduto = tipoProduto;
            this.condicao = condicao;
            txtDescricao.Text = tipoProduto.descricao;
            btnSalvar.Text = "Alterar";
            InitializeComponent();
        }

        private void FormTipoCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (condicao == 0)
            {
                ctx = new ContextBancoPds();
                TIPO_PRODUTO tipo = new TIPO_PRODUTO();
                tipo.descricao = txtDescricao.Text;
                ctx.TIPO_PRODUTO.Add(tipo);
                ctx.SaveChanges();
                DialogResult dialogResult = MessageBox.Show("Tipo Produto Adicionado com sucesso! Deseja voltar a lista de tipos?", "Sucesso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    txtDescricao.Text = "";
                }
            }
            else
            {
                ctx = new ContextBancoPds();
                ctx.TIPO_PRODUTO.Find(tipoProduto);
                tipoProduto.descricao = txtDescricao.Text;
                ctx.SaveChanges();
                condicao = 0;
                this.Close();
            }
        }
    }
}
