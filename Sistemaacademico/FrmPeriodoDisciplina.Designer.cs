namespace SistemaAcademico
{
    partial class FrmPeriodoDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeriodoDisciplina));
            this.tabControlProfessorDisciplina = new System.Windows.Forms.TabControl();
            this.tabPageProfessorDisciplina = new System.Windows.Forms.TabPage();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarDisciplina = new System.Windows.Forms.Button();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxSecretariado = new System.Windows.Forms.CheckBox();
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
            this.lblProfessor = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBoxProfessorDisciplina = new System.Windows.Forms.GroupBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.tabControlProfessorDisciplina.SuspendLayout();
            this.tabPageProfessorDisciplina.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxProfessorDisciplina.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProfessorDisciplina
            // 
            this.tabControlProfessorDisciplina.Controls.Add(this.tabPageProfessorDisciplina);
            this.tabControlProfessorDisciplina.Controls.Add(this.tabPage2);
            this.tabControlProfessorDisciplina.Location = new System.Drawing.Point(9, 91);
            this.tabControlProfessorDisciplina.Name = "tabControlProfessorDisciplina";
            this.tabControlProfessorDisciplina.SelectedIndex = 0;
            this.tabControlProfessorDisciplina.Size = new System.Drawing.Size(425, 138);
            this.tabControlProfessorDisciplina.TabIndex = 6;
            // 
            // tabPageProfessorDisciplina
            // 
            this.tabPageProfessorDisciplina.Controls.Add(this.txtProfessor);
            this.tabPageProfessorDisciplina.Controls.Add(this.label1);
            this.tabPageProfessorDisciplina.Controls.Add(this.btnAdicionarDisciplina);
            this.tabPageProfessorDisciplina.Controls.Add(this.comboBoxDisciplina);
            this.tabPageProfessorDisciplina.Controls.Add(this.lblDisciplina);
            this.tabPageProfessorDisciplina.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfessorDisciplina.Name = "tabPageProfessorDisciplina";
            this.tabPageProfessorDisciplina.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfessorDisciplina.Size = new System.Drawing.Size(417, 112);
            this.tabPageProfessorDisciplina.TabIndex = 0;
            this.tabPageProfessorDisciplina.Text = "Informações";
            this.tabPageProfessorDisciplina.UseVisualStyleBackColor = true;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(70, 33);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(317, 20);
            this.txtProfessor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Professor:";
            // 
            // btnAdicionarDisciplina
            // 
            this.btnAdicionarDisciplina.FlatAppearance.BorderSize = 0;
            this.btnAdicionarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDisciplina.Image")));
            this.btnAdicionarDisciplina.Location = new System.Drawing.Point(391, 6);
            this.btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            this.btnAdicionarDisciplina.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarDisciplina.TabIndex = 2;
            this.btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            this.btnAdicionarDisciplina.Click += new System.EventHandler(this.btnAdicionarDisciplina_Click);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDisciplina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(70, 6);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(317, 21);
            this.comboBoxDisciplina.TabIndex = 1;
            this.comboBoxDisciplina.SelectedValueChanged += new System.EventHandler(this.comboBoxDisciplina_SelectedValueChanged);
            this.comboBoxDisciplina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDisciplina_KeyPress);
            this.comboBoxDisciplina.Leave += new System.EventHandler(this.comboBoxDisciplina_Leave);
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(5, 10);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(59, 13);
            this.lblDisciplina.TabIndex = 0;
            this.lblDisciplina.Text = "Disciplina:*";
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
            this.tabPage2.Size = new System.Drawing.Size(417, 112);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(21, 16);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(37, 13);
            this.lblProfessor.TabIndex = 0;
            this.lblProfessor.Text = "Curso:";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(377, 256);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(296, 256);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBoxProfessorDisciplina
            // 
            this.groupBoxProfessorDisciplina.Controls.Add(this.txtPeriodo);
            this.groupBoxProfessorDisciplina.Controls.Add(this.label3);
            this.groupBoxProfessorDisciplina.Controls.Add(this.txtTurma);
            this.groupBoxProfessorDisciplina.Controls.Add(this.label2);
            this.groupBoxProfessorDisciplina.Controls.Add(this.txtCurso);
            this.groupBoxProfessorDisciplina.Controls.Add(this.tabControlProfessorDisciplina);
            this.groupBoxProfessorDisciplina.Controls.Add(this.lblProfessor);
            this.groupBoxProfessorDisciplina.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProfessorDisciplina.Name = "groupBoxProfessorDisciplina";
            this.groupBoxProfessorDisciplina.Size = new System.Drawing.Size(440, 238);
            this.groupBoxProfessorDisciplina.TabIndex = 0;
            this.groupBoxProfessorDisciplina.TabStop = false;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(64, 65);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(366, 20);
            this.txtPeriodo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Período:";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(64, 39);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(366, 20);
            this.txtTurma.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turma:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(64, 13);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(366, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // FrmPeriodoDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 288);
            this.Controls.Add(this.groupBoxProfessorDisciplina);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPeriodoDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Período - Disciplina";
            this.tabControlProfessorDisciplina.ResumeLayout(false);
            this.tabPageProfessorDisciplina.ResumeLayout(false);
            this.tabPageProfessorDisciplina.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxProfessorDisciplina.ResumeLayout(false);
            this.groupBoxProfessorDisciplina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProfessorDisciplina;
        private System.Windows.Forms.TabPage tabPageProfessorDisciplina;
        private System.Windows.Forms.Button btnAdicionarDisciplina;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxSecretariado;
        private System.Windows.Forms.CheckBox checkBoxProfessor;
        private System.Windows.Forms.CheckBox checkBoxAluno;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
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
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.GroupBox groupBoxProfessorDisciplina;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurso;
    }
}