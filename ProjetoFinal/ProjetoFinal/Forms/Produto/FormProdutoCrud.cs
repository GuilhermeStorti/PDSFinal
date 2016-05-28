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

namespace ProjetoFinal.Forms.Produto
{
    public partial class FormProdutoCrud : MetroForm
    {
        public FormProdutoCrud()
        {
            InitializeComponent();
        }

        private void FormProdutoCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtMaskValor.Text = "";
            comboFabricante.Text = "";
            comboTipo.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
