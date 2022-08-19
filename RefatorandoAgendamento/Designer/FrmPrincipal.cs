using System;
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
            lblNome.Text = usuarioServices.Usuario.Nome;

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
    }
}
