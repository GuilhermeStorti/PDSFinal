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
using ProjetoFinal.Forms.Tipo;

namespace ProjetoFinal.Forms.Tipo
{
    public partial class FormListaTipos : MetroForm
    {
        FormTipoCrud formTipoCrud;

        public FormListaTipos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formTipoCrud = new FormTipoCrud();
            this.Hide();
            formTipoCrud.ShowDialog();
            this.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formTipoCrud = new FormTipoCrud();
            this.Hide();
            formTipoCrud.ShowDialog();
            this.Show();
        }

        private void FormListaTipos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banco_pdsDataSet.TIPO_PRODUTO' table. You can move, or remove it, as needed.
            this.tIPO_PRODUTOTableAdapter.Fill(this.banco_pdsDataSet.TIPO_PRODUTO);

        }
    }
}
