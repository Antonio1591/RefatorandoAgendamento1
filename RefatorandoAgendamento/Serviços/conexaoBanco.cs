using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorandoAgendamento.Serviços
{
    public class conexaoBanco
    {
        public static string conexao()
        {
            try
            {
               string Sql= "server=localhost;port=3306;User Id = root; database=treino2;password=123456";
               
                return Sql;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro de conexão: " + ex );
            }

            return "";
        }

    }
}
