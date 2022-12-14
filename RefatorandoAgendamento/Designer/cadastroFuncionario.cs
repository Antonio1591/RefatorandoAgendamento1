using MySql.Data.MySqlClient;
using RefatorandoAgendamento.Modelo.Enums;
using RefatorandoAgendamento.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RefatorandoAgendamento.Designer
{
    public partial class cadastroFuncionario : Form
    {
        FuncionarioServices funcionario = new FuncionarioServices();
        public cadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
          
         
            var _func = funcionario.cadastro(txtNome.Text,masktxtSenha.Text,masktxtCPF.Text.Remove(3, 1).Remove(6, 1).Remove(9, 1),combNivelAcesso.Text);


            if(_func == true)
            {
                this.Close();
            }

        }

        private void cadastroFuncionario_Load(object sender, EventArgs e)
        {
            combNivelAcesso.Items.Add(NivelUsuarioEnum.Gerente).ToString();
            combNivelAcesso.Items.Add(NivelUsuarioEnum.Funcionario.ToString());
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void masktxtCPF_Leave(object sender, EventArgs e)
        {
            if (!masktxtCPF.MaskCompleted)
            {
                MessageBox.Show("Favor preencher todo o campo! ");
                masktxtCPF.Text = "";
            }
           
        }
    }
    
}
