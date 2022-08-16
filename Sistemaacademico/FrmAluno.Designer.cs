
namespace SistemaAcademico
{
    partial class FrmAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAluno));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsuarioAlterou = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.txtNomeUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtCodigoUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtIdentidade = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblIdentidade = new System.Windows.Forms.Label();
            this.checkBoxSecretariado = new System.Windows.Forms.CheckBox();
            this.checkBoxProfessor = new System.Windows.Forms.CheckBox();
            this.checkBoxAluno = new System.Windows.Forms.CheckBox();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDataAlteracao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabPageAluno = new System.Windows.Forms.TabPage();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnGrauEscolarAdicionar = new System.Windows.Forms.Button();
            this.btnAdicionarInstituicao = new System.Windows.Forms.Button();
            this.comboBoxGrauEscolar = new System.Windows.Forms.ComboBox();
            this.comboBoxInstituicao = new System.Windows.Forms.ComboBox();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.lblGrauEscolar = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtCNH = new System.Windows.Forms.TextBox();
            this.lblCNH = new System.Windows.Forms.Label();
            this.tabControlAluno = new System.Windows.Forms.TabControl();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.tabPage2.SuspendLayout();
            this.tabPageAluno.SuspendLayout();
            this.tabControlAluno.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(121, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome: *";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(92, 248);
            this.txtObservacoes.MaxLength = 500;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(382, 91);
            this.txtObservacoes.TabIndex = 34;
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(405, 191);
            this.maskedTextBoxCEP.Mask = "##.###-###";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxCEP.TabIndex = 28;
            this.maskedTextBoxCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(361, 198);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(38, 13);
            this.lblCEP.TabIndex = 27;
            this.lblCEP.Text = "CEP: *";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(14, 255);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblObservacoes.TabIndex = 33;
            this.lblObservacoes.Text = "Observações:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(273, 39);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(99, 13);
            this.lblDataNascimento.TabIndex = 6;
            this.lblDataNascimento.Text = "Data Nascimento: *";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(93, 217);
            this.maskedTextBoxTelefone.Mask = "(##) #####-####";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBoxTelefone.TabIndex = 30;
            this.maskedTextBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxTelefone.TextChanged += new System.EventHandler(this.maskedTextBoxTelefone_TextChanged);
            this.maskedTextBoxTelefone.Leave += new System.EventHandler(this.maskedTextBoxTelefone_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 217);
            this.txtEmail.MaxLength = 200;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 20);
            this.txtEmail.TabIndex = 32;
            // 
            // lblUsuarioAlterou
            // 
            this.lblUsuarioAlterou.AutoSize = true;
            this.lblUsuarioAlterou.Location = new System.Drawing.Point(6, 66);
            this.lblUsuarioAlterou.Name = "lblUsuarioAlterou";
            this.lblUsuarioAlterou.Size = new System.Drawing.Size(82, 13);
            this.lblUsuarioAlterou.TabIndex = 7;
            this.lblUsuarioAlterou.Text = "Usuário Alterou:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(10, 40);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 3;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(32, 14);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(56, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(182, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(35, 224);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 29;
            this.lblTelefone.Text = "Telefone:";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Location = new System.Drawing.Point(152, 190);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(203, 21);
            this.comboBoxCidade.TabIndex = 26;
            this.comboBoxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCidade_KeyPress);
            this.comboBoxCidade.Leave += new System.EventHandler(this.comboBoxCidade_Leave);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(37, 198);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade: *";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(247, 138);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(227, 20);
            this.txtBairro.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(172, 13);
            this.txtNome.MaxLength = 300;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 20);
            this.txtNome.TabIndex = 3;
            // 
            // radioButtonSituacaoInativo
            // 
            this.radioButtonSituacaoInativo.AutoSize = true;
            this.radioButtonSituacaoInativo.Location = new System.Drawing.Point(149, 10);
            this.radioButtonSituacaoInativo.Name = "radioButtonSituacaoInativo";
            this.radioButtonSituacaoInativo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSituacaoInativo.TabIndex = 2;
            this.radioButtonSituacaoInativo.Text = "Inativo";
            this.radioButtonSituacaoInativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoAtivo
            // 
            this.radioButtonSituacaoAtivo.AutoSize = true;
            this.radioButtonSituacaoAtivo.Checked = true;
            this.radioButtonSituacaoAtivo.Location = new System.Drawing.Point(94, 10);
            this.radioButtonSituacaoAtivo.Name = "radioButtonSituacaoAtivo";
            this.radioButtonSituacaoAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSituacaoAtivo.TabIndex = 1;
            this.radioButtonSituacaoAtivo.TabStop = true;
            this.radioButtonSituacaoAtivo.Text = "Ativo";
            this.radioButtonSituacaoAtivo.UseVisualStyleBackColor = true;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(93, 190);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(53, 21);
            this.comboBoxEstado.TabIndex = 25;
            this.comboBoxEstado.SelectedValueChanged += new System.EventHandler(this.comboBoxEstado_SelectedValueChanged);
            this.comboBoxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEstado_KeyPress);
            this.comboBoxEstado.Leave += new System.EventHandler(this.comboBoxEstado_Leave);
            // 
            // txtNomeUsuarioAlterou
            // 
            this.txtNomeUsuarioAlterou.Location = new System.Drawing.Point(139, 59);
            this.txtNomeUsuarioAlterou.Name = "txtNomeUsuarioAlterou";
            this.txtNomeUsuarioAlterou.ReadOnly = true;
            this.txtNomeUsuarioAlterou.Size = new System.Drawing.Size(245, 20);
            this.txtNomeUsuarioAlterou.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(197, 145);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro: *";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(93, 164);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(381, 20);
            this.txtComplemento.TabIndex = 23;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(33, 145);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(54, 13);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Número: *";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(93, 138);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 20);
            this.txtNumero.TabIndex = 19;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(93, 112);
            this.txtLogradouro.MaxLength = 200;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(381, 20);
            this.txtLogradouro.TabIndex = 17;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 171);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 22;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(16, 119);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(71, 13);
            this.lblLogradouro.TabIndex = 16;
            this.lblLogradouro.Text = "Logradouro: *";
            // 
            // txtCodigoUsuarioAlterou
            // 
            this.txtCodigoUsuarioAlterou.Location = new System.Drawing.Point(94, 59);
            this.txtCodigoUsuarioAlterou.Name = "txtCodigoUsuarioAlterou";
            this.txtCodigoUsuarioAlterou.ReadOnly = true;
            this.txtCodigoUsuarioAlterou.Size = new System.Drawing.Size(39, 20);
            this.txtCodigoUsuarioAlterou.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(255, 6);
            this.txtIdentidade.MaxLength = 20;
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(219, 20);
            this.txtIdentidade.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(437, 434);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblIdentidade
            // 
            this.lblIdentidade.AutoSize = true;
            this.lblIdentidade.Location = new System.Drawing.Point(182, 13);
            this.lblIdentidade.Name = "lblIdentidade";
            this.lblIdentidade.Size = new System.Drawing.Size(67, 13);
            this.lblIdentidade.TabIndex = 2;
            this.lblIdentidade.Text = "Identidade: *";
            // 
            // checkBoxSecretariado
            // 
            this.checkBoxSecretariado.AutoSize = true;
            this.checkBoxSecretariado.Enabled = false;
            this.checkBoxSecretariado.Location = new System.Drawing.Point(324, 85);
            this.checkBoxSecretariado.Name = "checkBoxSecretariado";
            this.checkBoxSecretariado.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSecretariado.TabIndex = 13;
            this.checkBoxSecretariado.Text = "Secretariado";
            this.checkBoxSecretariado.UseVisualStyleBackColor = true;
            // 
            // checkBoxProfessor
            // 
            this.checkBoxProfessor.AutoSize = true;
            this.checkBoxProfessor.Enabled = false;
            this.checkBoxProfessor.Location = new System.Drawing.Point(248, 85);
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
            this.checkBoxAluno.Location = new System.Drawing.Point(189, 85);
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
            this.checkBoxAdministrador.Location = new System.Drawing.Point(94, 85);
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
            this.dateTimePickerDataAlteracao.Location = new System.Drawing.Point(288, 33);
            this.dateTimePickerDataAlteracao.Name = "dateTimePickerDataAlteracao";
            this.dateTimePickerDataAlteracao.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataAlteracao.TabIndex = 6;
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Enabled = false;
            this.dateTimePickerDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(94, 33);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerDataCadastro.TabIndex = 4;
            this.dateTimePickerDataCadastro.Value = new System.DateTime(2021, 6, 29, 20, 13, 41, 0);
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
            this.tabPage2.Controls.Add(this.radioButtonSituacaoInativo);
            this.tabPage2.Controls.Add(this.radioButtonSituacaoAtivo);
            this.tabPage2.Controls.Add(this.lblUsuarioAlterou);
            this.tabPage2.Controls.Add(this.lblDataCadastro);
            this.tabPage2.Controls.Add(this.lblSituacao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(201, 40);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(81, 13);
            this.lblDataAlteracao.TabIndex = 5;
            this.lblDataAlteracao.Text = "Data Alteração:";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(93, 6);
            this.maskedTextBoxCPF.Mask = "###.###.###-##";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBoxCPF.TabIndex = 1;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(50, 13);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 13);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF: *";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(356, 434);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabPageAluno
            // 
            this.tabPageAluno.Controls.Add(this.dateTimePickerDataNascimento);
            this.tabPageAluno.Controls.Add(this.btnGrauEscolarAdicionar);
            this.tabPageAluno.Controls.Add(this.btnAdicionarInstituicao);
            this.tabPageAluno.Controls.Add(this.comboBoxGrauEscolar);
            this.tabPageAluno.Controls.Add(this.comboBoxInstituicao);
            this.tabPageAluno.Controls.Add(this.lblInstituicao);
            this.tabPageAluno.Controls.Add(this.lblGrauEscolar);
            this.tabPageAluno.Controls.Add(this.txtMatricula);
            this.tabPageAluno.Controls.Add(this.lblMatricula);
            this.tabPageAluno.Controls.Add(this.txtCNH);
            this.tabPageAluno.Controls.Add(this.lblCNH);
            this.tabPageAluno.Controls.Add(this.txtObservacoes);
            this.tabPageAluno.Controls.Add(this.maskedTextBoxCEP);
            this.tabPageAluno.Controls.Add(this.lblCEP);
            this.tabPageAluno.Controls.Add(this.lblObservacoes);
            this.tabPageAluno.Controls.Add(this.lblDataNascimento);
            this.tabPageAluno.Controls.Add(this.maskedTextBoxTelefone);
            this.tabPageAluno.Controls.Add(this.txtEmail);
            this.tabPageAluno.Controls.Add(this.lblEmail);
            this.tabPageAluno.Controls.Add(this.lblTelefone);
            this.tabPageAluno.Controls.Add(this.comboBoxCidade);
            this.tabPageAluno.Controls.Add(this.comboBoxEstado);
            this.tabPageAluno.Controls.Add(this.lblCidade);
            this.tabPageAluno.Controls.Add(this.txtBairro);
            this.tabPageAluno.Controls.Add(this.lblBairro);
            this.tabPageAluno.Controls.Add(this.txtComplemento);
            this.tabPageAluno.Controls.Add(this.lblNumero);
            this.tabPageAluno.Controls.Add(this.txtNumero);
            this.tabPageAluno.Controls.Add(this.txtLogradouro);
            this.tabPageAluno.Controls.Add(this.lblComplemento);
            this.tabPageAluno.Controls.Add(this.lblLogradouro);
            this.tabPageAluno.Controls.Add(this.txtIdentidade);
            this.tabPageAluno.Controls.Add(this.lblIdentidade);
            this.tabPageAluno.Controls.Add(this.maskedTextBoxCPF);
            this.tabPageAluno.Controls.Add(this.lblCPF);
            this.tabPageAluno.Location = new System.Drawing.Point(4, 22);
            this.tabPageAluno.Name = "tabPageAluno";
            this.tabPageAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAluno.Size = new System.Drawing.Size(480, 345);
            this.tabPageAluno.TabIndex = 0;
            this.tabPageAluno.Text = "Informações";
            this.tabPageAluno.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(378, 32);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataNascimento.TabIndex = 7;
            this.dateTimePickerDataNascimento.Value = new System.DateTime(2021, 7, 2, 0, 0, 0, 0);
            // 
            // btnGrauEscolarAdicionar
            // 
            this.btnGrauEscolarAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGrauEscolarAdicionar.FlatAppearance.BorderSize = 0;
            this.btnGrauEscolarAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrauEscolarAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrauEscolarAdicionar.Image")));
            this.btnGrauEscolarAdicionar.Location = new System.Drawing.Point(293, 58);
            this.btnGrauEscolarAdicionar.Name = "btnGrauEscolarAdicionar";
            this.btnGrauEscolarAdicionar.Size = new System.Drawing.Size(20, 20);
            this.btnGrauEscolarAdicionar.TabIndex = 10;
            this.btnGrauEscolarAdicionar.UseVisualStyleBackColor = true;
            this.btnGrauEscolarAdicionar.Click += new System.EventHandler(this.btnGrauEscolarAdicionar_Click);
            // 
            // btnAdicionarInstituicao
            // 
            this.btnAdicionarInstituicao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdicionarInstituicao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarInstituicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarInstituicao.Image")));
            this.btnAdicionarInstituicao.Location = new System.Drawing.Point(453, 85);
            this.btnAdicionarInstituicao.Name = "btnAdicionarInstituicao";
            this.btnAdicionarInstituicao.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarInstituicao.TabIndex = 15;
            this.btnAdicionarInstituicao.UseVisualStyleBackColor = true;
            this.btnAdicionarInstituicao.Click += new System.EventHandler(this.btnAdicionarInstituicao_Click);
            // 
            // comboBoxGrauEscolar
            // 
            this.comboBoxGrauEscolar.AutoCompleteCustomSource.AddRange(new string[] {
            "Boa Esperança",
            "Lavras"});
            this.comboBoxGrauEscolar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGrauEscolar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGrauEscolar.FormattingEnabled = true;
            this.comboBoxGrauEscolar.Location = new System.Drawing.Point(93, 58);
            this.comboBoxGrauEscolar.Name = "comboBoxGrauEscolar";
            this.comboBoxGrauEscolar.Size = new System.Drawing.Size(194, 21);
            this.comboBoxGrauEscolar.TabIndex = 9;
            this.comboBoxGrauEscolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxGrauEscolar_KeyPress);
            this.comboBoxGrauEscolar.Leave += new System.EventHandler(this.comboBoxGrauEscolar_Leave);
            // 
            // comboBoxInstituicao
            // 
            this.comboBoxInstituicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInstituicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInstituicao.FormattingEnabled = true;
            this.comboBoxInstituicao.Location = new System.Drawing.Point(93, 85);
            this.comboBoxInstituicao.Name = "comboBoxInstituicao";
            this.comboBoxInstituicao.Size = new System.Drawing.Size(354, 21);
            this.comboBoxInstituicao.TabIndex = 14;
            this.comboBoxInstituicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxInstituicao_KeyPress);
            this.comboBoxInstituicao.Leave += new System.EventHandler(this.comboBoxInstituicao_Leave);
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Location = new System.Drawing.Point(22, 93);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(65, 13);
            this.lblInstituicao.TabIndex = 13;
            this.lblInstituicao.Text = "Instituição: *";
            // 
            // lblGrauEscolar
            // 
            this.lblGrauEscolar.AutoSize = true;
            this.lblGrauEscolar.Location = new System.Drawing.Point(12, 66);
            this.lblGrauEscolar.Name = "lblGrauEscolar";
            this.lblGrauEscolar.Size = new System.Drawing.Size(75, 13);
            this.lblGrauEscolar.TabIndex = 8;
            this.lblGrauEscolar.Text = "GrauEscolar: *";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(388, 59);
            this.txtMatricula.MaxLength = 100;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(86, 20);
            this.txtMatricula.TabIndex = 12;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(320, 66);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(62, 13);
            this.lblMatricula.TabIndex = 11;
            this.lblMatricula.Text = "Matrícula: *";
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(93, 32);
            this.txtCNH.MaxLength = 15;
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(174, 20);
            this.txtCNH.TabIndex = 5;
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Location = new System.Drawing.Point(47, 39);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(33, 13);
            this.lblCNH.TabIndex = 4;
            this.lblCNH.Text = "CNH:";
            // 
            // tabControlAluno
            // 
            this.tabControlAluno.Controls.Add(this.tabPageAluno);
            this.tabControlAluno.Controls.Add(this.tabPage2);
            this.tabControlAluno.Location = new System.Drawing.Point(6, 39);
            this.tabControlAluno.Name = "tabControlAluno";
            this.tabControlAluno.SelectedIndex = 0;
            this.tabControlAluno.Size = new System.Drawing.Size(488, 371);
            this.tabControlAluno.TabIndex = 4;
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.tabControlAluno);
            this.groupBoxAluno.Controls.Add(this.txtNome);
            this.groupBoxAluno.Controls.Add(this.lblNome);
            this.groupBoxAluno.Controls.Add(this.txtCodigo);
            this.groupBoxAluno.Controls.Add(this.lblCodigo);
            this.groupBoxAluno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(500, 416);
            this.groupBoxAluno.TabIndex = 0;
            this.groupBoxAluno.TabStop = false;
            // 
            // FrmAluno
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 469);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAluno_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageAluno.ResumeLayout(false);
            this.tabPageAluno.PerformLayout();
            this.tabControlAluno.ResumeLayout(false);
            this.groupBoxAluno.ResumeLayout(false);
            this.groupBoxAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsuarioAlterou;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox txtNomeUsuarioAlterou;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtCodigoUsuarioAlterou;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtIdentidade;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblIdentidade;
        private System.Windows.Forms.CheckBox checkBoxSecretariado;
        private System.Windows.Forms.CheckBox checkBoxProfessor;
        private System.Windows.Forms.CheckBox checkBoxAluno;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAlteracao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCadastro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tabPageAluno;
        private System.Windows.Forms.TabControl tabControlAluno;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtCNH;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.ComboBox comboBoxGrauEscolar;
        private System.Windows.Forms.ComboBox comboBoxInstituicao;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.Label lblGrauEscolar;
        private System.Windows.Forms.Button btnGrauEscolarAdicionar;
        private System.Windows.Forms.Button btnAdicionarInstituicao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
    }
}