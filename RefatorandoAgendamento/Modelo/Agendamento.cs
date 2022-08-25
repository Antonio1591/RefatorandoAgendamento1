using RefatorandoAgendamento.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorandoAgendamento.Modelo
{
    public class Agendamento
    {

        public string Funcionario { get; set; }
        public string ClienteNome { get; set; }
        public DateTime DataAgendamento { get; set; }
        public SituacaoEnum Situacao { get; set; }
    }
}
