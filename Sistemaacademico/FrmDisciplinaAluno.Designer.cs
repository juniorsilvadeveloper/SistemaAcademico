namespace SistemaAcademico
{
    partial class FrmDisciplinaAluno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisciplinaAluno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtPesquisarMatricula = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.colCodigoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMediaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoEmAndamento = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoCancelado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoFinalizado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtInstituicao = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigoPeriodo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.txtCodigoDisciplina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome: *";
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(756, 298);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(13, 13);
            this.btnRemover.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRemover, "Remover");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(355, 19);
            this.txtPesquisarNome.MaxLength = 300;
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(411, 20);
            this.txtPesquisarNome.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(675, 500);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(144, 23);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(62, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula: *";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(55, 20);
            this.maskedTextBoxCPF.Mask = "###.###.###-##";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBoxCPF.TabIndex = 1;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 22);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 13);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF: *";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(756, 275);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(13, 13);
            this.btnAdicionar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAdicionar, "Adicionar");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtPesquisarMatricula
            // 
            this.txtPesquisarMatricula.Location = new System.Drawing.Point(212, 19);
            this.txtPesquisarMatricula.MaxLength = 100;
            this.txtPesquisarMatricula.Name = "txtPesquisarMatricula";
            this.txtPesquisarMatricula.Size = new System.Drawing.Size(86, 20);
            this.txtPesquisarMatricula.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPesquisarMatricula);
            this.groupBox3.Controls.Add(this.txtPesquisarNome);
            this.groupBox3.Controls.Add(this.lblMatricula);
            this.groupBox3.Controls.Add(this.maskedTextBoxCPF);
            this.groupBox3.Controls.Add(this.lblCPF);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
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
            this.ColMediaFinal,
            this.ColFrequencia,
            this.ColSituacao});
            this.dataGridViewAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAluno.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ReadOnly = true;
            this.dataGridViewAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAluno.Size = new System.Drawing.Size(732, 216);
            this.dataGridViewAluno.TabIndex = 0;
            this.dataGridViewAluno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAluno_CellFormatting);
            this.dataGridViewAluno.SelectionChanged += new System.EventHandler(this.dataGridViewAluno_SelectionChanged);
            this.dataGridViewAluno.Click += new System.EventHandler(this.dataGridViewAluno_Click);
            // 
            // colCodigoAluno
            // 
            this.colCodigoAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
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
            this.colCodigoAluno.Width = 65;
            // 
            // colNomeAluno
            // 
            this.colNomeAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeAluno.DataPropertyName = "Aluno.Nome";
            this.colNomeAluno.HeaderText = "Nome";
            this.colNomeAluno.Name = "colNomeAluno";
            this.colNomeAluno.ReadOnly = true;
            // 
            // colCPF
            // 
            this.colCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCPF.DataPropertyName = "Aluno.Cpf";
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            this.colCPF.Width = 52;
            // 
            // colMatricula
            // 
            this.colMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMatricula.DataPropertyName = "Aluno.Matricula";
            this.colMatricula.HeaderText = "Matrícula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.ReadOnly = true;
            this.colMatricula.Width = 77;
            // 
            // ColMediaFinal
            // 
            this.ColMediaFinal.DataPropertyName = "MediaFinal";
            this.ColMediaFinal.HeaderText = "Média Final";
            this.ColMediaFinal.Name = "ColMediaFinal";
            this.ColMediaFinal.ReadOnly = true;
            // 
            // ColFrequencia
            // 
            this.ColFrequencia.DataPropertyName = "Frequencia";
            this.ColFrequencia.HeaderText = "Frequência";
            this.ColFrequencia.Name = "ColFrequencia";
            this.ColFrequencia.ReadOnly = true;
            // 
            // ColSituacao
            // 
            this.ColSituacao.DataPropertyName = "SituacaoDisciplina.Nome";
            this.ColSituacao.HeaderText = "Situação";
            this.ColSituacao.Name = "ColSituacao";
            this.ColSituacao.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTurno);
            this.groupBox1.Controls.Add(this.txtInstituicao);
            this.groupBox1.Controls.Add(this.txtCurso);
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Controls.Add(this.lblCurso);
            this.groupBox1.Controls.Add(this.lblInstituicao);
            this.groupBox1.Controls.Add(this.txtPeriodo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtCodigoPeriodo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSituacaoEmAndamento);
            this.groupBox2.Controls.Add(this.radioButtonSituacaoCancelado);
            this.groupBox2.Controls.Add(this.radioButtonSituacaoFinalizado);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(498, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 35);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonSituacaoEmAndamento
            // 
            this.radioButtonSituacaoEmAndamento.AutoSize = true;
            this.radioButtonSituacaoEmAndamento.Checked = true;
            this.radioButtonSituacaoEmAndamento.Location = new System.Drawing.Point(6, 12);
            this.radioButtonSituacaoEmAndamento.Name = "radioButtonSituacaoEmAndamento";
            this.radioButtonSituacaoEmAndamento.Size = new System.Drawing.Size(97, 17);
            this.radioButtonSituacaoEmAndamento.TabIndex = 0;
            this.radioButtonSituacaoEmAndamento.TabStop = true;
            this.radioButtonSituacaoEmAndamento.Text = "Em Andamento";
            this.radioButtonSituacaoEmAndamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoCancelado
            // 
            this.radioButtonSituacaoCancelado.AutoSize = true;
            this.radioButtonSituacaoCancelado.Location = new System.Drawing.Point(187, 12);
            this.radioButtonSituacaoCancelado.Name = "radioButtonSituacaoCancelado";
            this.radioButtonSituacaoCancelado.Size = new System.Drawing.Size(76, 17);
            this.radioButtonSituacaoCancelado.TabIndex = 2;
            this.radioButtonSituacaoCancelado.Text = "Cancelado";
            this.radioButtonSituacaoCancelado.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoFinalizado
            // 
            this.radioButtonSituacaoFinalizado.AutoSize = true;
            this.radioButtonSituacaoFinalizado.Location = new System.Drawing.Point(109, 12);
            this.radioButtonSituacaoFinalizado.Name = "radioButtonSituacaoFinalizado";
            this.radioButtonSituacaoFinalizado.Size = new System.Drawing.Size(72, 17);
            this.radioButtonSituacaoFinalizado.TabIndex = 1;
            this.radioButtonSituacaoFinalizado.Text = "Finalizado";
            this.radioButtonSituacaoFinalizado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Turno:";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(323, 52);
            this.txtTurno.MaxLength = 300;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(111, 20);
            this.txtTurno.TabIndex = 9;
            // 
            // txtInstituicao
            // 
            this.txtInstituicao.Location = new System.Drawing.Point(498, 20);
            this.txtInstituicao.MaxLength = 300;
            this.txtInstituicao.Name = "txtInstituicao";
            this.txtInstituicao.ReadOnly = true;
            this.txtInstituicao.Size = new System.Drawing.Size(272, 20);
            this.txtInstituicao.TabIndex = 5;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(55, 52);
            this.txtCurso.MaxLength = 300;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(218, 20);
            this.txtCurso.TabIndex = 7;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(435, 55);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(59, 13);
            this.lblSituacao.TabIndex = 10;
            this.lblSituacao.Text = "Situação: *";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(9, 55);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(40, 13);
            this.lblCurso.TabIndex = 6;
            this.lblCurso.Text = "Curso: ";
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Location = new System.Drawing.Point(450, 23);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(42, 13);
            this.lblInstituicao.TabIndex = 4;
            this.lblInstituicao.Text = "Instit.: *";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(183, 83);
            this.txtPeriodo.MaxLength = 300;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(251, 20);
            this.txtPeriodo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 20);
            this.txtNome.MaxLength = 300;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(251, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Período:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(132, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome: *";
            // 
            // txtCodigoPeriodo
            // 
            this.txtCodigoPeriodo.Enabled = false;
            this.txtCodigoPeriodo.Location = new System.Drawing.Point(55, 83);
            this.txtCodigoPeriodo.Name = "txtCodigoPeriodo";
            this.txtCodigoPeriodo.ReadOnly = true;
            this.txtCodigoPeriodo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoPeriodo.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "C. Per.:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.dataGridViewAluno);
            this.groupBoxAluno.Location = new System.Drawing.Point(12, 259);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(738, 235);
            this.groupBoxAluno.TabIndex = 3;
            this.groupBoxAluno.TabStop = false;
            this.groupBoxAluno.Text = "Aluno(s)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtProfessor);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDisciplina);
            this.groupBox4.Controls.Add(this.txtCodigoDisciplina);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 56);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Período e Disciplina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Professor:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(498, 19);
            this.txtProfessor.MaxLength = 300;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(268, 20);
            this.txtProfessor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Disciplina:";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(217, 19);
            this.txtDisciplina.MaxLength = 300;
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.ReadOnly = true;
            this.txtDisciplina.Size = new System.Drawing.Size(217, 20);
            this.txtDisciplina.TabIndex = 7;
            // 
            // txtCodigoDisciplina
            // 
            this.txtCodigoDisciplina.Location = new System.Drawing.Point(85, 19);
            this.txtCodigoDisciplina.MaxLength = 300;
            this.txtCodigoDisciplina.Name = "txtCodigoDisciplina";
            this.txtCodigoDisciplina.ReadOnly = true;
            this.txtCodigoDisciplina.Size = new System.Drawing.Size(61, 20);
            this.txtCodigoDisciplina.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cód. Disciplina:";
            // 
            // FrmDisciplinaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.groupBoxAluno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisciplinaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disciplina - Aluno";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxAluno.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtPesquisarMatricula;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSituacaoEmAndamento;
        private System.Windows.Forms.RadioButton radioButtonSituacaoCancelado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoFinalizado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtInstituicao;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.TextBox txtCodigoDisciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoPeriodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMediaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSituacao;
    }
}