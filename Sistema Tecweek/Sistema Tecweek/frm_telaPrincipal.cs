﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Tecweek
{
    public partial class frm_telaPrincipal : Form
    {
        public frm_telaPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastroParticipantes cadastroPartic = new frm_cadastroParticipantes();
            cadastroPartic.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Escolaridade escolaridade = new frm_Escolaridade();
            escolaridade.ShowDialog();
        }

        private void períodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CPF cPF = new frm_CPF();
            cPF.ShowDialog();
        }
    }
}