using Dapper;
using MySql.Data.MySqlClient;
using RefatorandoAgendamento.Modelo;
using RefatorandoAgendamento.Modelo.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RefatorandoAgendamento.Serviços
{
    public class AgendamentoService
    {
        public IEnumerable<Agendamento> BuscarAgendamentos()
        {
            string sql = @"SELECT  Funcionario_Agendamento AS Funcionario, 
                            Cliente_Agendado AS ClienteNome, 
                            Horario_Agendamento AS DataAgendamento, 
                            Situacao_Agendamento AS  Situacao 
                            FROM agendamento";
            MySqlConnection conn = new MySqlConnection(conexaoBanco.conexao());

            return conn.Query<Agendamento>(sql);

        }

        public void InserirDados(string funcionario, string clienteNome, DateTime horarioAgendamento)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(conexaoBanco.conexao());
                var sql = $"INSERT INTO `agendamento` (`Funcionario_Agendamento`, `Cliente_Agendado`, `Horario_Agendamento`, `Situacao_Agendamento`) VALUES('{funcionario}', '{clienteNome}', '{horarioAgendamento:yyyy-MM-dd HH:mm:ss}', '0')";

                conn.Execute(sql);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

    }
}
