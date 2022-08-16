
namespace SistemaAcademico
{
    partial class FrmTurmaPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurmaPeriodo));
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.txtNomeUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.lblUsuarioAlterou = new System.Windows.Forms.Label();
            this.btnAdicionarTurma = new System.Windows.Forms.Button();
            this.btnAdicionarPeriodo = new System.Windows.Forms.Button();
            this.comboBoxPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAdicionarInstituicao = new System.Windows.Forms.Button();
            this.maskedTextBoxDataFim = new System.Windows.Forms.MaskedTextBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            this.checkBoxAluno = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDataAlteracao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.comboBoxTurma = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxInstituicao = new System.Windows.Forms.ComboBox();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.checkBoxSecretariado = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxProfessor = new System.Windows.Forms.CheckBox();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabPageAluno = new System.Windows.Forms.TabPage();
            this.tabControlAluno = new System.Windows.Forms.TabControl();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.tabPage2.SuspendLayout();
            this.tabPageAluno.SuspendLayout();
            this.tabControlAluno.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(220, 40);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(81, 13);
            this.lblDataAlteracao.TabIndex = 5;
            this.lblDataAlteracao.Text = "Data Alteração:";
            // 
            // txtNomeUsuarioAlterou
            // 
            this.txtNomeUsuarioAlterou.Location = new System.Drawing.Point(135, 59);
            this.txtNomeUsuarioAlterou.Name = "txtNomeUsuarioAlterou";
            this.txtNomeUsuarioAlterou.ReadOnly = true;
            this.txtNomeUsuarioAlterou.Size = new System.Drawing.Size(268, 20);
            this.txtNomeUsuarioAlterou.TabIndex = 9;
            // 
            // lblUsuarioAlterou
            // 
            this.lblUsuarioAlterou.AutoSize = true;
            this.lblUsuarioAlterou.Location = new System.Drawing.Point(2, 66);
            this.lblUsuarioAlterou.Name = "lblUsuarioAlterou";
            this.lblUsuarioAlterou.Size = new System.Drawing.Size(82, 13);
            this.lblUsuarioAlterou.TabIndex = 7;
            this.lblUsuarioAlterou.Text = "Usuário Alterou:";
            // 
            // btnAdicionarTurma
            // 
            this.btnAdicionarTurma.FlatAppearance.BorderSize = 0;
            this.btnAdicionarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarTurma.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarTurma.Image")));
            this.btnAdicionarTurma.Location = new System.Drawing.Point(379, 96);
            this.btnAdicionarTurma.Name = "btnAdicionarTurma";
            this.btnAdicionarTurma.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarTurma.TabIndex = 10;
            this.btnAdicionarTurma.UseVisualStyleBackColor = true;
            this.btnAdicionarTurma.Click += new System.EventHandler(this.btnAdicionarTurma_Click);
            // 
            // btnAdicionarPeriodo
            // 
            this.btnAdicionarPeriodo.FlatAppearance.BorderSize = 0;
            this.btnAdicionarPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarPeriodo.Image")));
            this.btnAdicionarPeriodo.Location = new System.Drawing.Point(379, 123);
            this.btnAdicionarPeriodo.Name = "btnAdicionarPeriodo";
            this.btnAdicionarPeriodo.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarPeriodo.TabIndex = 13;
            this.btnAdicionarPeriodo.UseVisualStyleBackColor = true;
            this.btnAdicionarPeriodo.Click += new System.EventHandler(this.btnAdicionarPeriodo_Click);
            // 
            // comboBoxPeriodo
            // 
            this.comboBoxPeriodo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPeriodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPeriodo.FormattingEnabled = true;
            this.comboBoxPeriodo.Location = new System.Drawing.Point(84, 123);
            this.comboBoxPeriodo.Name = "comboBoxPeriodo";
            this.comboBoxPeriodo.Size = new System.Drawing.Size(289, 21);
            this.comboBoxPeriodo.TabIndex = 12;
            this.comboBoxPeriodo.SelectedValueChanged += new System.EventHandler(this.comboBoxPeriodo_SelectedValueChanged);
            this.comboBoxPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPeriodo_KeyPress);
            this.comboBoxPeriodo.Leave += new System.EventHandler(this.comboBoxPeriodo_Leave);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(23, 131);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(55, 13);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Período: *";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(84, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(35, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnAdicionarInstituicao
            // 
            this.btnAdicionarInstituicao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarInstituicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarInstituicao.Image")));
            this.btnAdicionarInstituicao.Location = new System.Drawing.Point(379, 42);
            this.btnAdicionarInstituicao.Name = "btnAdicionarInstituicao";
            this.btnAdicionarInstituicao.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarInstituicao.TabIndex = 4;
            this.btnAdicionarInstituicao.UseVisualStyleBackColor = true;
            this.btnAdicionarInstituicao.Click += new System.EventHandler(this.btnAdicionarInstituicao_Click);
            // 
            // maskedTextBoxDataFim
            // 
            this.maskedTextBoxDataFim.Location = new System.Drawing.Point(223, 150);
            this.maskedTextBoxDataFim.Mask = "00/00/0000";
            this.maskedTextBoxDataFim.Name = "maskedTextBoxDataFim";
            this.maskedTextBoxDataFim.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxDataFim.TabIndex = 17;
            this.maskedTextBoxDataFim.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataFim.Leave += new System.EventHandler(this.maskedTextBoxDataFim_Leave);
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(158, 157);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(59, 13);
            this.lblDataFim.TabIndex = 16;
            this.lblDataFim.Text = "Data Fim: *";
            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.FlatAppearance.BorderSize = 0;
            this.btnAdicionarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCurso.Image")));
            this.btnAdicionarCurso.Location = new System.Drawing.Point(379, 69);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarCurso.TabIndex = 7;
            this.btnAdicionarCurso.UseVisualStyleBackColor = true;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);
            // 
            // checkBoxAluno
            // 
            this.checkBoxAluno.AutoSize = true;
            this.checkBoxAluno.Enabled = false;
            this.checkBoxAluno.Location = new System.Drawing.Point(183, 85);
            this.checkBoxAluno.Name = "checkBoxAluno";
            this.checkBoxAluno.Size = new System.Drawing.Size(53, 17);
            this.checkBoxAluno.TabIndex = 11;
            this.checkBoxAluno.Text = "Aluno";
            this.checkBoxAluno.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataAlteracao
            // 
            this.dateTimePickerDataAlteracao.Enabled = false;
            this.dateTimePickerDataAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataAlteracao.Location = new System.Drawing.Point(307, 33);
            this.dateTimePickerDataAlteracao.Name = "dateTimePickerDataAlteracao";
            this.dateTimePickerDataAlteracao.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataAlteracao.TabIndex = 6;
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Enabled = false;
            this.dateTimePickerDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(90, 33);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDataCadastro.TabIndex = 4;
            this.dateTimePickerDataCadastro.Value = new System.DateTime(2021, 6, 29, 20, 13, 41, 0);
            // 
            // txtCodigoUsuarioAlterou
            // 
            this.txtCodigoUsuarioAlterou.Location = new System.Drawing.Point(90, 59);
            this.txtCodigoUsuarioAlterou.Name = "txtCodigoUsuarioAlterou";
            this.txtCodigoUsuarioAlterou.ReadOnly = true;
            this.txtCodigoUsuarioAlterou.Size = new System.Drawing.Size(39, 20);
            this.txtCodigoUsuarioAlterou.TabIndex = 8;
            // 
            // maskedTextBoxDataInicio
            // 
            this.maskedTextBoxDataInicio.Location = new System.Drawing.Point(84, 150);
            this.maskedTextBoxDataInicio.Mask = "00/00/0000";
            this.maskedTextBoxDataInicio.Name = "maskedTextBoxDataInicio";
            this.maskedTextBoxDataInicio.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxDataInicio.TabIndex = 15;
            this.maskedTextBoxDataInicio.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataInicio.Leave += new System.EventHandler(this.maskedTextBoxDataInicio_Leave);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(8, 157);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(70, 13);
            this.lblDataInicio.TabIndex = 14;
            this.lblDataInicio.Text = "Data Início: *";
            // 
            // comboBoxTurma
            // 
            this.comboBoxTurma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTurma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTurma.FormattingEnabled = true;
            this.comboBoxTurma.Location = new System.Drawing.Point(84, 96);
            this.comboBoxTurma.Name = "comboBoxTurma";
            this.comboBoxTurma.Size = new System.Drawing.Size(289, 21);
            this.comboBoxTurma.TabIndex = 9;
            this.comboBoxTurma.SelectedValueChanged += new System.EventHandler(this.comboBoxTurma_SelectedValueChanged);
            this.comboBoxTurma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTurma_KeyPress);
            this.comboBoxTurma.Leave += new System.EventHandler(this.comboBoxTurma_Leave);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(31, 104);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(47, 13);
            this.lblTurma.TabIndex = 8;
            this.lblTurma.Text = "Turma: *";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(34, 77);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(44, 13);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso: *";
            // 
            // checkBoxAdministrador
            // 
            this.checkBoxAdministrador.AutoSize = true;
            this.checkBoxAdministrador.Enabled = false;
            this.checkBoxAdministrador.Location = new System.Drawing.Point(90, 85);
            this.checkBoxAdministrador.Name = "checkBoxAdministrador";
            this.checkBoxAdministrador.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAdministrador.TabIndex = 10;
            this.checkBoxAdministrador.Text = "Administrador";
            this.checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(6, 40);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 3;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(371, 256);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(84, 69);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(289, 21);
            this.comboBoxCurso.TabIndex = 6;
            this.comboBoxCurso.SelectedValueChanged += new System.EventHandler(this.comboBoxCurso_SelectedValueChanged);
            this.comboBoxCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCurso_KeyPress);
            this.comboBoxCurso.Leave += new System.EventHandler(this.comboBoxCurso_Leave);
            // 
            // comboBoxInstituicao
            // 
            this.comboBoxInstituicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInstituicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInstituicao.FormattingEnabled = true;
            this.comboBoxInstituicao.Location = new System.Drawing.Point(84, 42);
            this.comboBoxInstituicao.Name = "comboBoxInstituicao";
            this.comboBoxInstituicao.Size = new System.Drawing.Size(289, 21);
            this.comboBoxInstituicao.TabIndex = 3;
            this.comboBoxInstituicao.SelectedValueChanged += new System.EventHandler(this.comboBoxInstituicao_SelectedValueChanged);
            this.comboBoxInstituicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxInstituicao_KeyPress);
            this.comboBoxInstituicao.Leave += new System.EventHandler(this.comboBoxInstituicao_Leave);
            // 
            // radioButtonSituacaoAtivo
            // 
            this.radioButtonSituacaoAtivo.AutoSize = true;
            this.radioButtonSituacaoAtivo.Checked = true;
            this.radioButtonSituacaoAtivo.Location = new System.Drawing.Point(90, 10);
            this.radioButtonSituacaoAtivo.Name = "radioButtonSituacaoAtivo";
            this.radioButtonSituacaoAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSituacaoAtivo.TabIndex = 16;
            this.radioButtonSituacaoAtivo.TabStop = true;
            this.radioButtonSituacaoAtivo.Text = "Ativo";
            this.radioButtonSituacaoAtivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoInativo
            // 
            this.radioButtonSituacaoInativo.AutoSize = true;
            this.radioButtonSituacaoInativo.Location = new System.Drawing.Point(145, 10);
            this.radioButtonSituacaoInativo.Name = "radioButtonSituacaoInativo";
            this.radioButtonSituacaoInativo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSituacaoInativo.TabIndex = 17;
            this.radioButtonSituacaoInativo.Text = "Inativo";
            this.radioButtonSituacaoInativo.UseVisualStyleBackColor = true;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(25, 12);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(59, 13);
            this.lblSituacao.TabIndex = 15;
            this.lblSituacao.Text = "Situação: *";
            // 
            // checkBoxSecretariado
            // 
            this.checkBoxSecretariado.AutoSize = true;
            this.checkBoxSecretariado.Enabled = false;
            this.checkBoxSecretariado.Location = new System.Drawing.Point(317, 85);
            this.checkBoxSecretariado.Name = "checkBoxSecretariado";
            this.checkBoxSecretariado.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSecretariado.TabIndex = 13;
            this.checkBoxSecretariado.Text = "Secretariado";
            this.checkBoxSecretariado.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButtonSituacaoAtivo);
            this.tabPage2.Controls.Add(this.radioButtonSituacaoInativo);
            this.tabPage2.Controls.Add(this.lblSituacao);
            this.tabPage2.Controls.Add(this.checkBoxSecretariado);
            this.tabPage2.Controls.Add(this.checkBoxProfessor);
            this.tabPage2.Controls.Add(this.checkBoxAluno);
            this.tabPage2.Controls.Add(this.checkBoxAdministrador);
            this.tabPage2.Controls.Add(this.dateTimePickerDataAlteracao);
            this.tabPage2.Controls.Add(this.dateTimePickerDataCadastro);
            this.tabPage2.Controls.Add(this.lblDataAlteracao);
            this.tabPage2.Controls.Add(this.txtNomeUsuarioAlterou);
            this.tabPage2.Controls.Add(this.txtCodigoUsuarioAlterou);
            this.tabPage2.Controls.Add(this.lblUsuarioAlterou);
            this.tabPage2.Controls.Add(this.lblDataCadastro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxProfessor
            // 
            this.checkBoxProfessor.AutoSize = true;
            this.checkBoxProfessor.Enabled = false;
            this.checkBoxProfessor.Location = new System.Drawing.Point(241, 85);
            this.checkBoxProfessor.Name = "checkBoxProfessor";
            this.checkBoxProfessor.Size = new System.Drawing.Size(70, 17);
            this.checkBoxProfessor.TabIndex = 12;
            this.checkBoxProfessor.Text = "Professor";
            this.checkBoxProfessor.UseVisualStyleBackColor = true;
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Location = new System.Drawing.Point(13, 50);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(65, 13);
            this.lblInstituicao.TabIndex = 2;
            this.lblInstituicao.Text = "Instituição: *";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(290, 256);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // tabPageAluno
            // 
            this.tabPageAluno.Controls.Add(this.btnAdicionarTurma);
            this.tabPageAluno.Controls.Add(this.btnAdicionarPeriodo);
            this.tabPageAluno.Controls.Add(this.comboBoxPeriodo);
            this.tabPageAluno.Controls.Add(this.lblPeriodo);
            this.tabPageAluno.Controls.Add(this.txtCodigo);
            this.tabPageAluno.Controls.Add(this.lblCodigo);
            this.tabPageAluno.Controls.Add(this.btnAdicionarInstituicao);
            this.tabPageAluno.Controls.Add(this.maskedTextBoxDataFim);
            this.tabPageAluno.Controls.Add(this.lblDataFim);
            this.tabPageAluno.Controls.Add(this.btnAdicionarCurso);
            this.tabPageAluno.Controls.Add(this.maskedTextBoxDataInicio);
            this.tabPageAluno.Controls.Add(this.lblDataInicio);
            this.tabPageAluno.Controls.Add(this.comboBoxTurma);
            this.tabPageAluno.Controls.Add(this.lblTurma);
            this.tabPageAluno.Controls.Add(this.comboBoxCurso);
            this.tabPageAluno.Controls.Add(this.lblCurso);
            this.tabPageAluno.Controls.Add(this.comboBoxInstituicao);
            this.tabPageAluno.Controls.Add(this.lblInstituicao);
            this.tabPageAluno.Location = new System.Drawing.Point(4, 22);
            this.tabPageAluno.Name = "tabPageAluno";
            this.tabPageAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAluno.Size = new System.Drawing.Size(409, 187);
            this.tabPageAluno.TabIndex = 0;
            this.tabPageAluno.Text = "Informações";
            this.tabPageAluno.UseVisualStyleBackColor = true;
            // 
            // tabControlAluno
            // 
            this.tabControlAluno.Controls.Add(this.tabPageAluno);
            this.tabControlAluno.Controls.Add(this.tabPage2);
            this.tabControlAluno.Location = new System.Drawing.Point(6, 19);
            this.tabControlAluno.Name = "tabControlAluno";
            this.tabControlAluno.SelectedIndex = 0;
            this.tabControlAluno.Size = new System.Drawing.Size(417, 213);
            this.tabControlAluno.TabIndex = 0;
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.tabControlAluno);
            this.groupBoxAluno.Location = new System.Drawing.Point(17, 12);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(429, 238);
            this.groupBoxAluno.TabIndex = 3;
            this.groupBoxAluno.TabStop = false;
            // 
            // FrmTurmaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 291);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurmaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turma - Periodo";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageAluno.ResumeLayout(false);
            this.tabPageAluno.PerformLayout();
            this.tabControlAluno.ResumeLayout(false);
            this.groupBoxAluno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.TextBox txtNomeUsuarioAlterou;
        private System.Windows.Forms.Label lblUsuarioAlterou;
        private System.Windows.Forms.Button btnAdicionarTurma;
        private System.Windows.Forms.Button btnAdicionarPeriodo;
        private System.Windows.Forms.ComboBox comboBoxPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAdicionarInstituicao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFim;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Button btnAdicionarCurso;
        private System.Windows.Forms.CheckBox checkBoxAluno;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAlteracao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCadastro;
        private System.Windows.Forms.TextBox txtCodigoUsuarioAlterou;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.ComboBox comboBoxTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBoxInstituicao;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.CheckBox checkBoxSecretariado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxProfessor;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tabPageAluno;
        private System.Windows.Forms.TabControl tabControlAluno;
        private System.Windows.Forms.GroupBox groupBoxAluno;
    }
}