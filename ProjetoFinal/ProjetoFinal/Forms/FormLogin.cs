using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Models;
using ProjetoFinal.Forms;
using ProjetoFinal.Services;
using MetroFramework.Forms;
using ProjetoFinal.BancoPds;

namespace ProjetoFinal
{
    public partial class FormLogin : MetroForm
    {
        Usuario usuario = null;

        FormPrincipal formPrincipal;        

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ContextBancoPds ctx = new ContextBancoPds();

            var query = ctx.USUARIO.Where(p => p.login == txtUsuario.Text && p.senha == txtSenha.Text).ToList();
            if (query.Count == 0)
            {
                MessageBox.Show("Login ou senha incorretos.");
            }
            else
            {
                formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.ShowDialog();
                this.Show();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
