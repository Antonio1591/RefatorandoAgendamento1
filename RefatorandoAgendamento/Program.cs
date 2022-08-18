using RefatorandoAgendamento.Designer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefatorandoAgendamento
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logim logim = new Logim();
            if (logim.ShowDialog() == DialogResult.Yes)
            { 
                Application.Run(new FrmPrincipal()); 
            }
        }
    }
}
