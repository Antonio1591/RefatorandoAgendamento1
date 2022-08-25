namespace RefatorandoAgendamento.Designer
{
    partial class AgendamentoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataAgendamentoGridView = new System.Windows.Forms.DataGridView();
            this.FuncionarioComboBox = new System.Windows.Forms.ComboBox();
            this.DiaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SituacaoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HoraComboBox = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.FuncionarioAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataAgendamentoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAgendamentoGridView
            // 
            this.dataAgendamentoGridView.AllowUserToDeleteRows = false;
            this.dataAgendamentoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAgendamentoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionarioAgendamento,
            this.ClienteAgendamento,
            this.DiaColumn,
            this.HorarioDisponivel,
            this.SituacaoAgendamento});
            this.dataAgendamentoGridView.Location = new System.Drawing.Point(1, 124);
            this.dataAgendamentoGridView.Name = "dataAgendamentoGridView";
            this.dataAgendamentoGridView.Size = new System.Drawing.Size(704, 240);
            this.dataAgendamentoGridView.TabIndex = 0;
            this.dataAgendamentoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAgendamentoGridView_CellContentClick);
            this.dataAgendamentoGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataAgendamentoGridView_DataBindingComplete);
            // 
            // FuncionarioComboBox
            // 
            this.FuncionarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuncionarioComboBox.FormattingEnabled = true;
            this.FuncionarioComboBox.Location = new System.Drawing.Point(23, 44);
            this.FuncionarioComboBox.Name = "FuncionarioComboBox";
            this.FuncionarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.FuncionarioComboBox.TabIndex = 1;
            // 
            // DiaDateTimePicker
            // 
            this.DiaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DiaDateTimePicker.Location = new System.Drawing.Point(169, 46);
            this.DiaDateTimePicker.Name = "DiaDateTimePicker";
            this.DiaDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.DiaDateTimePicker.TabIndex = 2;
            // 
            // SituacaoComboBox
            // 
            this.SituacaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SituacaoComboBox.FormattingEnabled = true;
            this.SituacaoComboBox.Location = new System.Drawing.Point(563, 46);
            this.SituacaoComboBox.Name = "SituacaoComboBox";
            this.SituacaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.SituacaoComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dia Agendamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora agendamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Situação";
            // 
            // HoraComboBox
            // 
            this.HoraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoraComboBox.FormatString = "t";
            this.HoraComboBox.FormattingEnabled = true;
            this.HoraComboBox.Location = new System.Drawing.Point(369, 44);
            this.HoraComboBox.Name = "HoraComboBox";
            this.HoraComboBox.Size = new System.Drawing.Size(121, 21);
            this.HoraComboBox.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(563, 82);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(111, 27);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FuncionarioAgendamento
            // 
            this.FuncionarioAgendamento.HeaderText = "Funcionario";
            this.FuncionarioAgendamento.Name = "FuncionarioAgendamento";
            this.FuncionarioAgendamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FuncionarioAgendamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClienteAgendamento
            // 
            this.ClienteAgendamento.HeaderText = "Cliente agendado";
            this.ClienteAgendamento.Name = "ClienteAgendamento";
            this.ClienteAgendamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteAgendamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiaColumn
            // 
            this.DiaColumn.HeaderText = "Dia Agendamento";
            this.DiaColumn.Name = "DiaColumn";
            this.DiaColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DiaColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HorarioDisponivel
            // 
            this.HorarioDisponivel.HeaderText = "Horarios";
            this.HorarioDisponivel.Name = "HorarioDisponivel";
            this.HorarioDisponivel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SituacaoAgendamento
            // 
            this.SituacaoAgendamento.HeaderText = "Situação Agendamento";
            this.SituacaoAgendamento.Name = "SituacaoAgendamento";
            this.SituacaoAgendamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SituacaoAgendamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AgendamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(707, 376);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.HoraComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SituacaoComboBox);
            this.Controls.Add(this.DiaDateTimePicker);
            this.Controls.Add(this.FuncionarioComboBox);
            this.Controls.Add(this.dataAgendamentoGridView);
            this.Name = "AgendamentoView";
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAgendamentoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataAgendamentoGridView;
        private System.Windows.Forms.ComboBox FuncionarioComboBox;
        private System.Windows.Forms.DateTimePicker DiaDateTimePicker;
        private System.Windows.Forms.ComboBox SituacaoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HoraComboBox;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionarioAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituacaoAgendamento;
    }
}