
namespace SistemaAcademico.Módulos.Acadêmico.Principal
{
    partial class FrmTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurma));
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.checkBoxSecretariado = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxProfessor = new System.Windows.Forms.CheckBox();
            this.checkBoxAluno = new System.Windows.Forms.CheckBox();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDataAlteracao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.txtNomeUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.txtCodigoUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.lblUsuarioAlterou = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.comboBoxInstituicao = new System.Windows.Forms.ComboBox();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.tabControlAluno = new System.Windows.Forms.TabControl();
            this.tabPageAluno = new System.Windows.Forms.TabPage();
            this.btnAdicionarInstituicao = new System.Windows.Forms.Button();
            this.maskedTextBoxDataFim = new System.Windows.Forms.MaskedTextBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            this.maskedTextBoxDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoEmAndamento = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoCancelado = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoFinalizado = new System.Windows.Forms.RadioButton();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            this.tabControlAluno.SuspendLayout();
            this.tabPageAluno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(375, 255);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 13);
            this.txtNome.MaxLength = 300;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(294, 255);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // checkBoxSecretariado
            // 
            this.checkBoxSecretariado.AutoSize = true;
            this.checkBoxSecretariado.Enabled = false;
            this.checkBoxSecretariado.Location = new System.Drawing.Point(320, 58);
            this.checkBoxSecretariado.Name = "checkBoxSecretariado";
            this.checkBoxSecretariado.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSecretariado.TabIndex = 13;
            this.checkBoxSecretariado.Text = "Secretariado";
            this.checkBoxSecretariado.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Size = new System.Drawing.Size(409, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxProfessor
            // 
            this.checkBoxProfessor.AutoSize = true;
            this.checkBoxProfessor.Enabled = false;
            this.checkBoxProfessor.Location = new System.Drawing.Point(244, 58);
            this.checkBoxProfessor.Name = "checkBoxProfessor";
            this.checkBoxProfessor.Size = new System.Drawing.Size(70, 17);
            this.checkBoxProfessor.TabIndex = 12;
            this.checkBoxProfessor.Text = "Professor";
            this.checkBoxProfessor.UseVisualStyleBackColor = true;
            // 
            // checkBoxAluno
            // 
            this.checkBoxAluno.AutoSize = true;
            this.checkBoxAluno.Enabled = false;
            this.checkBoxAluno.Location = new System.Drawing.Point(185, 58);
            this.checkBoxAluno.Name = "checkBoxAluno";
            this.checkBoxAluno.Size = new System.Drawing.Size(53, 17);
            this.checkBoxAluno.TabIndex = 11;
            this.checkBoxAluno.Text = "Aluno";
            this.checkBoxAluno.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdministrador
            // 
            this.checkBoxAdministrador.AutoSize = true;
            this.checkBoxAdministrador.Enabled = false;
            this.checkBoxAdministrador.Location = new System.Drawing.Point(90, 58);
            this.checkBoxAdministrador.Name = "checkBoxAdministrador";
            this.checkBoxAdministrador.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAdministrador.TabIndex = 10;
            this.checkBoxAdministrador.Text = "Administrador";
            this.checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataAlteracao
            // 
            this.dateTimePickerDataAlteracao.Enabled = false;
            this.dateTimePickerDataAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataAlteracao.Location = new System.Drawing.Point(284, 6);
            this.dateTimePickerDataAlteracao.Name = "dateTimePickerDataAlteracao";
            this.dateTimePickerDataAlteracao.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataAlteracao.TabIndex = 6;
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Enabled = false;
            this.dateTimePickerDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(90, 6);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDataCadastro.TabIndex = 4;
            this.dateTimePickerDataCadastro.Value = new System.DateTime(2021, 6, 29, 20, 13, 41, 0);
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(197, 13);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(81, 13);
            this.lblDataAlteracao.TabIndex = 5;
            this.lblDataAlteracao.Text = "Data Alteração:";
            // 
            // txtNomeUsuarioAlterou
            // 
            this.txtNomeUsuarioAlterou.Location = new System.Drawing.Point(135, 32);
            this.txtNomeUsuarioAlterou.Name = "txtNomeUsuarioAlterou";
            this.txtNomeUsuarioAlterou.ReadOnly = true;
            this.txtNomeUsuarioAlterou.Size = new System.Drawing.Size(245, 20);
            this.txtNomeUsuarioAlterou.TabIndex = 9;
            // 
            // txtCodigoUsuarioAlterou
            // 
            this.txtCodigoUsuarioAlterou.Location = new System.Drawing.Point(90, 32);
            this.txtCodigoUsuarioAlterou.Name = "txtCodigoUsuarioAlterou";
            this.txtCodigoUsuarioAlterou.ReadOnly = true;
            this.txtCodigoUsuarioAlterou.Size = new System.Drawing.Size(39, 20);
            this.txtCodigoUsuarioAlterou.TabIndex = 8;
            // 
            // lblUsuarioAlterou
            // 
            this.lblUsuarioAlterou.AutoSize = true;
            this.lblUsuarioAlterou.Location = new System.Drawing.Point(2, 39);
            this.lblUsuarioAlterou.Name = "lblUsuarioAlterou";
            this.lblUsuarioAlterou.Size = new System.Drawing.Size(82, 13);
            this.lblUsuarioAlterou.TabIndex = 7;
            this.lblUsuarioAlterou.Text = "Usuário Alterou:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(6, 13);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 3;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // comboBoxInstituicao
            // 
            this.comboBoxInstituicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInstituicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInstituicao.FormattingEnabled = true;
            this.comboBoxInstituicao.Location = new System.Drawing.Point(85, 7);
            this.comboBoxInstituicao.Name = "comboBoxInstituicao";
            this.comboBoxInstituicao.Size = new System.Drawing.Size(291, 21);
            this.comboBoxInstituicao.TabIndex = 1;
            this.comboBoxInstituicao.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstituicao_SelectedIndexChanged);
            this.comboBoxInstituicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxInstituicao_KeyPress);
            this.comboBoxInstituicao.Leave += new System.EventHandler(this.comboBoxInstituicao_Leave);
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Location = new System.Drawing.Point(14, 15);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(65, 13);
            this.lblInstituicao.TabIndex = 0;
            this.lblInstituicao.Text = "Instituição: *";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.tabControlAluno);
            this.groupBoxAluno.Controls.Add(this.txtNome);
            this.groupBoxAluno.Controls.Add(this.lblNome);
            this.groupBoxAluno.Controls.Add(this.txtCodigo);
            this.groupBoxAluno.Controls.Add(this.lblCodigo);
            this.groupBoxAluno.Location = new System.Drawing.Point(21, 21);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(429, 228);
            this.groupBoxAluno.TabIndex = 0;
            this.groupBoxAluno.TabStop = false;
            // 
            // tabControlAluno
            // 
            this.tabControlAluno.Controls.Add(this.tabPageAluno);
            this.tabControlAluno.Controls.Add(this.tabPage2);
            this.tabControlAluno.Location = new System.Drawing.Point(6, 39);
            this.tabControlAluno.Name = "tabControlAluno";
            this.tabControlAluno.SelectedIndex = 0;
            this.tabControlAluno.Size = new System.Drawing.Size(417, 183);
            this.tabControlAluno.TabIndex = 4;
            // 
            // tabPageAluno
            // 
            this.tabPageAluno.Controls.Add(this.btnAdicionarInstituicao);
            this.tabPageAluno.Controls.Add(this.maskedTextBoxDataFim);
            this.tabPageAluno.Controls.Add(this.lblDataFim);
            this.tabPageAluno.Controls.Add(this.btnAdicionarCurso);
            this.tabPageAluno.Controls.Add(this.maskedTextBoxDataInicio);
            this.tabPageAluno.Controls.Add(this.lblDataInicio);
            this.tabPageAluno.Controls.Add(this.lblSituacao);
            this.tabPageAluno.Controls.Add(this.groupBox1);
            this.tabPageAluno.Controls.Add(this.comboBoxTurno);
            this.tabPageAluno.Controls.Add(this.lblTurno);
            this.tabPageAluno.Controls.Add(this.comboBoxCurso);
            this.tabPageAluno.Controls.Add(this.lblCurso);
            this.tabPageAluno.Controls.Add(this.comboBoxInstituicao);
            this.tabPageAluno.Controls.Add(this.lblInstituicao);
            this.tabPageAluno.Location = new System.Drawing.Point(4, 22);
            this.tabPageAluno.Name = "tabPageAluno";
            this.tabPageAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAluno.Size = new System.Drawing.Size(409, 157);
            this.tabPageAluno.TabIndex = 0;
            this.tabPageAluno.Text = "Informações";
            this.tabPageAluno.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarInstituicao
            // 
            this.btnAdicionarInstituicao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarInstituicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarInstituicao.Image")));
            this.btnAdicionarInstituicao.Location = new System.Drawing.Point(380, 7);
            this.btnAdicionarInstituicao.Name = "btnAdicionarInstituicao";
            this.btnAdicionarInstituicao.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarInstituicao.TabIndex = 14;
            this.btnAdicionarInstituicao.UseVisualStyleBackColor = true;
            this.btnAdicionarInstituicao.Click += new System.EventHandler(this.btnAdicionarInstituicao_Click);
            // 
            // maskedTextBoxDataFim
            // 
            this.maskedTextBoxDataFim.Location = new System.Drawing.Point(222, 88);
            this.maskedTextBoxDataFim.Mask = "00/00/0000";
            this.maskedTextBoxDataFim.Name = "maskedTextBoxDataFim";
            this.maskedTextBoxDataFim.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxDataFim.TabIndex = 11;
            this.maskedTextBoxDataFim.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataFim.Leave += new System.EventHandler(this.maskedTextBoxDataFim_Leave);
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(157, 95);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(59, 13);
            this.lblDataFim.TabIndex = 10;
            this.lblDataFim.Text = "Data Fim: *";
            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.FlatAppearance.BorderSize = 0;
            this.btnAdicionarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCurso.Image")));
            this.btnAdicionarCurso.Location = new System.Drawing.Point(380, 34);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarCurso.TabIndex = 5;
            this.btnAdicionarCurso.UseVisualStyleBackColor = true;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);
            // 
            // maskedTextBoxDataInicio
            // 
            this.maskedTextBoxDataInicio.Location = new System.Drawing.Point(85, 88);
            this.maskedTextBoxDataInicio.Mask = "00/00/0000";
            this.maskedTextBoxDataInicio.Name = "maskedTextBoxDataInicio";
            this.maskedTextBoxDataInicio.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxDataInicio.TabIndex = 9;
            this.maskedTextBoxDataInicio.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataInicio.Leave += new System.EventHandler(this.maskedTextBoxDataInicio_Leave);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(9, 95);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(70, 13);
            this.lblDataInicio.TabIndex = 8;
            this.lblDataInicio.Text = "Data Início: *";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(20, 125);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(59, 13);
            this.lblSituacao.TabIndex = 13;
            this.lblSituacao.Text = "Situação: *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSituacaoEmAndamento);
            this.groupBox1.Controls.Add(this.radioButtonSituacaoCancelado);
            this.groupBox1.Controls.Add(this.radioButtonSituacaoFinalizado);
            this.groupBox1.Location = new System.Drawing.Point(85, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 35);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
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
            this.radioButtonSituacaoEmAndamento.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoEmAndamento_CheckedChanged);
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
            this.radioButtonSituacaoCancelado.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoCancelado_CheckedChanged);
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
            this.radioButtonSituacaoFinalizado.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoFinalizado_CheckedChanged);
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTurno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(85, 61);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(109, 21);
            this.comboBoxTurno.TabIndex = 7;
            this.comboBoxTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTurno_KeyPress);
            this.comboBoxTurno.Leave += new System.EventHandler(this.comboBoxTurno_Leave);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(34, 69);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(45, 13);
            this.lblTurno.TabIndex = 6;
            this.lblTurno.Text = "Turno: *";
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(85, 34);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(291, 21);
            this.comboBoxCurso.TabIndex = 4;
            this.comboBoxCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCurso_KeyPress);
            this.comboBoxCurso.Leave += new System.EventHandler(this.comboBoxCurso_Leave);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(35, 42);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(44, 13);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso: *";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(132, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome: *";
            // 
            // FrmTurma
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 288);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turma";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxAluno.ResumeLayout(false);
            this.groupBoxAluno.PerformLayout();
            this.tabControlAluno.ResumeLayout(false);
            this.tabPageAluno.ResumeLayout(false);
            this.tabPageAluno.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox checkBoxSecretariado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxProfessor;
        private System.Windows.Forms.CheckBox checkBoxAluno;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAlteracao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCadastro;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.TextBox txtNomeUsuarioAlterou;
        private System.Windows.Forms.TextBox txtCodigoUsuarioAlterou;
        private System.Windows.Forms.Label lblUsuarioAlterou;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.ComboBox comboBoxInstituicao;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.TabControl tabControlAluno;
        private System.Windows.Forms.TabPage tabPageAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnAdicionarCurso;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.RadioButton radioButtonSituacaoCancelado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoFinalizado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoEmAndamento;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataFim;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Button btnAdicionarInstituicao;
    }
}