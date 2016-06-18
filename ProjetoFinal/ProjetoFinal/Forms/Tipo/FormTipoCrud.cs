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
        public FormTipoCrud()
        {
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
            ContextBancoPds ctx = new ContextBancoPds();
            TIPO_PRODUTO tipo = new TIPO_PRODUTO();
            tipo.descricao = txtDescricao.Text;
            ctx.TIPO_PRODUTO.Add(tipo);
            ctx.SaveChanges();
        }
    }
}
