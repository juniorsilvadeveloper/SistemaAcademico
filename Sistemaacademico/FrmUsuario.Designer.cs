namespace SistemaAcademico
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.checkBoxSecretariado = new System.Windows.Forms.CheckBox();
            this.checkBoxProfessor = new System.Windows.Forms.CheckBox();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionarUsuario = new System.Windows.Forms.Button();
            this.checkBoxAluno = new System.Windows.Forms.CheckBox();
            this.btnAdicionarInstituicao = new System.Windows.Forms.Button();
            this.comboBoxInstituicao = new System.Windows.Forms.ComboBox();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.tabControlAluno = new System.Windows.Forms.TabControl();
            this.tabPageAluno = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoOperador = new System.Windows.Forms.TextBox();
            this.radioButtonSecretariado = new System.Windows.Forms.RadioButton();
            this.lblCodigoOperador = new System.Windows.Forms.Label();
            this.radioButtonProfessor = new System.Windows.Forms.RadioButton();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.radioButtonAluno = new System.Windows.Forms.RadioButton();
            this.radioButtonAdministrador = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePickerDataAlteracao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.txtNomeUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.txtCodigoUsuarioAlterou = new System.Windows.Forms.TextBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.lblUsuarioAlterou = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.linkDica = new System.Windows.Forms.LinkLabel();
            this.tabControlAluno.SuspendLayout();
            this.tabPageAluno.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            this.SuspendLayout();
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
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(451, 285);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdicionarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAdicionarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarUsuario.Image")));
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(455, 42);
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarUsuario.TabIndex = 9;
            this.btnAdicionarUsuario.UseVisualStyleBackColor = true;
            this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);
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
            // btnAdicionarInstituicao
            // 
            this.btnAdicionarInstituicao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdicionarInstituicao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarInstituicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarInstituicao.Image")));
            this.btnAdicionarInstituicao.Location = new System.Drawing.Point(461, 6);
            this.btnAdicionarInstituicao.Name = "btnAdicionarInstituicao";
            this.btnAdicionarInstituicao.Size = new System.Drawing.Size(21, 21);
            this.btnAdicionarInstituicao.TabIndex = 2;
            this.btnAdicionarInstituicao.UseVisualStyleBackColor = true;
            this.btnAdicionarInstituicao.Click += new System.EventHandler(this.btnAdicionarInstituicao_Click);
            // 
            // comboBoxInstituicao
            // 
            this.comboBoxInstituicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInstituicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInstituicao.FormattingEnabled = true;
            this.comboBoxInstituicao.Location = new System.Drawing.Point(77, 6);
            this.comboBoxInstituicao.Name = "comboBoxInstituicao";
            this.comboBoxInstituicao.Size = new System.Drawing.Size(378, 21);
            this.comboBoxInstituicao.TabIndex = 1;
            this.comboBoxInstituicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxInstituicao_KeyPress);
            this.comboBoxInstituicao.Leave += new System.EventHandler(this.comboBoxInstituicao_Leave);
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Location = new System.Drawing.Point(6, 14);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(65, 13);
            this.lblInstituicao.TabIndex = 0;
            this.lblInstituicao.Text = "Instituição: *";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(6, 50);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(45, 13);
            this.lblNomeUsuario.TabIndex = 6;
            this.lblNomeUsuario.Text = "Nome: *";
            // 
            // tabControlAluno
            // 
            this.tabControlAluno.Controls.Add(this.tabPageAluno);
            this.tabControlAluno.Controls.Add(this.tabPage2);
            this.tabControlAluno.Location = new System.Drawing.Point(6, 35);
            this.tabControlAluno.Name = "tabControlAluno";
            this.tabControlAluno.SelectedIndex = 0;
            this.tabControlAluno.Size = new System.Drawing.Size(502, 226);
            this.tabControlAluno.TabIndex = 2;
            // 
            // tabPageAluno
            // 
            this.tabPageAluno.Controls.Add(this.groupBox2);
            this.tabPageAluno.Controls.Add(this.groupBox1);
            this.tabPageAluno.Controls.Add(this.btnAdicionarInstituicao);
            this.tabPageAluno.Controls.Add(this.comboBoxInstituicao);
            this.tabPageAluno.Controls.Add(this.lblInstituicao);
            this.tabPageAluno.Location = new System.Drawing.Point(4, 22);
            this.tabPageAluno.Name = "tabPageAluno";
            this.tabPageAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAluno.Size = new System.Drawing.Size(494, 200);
            this.tabPageAluno.TabIndex = 0;
            this.tabPageAluno.Text = "Informações";
            this.tabPageAluno.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNomeUsuario);
            this.groupBox2.Controls.Add(this.txtConfirmacaoSenha);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.lblConfirmacao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Login";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(111, 22);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(365, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(311, 48);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.PasswordChar = '*';
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(123, 20);
            this.txtConfirmacaoSenha.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(111, 48);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(112, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Tag = "";
            // 
            // lblConfirmacao
            // 
            this.lblConfirmacao.AutoSize = true;
            this.lblConfirmacao.Location = new System.Drawing.Point(229, 51);
            this.lblConfirmacao.Name = "lblConfirmacao";
            this.lblConfirmacao.Size = new System.Drawing.Size(76, 13);
            this.lblConfirmacao.TabIndex = 4;
            this.lblConfirmacao.Text = "Confirmação: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Usuario: *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionarUsuario);
            this.groupBox1.Controls.Add(this.txtCodigoOperador);
            this.groupBox1.Controls.Add(this.radioButtonSecretariado);
            this.groupBox1.Controls.Add(this.lblCodigoOperador);
            this.groupBox1.Controls.Add(this.radioButtonProfessor);
            this.groupBox1.Controls.Add(this.comboBoxUsuario);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.radioButtonAluno);
            this.groupBox1.Controls.Add(this.radioButtonAdministrador);
            this.groupBox1.Controls.Add(this.lblNomeUsuario);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Usuario";
            // 
            // txtCodigoOperador
            // 
            this.txtCodigoOperador.Enabled = false;
            this.txtCodigoOperador.Location = new System.Drawing.Point(405, 14);
            this.txtCodigoOperador.Name = "txtCodigoOperador";
            this.txtCodigoOperador.ReadOnly = true;
            this.txtCodigoOperador.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoOperador.TabIndex = 5;
            // 
            // radioButtonSecretariado
            // 
            this.radioButtonSecretariado.AutoSize = true;
            this.radioButtonSecretariado.Location = new System.Drawing.Point(233, 19);
            this.radioButtonSecretariado.Name = "radioButtonSecretariado";
            this.radioButtonSecretariado.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSecretariado.TabIndex = 3;
            this.radioButtonSecretariado.TabStop = true;
            this.radioButtonSecretariado.Text = "Secretariado";
            this.radioButtonSecretariado.UseVisualStyleBackColor = true;
            this.radioButtonSecretariado.CheckedChanged += new System.EventHandler(this.radioButtonSecretariado_CheckedChanged);
            // 
            // lblCodigoOperador
            // 
            this.lblCodigoOperador.AutoSize = true;
            this.lblCodigoOperador.Location = new System.Drawing.Point(324, 21);
            this.lblCodigoOperador.Name = "lblCodigoOperador";
            this.lblCodigoOperador.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoOperador.TabIndex = 4;
            this.lblCodigoOperador.Text = "Cód. Operador:";
            // 
            // radioButtonProfessor
            // 
            this.radioButtonProfessor.AutoSize = true;
            this.radioButtonProfessor.Location = new System.Drawing.Point(158, 19);
            this.radioButtonProfessor.Name = "radioButtonProfessor";
            this.radioButtonProfessor.Size = new System.Drawing.Size(69, 17);
            this.radioButtonProfessor.TabIndex = 2;
            this.radioButtonProfessor.TabStop = true;
            this.radioButtonProfessor.Text = "Professor";
            this.radioButtonProfessor.UseVisualStyleBackColor = true;
            this.radioButtonProfessor.CheckedChanged += new System.EventHandler(this.radioButtonProfessor_CheckedChanged);
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(57, 42);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(392, 21);
            this.comboBoxUsuario.TabIndex = 8;
            this.comboBoxUsuario.SelectedValueChanged += new System.EventHandler(this.comboBoxUsuario_SelectedValueChanged);
            this.comboBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxUsuario_KeyPress);
            this.comboBoxUsuario.Leave += new System.EventHandler(this.comboBoxUsuario_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 43);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(377, 20);
            this.txtNome.TabIndex = 7;
            // 
            // radioButtonAluno
            // 
            this.radioButtonAluno.AutoSize = true;
            this.radioButtonAluno.Location = new System.Drawing.Point(100, 19);
            this.radioButtonAluno.Name = "radioButtonAluno";
            this.radioButtonAluno.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAluno.TabIndex = 1;
            this.radioButtonAluno.TabStop = true;
            this.radioButtonAluno.Text = "Aluno";
            this.radioButtonAluno.UseVisualStyleBackColor = true;
            this.radioButtonAluno.CheckedChanged += new System.EventHandler(this.radioButtonAluno_CheckedChanged);
            // 
            // radioButtonAdministrador
            // 
            this.radioButtonAdministrador.AutoSize = true;
            this.radioButtonAdministrador.Checked = true;
            this.radioButtonAdministrador.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAdministrador.Name = "radioButtonAdministrador";
            this.radioButtonAdministrador.Size = new System.Drawing.Size(88, 17);
            this.radioButtonAdministrador.TabIndex = 0;
            this.radioButtonAdministrador.TabStop = true;
            this.radioButtonAdministrador.Text = "Administrador";
            this.radioButtonAdministrador.UseVisualStyleBackColor = true;
            this.radioButtonAdministrador.CheckedChanged += new System.EventHandler(this.radioButtonAdministrador_CheckedChanged);
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
            this.tabPage2.Size = new System.Drawing.Size(494, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(201, 40);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(81, 13);
            this.lblDataAlteracao.TabIndex = 5;
            this.lblDataAlteracao.Text = "Data Alteração:";
            // 
            // txtNomeUsuarioAlterou
            // 
            this.txtNomeUsuarioAlterou.Location = new System.Drawing.Point(139, 59);
            this.txtNomeUsuarioAlterou.Name = "txtNomeUsuarioAlterou";
            this.txtNomeUsuarioAlterou.ReadOnly = true;
            this.txtNomeUsuarioAlterou.Size = new System.Drawing.Size(245, 20);
            this.txtNomeUsuarioAlterou.TabIndex = 9;
            // 
            // txtCodigoUsuarioAlterou
            // 
            this.txtCodigoUsuarioAlterou.Location = new System.Drawing.Point(94, 59);
            this.txtCodigoUsuarioAlterou.Name = "txtCodigoUsuarioAlterou";
            this.txtCodigoUsuarioAlterou.ReadOnly = true;
            this.txtCodigoUsuarioAlterou.Size = new System.Drawing.Size(39, 20);
            this.txtCodigoUsuarioAlterou.TabIndex = 8;
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
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(370, 285);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.txtCodigo);
            this.groupBoxAluno.Controls.Add(this.lblCodigo);
            this.groupBoxAluno.Controls.Add(this.tabControlAluno);
            this.groupBoxAluno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(514, 267);
            this.groupBoxAluno.TabIndex = 0;
            this.groupBoxAluno.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(67, 20);
            this.txtCodigo.TabIndex = 1;
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
            // linkDica
            // 
            this.linkDica.AutoSize = true;
            this.linkDica.Location = new System.Drawing.Point(13, 294);
            this.linkDica.Name = "linkDica";
            this.linkDica.Size = new System.Drawing.Size(314, 13);
            this.linkDica.TabIndex = 3;
            this.linkDica.TabStop = true;
            this.linkDica.Text = "Cadastro Usuário: Nome: Fulano Cicrano Pereira -> fulano.pereira";
            // 
            // FrmUsuario
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 320);
            this.Controls.Add(this.linkDica);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuario_FormClosing);
            this.tabControlAluno.ResumeLayout(false);
            this.tabPageAluno.ResumeLayout(false);
            this.tabPageAluno.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxAluno.ResumeLayout(false);
            this.groupBoxAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSecretariado;
        private System.Windows.Forms.CheckBox checkBoxProfessor;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.CheckBox checkBoxAluno;
        private System.Windows.Forms.Button btnAdicionarInstituicao;
        private System.Windows.Forms.ComboBox comboBoxInstituicao;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TabControl tabControlAluno;
        private System.Windows.Forms.TabPage tabPageAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAlteracao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCadastro;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.TextBox txtNomeUsuarioAlterou;
        private System.Windows.Forms.TextBox txtCodigoUsuarioAlterou;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.Label lblUsuarioAlterou;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.TextBox txtCodigoOperador;
        private System.Windows.Forms.Label lblCodigoOperador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSecretariado;
        private System.Windows.Forms.RadioButton radioButtonProfessor;
        private System.Windows.Forms.RadioButton radioButtonAluno;
        private System.Windows.Forms.RadioButton radioButtonAdministrador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.LinkLabel linkDica;
    }
}