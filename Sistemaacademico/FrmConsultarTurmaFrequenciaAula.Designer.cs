namespace SistemaAcademico
{
    partial class FrmConsultarTurmaFrequenciaAula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.lblTotalRegistrosAulas = new System.Windows.Forms.Label();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoCancelado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoFinalizado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoEmAndamento = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBoxTurma = new System.Windows.Forms.GroupBox();
            this.dataGridViewDisciplina = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstituicao_Fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLancarAula = new System.Windows.Forms.Button();
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.radioButtonProfessor = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxDataFim = new System.Windows.Forms.MaskedTextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.radioButtonDisciplina = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblTotalRegistrosDisciplinas = new System.Windows.Forms.Label();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.dataGridViewAulas = new System.Windows.Forms.DataGridView();
            this.colCodigoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdAulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdAlunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdAusentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvaliacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colConteudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabelVerificarPendencias = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSituacoes.SuspendLayout();
            this.groupBoxTurma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplina)).BeginInit();
            this.groupBoxConsultar.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(363, 38);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 9;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // lblTotalRegistrosAulas
            // 
            this.lblTotalRegistrosAulas.AutoSize = true;
            this.lblTotalRegistrosAulas.Location = new System.Drawing.Point(-2, 475);
            this.lblTotalRegistrosAulas.Name = "lblTotalRegistrosAulas";
            this.lblTotalRegistrosAulas.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistrosAulas.TabIndex = 16;
            this.lblTotalRegistrosAulas.Text = "Total Registro(s): 0";
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoCancelado);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoFinalizado);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoEmAndamento);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(539, 44);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(220, 56);
            this.groupBoxSituacoes.TabIndex = 6;
            this.groupBoxSituacoes.TabStop = false;
            this.groupBoxSituacoes.Text = "Situação";
            // 
            // radioButtonSituacaoCancelado
            // 
            this.radioButtonSituacaoCancelado.AutoSize = true;
            this.radioButtonSituacaoCancelado.Location = new System.Drawing.Point(106, 34);
            this.radioButtonSituacaoCancelado.Name = "radioButtonSituacaoCancelado";
            this.radioButtonSituacaoCancelado.Size = new System.Drawing.Size(76, 17);
            this.radioButtonSituacaoCancelado.TabIndex = 3;
            this.radioButtonSituacaoCancelado.Text = "Cancelado";
            this.radioButtonSituacaoCancelado.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoFinalizado
            // 
            this.radioButtonSituacaoFinalizado.AutoSize = true;
            this.radioButtonSituacaoFinalizado.Location = new System.Drawing.Point(34, 34);
            this.radioButtonSituacaoFinalizado.Name = "radioButtonSituacaoFinalizado";
            this.radioButtonSituacaoFinalizado.Size = new System.Drawing.Size(72, 17);
            this.radioButtonSituacaoFinalizado.TabIndex = 2;
            this.radioButtonSituacaoFinalizado.Text = "Finalizado";
            this.radioButtonSituacaoFinalizado.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoEmAndamento
            // 
            this.radioButtonSituacaoEmAndamento.AutoSize = true;
            this.radioButtonSituacaoEmAndamento.Checked = true;
            this.radioButtonSituacaoEmAndamento.Location = new System.Drawing.Point(106, 15);
            this.radioButtonSituacaoEmAndamento.Name = "radioButtonSituacaoEmAndamento";
            this.radioButtonSituacaoEmAndamento.Size = new System.Drawing.Size(97, 17);
            this.radioButtonSituacaoEmAndamento.TabIndex = 1;
            this.radioButtonSituacaoEmAndamento.TabStop = true;
            this.radioButtonSituacaoEmAndamento.Text = "Em Andamento";
            this.radioButtonSituacaoEmAndamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoTodos
            // 
            this.radioButtonSituacaoTodos.AutoSize = true;
            this.radioButtonSituacaoTodos.Location = new System.Drawing.Point(34, 15);
            this.radioButtonSituacaoTodos.Name = "radioButtonSituacaoTodos";
            this.radioButtonSituacaoTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSituacaoTodos.TabIndex = 0;
            this.radioButtonSituacaoTodos.Text = "Todos";
            this.radioButtonSituacaoTodos.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(388, 478);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBoxTurma
            // 
            this.groupBoxTurma.Controls.Add(this.dataGridViewDisciplina);
            this.groupBoxTurma.Location = new System.Drawing.Point(1, 123);
            this.groupBoxTurma.Name = "groupBoxTurma";
            this.groupBoxTurma.Size = new System.Drawing.Size(765, 165);
            this.groupBoxTurma.TabIndex = 13;
            this.groupBoxTurma.TabStop = false;
            this.groupBoxTurma.Text = "Disciplina";
            // 
            // dataGridViewDisciplina
            // 
            this.dataGridViewDisciplina.AllowUserToAddRows = false;
            this.dataGridViewDisciplina.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCodigoDisciplina,
            this.colNomeDisciplina,
            this.colCodigoProfessor,
            this.colNomeProfessor,
            this.colInstituicao_Fantasia,
            this.colSituacaoCurso});
            this.dataGridViewDisciplina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisciplina.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDisciplina.Name = "dataGridViewDisciplina";
            this.dataGridViewDisciplina.ReadOnly = true;
            this.dataGridViewDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDisciplina.Size = new System.Drawing.Size(759, 146);
            this.dataGridViewDisciplina.TabIndex = 1;
            this.dataGridViewDisciplina.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDisciplina_CellFormatting);
            this.dataGridViewDisciplina.SelectionChanged += new System.EventHandler(this.dataGridViewDisciplina_SelectionChanged);
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
            this.btnSair.Location = new System.Drawing.Point(676, 478);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 23);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(484, 478);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLancarAula
            // 
            this.btnLancarAula.Location = new System.Drawing.Point(292, 478);
            this.btnLancarAula.Name = "btnLancarAula";
            this.btnLancarAula.Size = new System.Drawing.Size(90, 23);
            this.btnLancarAula.TabIndex = 18;
            this.btnLancarAula.Text = "Lançar Aula";
            this.btnLancarAula.UseVisualStyleBackColor = true;
            this.btnLancarAula.Click += new System.EventHandler(this.btnLancarAula_Click);
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.lblDataFim);
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblDataInicio);
            this.groupBoxConsultar.Controls.Add(this.radioButtonProfessor);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxDataFim);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxDataInicio);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Controls.Add(this.radioButtonDisciplina);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Location = new System.Drawing.Point(-2, 11);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(765, 106);
            this.groupBoxConsultar.TabIndex = 12;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(443, 75);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 23);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(228, 38);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 7;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // radioButtonProfessor
            // 
            this.radioButtonProfessor.AutoSize = true;
            this.radioButtonProfessor.Location = new System.Drawing.Point(153, 36);
            this.radioButtonProfessor.Name = "radioButtonProfessor";
            this.radioButtonProfessor.Size = new System.Drawing.Size(69, 17);
            this.radioButtonProfessor.TabIndex = 4;
            this.radioButtonProfessor.Text = "Professor";
            this.radioButtonProfessor.UseVisualStyleBackColor = true;
            this.radioButtonProfessor.CheckedChanged += new System.EventHandler(this.radioButtonProfessor_CheckedChanged);
            // 
            // maskedTextBoxDataFim
            // 
            this.maskedTextBoxDataFim.Location = new System.Drawing.Point(421, 35);
            this.maskedTextBoxDataFim.Mask = "00/00/0000";
            this.maskedTextBoxDataFim.Name = "maskedTextBoxDataFim";
            this.maskedTextBoxDataFim.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBoxDataFim.TabIndex = 10;
            this.maskedTextBoxDataFim.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataFim.Leave += new System.EventHandler(this.maskedTextBoxDataFim_Leave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(76, 9);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(686, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // maskedTextBoxDataInicio
            // 
            this.maskedTextBoxDataInicio.Location = new System.Drawing.Point(297, 35);
            this.maskedTextBoxDataInicio.Mask = "00/00/0000";
            this.maskedTextBoxDataInicio.Name = "maskedTextBoxDataInicio";
            this.maskedTextBoxDataInicio.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBoxDataInicio.TabIndex = 8;
            this.maskedTextBoxDataInicio.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataInicio.Leave += new System.EventHandler(this.maskedTextBoxDataInicio_Leave);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(14, 16);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // radioButtonDisciplina
            // 
            this.radioButtonDisciplina.AutoSize = true;
            this.radioButtonDisciplina.Location = new System.Drawing.Point(77, 36);
            this.radioButtonDisciplina.Name = "radioButtonDisciplina";
            this.radioButtonDisciplina.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDisciplina.TabIndex = 3;
            this.radioButtonDisciplina.Text = "Disciplina";
            this.radioButtonDisciplina.UseVisualStyleBackColor = true;
            this.radioButtonDisciplina.CheckedChanged += new System.EventHandler(this.radioButtonDisciplina_CheckedChanged);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Checked = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(13, 36);
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
            this.btnExibir.Location = new System.Drawing.Point(580, 478);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(90, 23);
            this.btnExibir.TabIndex = 17;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblTotalRegistrosDisciplinas
            // 
            this.lblTotalRegistrosDisciplinas.AutoSize = true;
            this.lblTotalRegistrosDisciplinas.Location = new System.Drawing.Point(-2, 291);
            this.lblTotalRegistrosDisciplinas.Name = "lblTotalRegistrosDisciplinas";
            this.lblTotalRegistrosDisciplinas.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistrosDisciplinas.TabIndex = 14;
            this.lblTotalRegistrosDisciplinas.Text = "Total Registro(s): 0";
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.dataGridViewAulas);
            this.groupBoxAluno.Location = new System.Drawing.Point(1, 307);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(765, 165);
            this.groupBoxAluno.TabIndex = 15;
            this.groupBoxAluno.TabStop = false;
            this.groupBoxAluno.Text = "Listagem das Aulas";
            // 
            // dataGridViewAulas
            // 
            this.dataGridViewAulas.AllowUserToAddRows = false;
            this.dataGridViewAulas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAulas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoAluno,
            this.colData,
            this.colQtdAulas,
            this.colQtdAlunos,
            this.colQtdAusentes,
            this.colAvaliacao,
            this.colConteudo});
            this.dataGridViewAulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAulas.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAulas.Name = "dataGridViewAulas";
            this.dataGridViewAulas.ReadOnly = true;
            this.dataGridViewAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAulas.Size = new System.Drawing.Size(759, 146);
            this.dataGridViewAulas.TabIndex = 0;
            this.dataGridViewAulas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAulas_CellFormatting);
            // 
            // colCodigoAluno
            // 
            this.colCodigoAluno.DataPropertyName = "Codigo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Format = "#,##0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoAluno.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCodigoAluno.HeaderText = "Código";
            this.colCodigoAluno.Name = "colCodigoAluno";
            this.colCodigoAluno.ReadOnly = true;
            this.colCodigoAluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigoAluno.Width = 80;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "Data";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colData.DefaultCellStyle = dataGridViewCellStyle5;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 80;
            // 
            // colQtdAulas
            // 
            this.colQtdAulas.DataPropertyName = "QuantidadeAulas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.colQtdAulas.DefaultCellStyle = dataGridViewCellStyle6;
            this.colQtdAulas.HeaderText = "Qtd. Aulas";
            this.colQtdAulas.Name = "colQtdAulas";
            this.colQtdAulas.ReadOnly = true;
            // 
            // colQtdAlunos
            // 
            this.colQtdAlunos.DataPropertyName = "QuantidadeAlunos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.colQtdAlunos.DefaultCellStyle = dataGridViewCellStyle7;
            this.colQtdAlunos.HeaderText = "Qtd. Alunos";
            this.colQtdAlunos.Name = "colQtdAlunos";
            this.colQtdAlunos.ReadOnly = true;
            // 
            // colQtdAusentes
            // 
            this.colQtdAusentes.DataPropertyName = "QuantidadeAusentes";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.colQtdAusentes.DefaultCellStyle = dataGridViewCellStyle8;
            this.colQtdAusentes.HeaderText = "Qtd. Ausentes";
            this.colQtdAusentes.Name = "colQtdAusentes";
            this.colQtdAusentes.ReadOnly = true;
            // 
            // colAvaliacao
            // 
            this.colAvaliacao.DataPropertyName = "Avaliacao";
            this.colAvaliacao.FillWeight = 200F;
            this.colAvaliacao.HeaderText = "Avaliação?";
            this.colAvaliacao.Name = "colAvaliacao";
            this.colAvaliacao.ReadOnly = true;
            this.colAvaliacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAvaliacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colConteudo
            // 
            this.colConteudo.DataPropertyName = "ConteudoVivenciado";
            this.colConteudo.HeaderText = "Conteúdo Vivenciado";
            this.colConteudo.Name = "colConteudo";
            this.colConteudo.ReadOnly = true;
            this.colConteudo.Width = 200;
            // 
            // linkLabelVerificarPendencias
            // 
            this.linkLabelVerificarPendencias.AutoSize = true;
            this.linkLabelVerificarPendencias.Location = new System.Drawing.Point(109, 483);
            this.linkLabelVerificarPendencias.Name = "linkLabelVerificarPendencias";
            this.linkLabelVerificarPendencias.Size = new System.Drawing.Size(177, 13);
            this.linkLabelVerificarPendencias.TabIndex = 24;
            this.linkLabelVerificarPendencias.TabStop = true;
            this.linkLabelVerificarPendencias.Text = "Verificar Pendências nas Disciplinas";
            this.toolTip1.SetToolTip(this.linkLabelVerificarPendencias, "Verificar se existem alunos disponíveis sem registro de aula, sendo lançado como " +
        "falta.");
            this.linkLabelVerificarPendencias.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVerificarPendencias_LinkClicked);
            // 
            // FrmConsultarTurmaFrequenciaAula
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 511);
            this.Controls.Add(this.linkLabelVerificarPendencias);
            this.Controls.Add(this.lblTotalRegistrosAulas);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBoxTurma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLancarAula);
            this.Controls.Add(this.groupBoxConsultar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblTotalRegistrosDisciplinas);
            this.Controls.Add(this.groupBoxAluno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarTurmaFrequenciaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar - Frequencia - Disciplina";
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.groupBoxTurma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplina)).EndInit();
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.groupBoxAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblTotalRegistrosAulas;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoCancelado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoFinalizado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoEmAndamento;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBoxTurma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLancarAula;
        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.RadioButton radioButtonProfessor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFim;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicio;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.RadioButton radioButtonDisciplina;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblTotalRegistrosDisciplinas;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.DataGridView dataGridViewAulas;
        private System.Windows.Forms.DataGridView dataGridViewDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstituicao_Fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacaoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdAusentes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAvaliacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConteudo;
        private System.Windows.Forms.LinkLabel linkLabelVerificarPendencias;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}