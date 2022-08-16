namespace SistemaAcademico
{
    partial class FrmConsultarDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarDisciplina));
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovaDisciplina = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultado = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExibir = new System.Windows.Forms.Button();
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.groupBoxSituacoes.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
            this.groupBoxConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(16, 371);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 18;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoInativo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoAtivo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(244, 39);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(184, 43);
            this.groupBoxSituacoes.TabIndex = 8;
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
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(291, 389);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(210, 389);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovaDisciplina
            // 
            this.btnNovaDisciplina.Location = new System.Drawing.Point(107, 389);
            this.btnNovaDisciplina.Name = "btnNovaDisciplina";
            this.btnNovaDisciplina.Size = new System.Drawing.Size(97, 23);
            this.btnNovaDisciplina.TabIndex = 20;
            this.btnNovaDisciplina.Text = "Nova Disciplina";
            this.btnNovaDisciplina.UseVisualStyleBackColor = true;
            this.btnNovaDisciplina.Click += new System.EventHandler(this.btnNovaDisciplina_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(357, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPesquisar_KeyPress);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Checked = true;
            this.radioButtonNome.Location = new System.Drawing.Point(184, 58);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 3;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(120, 58);
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
            this.txtPesquisar.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(372, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
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
            this.groupBoxResultado.Location = new System.Drawing.Point(13, 149);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(434, 219);
            this.groupBoxResultado.TabIndex = 17;
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
            this.colNome});
            this.dataGridViewResultado.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.ReadOnly = true;
            this.dataGridViewResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultado.Size = new System.Drawing.Size(422, 194);
            this.dataGridViewResultado.TabIndex = 0;
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
            this.colCodigo.ToolTipText = "Código do cargo";
            this.colCodigo.Width = 80;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.ToolTipText = "Nome do cargo";
            this.colNome.Width = 300;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(26, 389);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 19;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNome);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Location = new System.Drawing.Point(13, 27);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(434, 111);
            this.groupBoxConsultar.TabIndex = 16;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // FrmConsultarDisciplina
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 422);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovaDisciplina);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.groupBoxConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmConsultarDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar - Disciplina";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmConsultarDisciplina_KeyPress);
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovaDisciplina;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dataGridViewResultado;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
    }
}