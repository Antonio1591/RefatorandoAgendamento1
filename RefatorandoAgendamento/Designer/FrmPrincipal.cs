﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RefatorandoAgendamento.Modelo;
using RefatorandoAgendamento.Serviços;

namespace RefatorandoAgendamento.Designer
{
    public partial class Gerenciamento : Form
    {
        public Gerenciamento()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblNome.Text = "Funcionario: " + usuarioServices.Usuario.Nome;
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroFuncionario cadastrofuncionario = new cadastroFuncionario();
            cadastrofuncionario.Show();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCliente cadastrocliente= new cadastroCliente();
            cadastrocliente.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja sair do programa? ","Sair do sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           
            if(DialogResult == DialogResult.Yes)
            { 
                Application.Exit();
            }
            else
            {
                return;
            }
        }


    }
}
