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

namespace ProjetoFinal
{
    public partial class FormLogin : Form
    {
        Usuario usuario = null;

        FormPrincipal formPrincipal;        

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //usuario = UsuarioDAO.validaUsuario(txtUsuario.Text, txtSenha.Text);
            //if (usuario != null)
            //{
                formPrincipal = new FormPrincipal(usuario);
                this.Hide();
                formPrincipal.ShowDialog();
                this.Show();
            //}
                //else 
            //{
            //    MessageBox.Show("Login ou senha incorretos.");
            // }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
