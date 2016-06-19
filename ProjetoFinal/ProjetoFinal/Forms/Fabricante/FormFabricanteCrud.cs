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

namespace ProjetoFinal.Forms.Fabricante
{
    public partial class FormFabricanteCrud : MetroForm
    {
        ContextBancoPds ctx;
        FABRICANTE fabricante;
        public FormFabricanteCrud()
        {
            InitializeComponent();
        }

        private void FormFabricanteCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtNome.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            fabricante = new FABRICANTE();
            fabricante.descricao = txtDescricao.Text;
            fabricante.nome = txtNome.Text;
            ctx = new ContextBancoPds();
            ctx.FABRICANTE.Add(fabricante);
            ctx.SaveChanges();
            DialogResult dialogResult = MessageBox.Show("Fabricante adicionado com sucesso! Deseja voltar a lista?", "Sucesso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                txtNome.Text = "";
                txtDescricao.Text = "";
            }
        }
    }
}
