
namespace SistemaAcademico
{
    partial class FrmConsultarTurmaPeriodo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarTurmaPeriodo));
            this.btnNovoPeriodo = new System.Windows.Forms.Button();
            this.lblTotalRegistrosTurma = new System.Windows.Forms.Label();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.dataGridViewPeriodo = new System.Windows.Forms.DataGridView();
            this.colCodigoPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeirodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataInicioPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFimPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDisciplina = new System.Windows.Forms.GroupBox();
            this.dataGridViewDisciplinaProfessor = new System.Windows.Forms.DataGridView();
            this.colSituacaoProfessorDisciplina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNomeProfessorDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codInstituicaoFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVincularDisciplina = new System.Windows.Forms.Button();
            this.lblTotalRegistroDisciplinaProfessor = new System.Windows.Forms.Label();
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.radioButtonPeriodo = new System.Windows.Forms.RadioButton();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.maskedTextBoxDataFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonCurso = new System.Windows.Forms.RadioButton();
            this.comboBoxPeriodo = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblTotalRegistroPeriodo = new System.Windows.Forms.Label();
            this.groupBoxTurma = new System.Windows.Forms.GroupBox();
            this.dataGridViewTurma = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.btnAtivarInativarDisciplina = new System.Windows.Forms.Button();
            this.btnConsultarAlunos = new System.Windows.Forms.Button();
            this.groupBoxAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeriodo)).BeginInit();
            this.groupBoxDisciplina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinaProfessor)).BeginInit();
            this.groupBoxConsultar.SuspendLayout();
            this.groupBoxTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).BeginInit();
            this.groupBoxSituacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoPeriodo
            // 
            this.btnNovoPeriodo.Location = new System.Drawing.Point(190, 527);
            this.btnNovoPeriodo.Name = "btnNovoPeriodo";
            this.btnNovoPeriodo.Size = new System.Drawing.Size(97, 23);
            this.btnNovoPeriodo.TabIndex = 11;
            this.btnNovoPeriodo.Text = "Novo Período";
            this.btnNovoPeriodo.UseVisualStyleBackColor = true;
            this.btnNovoPeriodo.Click += new System.EventHandler(this.btnNovoPeriodo_Click);
            // 
            // lblTotalRegistrosTurma
            // 
            this.lblTotalRegistrosTurma.AutoSize = true;
            this.lblTotalRegistrosTurma.Location = new System.Drawing.Point(14, 296);
            this.lblTotalRegistrosTurma.Name = "lblTotalRegistrosTurma";
            this.lblTotalRegistrosTurma.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistrosTurma.TabIndex = 6;
            this.lblTotalRegistrosTurma.Text = "Total Registro(s): 0";
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.dataGridViewPeriodo);
            this.groupBoxAluno.Location = new System.Drawing.Point(11, 317);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(428, 185);
            this.groupBoxAluno.TabIndex = 7;
            this.groupBoxAluno.TabStop = false;
            this.groupBoxAluno.Text = "Período";
            // 
            // dataGridViewPeriodo
            // 
            this.dataGridViewPeriodo.AllowUserToAddRows = false;
            this.dataGridViewPeriodo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPeriodo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeriodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoPeriodo,
            this.colPeirodo,
            this.colDataInicioPeriodo,
            this.colDataFimPeriodo,
            this.colSituacaoPeriodo});
            this.dataGridViewPeriodo.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPeriodo.Name = "dataGridViewPeriodo";
            this.dataGridViewPeriodo.ReadOnly = true;
            this.dataGridViewPeriodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeriodo.Size = new System.Drawing.Size(416, 160);
            this.dataGridViewPeriodo.TabIndex = 0;
            this.dataGridViewPeriodo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPeríodo_CellFormatting);
            this.dataGridViewPeriodo.SelectionChanged += new System.EventHandler(this.dataGridViewPeriodo_SelectionChanged);
            // 
            // colCodigoPeriodo
            // 
            this.colCodigoPeriodo.DataPropertyName = "Periodo.Codigo";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoPeriodo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigoPeriodo.HeaderText = "Código";
            this.colCodigoPeriodo.Name = "colCodigoPeriodo";
            this.colCodigoPeriodo.ReadOnly = true;
            // 
            // colPeirodo
            // 
            this.colPeirodo.DataPropertyName = "Periodo.Nome";
            this.colPeirodo.HeaderText = "Período";
            this.colPeirodo.Name = "colPeirodo";
            this.colPeirodo.ReadOnly = true;
            this.colPeirodo.Width = 140;
            // 
            // colDataInicioPeriodo
            // 
            this.colDataInicioPeriodo.DataPropertyName = "DataInicio";
            this.colDataInicioPeriodo.HeaderText = "Data Início";
            this.colDataInicioPeriodo.Name = "colDataInicioPeriodo";
            this.colDataInicioPeriodo.ReadOnly = true;
            // 
            // colDataFimPeriodo
            // 
            this.colDataFimPeriodo.DataPropertyName = "DataFim";
            this.colDataFimPeriodo.HeaderText = "Data Fim";
            this.colDataFimPeriodo.Name = "colDataFimPeriodo";
            this.colDataFimPeriodo.ReadOnly = true;
            // 
            // colSituacaoPeriodo
            // 
            this.colSituacaoPeriodo.DataPropertyName = "Situacao";
            this.colSituacaoPeriodo.HeaderText = "Situação";
            this.colSituacaoPeriodo.Name = "colSituacaoPeriodo";
            this.colSituacaoPeriodo.ReadOnly = true;
            // 
            // groupBoxDisciplina
            // 
            this.groupBoxDisciplina.Controls.Add(this.dataGridViewDisciplinaProfessor);
            this.groupBoxDisciplina.Location = new System.Drawing.Point(445, 316);
            this.groupBoxDisciplina.Name = "groupBoxDisciplina";
            this.groupBoxDisciplina.Size = new System.Drawing.Size(428, 185);
            this.groupBoxDisciplina.TabIndex = 8;
            this.groupBoxDisciplina.TabStop = false;
            this.groupBoxDisciplina.Text = "Disciplina/Professor";
            // 
            // dataGridViewDisciplinaProfessor
            // 
            this.dataGridViewDisciplinaProfessor.AllowUserToAddRows = false;
            this.dataGridViewDisciplinaProfessor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDisciplinaProfessor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDisciplinaProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplinaProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSituacaoProfessorDisciplina,
            this.colNomeProfessorDisciplina,
            this.colCodigoDisciplina,
            this.colSituacaoDisciplina,
            this.colDisciplina,
            this.colProfessor,
            this.codInstituicaoFantasia});
            this.dataGridViewDisciplinaProfessor.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewDisciplinaProfessor.Name = "dataGridViewDisciplinaProfessor";
            this.dataGridViewDisciplinaProfessor.ReadOnly = true;
            this.dataGridViewDisciplinaProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDisciplinaProfessor.Size = new System.Drawing.Size(416, 160);
            this.dataGridViewDisciplinaProfessor.TabIndex = 0;
            this.dataGridViewDisciplinaProfessor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDisciplinaProfessor_CellFormatting);
            // 
            // colSituacaoProfessorDisciplina
            // 
            this.colSituacaoProfessorDisciplina.DataPropertyName = "Situacao";
            this.colSituacaoProfessorDisciplina.HeaderText = "Situação";
            this.colSituacaoProfessorDisciplina.Name = "colSituacaoProfessorDisciplina";
            this.colSituacaoProfessorDisciplina.ReadOnly = true;
            this.colSituacaoProfessorDisciplina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSituacaoProfessorDisciplina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNomeProfessorDisciplina
            // 
            this.colNomeProfessorDisciplina.DataPropertyName = "PeriodoDisciplina.Disciplina.Nome";
            this.colNomeProfessorDisciplina.HeaderText = "Nome";
            this.colNomeProfessorDisciplina.Name = "colNomeProfessorDisciplina";
            this.colNomeProfessorDisciplina.ReadOnly = true;
            this.colNomeProfessorDisciplina.Width = 180;
            // 
            // colCodigoDisciplina
            // 
            this.colCodigoDisciplina.DataPropertyName = "PeriodoDisciplina.Disciplina.Codigo";
            this.colCodigoDisciplina.HeaderText = "Cód. Disciplina";
            this.colCodigoDisciplina.Name = "colCodigoDisciplina";
            this.colCodigoDisciplina.ReadOnly = true;
            // 
            // colSituacaoDisciplina
            // 
            this.colSituacaoDisciplina.DataPropertyName = "SituacaoDisciplina.Nome";
            this.colSituacaoDisciplina.HeaderText = "Situação Disciplina";
            this.colSituacaoDisciplina.Name = "colSituacaoDisciplina";
            this.colSituacaoDisciplina.ReadOnly = true;
            // 
            // colDisciplina
            // 
            this.colDisciplina.DataPropertyName = "PeriodoDisciplina.Disciplina.Nome";
            this.colDisciplina.HeaderText = "Disciplina";
            this.colDisciplina.Name = "colDisciplina";
            this.colDisciplina.ReadOnly = true;
            // 
            // colProfessor
            // 
            this.colProfessor.DataPropertyName = "PeriodoDisciplina.Professor.Nome";
            this.colProfessor.HeaderText = "Professor";
            this.colProfessor.Name = "colProfessor";
            this.colProfessor.ReadOnly = true;
            // 
            // codInstituicaoFantasia
            // 
            this.codInstituicaoFantasia.DataPropertyName = "TurmaPeriodo.Turma.Instituicao.NomeFantasia";
            this.codInstituicaoFantasia.HeaderText = "Instituicao - Fantasia";
            this.codInstituicaoFantasia.Name = "codInstituicaoFantasia";
            this.codInstituicaoFantasia.ReadOnly = true;
            this.codInstituicaoFantasia.Width = 150;
            // 
            // btnVincularDisciplina
            // 
            this.btnVincularDisciplina.Location = new System.Drawing.Point(293, 527);
            this.btnVincularDisciplina.Name = "btnVincularDisciplina";
            this.btnVincularDisciplina.Size = new System.Drawing.Size(101, 23);
            this.btnVincularDisciplina.TabIndex = 12;
            this.btnVincularDisciplina.Text = "Vincular Disciplina";
            this.btnVincularDisciplina.UseVisualStyleBackColor = true;
            this.btnVincularDisciplina.Click += new System.EventHandler(this.btnVincularDisciplina_Click);
            // 
            // lblTotalRegistroDisciplinaProfessor
            // 
            this.lblTotalRegistroDisciplinaProfessor.AutoSize = true;
            this.lblTotalRegistroDisciplinaProfessor.Location = new System.Drawing.Point(451, 499);
            this.lblTotalRegistroDisciplinaProfessor.Name = "lblTotalRegistroDisciplinaProfessor";
            this.lblTotalRegistroDisciplinaProfessor.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistroDisciplinaProfessor.TabIndex = 10;
            this.lblTotalRegistroDisciplinaProfessor.Text = "Total Registro(s): 0";
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.lblDataFim);
            this.groupBoxConsultar.Controls.Add(this.radioButtonPeriodo);
            this.groupBoxConsultar.Controls.Add(this.lblDataInicio);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxDataFim);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxDataInicio);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNome);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCurso);
            this.groupBoxConsultar.Location = new System.Drawing.Point(11, 12);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(632, 61);
            this.groupBoxConsultar.TabIndex = 0;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(468, 27);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 6;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // radioButtonPeriodo
            // 
            this.radioButtonPeriodo.AutoSize = true;
            this.radioButtonPeriodo.Location = new System.Drawing.Point(216, 25);
            this.radioButtonPeriodo.Name = "radioButtonPeriodo";
            this.radioButtonPeriodo.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPeriodo.TabIndex = 3;
            this.radioButtonPeriodo.Text = "Período";
            this.radioButtonPeriodo.UseVisualStyleBackColor = true;
            this.radioButtonPeriodo.CheckedChanged += new System.EventHandler(this.radioButtonPeriodo_CheckedChanged);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(317, 27);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 4;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // maskedTextBoxDataFim
            // 
            this.maskedTextBoxDataFim.Location = new System.Drawing.Point(526, 20);
            this.maskedTextBoxDataFim.Mask = "00/00/0000";
            this.maskedTextBoxDataFim.Name = "maskedTextBoxDataFim";
            this.maskedTextBoxDataFim.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxDataFim.TabIndex = 7;
            this.maskedTextBoxDataFim.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataFim.Leave += new System.EventHandler(this.maskedTextBoxDataFim_Leave);
            // 
            // maskedTextBoxDataInicio
            // 
            this.maskedTextBoxDataInicio.Location = new System.Drawing.Point(386, 20);
            this.maskedTextBoxDataInicio.Mask = "00/00/0000";
            this.maskedTextBoxDataInicio.Name = "maskedTextBoxDataInicio";
            this.maskedTextBoxDataInicio.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxDataInicio.TabIndex = 5;
            this.maskedTextBoxDataInicio.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataInicio.Leave += new System.EventHandler(this.maskedTextBoxDataInicio_Leave);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Checked = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(11, 25);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 0;
            this.radioButtonCodigo.TabStop = true;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.CheckedChanged += new System.EventHandler(this.radioButtonCodigo_CheckedChanged);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(83, 25);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 1;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // radioButtonCurso
            // 
            this.radioButtonCurso.AutoSize = true;
            this.radioButtonCurso.Location = new System.Drawing.Point(150, 25);
            this.radioButtonCurso.Name = "radioButtonCurso";
            this.radioButtonCurso.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCurso.TabIndex = 2;
            this.radioButtonCurso.Text = "Curso";
            this.radioButtonCurso.UseVisualStyleBackColor = true;
            this.radioButtonCurso.CheckedChanged += new System.EventHandler(this.radioButtonCurso_CheckedChanged);
            // 
            // comboBoxPeriodo
            // 
            this.comboBoxPeriodo.FormattingEnabled = true;
            this.comboBoxPeriodo.Location = new System.Drawing.Point(76, 80);
            this.comboBoxPeriodo.Name = "comboBoxPeriodo";
            this.comboBoxPeriodo.Size = new System.Drawing.Size(716, 21);
            this.comboBoxPeriodo.TabIndex = 3;
            this.comboBoxPeriodo.SelectedValueChanged += new System.EventHandler(this.comboBoxPeriodo_SelectedValueChanged);
            this.comboBoxPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPeriodo_KeyPress);
            this.comboBoxPeriodo.Leave += new System.EventHandler(this.comboBoxPeriodo_Leave);
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(153, 80);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(639, 21);
            this.comboBoxCurso.TabIndex = 5;
            this.comboBoxCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCurso_KeyPress);
            this.comboBoxCurso.Leave += new System.EventHandler(this.comboBoxCurso_Leave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(153, 81);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(639, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(798, 79);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(14, 84);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 2;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(637, 527);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar Período";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblTotalRegistroPeriodo
            // 
            this.lblTotalRegistroPeriodo.AutoSize = true;
            this.lblTotalRegistroPeriodo.Location = new System.Drawing.Point(17, 505);
            this.lblTotalRegistroPeriodo.Name = "lblTotalRegistroPeriodo";
            this.lblTotalRegistroPeriodo.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistroPeriodo.TabIndex = 9;
            this.lblTotalRegistroPeriodo.Text = "Total Registro(s): 0";
            // 
            // groupBoxTurma
            // 
            this.groupBoxTurma.Controls.Add(this.dataGridViewTurma);
            this.groupBoxTurma.Location = new System.Drawing.Point(11, 108);
            this.groupBoxTurma.Name = "groupBoxTurma";
            this.groupBoxTurma.Size = new System.Drawing.Size(862, 185);
            this.groupBoxTurma.TabIndex = 5;
            this.groupBoxTurma.TabStop = false;
            this.groupBoxTurma.Text = "Turma";
            // 
            // dataGridViewTurma
            // 
            this.dataGridViewTurma.AllowUserToAddRows = false;
            this.dataGridViewTurma.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTurma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colNomeFantasia,
            this.colCodigoCurso,
            this.colCurso,
            this.colDataInicio,
            this.colDataFim,
            this.colSituacao});
            this.dataGridViewTurma.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTurma.Name = "dataGridViewTurma";
            this.dataGridViewTurma.ReadOnly = true;
            this.dataGridViewTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTurma.Size = new System.Drawing.Size(850, 160);
            this.dataGridViewTurma.TabIndex = 0;
            this.dataGridViewTurma.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTurma_CellFormatting);
            this.dataGridViewTurma.SelectionChanged += new System.EventHandler(this.dataGridViewTurma_SelectionChanged);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 180;
            // 
            // colNomeFantasia
            // 
            this.colNomeFantasia.DataPropertyName = "Instituicao.NomeFantasia";
            this.colNomeFantasia.HeaderText = "Instituição - Fantasia";
            this.colNomeFantasia.Name = "colNomeFantasia";
            this.colNomeFantasia.ReadOnly = true;
            this.colNomeFantasia.Width = 150;
            // 
            // colCodigoCurso
            // 
            this.colCodigoCurso.DataPropertyName = "Curso.Codigo";
            this.colCodigoCurso.HeaderText = "Código Curso";
            this.colCodigoCurso.Name = "colCodigoCurso";
            this.colCodigoCurso.ReadOnly = true;
            // 
            // colCurso
            // 
            this.colCurso.DataPropertyName = "Curso.Nome";
            this.colCurso.HeaderText = "Curso";
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            // 
            // colDataInicio
            // 
            this.colDataInicio.DataPropertyName = "DataInicio";
            this.colDataInicio.HeaderText = "Data Início";
            this.colDataInicio.Name = "colDataInicio";
            this.colDataInicio.ReadOnly = true;
            // 
            // colDataFim
            // 
            this.colDataFim.DataPropertyName = "DataFim";
            this.colDataFim.HeaderText = "Data Fim";
            this.colDataFim.Name = "colDataFim";
            this.colDataFim.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.DataPropertyName = "SituacaoTurma.Nome";
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(718, 527);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(799, 527);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoInativo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoAtivo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(649, 12);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(224, 61);
            this.groupBoxSituacoes.TabIndex = 1;
            this.groupBoxSituacoes.TabStop = false;
            this.groupBoxSituacoes.Text = "Situação";
            // 
            // radioButtonSituacaoInativo
            // 
            this.radioButtonSituacaoInativo.AutoSize = true;
            this.radioButtonSituacaoInativo.Location = new System.Drawing.Point(153, 25);
            this.radioButtonSituacaoInativo.Name = "radioButtonSituacaoInativo";
            this.radioButtonSituacaoInativo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSituacaoInativo.TabIndex = 2;
            this.radioButtonSituacaoInativo.Text = "Inativo";
            this.radioButtonSituacaoInativo.UseVisualStyleBackColor = true;
            this.radioButtonSituacaoInativo.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoInativo_CheckedChanged);
            // 
            // radioButtonSituacaoAtivo
            // 
            this.radioButtonSituacaoAtivo.AutoSize = true;
            this.radioButtonSituacaoAtivo.Location = new System.Drawing.Point(90, 25);
            this.radioButtonSituacaoAtivo.Name = "radioButtonSituacaoAtivo";
            this.radioButtonSituacaoAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSituacaoAtivo.TabIndex = 1;
            this.radioButtonSituacaoAtivo.Text = "Ativo";
            this.radioButtonSituacaoAtivo.UseVisualStyleBackColor = true;
            this.radioButtonSituacaoAtivo.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoAtivo_CheckedChanged);
            // 
            // radioButtonSituacaoTodos
            // 
            this.radioButtonSituacaoTodos.AutoSize = true;
            this.radioButtonSituacaoTodos.Checked = true;
            this.radioButtonSituacaoTodos.Location = new System.Drawing.Point(21, 25);
            this.radioButtonSituacaoTodos.Name = "radioButtonSituacaoTodos";
            this.radioButtonSituacaoTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSituacaoTodos.TabIndex = 0;
            this.radioButtonSituacaoTodos.TabStop = true;
            this.radioButtonSituacaoTodos.Text = "Todos";
            this.radioButtonSituacaoTodos.UseVisualStyleBackColor = true;
            this.radioButtonSituacaoTodos.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoTodos_CheckedChanged);
            // 
            // btnAtivarInativarDisciplina
            // 
            this.btnAtivarInativarDisciplina.Location = new System.Drawing.Point(400, 527);
            this.btnAtivarInativarDisciplina.Name = "btnAtivarInativarDisciplina";
            this.btnAtivarInativarDisciplina.Size = new System.Drawing.Size(131, 23);
            this.btnAtivarInativarDisciplina.TabIndex = 13;
            this.btnAtivarInativarDisciplina.Text = "Ativar/Inativar Disciplina";
            this.btnAtivarInativarDisciplina.UseVisualStyleBackColor = true;
            this.btnAtivarInativarDisciplina.Click += new System.EventHandler(this.btnAtivarInativarDisciplina_Click);
            // 
            // btnConsultarAlunos
            // 
            this.btnConsultarAlunos.Location = new System.Drawing.Point(537, 527);
            this.btnConsultarAlunos.Name = "btnConsultarAlunos";
            this.btnConsultarAlunos.Size = new System.Drawing.Size(94, 23);
            this.btnConsultarAlunos.TabIndex = 17;
            this.btnConsultarAlunos.Text = "Consultar Alunos";
            this.btnConsultarAlunos.UseVisualStyleBackColor = true;
            this.btnConsultarAlunos.Click += new System.EventHandler(this.btnConsultarAlunos_Click);
            // 
            // FrmConsultarTurmaPeriodo
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 562);
            this.Controls.Add(this.btnConsultarAlunos);
            this.Controls.Add(this.btnAtivarInativarDisciplina);
            this.Controls.Add(this.groupBoxSituacoes);
            this.Controls.Add(this.btnNovoPeriodo);
            this.Controls.Add(this.comboBoxPeriodo);
            this.Controls.Add(this.lblTotalRegistrosTurma);
            this.Controls.Add(this.groupBoxAluno);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.groupBoxDisciplina);
            this.Controls.Add(this.btnVincularDisciplina);
            this.Controls.Add(this.lblTotalRegistroDisciplinaProfessor);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.groupBoxConsultar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblTotalRegistroPeriodo);
            this.Controls.Add(this.groupBoxTurma);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarTurmaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turma Periodo - Consultar";
            this.groupBoxAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeriodo)).EndInit();
            this.groupBoxDisciplina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplinaProfessor)).EndInit();
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.groupBoxTurma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).EndInit();
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoPeriodo;
        private System.Windows.Forms.Label lblTotalRegistrosTurma;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.GroupBox groupBoxDisciplina;
        private System.Windows.Forms.Button btnVincularDisciplina;
        private System.Windows.Forms.Label lblTotalRegistroDisciplinaProfessor;
        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.RadioButton radioButtonPeriodo;
        private System.Windows.Forms.ComboBox comboBoxPeriodo;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicio;
        private System.Windows.Forms.RadioButton radioButtonCurso;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblTotalRegistroPeriodo;
        private System.Windows.Forms.GroupBox groupBoxTurma;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridViewPeriodo;
        private System.Windows.Forms.DataGridView dataGridViewDisciplinaProfessor;
        private System.Windows.Forms.DataGridView dataGridViewTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeirodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataInicioPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFimPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacaoPeriodo;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.Button btnAtivarInativarDisciplina;
        private System.Windows.Forms.Button btnConsultarAlunos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacaoProfessorDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProfessorDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacaoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codInstituicaoFantasia;
    }
}