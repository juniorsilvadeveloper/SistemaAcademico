namespace SistemaAcademico
{
    partial class FrmConsultarCursoDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarCursoDisciplina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDisciplina = new System.Windows.Forms.DataGridView();
            this.colCodigoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoDisciplina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVincular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDisciplina = new System.Windows.Forms.RadioButton();
            this.radioButtonCurso = new System.Windows.Forms.RadioButton();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dataGridViewCurso = new System.Windows.Forms.DataGridView();
            this.colCodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoCurso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAtivarInativar = new System.Windows.Forms.Button();
            this.groupBoxCurso = new System.Windows.Forms.GroupBox();
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplina)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).BeginInit();
            this.groupBoxCurso.SuspendLayout();
            this.groupBoxConsultar.SuspendLayout();
            this.groupBoxSituacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDisciplina);
            this.groupBox1.Location = new System.Drawing.Point(377, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 251);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dsiciplina(s)";
            // 
            // dataGridViewDisciplina
            // 
            this.dataGridViewDisciplina.AllowUserToAddRows = false;
            this.dataGridViewDisciplina.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoDisciplina,
            this.colNomeDisciplina,
            this.colSituacaoDisciplina});
            this.dataGridViewDisciplina.Location = new System.Drawing.Point(4, 16);
            this.dataGridViewDisciplina.Name = "dataGridViewDisciplina";
            this.dataGridViewDisciplina.ReadOnly = true;
            this.dataGridViewDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDisciplina.Size = new System.Drawing.Size(365, 232);
            this.dataGridViewDisciplina.TabIndex = 0;
            this.dataGridViewDisciplina.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDisciplina_CellFormatting);
            this.dataGridViewDisciplina.SelectionChanged += new System.EventHandler(this.dataGridViewDisciplina_SelectionChanged);
            this.dataGridViewDisciplina.DoubleClick += new System.EventHandler(this.dataGridViewDisciplina_DoubleClick);
            // 
            // colCodigoDisciplina
            // 
            this.colCodigoDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCodigoDisciplina.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoDisciplina.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodigoDisciplina.HeaderText = "Código";
            this.colCodigoDisciplina.Name = "colCodigoDisciplina";
            this.colCodigoDisciplina.ReadOnly = true;
            this.colCodigoDisciplina.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigoDisciplina.Width = 65;
            // 
            // colNomeDisciplina
            // 
            this.colNomeDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeDisciplina.DataPropertyName = "Nome";
            this.colNomeDisciplina.HeaderText = "Nome";
            this.colNomeDisciplina.Name = "colNomeDisciplina";
            this.colNomeDisciplina.ReadOnly = true;
            // 
            // colSituacaoDisciplina
            // 
            this.colSituacaoDisciplina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSituacaoDisciplina.DataPropertyName = "Situacao";
            this.colSituacaoDisciplina.HeaderText = "Situação";
            this.colSituacaoDisciplina.Name = "colSituacaoDisciplina";
            this.colSituacaoDisciplina.ReadOnly = true;
            this.colSituacaoDisciplina.Width = 55;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(653, 88);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(673, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(483, 392);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(75, 23);
            this.btnVincular.TabIndex = 30;
            this.btnVincular.Text = "Vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDisciplina);
            this.groupBox2.Controls.Add(this.radioButtonCurso);
            this.groupBox2.Location = new System.Drawing.Point(8, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 43);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar por:";
            // 
            // radioButtonDisciplina
            // 
            this.radioButtonDisciplina.AutoSize = true;
            this.radioButtonDisciplina.Location = new System.Drawing.Point(56, 19);
            this.radioButtonDisciplina.Name = "radioButtonDisciplina";
            this.radioButtonDisciplina.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDisciplina.TabIndex = 2;
            this.radioButtonDisciplina.Text = "Disciplina";
            this.radioButtonDisciplina.UseVisualStyleBackColor = true;
            this.radioButtonDisciplina.CheckedChanged += new System.EventHandler(this.radioButtonDisciplina_CheckedChanged);
            // 
            // radioButtonCurso
            // 
            this.radioButtonCurso.AutoSize = true;
            this.radioButtonCurso.Checked = true;
            this.radioButtonCurso.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCurso.Name = "radioButtonCurso";
            this.radioButtonCurso.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCurso.TabIndex = 1;
            this.radioButtonCurso.TabStop = true;
            this.radioButtonCurso.Text = "Curso";
            this.radioButtonCurso.UseVisualStyleBackColor = true;
            this.radioButtonCurso.CheckedChanged += new System.EventHandler(this.radioButtonCurso_CheckedChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(402, 392);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 33;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnEixibir_Click);
            // 
            // dataGridViewCurso
            // 
            this.dataGridViewCurso.AllowUserToAddRows = false;
            this.dataGridViewCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoCurso,
            this.colNomeCurso,
            this.colSituacaoCurso});
            this.dataGridViewCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCurso.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCurso.Name = "dataGridViewCurso";
            this.dataGridViewCurso.ReadOnly = true;
            this.dataGridViewCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCurso.Size = new System.Drawing.Size(353, 235);
            this.dataGridViewCurso.TabIndex = 0;
            this.dataGridViewCurso.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCurso_CellFormatting);
            this.dataGridViewCurso.SelectionChanged += new System.EventHandler(this.dataGridViewCurso_SelectionChanged);
            this.dataGridViewCurso.DoubleClick += new System.EventHandler(this.dataGridViewCurso_DoubleClick);
            // 
            // colCodigoCurso
            // 
            this.colCodigoCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCodigoCurso.DataPropertyName = "Codigo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Format = "#,##0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.colCodigoCurso.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCodigoCurso.HeaderText = "Código";
            this.colCodigoCurso.Name = "colCodigoCurso";
            this.colCodigoCurso.ReadOnly = true;
            this.colCodigoCurso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodigoCurso.Width = 65;
            // 
            // colNomeCurso
            // 
            this.colNomeCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeCurso.DataPropertyName = "Nome";
            this.colNomeCurso.HeaderText = "Nome";
            this.colNomeCurso.Name = "colNomeCurso";
            this.colNomeCurso.ReadOnly = true;
            // 
            // colSituacaoCurso
            // 
            this.colSituacaoCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSituacaoCurso.DataPropertyName = "Situacao";
            this.colSituacaoCurso.HeaderText = "Situação";
            this.colSituacaoCurso.Name = "colSituacaoCurso";
            this.colSituacaoCurso.ReadOnly = true;
            this.colSituacaoCurso.Width = 55;
            // 
            // btnAtivarInativar
            // 
            this.btnAtivarInativar.Location = new System.Drawing.Point(564, 392);
            this.btnAtivarInativar.Name = "btnAtivarInativar";
            this.btnAtivarInativar.Size = new System.Drawing.Size(103, 23);
            this.btnAtivarInativar.TabIndex = 32;
            this.btnAtivarInativar.Text = "Ativar/Inativar";
            this.btnAtivarInativar.UseVisualStyleBackColor = true;
            this.btnAtivarInativar.Click += new System.EventHandler(this.btnAtivarInativar_Click);
            // 
            // groupBoxCurso
            // 
            this.groupBoxCurso.Controls.Add(this.dataGridViewCurso);
            this.groupBoxCurso.Location = new System.Drawing.Point(12, 135);
            this.groupBoxCurso.Name = "groupBoxCurso";
            this.groupBoxCurso.Size = new System.Drawing.Size(359, 254);
            this.groupBoxCurso.TabIndex = 28;
            this.groupBoxCurso.TabStop = false;
            this.groupBoxCurso.Text = "Curso(s)";
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNome);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Controls.Add(this.groupBox2);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(740, 117);
            this.groupBoxConsultar.TabIndex = 27;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoInativo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoAtivo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(550, 39);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(184, 43);
            this.groupBoxSituacoes.TabIndex = 13;
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
            this.radioButtonNome.Location = new System.Drawing.Point(490, 58);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 12;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(426, 58);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 11;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.CheckedChanged += new System.EventHandler(this.radioButtonCodigo_CheckedChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(64, 13);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(670, 20);
            this.txtPesquisar.TabIndex = 10;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(5, 20);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 9;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 393);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(34, 13);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ajuda";
            this.toolTip1.SetToolTip(this.linkLabel1, "Dê um duplo clique para consultar o curso ou disciplina com mais informações.");
            // 
            // FrmConsultarCursoDisciplina
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 425);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnAtivarInativar);
            this.Controls.Add(this.groupBoxCurso);
            this.Controls.Add(this.groupBoxConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarCursoDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar - Curso / Disciplina";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).EndInit();
            this.groupBoxCurso.ResumeLayout(false);
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDisciplina;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDisciplina;
        private System.Windows.Forms.RadioButton radioButtonCurso;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dataGridViewCurso;
        private System.Windows.Forms.Button btnAtivarInativar;
        private System.Windows.Forms.GroupBox groupBoxCurso;
        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDisciplina;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacaoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCurso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacaoCurso;
    }
}