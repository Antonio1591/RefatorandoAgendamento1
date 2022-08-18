using MySql.Data.MySqlClient;
using RefatorandoAgendamento.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RefatorandoAgendamento.Serviços
{
    public class ClienteServices
    {
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string CPF { get; private set; }
        public string NivelAcesso { get; private set; }
        public Cliente PegarDadosFuncionario(string nome, string senha)
        {
            try
            {
                sair();

                Nome = nome;
                Senha = senha;
                MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
                string sql = "Select CPF,NivelAcesso from Cliente where nome= @Nome and @Senha";
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Senha", senha);
                con.Open();
                comando.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = comando.ExecuteReader();
                dr.Read();
                CPF = dr.GetString(0).ToString();
                NivelAcesso=dr.GetString(1).ToString();
                con.Close();
                //System.Windows.Forms.MessageBox.Show("Test" + Nivel_acesso);

            }
            catch
            {
                return null;
            }
            Cliente cliente = new Cliente(nome, senha, CPF, NivelAcesso);

            return cliente;
        }

        public void sair()
        {
            Nome = null;
        }

    }
}
