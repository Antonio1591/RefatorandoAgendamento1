using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorandoAgendamento.Modelo
{
    public class Funcionario:Usuario
    {
        public Funcionario()
        {

        }
        public  Funcionario(string nome)
        {
           this.Nome = nome;
        }

        public string Nome { get; private  set; }

    }
}
