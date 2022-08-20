namespace RefatorandoAgendamento.Designer
{
    partial class Agendamento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FuncionarioAgendamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ClienteAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionarioAgendamento,
            this.ClienteAgendamento,
            this.HorarioDisponivel,
            this.SituacaoAgendamento});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // FuncionarioAgendamento
            // 
            this.FuncionarioAgendamento.HeaderText = "Funcionario";
            this.FuncionarioAgendamento.Name = "FuncionarioAgendamento";
            // 
            // ClienteAgendamento
            // 
            this.ClienteAgendamento.HeaderText = "Cliente agendado";
            this.ClienteAgendamento.Name = "ClienteAgendamento";
            this.ClienteAgendamento.ReadOnly = true;
            this.ClienteAgendamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteAgendamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClienteAgendamento.Visible = false;
            // 
            // HorarioDisponivel
            // 
            this.HorarioDisponivel.HeaderText = "Horarios Disponiveis";
            this.HorarioDisponivel.Name = "HorarioDisponivel";
            this.HorarioDisponivel.ReadOnly = true;
            // 
            // SituacaoAgendamento
            // 
            this.SituacaoAgendamento.HeaderText = "Situação Agendamento";
            this.SituacaoAgendamento.Name = "SituacaoAgendamento";
            this.SituacaoAgendamento.ReadOnly = true;
            this.SituacaoAgendamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SituacaoAgendamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn FuncionarioAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituacaoAgendamento;
    }
}