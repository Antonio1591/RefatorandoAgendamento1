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
using RefatorandoAgendamento.Modelo.Enums;
using RefatorandoAgendamento.Serviços;
using static RefatorandoAgendamento.Modelo.Enums.SituacaoEnum;

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
            if(usuarioServices.Usuario.nivel_usuario == NivelUsuarioEnum.Cliente.ToString())
            {
                menuCadastro.Visible = false;
                menuRelatorio.Visible = false;
            }if(usuarioServices.Usuario.nivel_usuario == NivelUsuarioEnum.Funcionario.ToString())
            {
                menuCadastroFuncionario.Visible = false;
            }
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
            
            if(MessageBox.Show("Deseja sair do programa? ", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Agendamento().Show();
        }
    }
}
