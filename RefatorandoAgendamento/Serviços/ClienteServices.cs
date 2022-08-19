using MySql.Data.MySqlClient;
using RefatorandoAgendamento.Modelo;
using RefatorandoAgendamento.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefatorandoAgendamento.Serviços
{
    public class ClienteServices
    {
      usuarioServices usuario= new usuarioServices();
        
        public bool cadastro(string nome, string senha,string cpf)
        {
            try
            {
                string nivelUsuario = NivelUsuarioEnum.Cliente.ToString();
               
                MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
                string sql = "INSERT INTO `treino2`.`Cliente` (`Nome`,`Senha`, `CPF`, `NivelAcesso`) VALUES(@nome, @senha, @CPF, @nivel_acesso)";
                //"INSERT INTO `treino`.`funcionario` (`Nome`, `CPF`, `nivel_acesso`) VALUES (@Nome,@CPF,@nivel_acesso)";
                MySqlCommand comando = new MySqlCommand(sql, con);
                if (nome.Length < 4)
                {
                    MessageBox.Show("Erro ao cadastrar Cliente, Nome do Cliente tem que ter mais de 4 digitos", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (senha.Length < 4)
                {
                    MessageBox.Show("Erro ao cadastrar Cliente, senha deve conter mais de 4 digitos", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (nome == "" || senha == "" || cpf == "" )
                {
                    MessageBox.Show("Erro ao cadastrar Cliente não pode haver campos vazios ", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@CPF", cpf);
                comando.Parameters.AddWithValue("@nivel_acesso", nivelUsuario);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
                usuario.cadastroUsuario(nome, senha, cpf, nivelUsuario);
                MessageBox.Show($"Cliente: {nome} Cadastrado no sistema! ");

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Cliente", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
