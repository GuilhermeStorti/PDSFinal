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

namespace ProjetoFinal.Forms.Fabricante
{
    public partial class FormListaFabricante : MetroForm
    {
        FormFabricanteCrud formFabricanteCrud;

        public FormListaFabricante()
        {
            InitializeComponent();
        }

        private void FormListaFabricante_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formFabricanteCrud = new FormFabricanteCrud();
            this.Hide();
            formFabricanteCrud.ShowDialog();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formFabricanteCrud = new FormFabricanteCrud();
            this.Hide();
            formFabricanteCrud.ShowDialog();
            this.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
