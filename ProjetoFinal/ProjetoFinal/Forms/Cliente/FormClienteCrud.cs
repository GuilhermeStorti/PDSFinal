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
        private ContextBancoPds ctx;
        private ENDERECO endereco;
        private CLIENTE cliente;
        public FormClienteCrud()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ctx = new ContextBancoPds();
            endereco = new ENDERECO();
            endereco.logradouro = txtLogradouro.Text;
            endereco.numero = txtNumero.Text == "" ? 0 : Convert.ToInt32(txtNumero.Text);
            endereco.bairro = txtBairro.Text;
            endereco.cidade = txtCidade.Text;
            endereco.estado = txtEstado.Text;
            endereco.complemento = txtComplemento.Text;
            endereco.cep = txtCep.Text;
            var query = ctx.ENDERECO.Where(en => en.logradouro == endereco.logradouro && en.numero == endereco.numero).ToList();
            if (query.Count == 0)
            {
                ctx.ENDERECO.Add(endereco);
                ctx.SaveChanges();
                endereco = ctx.ENDERECO.Where(en => en.logradouro == endereco.logradouro && en.numero == endereco.numero).First<ENDERECO>();
            }
            else
            {
                endereco = ctx.ENDERECO.Where(en => en.logradouro == endereco.logradouro && en.numero == endereco.numero).First<ENDERECO>();
            }
            cliente = new CLIENTE();
            cliente.nome = txtNome.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.email = txtEmail.Text;
            cliente.cpf = txtCPF.Text;
            cliente.id_endereco = endereco.id_endereco;
            ctx = new ContextBancoPds();
            ctx.CLIENTE.Add(cliente);
            ctx.SaveChanges();
            DialogResult dialogResult = MessageBox.Show("Cliente Adicionado com sucesso! Deseja voltar a lista?", "Sucesso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                limpar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtEstado.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtTelefone.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
