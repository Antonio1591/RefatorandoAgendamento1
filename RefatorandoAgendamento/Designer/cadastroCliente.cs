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
    public partial class cadastroCliente : Form
    {
        public cadastroCliente()
        {
            InitializeComponent();
        }
        ClienteServices cliente= new ClienteServices();
        private void btnCadastro_Click(object sender, EventArgs e)
        {
         var _cliente=  cliente.cadastro(txtNome.Text,maskSenha.Text,maskCPF.Text.Remove(3, 1).Remove(6, 1).Remove(9, 1));
            if(_cliente == true)
            {
                this.Close();
            }
        }
    }
}
