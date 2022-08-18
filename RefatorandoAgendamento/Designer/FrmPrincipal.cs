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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        usuarioServices usuario = new usuarioServices();
        private void lblNome_Click(object sender, EventArgs e)
        {
            lblNome.Text= usuario.Nome;
        }
    }
}
