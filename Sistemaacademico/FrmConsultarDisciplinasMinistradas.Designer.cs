
namespace SistemaAcademico
{
    partial class FrmConsultarDisciplinasMinistradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarDisciplinasMinistradas));
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoCancelado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoFinalizado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoEmAndamento = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBoxTurma = new System.Windows.Forms.GroupBox();
            this.dataGridViewTurma = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstituicao_Fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.radioButtonNomeProfessor = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigoProfessor = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioButtonNomeDisciplina = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.radioButtonCodigoDisciplina = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.btnVincularAlunos = new System.Windows.Forms.Button();
            this.groupBoxSituacoes.SuspendLayout();
            this.groupBoxTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).BeginInit();
            this.groupBoxConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoCancelado);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoFinalizado);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoEmAndamento);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(448, 37);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(190, 70);
            this.groupBoxSituacoes.TabIndex = 7;
            this.groupBoxSituacoes.TabStop = false;
            this.groupBoxSituacoes.Text = "Situação";
            // 
            // radioButtonSituacaoCancelado
            // 
            this.radioButtonSituacaoCancelado.AutoSize = true;
            this.radioButtonSituacaoCancelado.Location = new System.Drawing.Point(86, 41);
            this.radioButtonSituacaoCancelado.Name = "radioButtonSituacaoCancelado";
            this.radioButtonSituacaoCancelado.Size = new System.Drawing.Size(76, 17);
            this.radioButtonSituacaoCancelado.TabIndex = 3;
            this.radioButtonSituacaoCancelado.Text = "Cancelado";
            this.radioButtonSituacaoCancelado.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoFinalizado
            // 
            this.radioButtonSituacaoFinalizado.AutoSize = true;
            this.radioButtonSituacaoFinalizado.Location = new System.Drawing.Point(9, 41);
            this.radioButtonSituacaoFinalizado.Name = "radioButtonSituacaoFinalizado";
            this.radioButtonSituacaoFinalizado.Size = new System.Drawing.Size(72, 17);
            this.radioButtonSituacaoFinalizado.TabIndex = 2;
            this.radioButtonSituacaoFinalizado.Text = "Finalizado";
            this.radioButtonSituacaoFinalizado.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoEmAndamento
            // 
            this.radioButtonSituacaoEmAndamento.AutoSize = true;
            this.radioButtonSituacaoEmAndamento.Location = new System.Drawing.Point(86, 17);
            this.radioButtonSituacaoEmAndamento.Name = "radioButtonSituacaoEmAndamento";
            this.radioButtonSituacaoEmAndamento.Size = new System.Drawing.Size(97, 17);
            this.radioButtonSituacaoEmAndamento.TabIndex = 1;
            this.radioButtonSituacaoEmAndamento.Text = "Em Andamento";
            this.radioButtonSituacaoEmAndamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoTodos
            // 
            this.radioButtonSituacaoTodos.AutoSize = true;
            this.radioButtonSituacaoTodos.Checked = true;
            this.radioButtonSituacaoTodos.Location = new System.Drawing.Point(9, 17);
            this.radioButtonSituacaoTodos.Name = "radioButtonSituacaoTodos";
            this.radioButtonSituacaoTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSituacaoTodos.TabIndex = 0;
            this.radioButtonSituacaoTodos.TabStop = true;
            this.radioButtonSituacaoTodos.Text = "Todos";
            this.radioButtonSituacaoTodos.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(305, 462);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBoxTurma
            // 
            this.groupBoxTurma.Controls.Add(this.dataGridViewTurma);
            this.groupBoxTurma.Location = new System.Drawing.Point(10, 164);
            this.groupBoxTurma.Name = "groupBoxTurma";
            this.groupBoxTurma.Size = new System.Drawing.Size(638, 292);
            this.groupBoxTurma.TabIndex = 1;
            this.groupBoxTurma.TabStop = false;
            this.groupBoxTurma.Text = "Turma";
            // 
            // dataGridViewTurma
            // 
            this.dataGridViewTurma.AllowUserToAddRows = false;
            this.dataGridViewTurma.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTurma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCodigoDisciplina,
            this.colNomeDisciplina,
            this.colCodigoProfessor,
            this.colNomeProfessor,
            this.colInstituicao_Fantasia,
            this.colSituacaoCurso});
            this.dataGridViewTurma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTurma.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTurma.Name = "dataGridViewTurma";
            this.dataGridViewTurma.ReadOnly = true;
            this.dataGridViewTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTurma.Size = new System.Drawing.Size(632, 273);
            this.dataGridViewTurma.TabIndex = 0;
            this.dataGridViewTurma.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTurma_CellFormatting);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 65;
            // 
            // colCodigoDisciplina
            // 
            this.colCodigoDisciplina.HeaderText = "Cód. Disciplina";
            this.colCodigoDisciplina.Name = "colCodigoDisciplina";
            this.colCodigoDisciplina.ReadOnly = true;
            this.colCodigoDisciplina.Width = 120;
            // 
            // colNomeDisciplina
            // 
            this.colNomeDisciplina.HeaderText = "Disciplina";
            this.colNomeDisciplina.Name = "colNomeDisciplina";
            this.colNomeDisciplina.ReadOnly = true;
            // 
            // colCodigoProfessor
            // 
            this.colCodigoProfessor.HeaderText = "Cód. Professor";
            this.colCodigoProfessor.Name = "colCodigoProfessor";
            this.colCodigoProfessor.ReadOnly = true;
            this.colCodigoProfessor.Width = 120;
            // 
            // colNomeProfessor
            // 
            this.colNomeProfessor.HeaderText = "Professor";
            this.colNomeProfessor.Name = "colNomeProfessor";
            this.colNomeProfessor.ReadOnly = true;
            // 
            // colInstituicao_Fantasia
            // 
            this.colInstituicao_Fantasia.HeaderText = "Instituição - Fantasia";
            this.colInstituicao_Fantasia.Name = "colInstituicao_Fantasia";
            this.colInstituicao_Fantasia.ReadOnly = true;
            this.colInstituicao_Fantasia.Width = 140;
            // 
            // colSituacaoCurso
            // 
            this.colSituacaoCurso.HeaderText = "Situação";
            this.colSituacaoCurso.Name = "colSituacaoCurso";
            this.colSituacaoCurso.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(573, 462);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(386, 462);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(202, 462);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.radioButtonNomeProfessor);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigoProfessor);
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNomeDisciplina);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigoDisciplina);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Location = new System.Drawing.Point(10, 12);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(638, 146);
            this.groupBoxConsultar.TabIndex = 0;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // radioButtonNomeProfessor
            // 
            this.radioButtonNomeProfessor.AutoSize = true;
            this.radioButtonNomeProfessor.Location = new System.Drawing.Point(373, 46);
            this.radioButtonNomeProfessor.Name = "radioButtonNomeProfessor";
            this.radioButtonNomeProfessor.Size = new System.Drawing.Size(69, 17);
            this.radioButtonNomeProfessor.TabIndex = 6;
            this.radioButtonNomeProfessor.Text = "Professor";
            this.radioButtonNomeProfessor.UseVisualStyleBackColor = true;
            this.radioButtonNomeProfessor.CheckedChanged += new System.EventHandler(this.radioButtonNomeProfessor_CheckedChanged);
            // 
            // radioButtonCodigoProfessor
            // 
            this.radioButtonCodigoProfessor.AutoSize = true;
            this.radioButtonCodigoProfessor.Location = new System.Drawing.Point(262, 46);
            this.radioButtonCodigoProfessor.Name = "radioButtonCodigoProfessor";
            this.radioButtonCodigoProfessor.Size = new System.Drawing.Size(105, 17);
            this.radioButtonCodigoProfessor.TabIndex = 5;
            this.radioButtonCodigoProfessor.Text = "Código Professor";
            this.radioButtonCodigoProfessor.UseVisualStyleBackColor = true;
            this.radioButtonCodigoProfessor.CheckedChanged += new System.EventHandler(this.radioButtonCodigoProfessor_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(557, 113);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPesquisar_KeyPress);
            // 
            // radioButtonNomeDisciplina
            // 
            this.radioButtonNomeDisciplina.AutoSize = true;
            this.radioButtonNomeDisciplina.Location = new System.Drawing.Point(186, 46);
            this.radioButtonNomeDisciplina.Name = "radioButtonNomeDisciplina";
            this.radioButtonNomeDisciplina.Size = new System.Drawing.Size(70, 17);
            this.radioButtonNomeDisciplina.TabIndex = 4;
            this.radioButtonNomeDisciplina.Text = "Disciplina";
            this.radioButtonNomeDisciplina.UseVisualStyleBackColor = true;
            this.radioButtonNomeDisciplina.CheckedChanged += new System.EventHandler(this.radioButtonNomeDisciplina_CheckedChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(72, 11);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(556, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(10, 18);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // radioButtonCodigoDisciplina
            // 
            this.radioButtonCodigoDisciplina.AutoSize = true;
            this.radioButtonCodigoDisciplina.Location = new System.Drawing.Point(74, 46);
            this.radioButtonCodigoDisciplina.Name = "radioButtonCodigoDisciplina";
            this.radioButtonCodigoDisciplina.Size = new System.Drawing.Size(106, 17);
            this.radioButtonCodigoDisciplina.TabIndex = 3;
            this.radioButtonCodigoDisciplina.Text = "Código Disciplina";
            this.radioButtonCodigoDisciplina.UseVisualStyleBackColor = true;
            this.radioButtonCodigoDisciplina.CheckedChanged += new System.EventHandler(this.radioButtonCodigoDisciplina_CheckedChanged);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Checked = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(10, 46);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 2;
            this.radioButtonCodigo.TabStop = true;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.CheckedChanged += new System.EventHandler(this.radioButtonCodigo_CheckedChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(121, 462);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(10, 467);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 2;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // btnVincularAlunos
            // 
            this.btnVincularAlunos.Location = new System.Drawing.Point(467, 462);
            this.btnVincularAlunos.Name = "btnVincularAlunos";
            this.btnVincularAlunos.Size = new System.Drawing.Size(100, 23);
            this.btnVincularAlunos.TabIndex = 8;
            this.btnVincularAlunos.Text = "Vincular Alunos";
            this.btnVincularAlunos.UseVisualStyleBackColor = true;
            this.btnVincularAlunos.Click += new System.EventHandler(this.btnVincularAlunos_Click);
            // 
            // FrmConsultarDisciplinasMinistradas
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 497);
            this.Controls.Add(this.btnVincularAlunos);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBoxTurma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBoxConsultar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblTotalRegistros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarDisciplinasMinistradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplinas Ministradas - Consultar";
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.groupBoxTurma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).EndInit();
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoCancelado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoFinalizado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoEmAndamento;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBoxTurma;
        private System.Windows.Forms.DataGridView dataGridViewTurma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioButtonNomeDisciplina;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.RadioButton radioButtonCodigoDisciplina;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.RadioButton radioButtonCodigoProfessor;
        private System.Windows.Forms.RadioButton radioButtonNomeProfessor;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstituicao_Fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacaoCurso;
        private System.Windows.Forms.Button btnVincularAlunos;
    }
}