﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
