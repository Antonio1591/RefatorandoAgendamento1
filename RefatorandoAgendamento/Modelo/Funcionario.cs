using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorandoAgendamento.Modelo
{
    public class Funcionario
    {
        public Funcionario()
        {
        
        }

        
        public Funcionario(string nome, string senha, string cNPJ, string nivelAcesso)
        {
            Nome = nome;
            Senha = senha;
            CNPJ = cNPJ;
            NivelAcesso = nivelAcesso;
            Logado = Logado;
        }

        public void AlterarStatusLogado(bool logado)
        {
            Logado = logado;
        }

        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string CNPJ { get; private set; }
        public string NivelAcesso { get; private set; }
        public Boolean Logado { get;  private set; }

    }
}
