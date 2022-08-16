namespace SistemaAcademico
{
    partial class FrmConsultarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarTurma));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.maskedTextBoxDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.colCodigoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstituicaoFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaonoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.dataGridViewTurma = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.maskedTextBoxDataFim = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonCurso = new System.Windows.Forms.RadioButton();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoCancelado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoFinalizado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoEmAndamento = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxTurma = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovaTurma = new System.Windows.Forms.Button();
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.groupBoxAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).BeginInit();
            this.groupBoxSituacoes.SuspendLayout();
            this.groupBoxTurma.SuspendLayout();
            this.groupBoxConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(777, 99);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // maskedTextBoxDataInicio
            // 
            this.maskedTextBoxDataInicio.Location = new System.Drawing.Point(466, 71);
            this.maskedTextBoxDataInicio.Mask = "00/00/0000";
            this.maskedTextBoxDataInicio.Name = "maskedTextBoxDataInicio";
            this.maskedTextBoxDataInicio.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxDataInicio.TabIndex = 8;
            this.maskedTextBoxDataInicio.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataInicio.Leave += new System.EventHandler(this.maskedTextBoxDataInicio_Leave);
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.dataGridViewAluno);
            this.groupBoxAluno.Location = new System.Drawing.Point(10, 341);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(861, 165);
            this.groupBoxAluno.TabIndex = 3;
            this.groupBoxAluno.TabStop = false;
            this.groupBoxAluno.Text = "Aluno(s)";
            // 
            // dataGridViewAluno
            // 
            this.dataGridViewAluno.AllowUserToAddRows = false;
            this.dataGridViewAluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAluno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoAluno,
            this.colNomeAluno,
            this.colCPF,
            this.colMatricula,
            this.colInstituicaoFantasia,
            this.colSituacaonoCurso});
            this.dataGridViewAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAluno.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ReadOnly = true;
            this.dataGridViewAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAluno.Size = new System.Drawing.Size(855, 146);
            this.dataGridViewAluno.TabIndex = 0;
            this.dataGridViewAluno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAluno_CellFormatting);
            this.dataGridViewAluno.DoubleClick += new System.EventHandler(this.dataGridViewAluno_DoubleClick);
            // 
            // colCodigoAluno
            // 
            this.colCodigoAluno.DataPropertyName = "Aluno.Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoAluno.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigoAluno.HeaderText = "Código";
            this.colCodigoAluno.Name = "colCodigoAluno";
            this.colCodigoAluno.ReadOnly = true;
            this.colCodigoAluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigoAluno.Width = 80;
            // 
            // colNomeAluno
            // 
            this.colNomeAluno.DataPropertyName = "Aluno.Nome";
            this.colNomeAluno.HeaderText = "Nome";
            this.colNomeAluno.Name = "colNomeAluno";
            this.colNomeAluno.ReadOnly = true;
            this.colNomeAluno.Width = 232;
            // 
            // colCPF
            // 
            this.colCPF.DataPropertyName = "Aluno.Cpf";
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            // 
            // colMatricula
            // 
            this.colMatricula.DataPropertyName = "Aluno.Matricula";
            this.colMatricula.HeaderText = "Matrícula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.ReadOnly = true;
            // 
            // colInstituicaoFantasia
            // 
            this.colInstituicaoFantasia.DataPropertyName = "Turma.Instituicao.NomeFantasia";
            this.colInstituicaoFantasia.HeaderText = "Instituicao - Fantasia";
            this.colInstituicaoFantasia.Name = "colInstituicaoFantasia";
            this.colInstituicaoFantasia.ReadOnly = true;
            this.colInstituicaoFantasia.Width = 170;
            // 
            // colSituacaonoCurso
            // 
            this.colSituacaonoCurso.DataPropertyName = "SituacaoCurso.Nome";
            this.colSituacaonoCurso.FillWeight = 200F;
            this.colSituacaonoCurso.HeaderText = "Situação no Curso";
            this.colSituacaonoCurso.Name = "colSituacaonoCurso";
            this.colSituacaonoCurso.ReadOnly = true;
            this.colSituacaonoCurso.Width = 130;
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
            // dataGridViewTurma
            // 
            this.dataGridViewTurma.AllowUserToAddRows = false;
            this.dataGridViewTurma.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTurma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNomeTurma,
            this.colInstituicao,
            this.colCodigoCurso,
            this.colNomeCurso,
            this.colDataInicio,
            this.colDataFim,
            this.colSituacaoCurso});
            this.dataGridViewTurma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTurma.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTurma.Name = "dataGridViewTurma";
            this.dataGridViewTurma.ReadOnly = true;
            this.dataGridViewTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTurma.Size = new System.Drawing.Size(855, 146);
            this.dataGridViewTurma.TabIndex = 0;
            this.dataGridViewTurma.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTurma_CellFormatting);
            this.dataGridViewTurma.SelectionChanged += new System.EventHandler(this.dataGridViewTurma_SelectionChanged);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.ToolTipText = "Código";
            this.colCodigo.Width = 65;
            // 
            // colNomeTurma
            // 
            this.colNomeTurma.DataPropertyName = "Nome";
            this.colNomeTurma.HeaderText = "Nome";
            this.colNomeTurma.Name = "colNomeTurma";
            this.colNomeTurma.ReadOnly = true;
            this.colNomeTurma.ToolTipText = "Nome";
            this.colNomeTurma.Width = 154;
            // 
            // colInstituicao
            // 
            this.colInstituicao.DataPropertyName = "Instituicao.NomeFantasia";
            this.colInstituicao.HeaderText = "Instituição - Nome Fantasia";
            this.colInstituicao.Name = "colInstituicao";
            this.colInstituicao.ReadOnly = true;
            this.colInstituicao.ToolTipText = "Instituição";
            this.colInstituicao.Width = 160;
            // 
            // colCodigoCurso
            // 
            this.colCodigoCurso.DataPropertyName = "Curso.Codigo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoCurso.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCodigoCurso.HeaderText = "Código Curso";
            this.colCodigoCurso.Name = "colCodigoCurso";
            this.colCodigoCurso.ReadOnly = true;
            this.colCodigoCurso.ToolTipText = "Código Curso";
            // 
            // colNomeCurso
            // 
            this.colNomeCurso.DataPropertyName = "Curso.Nome";
            this.colNomeCurso.HeaderText = "Curso";
            this.colNomeCurso.Name = "colNomeCurso";
            this.colNomeCurso.ReadOnly = true;
            this.colNomeCurso.ToolTipText = "Curso";
            this.colNomeCurso.Width = 154;
            // 
            // colDataInicio
            // 
            this.colDataInicio.DataPropertyName = "DataInicio";
            this.colDataInicio.HeaderText = "Data Início";
            this.colDataInicio.Name = "colDataInicio";
            this.colDataInicio.ReadOnly = true;
            this.colDataInicio.ToolTipText = "Data Início";
            // 
            // colDataFim
            // 
            this.colDataFim.DataPropertyName = "DataFim";
            this.colDataFim.HeaderText = "Data Fim";
            this.colDataFim.Name = "colDataFim";
            this.colDataFim.ReadOnly = true;
            this.colDataFim.ToolTipText = "Data Fim";
            // 
            // colSituacaoCurso
            // 
            this.colSituacaoCurso.DataPropertyName = "SituacaoTurma.Nome";
            this.colSituacaoCurso.HeaderText = "Situacao";
            this.colSituacaoCurso.Name = "colSituacaoCurso";
            this.colSituacaoCurso.ReadOnly = true;
            this.colSituacaoCurso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSituacaoCurso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSituacaoCurso.ToolTipText = "Situacao";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(72, 11);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(783, 20);
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
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(590, 512);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(97, 23);
            this.btnAlunos.TabIndex = 9;
            this.btnAlunos.Text = "Aluno(s)";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(539, 78);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 9;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(402, 78);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 7;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // maskedTextBoxDataFim
            // 
            this.maskedTextBoxDataFim.Location = new System.Drawing.Point(597, 71);
            this.maskedTextBoxDataFim.Mask = "00/00/0000";
            this.maskedTextBoxDataFim.Name = "maskedTextBoxDataFim";
            this.maskedTextBoxDataFim.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxDataFim.TabIndex = 10;
            this.maskedTextBoxDataFim.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataFim.Leave += new System.EventHandler(this.maskedTextBoxDataFim_Leave);
            // 
            // radioButtonCurso
            // 
            this.radioButtonCurso.AutoSize = true;
            this.radioButtonCurso.Location = new System.Drawing.Point(133, 46);
            this.radioButtonCurso.Name = "radioButtonCurso";
            this.radioButtonCurso.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCurso.TabIndex = 4;
            this.radioButtonCurso.Text = "Curso";
            this.radioButtonCurso.UseVisualStyleBackColor = true;
            this.radioButtonCurso.CheckedChanged += new System.EventHandler(this.radioButtonCurso_CheckedChanged);
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(191, 44);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(474, 21);
            this.comboBoxCurso.TabIndex = 5;
            this.comboBoxCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCurso_KeyPress);
            this.comboBoxCurso.Leave += new System.EventHandler(this.comboBoxCurso_Leave);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(74, 46);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 3;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNomeAluno_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Registro(s): 0";
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoCancelado);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoFinalizado);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoEmAndamento);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(671, 37);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(181, 56);
            this.groupBoxSituacoes.TabIndex = 6;
            this.groupBoxSituacoes.TabStop = false;
            this.groupBoxSituacoes.Text = "Situação";
            // 
            // radioButtonSituacaoCancelado
            // 
            this.radioButtonSituacaoCancelado.AutoSize = true;
            this.radioButtonSituacaoCancelado.Location = new System.Drawing.Point(78, 34);
            this.radioButtonSituacaoCancelado.Name = "radioButtonSituacaoCancelado";
            this.radioButtonSituacaoCancelado.Size = new System.Drawing.Size(76, 17);
            this.radioButtonSituacaoCancelado.TabIndex = 3;
            this.radioButtonSituacaoCancelado.Text = "Cancelado";
            this.radioButtonSituacaoCancelado.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoFinalizado
            // 
            this.radioButtonSituacaoFinalizado.AutoSize = true;
            this.radioButtonSituacaoFinalizado.Location = new System.Drawing.Point(6, 34);
            this.radioButtonSituacaoFinalizado.Name = "radioButtonSituacaoFinalizado";
            this.radioButtonSituacaoFinalizado.Size = new System.Drawing.Size(72, 17);
            this.radioButtonSituacaoFinalizado.TabIndex = 2;
            this.radioButtonSituacaoFinalizado.Text = "Finalizado";
            this.radioButtonSituacaoFinalizado.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoEmAndamento
            // 
            this.radioButtonSituacaoEmAndamento.AutoSize = true;
            this.radioButtonSituacaoEmAndamento.Location = new System.Drawing.Point(78, 15);
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
            this.radioButtonSituacaoTodos.Location = new System.Drawing.Point(6, 15);
            this.radioButtonSituacaoTodos.Name = "radioButtonSituacaoTodos";
            this.radioButtonSituacaoTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSituacaoTodos.TabIndex = 0;
            this.radioButtonSituacaoTodos.TabStop = true;
            this.radioButtonSituacaoTodos.Text = "Todos";
            this.radioButtonSituacaoTodos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Alterar Situação";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxTurma
            // 
            this.groupBoxTurma.Controls.Add(this.dataGridViewTurma);
            this.groupBoxTurma.Location = new System.Drawing.Point(10, 147);
            this.groupBoxTurma.Name = "groupBoxTurma";
            this.groupBoxTurma.Size = new System.Drawing.Size(861, 165);
            this.groupBoxTurma.TabIndex = 1;
            this.groupBoxTurma.TabStop = false;
            this.groupBoxTurma.Text = "Turma";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(796, 512);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(509, 512);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovaTurma
            // 
            this.btnNovaTurma.Location = new System.Drawing.Point(325, 512);
            this.btnNovaTurma.Name = "btnNovaTurma";
            this.btnNovaTurma.Size = new System.Drawing.Size(97, 23);
            this.btnNovaTurma.TabIndex = 6;
            this.btnNovaTurma.Text = "Nova Turma";
            this.btnNovaTurma.UseVisualStyleBackColor = true;
            this.btnNovaTurma.Click += new System.EventHandler(this.btnNovaTurma_Click);
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.comboBoxCurso);
            this.groupBoxConsultar.Controls.Add(this.lblDataFim);
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblDataInicio);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCurso);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxDataFim);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxDataInicio);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNome);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Location = new System.Drawing.Point(10, 11);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(861, 130);
            this.groupBoxConsultar.TabIndex = 0;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(244, 512);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(428, 512);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(10, 315);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 2;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // FrmConsultarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 547);
            this.Controls.Add(this.groupBoxAluno);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxTurma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovaTurma);
            this.Controls.Add(this.groupBoxConsultar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblTotalRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turma - Consultar";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmConsultarTurma_KeyPress);
            this.groupBoxAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurma)).EndInit();
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.groupBoxTurma.ResumeLayout(false);
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicio;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.DataGridView dataGridViewTurma;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFim;
        private System.Windows.Forms.RadioButton radioButtonCurso;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoCancelado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoFinalizado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoEmAndamento;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxTurma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovaTurma;
        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacaoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstituicaoFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacaonoCurso;
    }
}