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

        //public Usuario logar(string nome, string senha)
        //{
        //    if (nome == null)
        //    {
        //        throw new Exception("nome não atribuido");
        //    }

        //    MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
        //    Usuario usuario = new Usuario();


        //    try
        //    {
        //        string strsql = "select * from funcionario where nome = @nome and senha= @senha";
        //        MySqlCommand comando = new MySqlCommand(strsql, con);
        //        comando.Parameters.AddWithValue("@nome", usuario.Nome);
        //        comando.Parameters.AddWithValue("@senha", usuario.Senha);
        //        con.Open();
        //        comando.ExecuteNonQuery();
        //        MySqlDataAdapter da = new MySqlDataAdapter(comando);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);

        //        if (dt.Rows.Count == 1)
        //        {

        //            return usuario;
        //        }
        //        else
        //        {
        //            throw new Exception("Usuario Não encontrado");
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show("erro ao logar " + ex);
        //        con.Close();
        //        return null;
        //    }


        //}

        public UsuarioServices Logim(string nome, string senha)
        {
            try
            {
                sair();

                Nome = nome;
                Senha = senha;
                MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
                string sql = "Select cnpj_usuario,nivel_usuario from usuario where nome_usuario= @nome and senha_usuario=@senha;";
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
            UsuarioServices usuario = new UsuarioServices(nome, senha, CNPJ, nivel_usuario,Logado);
            if (Nome == null && Senha == null && CNPJ == null && nivel_usuario == null )
            {
                MessageBox.Show("Usuario ou Senha incorreto", "Logim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            if(Nome == "" && Senha == "" && CNPJ == ""  && nivel_usuario == "")
            {
                MessageBox.Show("Usuario ou Senha incorreto", "Logim", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            return usuario;
        
        }
        
        public void sair()
        {
            Nome = null;
            Logado = false;
            
        }
    }
}
