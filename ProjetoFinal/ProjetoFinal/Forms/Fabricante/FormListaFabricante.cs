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
using ProjetoFinal.Forms.Fabricante;
using ProjetoFinal.BancoPds;

namespace ProjetoFinal.Forms.Fabricante
{
    public partial class FormListaFabricante : MetroForm
    {
        FormFabricanteCrud formFabricanteCrud;
        ContextBancoPds ctx;

        public FormListaFabricante()
        {
            InitializeComponent();
            atualizarBinding();
        }

        private void FormListaFabricante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet1.FABRICANTE' table. You can move, or remove it, as needed.
            this.fABRICANTETableAdapter.Fill(this.banco_pdsDataSet1.FABRICANTE);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formFabricanteCrud = new FormFabricanteCrud();
            this.Hide();
            formFabricanteCrud.ShowDialog();
            fABRICANTEBindingSource1.ResetBindings(false);
            atualizarBinding();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formFabricanteCrud = new FormFabricanteCrud();
            this.Hide();
            formFabricanteCrud.ShowDialog();
            fABRICANTEBindingSource1.ResetBindings(false);
            atualizarBinding();
            this.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ctx = new ContextBancoPds();
            FABRICANTE fab = (FABRICANTE) fABRICANTEBindingSource1.Current;
            ctx.FABRICANTE.Find(fab);
            ctx.FABRICANTE.Remove(fab);
            ctx.SaveChanges();
            atualizarBinding();
        }

        private void atualizarBinding()
        {
            ctx = new ContextBancoPds();
            fABRICANTEBindingSource1.DataSource = ctx.FABRICANTE.ToList();
        }
    }
}
