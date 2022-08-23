using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorandoAgendamento.Modelo
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(string nome, string senha, string cNPJ, string nivelAcesso, bool logado)
        {
            logim = nome;
            Senha = senha;
            CNPJ = cNPJ;
            nivel_usuario = nivelAcesso;
            Logado = logado;
        }

        public void AlterarStatusLogado(bool logado)
        {
            Logado = logado;
        }
       
        public int ID { get; private set; }
        public string logim { get; private set; }
        public string Senha { get; private set; }
        public string CNPJ { get; private set; }
        public string nivel_usuario { get; private set; }
        public bool Logado { get; private set; }


    }
}
