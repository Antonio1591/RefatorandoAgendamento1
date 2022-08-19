using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RefatorandoAgendamento.Serviços;
using RefatorandoAgendamento.Designer;
using RefatorandoAgendamento.Modelo;

namespace RefatorandoAgendamento
{
    public partial class Logim : Form
    {
        public Logim()
        {           
            InitializeComponent();
            
        }
        
        usuarioServices _usuarioServices = new usuarioServices();
        private void btnLogar_Click(object sender, EventArgs e)
        {
            var usuario = _usuarioServices.Logim(txtUsuario.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            usuario.AlterarStatusLogado(true);


            if (usuario.Logado == true)
            {

                this.DialogResult = DialogResult.Yes;
            }

        }
          
    }
}
