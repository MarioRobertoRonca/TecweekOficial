﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecweek_Modelo;

namespace Sistema_Tecweek
{
    public partial class frm_Escolaridade : Form
    {
        public String operacao;

        public void alterarBotao(bool op) {
            if (op)
            {
                Btn_escolaSalvar.Enabled = true;
                Btn_escolaCancelar.Enabled = true;
                Btn_escolaNovo.Enabled = false;
                Btn_escolaEditar.Enabled = false;
                Btn_escolaExcluir.Enabled = false;
                Txt_escolaNome.Enabled = true;
                Txt_escolaCod.Enabled = true;
                Txt_escolaPesquisar.Enabled = false;
            } else
            {
                Btn_escolaNovo.Enabled = true;
                Btn_escolaEditar.Enabled = true;
                Btn_escolaExcluir.Enabled = true;
                Btn_escolaSalvar.Enabled = false;
                Btn_escolaCancelar.Enabled = false;
                Txt_escolaNome.Enabled = false;
                Txt_escolaCod.Enabled = false;
                Txt_escolaPesquisar.Enabled = true;
            }
        }

        public void limpaTela()
        {
            Txt_escolaCod.Clear();
            Txt_escolaNome.Clear();
        }

        public frm_Escolaridade()
        {
            InitializeComponent();
        }

        private void Txt_pesquisar_Enter(object sender, EventArgs e)
        {
            if(Txt_escolaPesquisar.Text == "Digite para pesquisar...")
            {
                Txt_escolaPesquisar.Text = "";
                Txt_escolaPesquisar.ForeColor = Color.Black;
            }
        }

        private void Txt_pesquisar_Leave(object sender, EventArgs e)
        {
            if (Txt_escolaPesquisar.Text == "")
            {
                Txt_escolaPesquisar.Text = "Digite para pesquisar...";
                Txt_escolaPesquisar.ForeColor = Color.Silver;
            }
        }

        private void Btn_escolaNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotao(true);
        }

        private void Btn_escolaCancelar_Click(object sender, EventArgs e)
        {
            this.limpaTela();
            this.alterarBotao(false);
        }

        private void frm_Escolaridade_Load(object sender, EventArgs e)
        {
            Btn_escolaNovo.Enabled = true;
            Btn_escolaEditar.Enabled = true;
            Btn_escolaExcluir.Enabled = true;
            Btn_escolaSalvar.Enabled = false;
            Btn_escolaCancelar.Enabled = false;
            Txt_escolaNome.Enabled = false;
            Txt_escolaCod.Enabled = false;
            Txt_escolaPesquisar.Enabled = true;
        }

        private void Btn_escolaSalvar_Click(object sender, EventArgs e)
        {
            modeloEscolaridade modelo = new modeloEscolaridade
            {
                escNome = Txt_escolaNome.Text
            };
            if(this.operacao == "inserir")
            {
                // cadastra no banco a escolaridade.
            }
        }
    }
}
