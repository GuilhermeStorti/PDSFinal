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
using ProjetoFinal.Forms.Tipo;
using ProjetoFinal.BancoPds;

namespace ProjetoFinal.Forms.Tipo
{
    public partial class FormListaTipos : MetroForm
    {
        FormTipoCrud formTipoCrud;
        ContextBancoPds ctx;

        public FormListaTipos()
        {
            InitializeComponent();
            ctx = new ContextBancoPds();
            tIPOPRODUTOBindingSource1.DataSource = ctx.TIPO_PRODUTO.ToList();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TIPO_PRODUTO tipo = (TIPO_PRODUTO) tIPOPRODUTOBindingSource1.Current;
            formTipoCrud = new FormTipoCrud(tipo, 1);
            this.Hide();
            formTipoCrud.ShowDialog();
            this.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formTipoCrud = new FormTipoCrud();
            this.Hide();
            formTipoCrud.ShowDialog();
            ctx = new ContextBancoPds();
            tIPOPRODUTOBindingSource1.ResetBindings(false);
            tIPOPRODUTOBindingSource1.DataSource = ctx.TIPO_PRODUTO.ToList();
            this.Show();
        }

        private void FormListaTipos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet.TIPO_PRODUTO' table. You can move, or remove it, as needed.
            this.tIPO_PRODUTOTableAdapter.Fill(this.banco_pdsDataSet.TIPO_PRODUTO);

        }
    }
}
