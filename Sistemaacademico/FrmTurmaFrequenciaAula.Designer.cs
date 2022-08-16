namespace SistemaAcademico
{
    partial class FrmTurmaFrequenciaAula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtInstituicao = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblInstituicao = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.txtCodigoDisciplina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConteudoVivenciado = new System.Windows.Forms.TextBox();
            this.lblConteudoVivenciado = new System.Windows.Forms.Label();
            this.checkBoxAvaliação = new System.Windows.Forms.CheckBox();
            this.txtQuantidadeAulas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeDataFrequencia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoFrequencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.colCodigoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdFaltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaltou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTotalFaltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBoxAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.txtInstituicao.Size = new System.Drawing.Size(228, 20);
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
            this.txtPeriodo.Location = new System.Drawing.Point(498, 52);
            this.txtPeriodo.MaxLength = 300;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(228, 20);
            this.txtPeriodo.TabIndex = 11;
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
            this.label7.Location = new System.Drawing.Point(444, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
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
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(55, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 1;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtProfessor);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDisciplina);
            this.groupBox4.Controls.Add(this.txtCodigoDisciplina);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(732, 56);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Período e Disciplina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Professor:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(498, 19);
            this.txtProfessor.MaxLength = 300;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(228, 20);
            this.txtProfessor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disciplina:";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(217, 19);
            this.txtDisciplina.MaxLength = 300;
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.ReadOnly = true;
            this.txtDisciplina.Size = new System.Drawing.Size(217, 20);
            this.txtDisciplina.TabIndex = 3;
            // 
            // txtCodigoDisciplina
            // 
            this.txtCodigoDisciplina.Location = new System.Drawing.Point(85, 19);
            this.txtCodigoDisciplina.MaxLength = 300;
            this.txtCodigoDisciplina.Name = "txtCodigoDisciplina";
            this.txtCodigoDisciplina.ReadOnly = true;
            this.txtCodigoDisciplina.Size = new System.Drawing.Size(61, 20);
            this.txtCodigoDisciplina.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cód. Disciplina:";
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.dataGridViewAlunos);
            this.groupBoxAluno.Location = new System.Drawing.Point(12, 293);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(732, 235);
            this.groupBoxAluno.TabIndex = 3;
            this.groupBoxAluno.TabStop = false;
            this.groupBoxAluno.Text = "Aluno(s)";
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoAluno,
            this.colNomeAluno,
            this.colQtdFaltas,
            this.colFaltou,
            this.colTotalFaltas,
            this.colTotalAulas});
            this.dataGridViewAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAlunos.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.ReadOnly = true;
            this.dataGridViewAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlunos.Size = new System.Drawing.Size(726, 216);
            this.dataGridViewAlunos.TabIndex = 0;
            this.dataGridViewAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlunos_CellContentClick);
            this.dataGridViewAlunos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlunos_CellEndEdit);
            this.dataGridViewAlunos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAlunos_CellFormatting);
            this.dataGridViewAlunos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewAlunos_EditingControlShowing);
            this.dataGridViewAlunos.SelectionChanged += new System.EventHandler(this.dataGridViewAlunos_SelectionChanged);
            this.dataGridViewAlunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewAlunos_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(666, 531);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTurno);
            this.groupBox1.Controls.Add(this.txtInstituicao);
            this.groupBox1.Controls.Add(this.txtCurso);
            this.groupBox1.Controls.Add(this.lblCurso);
            this.groupBox1.Controls.Add(this.lblInstituicao);
            this.groupBox1.Controls.Add(this.txtPeriodo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConteudoVivenciado);
            this.groupBox2.Controls.Add(this.lblConteudoVivenciado);
            this.groupBox2.Controls.Add(this.checkBoxAvaliação);
            this.groupBox2.Controls.Add(this.txtQuantidadeAulas);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimeDataFrequencia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCodigoFrequencia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aula";
            // 
            // txtConteudoVivenciado
            // 
            this.txtConteudoVivenciado.Location = new System.Drawing.Point(3, 73);
            this.txtConteudoVivenciado.MaxLength = 300;
            this.txtConteudoVivenciado.Multiline = true;
            this.txtConteudoVivenciado.Name = "txtConteudoVivenciado";
            this.txtConteudoVivenciado.Size = new System.Drawing.Size(723, 45);
            this.txtConteudoVivenciado.TabIndex = 8;
            // 
            // lblConteudoVivenciado
            // 
            this.lblConteudoVivenciado.AutoSize = true;
            this.lblConteudoVivenciado.Location = new System.Drawing.Point(6, 57);
            this.lblConteudoVivenciado.Name = "lblConteudoVivenciado";
            this.lblConteudoVivenciado.Size = new System.Drawing.Size(112, 13);
            this.lblConteudoVivenciado.TabIndex = 7;
            this.lblConteudoVivenciado.Text = "Conteúdo Vivenciado:";
            // 
            // checkBoxAvaliação
            // 
            this.checkBoxAvaliação.AutoSize = true;
            this.checkBoxAvaliação.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAvaliação.Location = new System.Drawing.Point(440, 21);
            this.checkBoxAvaliação.Name = "checkBoxAvaliação";
            this.checkBoxAvaliação.Size = new System.Drawing.Size(73, 17);
            this.checkBoxAvaliação.TabIndex = 6;
            this.checkBoxAvaliação.Text = "Avaliação";
            this.checkBoxAvaliação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAvaliação.UseVisualStyleBackColor = true;
            // 
            // txtQuantidadeAulas
            // 
            this.txtQuantidadeAulas.Location = new System.Drawing.Point(347, 19);
            this.txtQuantidadeAulas.MaxLength = 300;
            this.txtQuantidadeAulas.Name = "txtQuantidadeAulas";
            this.txtQuantidadeAulas.Size = new System.Drawing.Size(87, 20);
            this.txtQuantidadeAulas.TabIndex = 5;
            this.txtQuantidadeAulas.Text = "1";
            this.txtQuantidadeAulas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeAulas_KeyPress);
            this.txtQuantidadeAulas.Leave += new System.EventHandler(this.txtQuantidadeAulas_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Qtde Aulas:";
            // 
            // dateTimeDataFrequencia
            // 
            this.dateTimeDataFrequencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataFrequencia.Location = new System.Drawing.Point(183, 19);
            this.dateTimeDataFrequencia.Name = "dateTimeDataFrequencia";
            this.dateTimeDataFrequencia.Size = new System.Drawing.Size(90, 20);
            this.dateTimeDataFrequencia.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data:";
            // 
            // txtCodigoFrequencia
            // 
            this.txtCodigoFrequencia.Location = new System.Drawing.Point(55, 19);
            this.txtCodigoFrequencia.MaxLength = 300;
            this.txtCodigoFrequencia.Name = "txtCodigoFrequencia";
            this.txtCodigoFrequencia.Size = new System.Drawing.Size(91, 20);
            this.txtCodigoFrequencia.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvar.Location = new System.Drawing.Point(585, 531);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // colCodigoAluno
            // 
            this.colCodigoAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodigoAluno.DataPropertyName = "Aluno,Codigo";
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
            // colQtdFaltas
            // 
            this.colQtdFaltas.DataPropertyName = "QtdFaltas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colQtdFaltas.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQtdFaltas.HeaderText = "Qtd. Faltas";
            this.colQtdFaltas.Name = "colQtdFaltas";
            this.colQtdFaltas.ReadOnly = true;
            // 
            // colFaltou
            // 
            this.colFaltou.DataPropertyName = "Faltou";
            this.colFaltou.HeaderText = "Faltou?";
            this.colFaltou.Name = "colFaltou";
            this.colFaltou.ReadOnly = true;
            // 
            // colTotalFaltas
            // 
            this.colTotalFaltas.DataPropertyName = "TotalFaltas";
            this.colTotalFaltas.HeaderText = "Total de Faltas";
            this.colTotalFaltas.Name = "colTotalFaltas";
            this.colTotalFaltas.ReadOnly = true;
            // 
            // colTotalAulas
            // 
            this.colTotalAulas.DataPropertyName = "TotalAulas";
            this.colTotalAulas.HeaderText = "Total de Aulas";
            this.colTotalAulas.Name = "colTotalAulas";
            this.colTotalAulas.ReadOnly = true;
            // 
            // FrmTurmaFrequenciaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 575);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxAluno);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurmaFrequenciaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequência - Disciplina";
            this.Load += new System.EventHandler(this.FrmTurmaFrequenciaAula_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtInstituicao;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblInstituicao;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.TextBox txtCodigoDisciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.DataGridView dataGridViewAlunos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAvaliação;
        private System.Windows.Forms.TextBox txtQuantidadeAulas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeDataFrequencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoFrequencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConteudoVivenciado;
        private System.Windows.Forms.Label lblConteudoVivenciado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdFaltas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFaltou;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFaltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAulas;
    }
}