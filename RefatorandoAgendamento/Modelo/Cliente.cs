using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorandoAgendamento.Modelo
{
    public class Cliente
    {
        public Cliente(string nome, string senha, string cnpj,string nivelAcesso)
        {
            Nome = nome;
            Senha = senha;
            CNPJ = cnpj;
            NivelAcesso = nivelAcesso;
        }
        public void AlterarStatusLogado(bool logado)
        {
            Logado = logado;
        }

        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string CNPJ { get; private set; }
        public Boolean Logado { get; private set; }
        public string NivelAcesso { get; private set; }
        public string Descricao { get; private set; }
    }
}
