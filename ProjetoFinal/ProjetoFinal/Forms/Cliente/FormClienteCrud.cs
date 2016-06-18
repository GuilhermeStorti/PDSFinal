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

namespace ProjetoFinal.Forms.Cliente
{
    public partial class FormClienteCrud : MetroForm
    {
        public FormClienteCrud()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ContextBancoPds ctx = new ContextBancoPds();
            ENDERECO endereco = new ENDERECO();
            endereco.logradouro = txtLogradouro.Text;
            endereco.numero = Convert.ToInt32(txtNumero.Text);
            endereco.bairro = txtBairro.Text;
            endereco.cidade = txtCidade.Text;
            endereco.estado = txtEstado.Text;
            endereco.complemento = txtComplemento.Text;
            endereco.cep = txtMaskCEP.Text;
            var query = ctx.ENDERECO.Where(en => en.logradouro == endereco.logradouro && en.numero == endereco.numero).ToList();
            if (query.Count == 0)
            {
                ctx.ENDERECO.Add(endereco);
                ctx.SaveChanges();
                endereco = (ENDERECO)ctx.ENDERECO.Where(en => en.logradouro == endereco.logradouro && en.numero == endereco.numero);
            }
            else
            {
            }
            CLIENTE cliente = new CLIENTE();
            cliente.nome = txtNome.Text;
            cliente.telefone = txtMaskTelefone.Text;
            cliente.email = txtEmail.Text;
            cliente.cpf = txtMaskCPF.Text;
            cliente.id_endereco = endereco.id_endereco;
            ctx = new ContextBancoPds();
            ctx.CLIENTE.Add(cliente);
            ctx.SaveChanges();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtMaskCEP.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtMaskCPF.Text = "";
            txtEmail.Text = "";
            txtEstado.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtMaskTelefone.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
