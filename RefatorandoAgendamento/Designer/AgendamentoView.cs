using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RefatorandoAgendamento.Serviços;

namespace RefatorandoAgendamento.Designer
{
    public partial class AgendamentoView : Form
    {
        FuncionarioServices _funcionarioService = new FuncionarioServices();
        AgendamentoService _agendamentoService = new AgendamentoService();

        public AgendamentoView()
        {
            InitializeComponent();

            DiaDateTimePicker.ValueChanged += DiaDateTimePicker_ValueChanged;
        }

        private void DiaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            HoraComboBox.Items.Clear();

            var agendamentos = _agendamentoService.BuscarAgendamentos();

            var dataSelecionada = DiaDateTimePicker.Value;
            var horasPeriodo = Enumerable.Range(8, 12)
                                         .Select(d => dataSelecionada.Date.AddHours(d));

            foreach (var hora in horasPeriodo)
            {
                if (agendamentos.Any(d => d.DataAgendamento == hora))
                    continue;

                HoraComboBox.Items.Add(hora);
            }
        }


        private void Agendamento_Load(object sender, EventArgs e)
        {
            DiaDateTimePicker_ValueChanged(sender, e);

            var Funcionarios = _funcionarioService.BuscarFuncionario();
            foreach (var Funcionario in Funcionarios)
            {
                FuncionarioComboBox.Items.Add(Funcionario.Nome);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DateTime dia = DiaDateTimePicker.Value;
            DateTime hora = DateTime.Parse(HoraComboBox.Text);

            DateTime dataSelecionada = new DateTime(dia.Year, dia.Month, dia.Day, hora.Hour, hora.Minute, hora.Second);

            _agendamentoService.InserirDados(FuncionarioComboBox.Text, usuarioServices.Usuario.ID, dataSelecionada);

            MessageBox.Show("Agendamento realizado com sucesso!", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
