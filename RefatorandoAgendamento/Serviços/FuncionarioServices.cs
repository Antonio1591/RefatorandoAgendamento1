using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefatorandoAgendamento.Serviços;
using RefatorandoAgendamento.Modelo;
using Dapper;
using System.Windows.Forms;

namespace RefatorandoAgendamento.Serviços
{
    public class FuncionarioServices
    {
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string CPF { get; private set; }
        public string Nivel_acesso { get; private set; }

        public Boolean Logado { get; private set; }


        public Funcionario PegarDadosFuncionario(string nome, string senha)
        {
            try
            {
                sair();

                Nome = nome;
                Senha = senha;
                MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
                string sql = "Select CPF,nivel_acesso from funcionario where nome= @Nome and @Senha";
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
                Nivel_acesso = dr.GetString(1).ToString();
                con.Close();
                //System.Windows.Forms.MessageBox.Show("Test" + Nivel_acesso);

            }
            catch 
            {
                return null;
            }
            Funcionario funcionario = new Funcionario(nome, senha, CPF, Nivel_acesso);

            return funcionario;
        }




        //public Funcionario logar()
        //{
        //    if (Nome == null)
        //    {
        //        throw new Exception("Nome não atribuido");
        //    }

        //    MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
        //    Funcionario funcionario = new Funcionario(Nome, Senha, CPF, Nivel_acesso);


        //    try
        //    {               
        //        string strSql = "Select * from funcionario where nome = @nome and senha= @senha";
        //        MySqlCommand comando = new MySqlCommand(strSql, con);
        //        comando.Parameters.AddWithValue("@nome", funcionario.Nome);
        //        comando.Parameters.AddWithValue("@senha", funcionario.Senha);
        //        con.Open();
        //        comando.ExecuteNonQuery();
        //        MySqlDataAdapter Da = new MySqlDataAdapter(comando);
        //        DataTable dt = new DataTable();
        //        Da.Fill(dt);

        //        if (dt.Rows.Count == 1)
        //        {
        //            con.Close();
        //            funcionario.AlterarStatusLogado(true);
        //            return funcionario;

        //        }
        //        else
        //        {
        //            throw new Exception();
        //        }
              

        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Erro ao logar " + ex);
        //        con.Close();
        //        return null;
        //    }

        //}

        public void sair()
        {
            Nome = null;
            
        }




        
    }
}
