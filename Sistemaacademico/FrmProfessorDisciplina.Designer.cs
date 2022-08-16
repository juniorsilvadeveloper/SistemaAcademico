namespace SistemaAcademico
{
    partial class FrmProfessorDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessorDisciplina));
            this.btnSair = new System.Windows.Forms.Button();
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
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.lblUsuarioAlterou = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.comboBoxInstituicao = new System.Windows.Forms.ComboBox();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblProfessor = new System.Windows.Forms.Label();
            this.btnAdicionarInstituicao = new System.Windows.Forms.Button();
            this.groupBoxProfessorDisciplina = new System.Windows.Forms.GroupBox();
            this.tabControlProfessorDisciplina = new System.Windows.Forms.TabControl();
            this.tabPageProfessorDisciplina = new System.Windows.Forms.TabPage();
            this.btnAdicionarProfessor = new System.Windows.Forms.Button();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.btnAdicionarDisciplina = new System.Windows.Forms.Button();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.tabPage2.SuspendLayout();
            this.tabControlProfessorDisciplina.SuspendLayout();
            this.tabPageProfessorDisciplina.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(366, 165);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(285, 165);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.tabPage2.Size = new System.Drawing.Size(425, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // comboBoxInstituicao
            // 
            this.comboBoxInstituicao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInstituicao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInstituicao.FormattingEnabled = true;
            this.comboBoxInstituicao.Location = new System.Drawing.Point(85, 7);
            this.comboBoxInstituicao.Name = "comboBoxInstituicao";
            this.comboBoxInstituicao.Size = new System.Drawing.Size(304, 21);
            this.comboBoxInstituicao.TabIndex = 1;
            this.comboBoxInstituicao.SelectedValueChanged += new System.EventHandler(this.comboBoxInstituição_SelectedValueChanged);
            this.comboBoxInstituicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxInstituicao_KeyPress);
            this.comboBoxInstituicao.Leave += new System.EventHandler(this.comboBoxInstituicao_Leave);
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Location = new System.Drawing.Point(17, 10);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(62, 13);
            this.lblInstituicao.TabIndex = 0;
            this.lblInstituicao.Text = "Instituição:*";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(20, 64);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(59, 13);
            this.lblDisciplina.TabIndex = 5;
            this.lblDisciplina.Text = "Disciplina:*";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(21, 36);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(58, 13);
            this.lblProfessor.TabIndex = 3;
            this.lblProfessor.Text = "Professor:*";
            this.toolTip1.SetToolTip(this.lblProfessor, "Duração Período");
            // 
            // btnAdicionarInstituicao
            // 
            this.btnAdicionarInstituicao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarInstituicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarInstituicao.Image")));
            this.btnAdicionarInstituicao.Location = new System.Drawing.Point(395, 7);
            this.btnAdicionarInstituicao.Name = "btnAdicionarInstituicao";
            this.btnAdicionarInstituicao.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarInstituicao.TabIndex = 2;
            this.btnAdicionarInstituicao.UseVisualStyleBackColor = true;
            this.btnAdicionarInstituicao.Click += new System.EventHandler(this.btnAdicionarInstituicao_Click);
            // 
            // groupBoxProfessorDisciplina
            // 
            this.groupBoxProfessorDisciplina.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProfessorDisciplina.Name = "groupBoxProfessorDisciplina";
            this.groupBoxProfessorDisciplina.Size = new System.Drawing.Size(450, 153);
            this.groupBoxProfessorDisciplina.TabIndex = 6;
            this.groupBoxProfessorDisciplina.TabStop = false;
            // 
            // tabControlProfessorDisciplina
            // 
            this.tabControlProfessorDisciplina.Controls.Add(this.tabPageProfessorDisciplina);
            this.tabControlProfessorDisciplina.Controls.Add(this.tabPage2);
            this.tabControlProfessorDisciplina.Location = new System.Drawing.Point(12, 20);
            this.tabControlProfessorDisciplina.Name = "tabControlProfessorDisciplina";
            this.tabControlProfessorDisciplina.SelectedIndex = 0;
            this.tabControlProfessorDisciplina.Size = new System.Drawing.Size(433, 139);
            this.tabControlProfessorDisciplina.TabIndex = 4;
            // 
            // tabPageProfessorDisciplina
            // 
            this.tabPageProfessorDisciplina.Controls.Add(this.btnAdicionarProfessor);
            this.tabPageProfessorDisciplina.Controls.Add(this.comboBoxProfessor);
            this.tabPageProfessorDisciplina.Controls.Add(this.btnAdicionarDisciplina);
            this.tabPageProfessorDisciplina.Controls.Add(this.comboBoxDisciplina);
            this.tabPageProfessorDisciplina.Controls.Add(this.btnAdicionarInstituicao);
            this.tabPageProfessorDisciplina.Controls.Add(this.comboBoxInstituicao);
            this.tabPageProfessorDisciplina.Controls.Add(this.lblInstituicao);
            this.tabPageProfessorDisciplina.Controls.Add(this.lblProfessor);
            this.tabPageProfessorDisciplina.Controls.Add(this.lblDisciplina);
            this.tabPageProfessorDisciplina.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfessorDisciplina.Name = "tabPageProfessorDisciplina";
            this.tabPageProfessorDisciplina.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfessorDisciplina.Size = new System.Drawing.Size(425, 113);
            this.tabPageProfessorDisciplina.TabIndex = 0;
            this.tabPageProfessorDisciplina.Text = "Informações";
            this.tabPageProfessorDisciplina.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProfessor
            // 
            this.btnAdicionarProfessor.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProfessor.Image")));
            this.btnAdicionarProfessor.Location = new System.Drawing.Point(395, 33);
            this.btnAdicionarProfessor.Name = "btnAdicionarProfessor";
            this.btnAdicionarProfessor.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarProfessor.TabIndex = 9;
            this.btnAdicionarProfessor.UseVisualStyleBackColor = true;
            this.btnAdicionarProfessor.Click += new System.EventHandler(this.btnAdicionarProfessor_Click);
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(85, 33);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(304, 21);
            this.comboBoxProfessor.TabIndex = 8;
            this.comboBoxProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxProfessor_KeyPress);
            this.comboBoxProfessor.Leave += new System.EventHandler(this.comboBoxProfessor_Leave);
            // 
            // btnAdicionarDisciplina
            // 
            this.btnAdicionarDisciplina.FlatAppearance.BorderSize = 0;
            this.btnAdicionarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDisciplina.Image")));
            this.btnAdicionarDisciplina.Location = new System.Drawing.Point(395, 60);
            this.btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            this.btnAdicionarDisciplina.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarDisciplina.TabIndex = 7;
            this.btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            this.btnAdicionarDisciplina.Click += new System.EventHandler(this.btnAdicionarDisciplina_Click);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDisciplina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(85, 60);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(304, 21);
            this.comboBoxDisciplina.TabIndex = 6;
            this.comboBoxDisciplina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDisciplina_KeyPress);
            this.comboBoxDisciplina.Leave += new System.EventHandler(this.comboBoxDisciplina_Leave);
            // 
            // FrmProfessorDisciplina
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 192);
            this.Controls.Add(this.tabControlProfessorDisciplina);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxProfessorDisciplina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfessorDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professor/Disciplina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProfessorDisciplina_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControlProfessorDisciplina.ResumeLayout(false);
            this.tabPageProfessorDisciplina.ResumeLayout(false);
            this.tabPageProfessorDisciplina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
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
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Button btnAdicionarInstituicao;
        private System.Windows.Forms.GroupBox groupBoxProfessorDisciplina;
        private System.Windows.Forms.TabControl tabControlProfessorDisciplina;
        private System.Windows.Forms.TabPage tabPageProfessorDisciplina;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnAdicionarProfessor;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.Button btnAdicionarDisciplina;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
    }
}