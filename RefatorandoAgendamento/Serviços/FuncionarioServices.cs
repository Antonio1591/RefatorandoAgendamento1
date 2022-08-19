﻿using MySql.Data.MySqlClient;
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
        usuarioServices usuario = new usuarioServices();
        public bool cadastro(string nome,string senha,string cpf, string nivel_acesso)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexaoBanco.conexao());
                string sql = "INSERT INTO `treino2`.`funcionario` (`Nome`,`Senha`, `CPF`, `nivel_acesso`) VALUES(@nome, @senha, @CPF, @nivel_acesso)";
                //"INSERT INTO `treino`.`funcionario` (`Nome`, `CPF`, `nivel_acesso`) VALUES (@Nome,@CPF,@nivel_acesso)";
                MySqlCommand comando = new MySqlCommand(sql, con);
                if (nome.Length < 4)
                {
                    MessageBox.Show("Erro ao cadastrar Funcionario, Nome do funcionario tem que ter mais de 4 digitos", "Cadastro Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (senha.Length < 4)
                {
                    MessageBox.Show("Erro ao cadastrar Funcionario, senha deve conter mais de 4 digitos", "Cadastro Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (nome == "" || senha == "" || cpf == "" || nivel_acesso == "")
                {
                    MessageBox.Show("Erro ao cadastrar funcionario não pode haver campos vazios ", "Cadastro Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@CPF", cpf);
                comando.Parameters.AddWithValue("@nivel_acesso", nivel_acesso);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
                usuario.cadastroUsuario(nome,senha, cpf, nivel_acesso);
                MessageBox.Show($"Funcionario {nome} Cadastrado no sistema! ");
               
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Funcionario", "Cadastro Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

    }
}
