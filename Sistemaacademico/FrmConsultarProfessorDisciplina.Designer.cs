namespace SistemaAcademico
{
    partial class FrmConsultarProfessorDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProfessorDisciplina));
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDisciplina = new System.Windows.Forms.RadioButton();
            this.radioButtonProfessor = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewProfessor = new System.Windows.Forms.DataGridView();
            this.colCodigoProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoProfessor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDisciplina = new System.Windows.Forms.DataGridView();
            this.colCodigoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoDisciplina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnAtivarInativar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBoxConsultar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSituacoes.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.groupBox2);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCPF);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNome);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxCPF);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(740, 117);
            this.groupBoxConsultar.TabIndex = 1;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDisciplina);
            this.groupBox2.Controls.Add(this.radioButtonProfessor);
            this.groupBox2.Location = new System.Drawing.Point(10, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 43);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar por:";
            // 
            // radioButtonDisciplina
            // 
            this.radioButtonDisciplina.AutoSize = true;
            this.radioButtonDisciplina.Location = new System.Drawing.Point(74, 19);
            this.radioButtonDisciplina.Name = "radioButtonDisciplina";
            this.radioButtonDisciplina.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDisciplina.TabIndex = 2;
            this.radioButtonDisciplina.Text = "Disciplina";
            this.radioButtonDisciplina.UseVisualStyleBackColor = true;
            this.radioButtonDisciplina.CheckedChanged += new System.EventHandler(this.radioButtonDisciplina_CheckedChanged);
            // 
            // radioButtonProfessor
            // 
            this.radioButtonProfessor.AutoSize = true;
            this.radioButtonProfessor.Checked = true;
            this.radioButtonProfessor.Location = new System.Drawing.Point(6, 19);
            this.radioButtonProfessor.Name = "radioButtonProfessor";
            this.radioButtonProfessor.Size = new System.Drawing.Size(69, 17);
            this.radioButtonProfessor.TabIndex = 1;
            this.radioButtonProfessor.TabStop = true;
            this.radioButtonProfessor.Text = "Professor";
            this.radioButtonProfessor.UseVisualStyleBackColor = true;
            this.radioButtonProfessor.CheckedChanged += new System.EventHandler(this.radioButtonProfessor_CheckedChanged);
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.Location = new System.Drawing.Point(492, 58);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(45, 17);
            this.radioButtonCPF.TabIndex = 5;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            this.radioButtonCPF.CheckedChanged += new System.EventHandler(this.radioButtonCPF_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(659, 88);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPesquisar_KeyPress);
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoInativo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoAtivo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(550, 39);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(184, 43);
            this.groupBoxSituacoes.TabIndex = 6;
            this.groupBoxSituacoes.TabStop = false;
            this.groupBoxSituacoes.Text = "Situação";
            // 
            // radioButtonSituacaoInativo
            // 
            this.radioButtonSituacaoInativo.AutoSize = true;
            this.radioButtonSituacaoInativo.Location = new System.Drawing.Point(122, 19);
            this.radioButtonSituacaoInativo.Name = "radioButtonSituacaoInativo";
            this.radioButtonSituacaoInativo.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSituacaoInativo.TabIndex = 2;
            this.radioButtonSituacaoInativo.Text = "Inativo";
            this.radioButtonSituacaoInativo.UseVisualStyleBackColor = true;
            this.radioButtonSituacaoInativo.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoInativo_CheckedChanged);
            // 
            // radioButtonSituacaoAtivo
            // 
            this.radioButtonSituacaoAtivo.AutoSize = true;
            this.radioButtonSituacaoAtivo.Location = new System.Drawing.Point(67, 19);
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
            this.radioButtonSituacaoTodos.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSituacaoTodos.Name = "radioButtonSituacaoTodos";
            this.radioButtonSituacaoTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSituacaoTodos.TabIndex = 0;
            this.radioButtonSituacaoTodos.TabStop = true;
            this.radioButtonSituacaoTodos.Text = "Todos";
            this.radioButtonSituacaoTodos.UseVisualStyleBackColor = true;
            this.radioButtonSituacaoTodos.CheckedChanged += new System.EventHandler(this.radioButtonSituacaoTodos_CheckedChanged);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Checked = true;
            this.radioButtonNome.Location = new System.Drawing.Point(433, 58);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 4;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(369, 58);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 3;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.CheckedChanged += new System.EventHandler(this.radioButtonCodigo_CheckedChanged);
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(67, 13);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBoxCPF.TabIndex = 1;
            this.maskedTextBoxCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCPF.Visible = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(66, 13);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(668, 20);
            this.txtPesquisar.TabIndex = 2;
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
            this.groupBoxResultado.Controls.Add(this.dataGridViewProfessor);
            this.groupBoxResultado.Location = new System.Drawing.Point(12, 135);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(363, 254);
            this.groupBoxResultado.TabIndex = 2;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Professor(es)";
            // 
            // dataGridViewProfessor
            // 
            this.dataGridViewProfessor.AllowUserToAddRows = false;
            this.dataGridViewProfessor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewProfessor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoProfessor,
            this.colNomeProfessor,
            this.colSituacaoProfessor});
            this.dataGridViewProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProfessor.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewProfessor.Name = "dataGridViewProfessor";
            this.dataGridViewProfessor.ReadOnly = true;
            this.dataGridViewProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProfessor.Size = new System.Drawing.Size(357, 235);
            this.dataGridViewProfessor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dataGridViewProfessor, "Dê um duplo clique para consultar o professor.");
            this.dataGridViewProfessor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProfessor_CellFormatting);
            this.dataGridViewProfessor.SelectionChanged += new System.EventHandler(this.dataGridViewProfessor_SelectionChanged);
            this.dataGridViewProfessor.DoubleClick += new System.EventHandler(this.dataGridViewProfessor_DoubleClick);
            // 
            // colCodigoProfessor
            // 
            this.colCodigoProfessor.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoProfessor.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigoProfessor.HeaderText = "Código";
            this.colCodigoProfessor.Name = "colCodigoProfessor";
            this.colCodigoProfessor.ReadOnly = true;
            this.colCodigoProfessor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigoProfessor.ToolTipText = "Código do professor";
            this.colCodigoProfessor.Width = 65;
            // 
            // colNomeProfessor
            // 
            this.colNomeProfessor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeProfessor.DataPropertyName = "Nome";
            this.colNomeProfessor.HeaderText = "Nome";
            this.colNomeProfessor.Name = "colNomeProfessor";
            this.colNomeProfessor.ReadOnly = true;
            // 
            // colSituacaoProfessor
            // 
            this.colSituacaoProfessor.DataPropertyName = "Situacao";
            this.colSituacaoProfessor.HeaderText = "Situação";
            this.colSituacaoProfessor.Name = "colSituacaoProfessor";
            this.colSituacaoProfessor.ReadOnly = true;
            this.colSituacaoProfessor.Width = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDisciplina);
            this.groupBox1.Location = new System.Drawing.Point(381, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 251);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dsiciplina(s)";
            // 
            // dataGridViewDisciplina
            // 
            this.dataGridViewDisciplina.AllowUserToAddRows = false;
            this.dataGridViewDisciplina.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoDisciplina,
            this.colNomeDisciplina,
            this.colSituacaoDisciplina});
            this.dataGridViewDisciplina.Location = new System.Drawing.Point(0, 16);
            this.dataGridViewDisciplina.Name = "dataGridViewDisciplina";
            this.dataGridViewDisciplina.ReadOnly = true;
            this.dataGridViewDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDisciplina.Size = new System.Drawing.Size(371, 235);
            this.dataGridViewDisciplina.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dataGridViewDisciplina, "Dê um duplo clique para consultar a disciplina.");
            this.dataGridViewDisciplina.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDisciplina_CellFormatting);
            this.dataGridViewDisciplina.SelectionChanged += new System.EventHandler(this.dataGridViewDisciplina_SelectionChanged);
            this.dataGridViewDisciplina.DoubleClick += new System.EventHandler(this.dataGridViewDisciplina_DoubleClick);
            // 
            // colCodigoDisciplina
            // 
            this.colCodigoDisciplina.DataPropertyName = "Codigo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Format = "#,##0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoDisciplina.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCodigoDisciplina.HeaderText = "Código";
            this.colCodigoDisciplina.Name = "colCodigoDisciplina";
            this.colCodigoDisciplina.ReadOnly = true;
            this.colCodigoDisciplina.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigoDisciplina.ToolTipText = "Código do cargo";
            this.colCodigoDisciplina.Width = 65;
            // 
            // colNomeDisciplina
            // 
            this.colNomeDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeDisciplina.DataPropertyName = "Nome";
            this.colNomeDisciplina.HeaderText = "Nome";
            this.colNomeDisciplina.Name = "colNomeDisciplina";
            this.colNomeDisciplina.ReadOnly = true;
            this.colNomeDisciplina.ToolTipText = "Nome do cargo";
            // 
            // colSituacaoDisciplina
            // 
            this.colSituacaoDisciplina.DataPropertyName = "Situacao";
            this.colSituacaoDisciplina.HeaderText = "Situação";
            this.colSituacaoDisciplina.Name = "colSituacaoDisciplina";
            this.colSituacaoDisciplina.ReadOnly = true;
            this.colSituacaoDisciplina.Width = 55;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(678, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(487, 392);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(75, 23);
            this.btnVincular.TabIndex = 24;
            this.btnVincular.Text = "Vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // btnAtivarInativar
            // 
            this.btnAtivarInativar.Location = new System.Drawing.Point(569, 392);
            this.btnAtivarInativar.Name = "btnAtivarInativar";
            this.btnAtivarInativar.Size = new System.Drawing.Size(103, 23);
            this.btnAtivarInativar.TabIndex = 25;
            this.btnAtivarInativar.Text = "Ativar/Inativar";
            this.btnAtivarInativar.UseVisualStyleBackColor = true;
            this.btnAtivarInativar.Click += new System.EventHandler(this.btnAtivarInativar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(406, 392);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 26;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 395);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ajuda";
            this.toolTip1.SetToolTip(this.linkLabel1, "Dê um duplo clique para consultar o professor ou disciplina com mais informações." +
        "");
            // 
            // FrmConsultarProfessorDisciplina
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 424);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnAtivarInativar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.groupBoxConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarProfessorDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar - Professor / Disciplina";
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dataGridViewProfessor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDisciplina;
        private System.Windows.Forms.RadioButton radioButtonProfessor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDisciplina;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnAtivarInativar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProfessor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacaoProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDisciplina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacaoDisciplina;
    }
}