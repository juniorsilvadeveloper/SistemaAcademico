namespace SistemaAcademico
{
    partial class FrmTurmaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurmaAluno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisarMatricula = new System.Windows.Forms.TextBox();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.colCodigoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 93);
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
            this.groupBox2.Location = new System.Drawing.Point(503, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 35);
            this.groupBox2.TabIndex = 27;
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
            this.label1.Location = new System.Drawing.Point(279, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Turno:";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(323, 57);
            this.txtTurno.MaxLength = 300;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(115, 20);
            this.txtTurno.TabIndex = 25;
            // 
            // txtInstituicao
            // 
            this.txtInstituicao.Location = new System.Drawing.Point(477, 20);
            this.txtInstituicao.MaxLength = 300;
            this.txtInstituicao.Name = "txtInstituicao";
            this.txtInstituicao.ReadOnly = true;
            this.txtInstituicao.Size = new System.Drawing.Size(293, 20);
            this.txtInstituicao.TabIndex = 24;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(55, 57);
            this.txtCurso.MaxLength = 300;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(218, 20);
            this.txtCurso.TabIndex = 23;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(444, 60);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(59, 13);
            this.lblSituacao.TabIndex = 22;
            this.lblSituacao.Text = "Situação: *";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(9, 60);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(40, 13);
            this.lblCurso.TabIndex = 19;
            this.lblCurso.Text = "Curso: ";
            // 
            // lblInstituicao
            // 
            this.lblInstituicao.AutoSize = true;
            this.lblInstituicao.Location = new System.Drawing.Point(406, 23);
            this.lblInstituicao.Name = "lblInstituicao";
            this.lblInstituicao.Size = new System.Drawing.Size(65, 13);
            this.lblInstituicao.TabIndex = 14;
            this.lblInstituicao.Text = "Instituição: *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 20);
            this.txtNome.MaxLength = 300;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(217, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(132, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome: *";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código:";
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.dataGridViewAluno);
            this.groupBoxAluno.Location = new System.Drawing.Point(12, 174);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(738, 235);
            this.groupBoxAluno.TabIndex = 43;
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
            this.colEmailAluno,
            this.colAtivo});
            this.dataGridViewAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAluno.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ReadOnly = true;
            this.dataGridViewAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAluno.Size = new System.Drawing.Size(732, 216);
            this.dataGridViewAluno.TabIndex = 0;
            this.dataGridViewAluno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAluno_CellFormatting);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(675, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 45;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(594, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPesquisarMatricula);
            this.groupBox3.Controls.Add(this.txtPesquisarNome);
            this.groupBox3.Controls.Add(this.lblMatricula);
            this.groupBox3.Controls.Add(this.maskedTextBoxCPF);
            this.groupBox3.Controls.Add(this.lblCPF);
            this.groupBox3.Location = new System.Drawing.Point(12, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 57);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome: *";
            // 
            // txtPesquisarMatricula
            // 
            this.txtPesquisarMatricula.Location = new System.Drawing.Point(212, 19);
            this.txtPesquisarMatricula.MaxLength = 100;
            this.txtPesquisarMatricula.Name = "txtPesquisarMatricula";
            this.txtPesquisarMatricula.Size = new System.Drawing.Size(86, 20);
            this.txtPesquisarMatricula.TabIndex = 16;
            this.txtPesquisarMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            this.txtPesquisarMatricula.Leave += new System.EventHandler(this.txtMatricula_Leave);
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(355, 19);
            this.txtPesquisarNome.MaxLength = 300;
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(411, 20);
            this.txtPesquisarNome.TabIndex = 24;
            this.txtPesquisarNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisarNome_KeyPress);
            this.txtPesquisarNome.Leave += new System.EventHandler(this.txtPesquisarNome_Leave);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(144, 23);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(62, 13);
            this.lblMatricula.TabIndex = 15;
            this.lblMatricula.Text = "Matrícula: *";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(55, 20);
            this.maskedTextBoxCPF.Mask = "###.###.###-##";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBoxCPF.TabIndex = 14;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCPF_KeyPress);
            this.maskedTextBoxCPF.Leave += new System.EventHandler(this.maskedTextBoxCPF_Leave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 22);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 13);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "CPF: *";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(756, 190);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(13, 13);
            this.btnAdicionar.TabIndex = 46;
            this.toolTip1.SetToolTip(this.btnAdicionar, "Adicionar");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(756, 213);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(13, 13);
            this.btnRemover.TabIndex = 47;
            this.toolTip1.SetToolTip(this.btnRemover, "Remover");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
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
            // colEmailAluno
            // 
            this.colEmailAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmailAluno.DataPropertyName = "Aluno.Email";
            this.colEmailAluno.HeaderText = "E-mail";
            this.colEmailAluno.Name = "colEmailAluno";
            this.colEmailAluno.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAtivo.DataPropertyName = "Ativo";
            this.colAtivo.FillWeight = 200F;
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAtivo.Visible = false;
            this.colAtivo.Width = 56;
            // 
            // FrmTurmaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxAluno);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurmaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTurmaAluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtInstituicao;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSituacaoEmAndamento;
        private System.Windows.Forms.RadioButton radioButtonSituacaoCancelado;
        private System.Windows.Forms.RadioButton radioButtonSituacaoFinalizado;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisarMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailAluno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
    }
}