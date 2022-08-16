namespace SistemaAcademico
{
    partial class FrmConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarUsuario));
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.groupBoxTipoUsuario = new System.Windows.Forms.GroupBox();
            this.radioButtonTipoUsuarioTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonSecretariado = new System.Windows.Forms.RadioButton();
            this.radioButtonProfessor = new System.Windows.Forms.RadioButton();
            this.radioButtonAluno = new System.Windows.Forms.RadioButton();
            this.radioButtonAdministrador = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioButtonCodigoOperador = new System.Windows.Forms.RadioButton();
            this.radioButtonNomeUsuario = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultado = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeFfantasiaInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdministrador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAluno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProfessor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSecretariado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPermissoes = new System.Windows.Forms.Button();
            this.groupBoxConsultar.SuspendLayout();
            this.groupBoxTipoUsuario.SuspendLayout();
            this.groupBoxSituacoes.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.groupBoxTipoUsuario);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigoOperador);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNomeUsuario);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNome);
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Location = new System.Drawing.Point(2, 12);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(660, 168);
            this.groupBoxConsultar.TabIndex = 0;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // groupBoxTipoUsuario
            // 
            this.groupBoxTipoUsuario.Controls.Add(this.radioButtonTipoUsuarioTodos);
            this.groupBoxTipoUsuario.Controls.Add(this.radioButtonSecretariado);
            this.groupBoxTipoUsuario.Controls.Add(this.radioButtonProfessor);
            this.groupBoxTipoUsuario.Controls.Add(this.radioButtonAluno);
            this.groupBoxTipoUsuario.Controls.Add(this.radioButtonAdministrador);
            this.groupBoxTipoUsuario.Location = new System.Drawing.Point(278, 84);
            this.groupBoxTipoUsuario.Name = "groupBoxTipoUsuario";
            this.groupBoxTipoUsuario.Size = new System.Drawing.Size(376, 46);
            this.groupBoxTipoUsuario.TabIndex = 6;
            this.groupBoxTipoUsuario.TabStop = false;
            this.groupBoxTipoUsuario.Text = "Tipo Usuario";
            // 
            // radioButtonTipoUsuarioTodos
            // 
            this.radioButtonTipoUsuarioTodos.AutoSize = true;
            this.radioButtonTipoUsuarioTodos.Checked = true;
            this.radioButtonTipoUsuarioTodos.Location = new System.Drawing.Point(6, 19);
            this.radioButtonTipoUsuarioTodos.Name = "radioButtonTipoUsuarioTodos";
            this.radioButtonTipoUsuarioTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTipoUsuarioTodos.TabIndex = 9;
            this.radioButtonTipoUsuarioTodos.TabStop = true;
            this.radioButtonTipoUsuarioTodos.Text = "Todos";
            this.radioButtonTipoUsuarioTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecretariado
            // 
            this.radioButtonSecretariado.AutoSize = true;
            this.radioButtonSecretariado.Location = new System.Drawing.Point(293, 19);
            this.radioButtonSecretariado.Name = "radioButtonSecretariado";
            this.radioButtonSecretariado.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSecretariado.TabIndex = 4;
            this.radioButtonSecretariado.Text = "Secretariado";
            this.radioButtonSecretariado.UseVisualStyleBackColor = true;
            this.radioButtonSecretariado.CheckedChanged += new System.EventHandler(this.radioButtonSecretariado_CheckedChanged);
            // 
            // radioButtonProfessor
            // 
            this.radioButtonProfessor.AutoSize = true;
            this.radioButtonProfessor.Location = new System.Drawing.Point(218, 19);
            this.radioButtonProfessor.Name = "radioButtonProfessor";
            this.radioButtonProfessor.Size = new System.Drawing.Size(69, 17);
            this.radioButtonProfessor.TabIndex = 3;
            this.radioButtonProfessor.Text = "Professor";
            this.radioButtonProfessor.UseVisualStyleBackColor = true;
            this.radioButtonProfessor.CheckedChanged += new System.EventHandler(this.radioButtonProfessor_CheckedChanged);
            // 
            // radioButtonAluno
            // 
            this.radioButtonAluno.AutoSize = true;
            this.radioButtonAluno.Location = new System.Drawing.Point(160, 19);
            this.radioButtonAluno.Name = "radioButtonAluno";
            this.radioButtonAluno.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAluno.TabIndex = 2;
            this.radioButtonAluno.Text = "Aluno";
            this.radioButtonAluno.UseVisualStyleBackColor = true;
            this.radioButtonAluno.CheckedChanged += new System.EventHandler(this.radioButtonAluno_CheckedChanged);
            // 
            // radioButtonAdministrador
            // 
            this.radioButtonAdministrador.AutoSize = true;
            this.radioButtonAdministrador.Location = new System.Drawing.Point(67, 19);
            this.radioButtonAdministrador.Name = "radioButtonAdministrador";
            this.radioButtonAdministrador.Size = new System.Drawing.Size(88, 17);
            this.radioButtonAdministrador.TabIndex = 1;
            this.radioButtonAdministrador.Text = "Administrador";
            this.radioButtonAdministrador.UseVisualStyleBackColor = true;
            this.radioButtonAdministrador.CheckedChanged += new System.EventHandler(this.radioButtonAdministrador_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(579, 136);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // radioButtonCodigoOperador
            // 
            this.radioButtonCodigoOperador.AutoSize = true;
            this.radioButtonCodigoOperador.Location = new System.Drawing.Point(74, 48);
            this.radioButtonCodigoOperador.Name = "radioButtonCodigoOperador";
            this.radioButtonCodigoOperador.Size = new System.Drawing.Size(105, 17);
            this.radioButtonCodigoOperador.TabIndex = 3;
            this.radioButtonCodigoOperador.TabStop = true;
            this.radioButtonCodigoOperador.Text = "Codigo Operador";
            this.radioButtonCodigoOperador.UseVisualStyleBackColor = true;
            this.radioButtonCodigoOperador.CheckedChanged += new System.EventHandler(this.radioButtonCodigoOperador_CheckedChanged);
            // 
            // radioButtonNomeUsuario
            // 
            this.radioButtonNomeUsuario.AutoSize = true;
            this.radioButtonNomeUsuario.Location = new System.Drawing.Point(244, 48);
            this.radioButtonNomeUsuario.Name = "radioButtonNomeUsuario";
            this.radioButtonNomeUsuario.Size = new System.Drawing.Size(92, 17);
            this.radioButtonNomeUsuario.TabIndex = 5;
            this.radioButtonNomeUsuario.TabStop = true;
            this.radioButtonNomeUsuario.Text = "Nome Usuario";
            this.radioButtonNomeUsuario.UseVisualStyleBackColor = true;
            this.radioButtonNomeUsuario.CheckedChanged += new System.EventHandler(this.radioButtonNomeUsuario_CheckedChanged);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Checked = true;
            this.radioButtonNome.Location = new System.Drawing.Point(185, 48);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 4;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoInativo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoAtivo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(470, 39);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(184, 39);
            this.groupBoxSituacoes.TabIndex = 7;
            this.groupBoxSituacoes.TabStop = false;
            this.groupBoxSituacoes.Text = "Situação";
            // 
            // radioButtonSituacaoInativo
            // 
            this.radioButtonSituacaoInativo.AutoSize = true;
            this.radioButtonSituacaoInativo.Location = new System.Drawing.Point(122, 17);
            this.radioButtonSituacaoInativo.Name = "radioButtonSituacaoInativo";
            this.radioButtonSituacaoInativo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSituacaoInativo.TabIndex = 2;
            this.radioButtonSituacaoInativo.Text = "Inativo";
            this.radioButtonSituacaoInativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSituacaoAtivo
            // 
            this.radioButtonSituacaoAtivo.AutoSize = true;
            this.radioButtonSituacaoAtivo.Location = new System.Drawing.Point(67, 17);
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
            this.radioButtonSituacaoTodos.Location = new System.Drawing.Point(6, 16);
            this.radioButtonSituacaoTodos.Name = "radioButtonSituacaoTodos";
            this.radioButtonSituacaoTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSituacaoTodos.TabIndex = 0;
            this.radioButtonSituacaoTodos.TabStop = true;
            this.radioButtonSituacaoTodos.Text = "Todos";
            this.radioButtonSituacaoTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(10, 48);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 2;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.CheckedChanged += new System.EventHandler(this.radioButtonCodigo_CheckedChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(66, 13);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(588, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(7, 20);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.dataGridViewResultado);
            this.groupBoxResultado.Location = new System.Drawing.Point(2, 186);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(660, 254);
            this.groupBoxResultado.TabIndex = 1;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado";
            // 
            // dataGridViewResultado
            // 
            this.dataGridViewResultado.AllowUserToAddRows = false;
            this.dataGridViewResultado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewResultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCodigoOperador,
            this.colNome,
            this.colMatricula,
            this.colNomeFfantasiaInstituicao,
            this.colAdministrador,
            this.colAluno,
            this.colProfessor,
            this.colSecretariado,
            this.colSituacao});
            this.dataGridViewResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultado.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.ReadOnly = true;
            this.dataGridViewResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultado.Size = new System.Drawing.Size(654, 235);
            this.dataGridViewResultado.TabIndex = 0;
            this.dataGridViewResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewResultado_CellFormatting);
            this.dataGridViewResultado.SelectionChanged += new System.EventHandler(this.dataGridViewResultado_SelectionChanged);
            this.dataGridViewResultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewResultado_MouseDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigo.Width = 80;
            // 
            // colCodigoOperador
            // 
            this.colCodigoOperador.DataPropertyName = "IdUsuario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodigoOperador.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCodigoOperador.HeaderText = "CodigoOperador";
            this.colCodigoOperador.Name = "colCodigoOperador";
            this.colCodigoOperador.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "NomeReal";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 150;
            // 
            // colMatricula
            // 
            this.colMatricula.DataPropertyName = "NomeUsuario";
            this.colMatricula.HeaderText = "Nome Usuário";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.ReadOnly = true;
            // 
            // colNomeFfantasiaInstituicao
            // 
            this.colNomeFfantasiaInstituicao.DataPropertyName = "Instituicao.NomeFantasia";
            this.colNomeFfantasiaInstituicao.FillWeight = 200F;
            this.colNomeFfantasiaInstituicao.HeaderText = "Instituição - Fantasia";
            this.colNomeFfantasiaInstituicao.Name = "colNomeFfantasiaInstituicao";
            this.colNomeFfantasiaInstituicao.ReadOnly = true;
            this.colNomeFfantasiaInstituicao.Width = 150;
            // 
            // colAdministrador
            // 
            this.colAdministrador.DataPropertyName = "Administrador";
            this.colAdministrador.HeaderText = "Administrador";
            this.colAdministrador.Name = "colAdministrador";
            this.colAdministrador.ReadOnly = true;
            // 
            // colAluno
            // 
            this.colAluno.DataPropertyName = "Aluno";
            this.colAluno.HeaderText = "Aluno";
            this.colAluno.Name = "colAluno";
            this.colAluno.ReadOnly = true;
            // 
            // colProfessor
            // 
            this.colProfessor.DataPropertyName = "Professor";
            this.colProfessor.HeaderText = "Professor";
            this.colProfessor.Name = "colProfessor";
            this.colProfessor.ReadOnly = true;
            // 
            // colSecretariado
            // 
            this.colSecretariado.DataPropertyName = "Secretariado";
            this.colSecretariado.HeaderText = "Secretariado";
            this.colSecretariado.Name = "colSecretariado";
            this.colSecretariado.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.DataPropertyName = "Situacao";
            this.colSituacao.HeaderText = "Situacao";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Width = 70;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(587, 446);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(506, 446);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(425, 446);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(322, 446);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(97, 23);
            this.btnNovoUsuario.TabIndex = 4;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(241, 446);
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
            this.lblTotalRegistros.Location = new System.Drawing.Point(3, 451);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 2;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 464);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ajuda";
            this.toolTip1.SetToolTip(this.linkLabel1, "Dê um duplo clique no usuário para realizar a consulta com mais informações do ti" +
        "po usuário.");
            // 
            // btnPermissoes
            // 
            this.btnPermissoes.Location = new System.Drawing.Point(160, 446);
            this.btnPermissoes.Name = "btnPermissoes";
            this.btnPermissoes.Size = new System.Drawing.Size(75, 23);
            this.btnPermissoes.TabIndex = 29;
            this.btnPermissoes.Text = "Permissões";
            this.btnPermissoes.UseVisualStyleBackColor = true;
            this.btnPermissoes.Click += new System.EventHandler(this.btnPermissoes_Click);
            // 
            // FrmConsultarUsuario
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 481);
            this.Controls.Add(this.btnPermissoes);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBoxConsultar);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblTotalRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar  - Usuario ";
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.groupBoxTipoUsuario.ResumeLayout(false);
            this.groupBoxTipoUsuario.PerformLayout();
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.RadioButton radioButtonCodigoOperador;
        private System.Windows.Forms.RadioButton radioButtonNomeUsuario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dataGridViewResultado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.GroupBox groupBoxTipoUsuario;
        private System.Windows.Forms.RadioButton radioButtonSecretariado;
        private System.Windows.Forms.RadioButton radioButtonProfessor;
        private System.Windows.Forms.RadioButton radioButtonAluno;
        private System.Windows.Forms.RadioButton radioButtonAdministrador;
        private System.Windows.Forms.RadioButton radioButtonTipoUsuarioTodos;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFfantasiaInstituicao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAdministrador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAluno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProfessor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSecretariado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacao;
        private System.Windows.Forms.Button btnPermissoes;
    }
}