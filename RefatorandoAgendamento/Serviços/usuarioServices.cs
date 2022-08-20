using MySql.Data.MySqlClient;
using RefatorandoAgendamento.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using System.Windows.Forms;
using RefatorandoAgendamento.Modelo.Enums;
using static RefatorandoAgendamento.Modelo.Enums.SituacaoEnum;

namespace RefatorandoAgendamento.Serviços
{
    public class usuarioServices
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string CNPJ { get; private set; }
        public bool Logado { get; private set; }
        public string nivel_usuario { get; private set; }
        public static Usuario Usuario { get; set; } = null;

        public Usuario Logim(string nome, string senha)
        {
            try
            {
                sair();

                Nome = nome;
                Senha = senha;
                MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
                string sql = "Select cnpj_usuario,nivel_usuario from usuario where  nome_usuario=@nome and senha_usuario=@senha";
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Senha", senha);
                con.Open();
                comando.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = comando.ExecuteReader();
                dr.Read();
                CNPJ = dr.GetString(0).ToString();
                nivel_usuario = dr.GetString(1).ToString();
                con.Close();
                //System.Windows.Forms.MessageBox.Show("Test" + Nivel_acesso);

            }
            catch
            {
                return null;
            }

            Usuario usuario = new Usuario(nome, senha, CNPJ, nivel_usuario, Logado);

            if (Nome == null && Senha == null && CNPJ == null && nivel_usuario == null)
            {
                MessageBox.Show("Usuario ou Senha incorreto", "Logim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            if (Nome == "" && Senha == "" && CNPJ == "" && nivel_usuario == "")
            {
                MessageBox.Show("Usuario ou Senha incorreto", "Logim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            Usuario = usuario;
            return usuario;
        }

        public void sair()
        {
            Nome = null;
            Logado = false;

        }


        public void cadastroUsuario(string nome, string senha, string cnpj, string nivel_usuario)
        {
            string Situacao = situacaoEnum.Ativo.ToString();
            try
            {

                MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
                string sql = "INSERT INTO `treino2`.`usuario` (`nome_usuario`, `senha_usuario`, `cnpj_usuario`, `nivel_usuario`,`situacao_usuario`) VALUES(@nome,@senha, @cnpj_usuario,@nivel_usuario,@Situacao)";
                //"INSERT INTO `treino`.`funcionario` (`Nome`, `CPF`, `nivel_acesso`) VALUES (@Nome,@CPF,@nivel_acesso)";
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@cnpj_usuario", cnpj);
                comando.Parameters.AddWithValue("@nivel_usuario", nivel_usuario);
                comando.Parameters.AddWithValue("@Situacao", Situacao);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel cadastrar o Usuario: " + ex);

            }
        }


    }
}
