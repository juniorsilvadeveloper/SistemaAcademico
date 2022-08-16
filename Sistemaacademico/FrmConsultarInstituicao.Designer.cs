
namespace SistemaAcademico
{
    partial class FrmConsultarInstituicao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarInstituicao));
            this.groupBoxConsultar = new System.Windows.Forms.GroupBox();
            this.radioButtonCNPJ = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBoxSituacoes = new System.Windows.Forms.GroupBox();
            this.radioButtonSituacaoInativo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoAtivo = new System.Windows.Forms.RadioButton();
            this.radioButtonSituacaoTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonRazaoSocial = new System.Windows.Forms.RadioButton();
            this.radioButtonNomeFantasia = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultado = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazaoSocialInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeFantasiaInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNPJInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiglaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefoneInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailInstituicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoInstituicao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovaInstituicao = new System.Windows.Forms.Button();
            this.groupBoxConsultar.SuspendLayout();
            this.groupBoxSituacoes.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConsultar
            // 
            this.groupBoxConsultar.Controls.Add(this.radioButtonCNPJ);
            this.groupBoxConsultar.Controls.Add(this.btnPesquisar);
            this.groupBoxConsultar.Controls.Add(this.groupBoxSituacoes);
            this.groupBoxConsultar.Controls.Add(this.radioButtonRazaoSocial);
            this.groupBoxConsultar.Controls.Add(this.radioButtonNomeFantasia);
            this.groupBoxConsultar.Controls.Add(this.radioButtonCodigo);
            this.groupBoxConsultar.Controls.Add(this.maskedTextBoxCNPJ);
            this.groupBoxConsultar.Controls.Add(this.txtPesquisar);
            this.groupBoxConsultar.Controls.Add(this.lblPesquisar);
            this.groupBoxConsultar.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConsultar.Name = "groupBoxConsultar";
            this.groupBoxConsultar.Size = new System.Drawing.Size(660, 117);
            this.groupBoxConsultar.TabIndex = 0;
            this.groupBoxConsultar.TabStop = false;
            this.groupBoxConsultar.Text = "Consultar";
            // 
            // radioButtonCNPJ
            // 
            this.radioButtonCNPJ.AutoSize = true;
            this.radioButtonCNPJ.Location = new System.Drawing.Point(412, 58);
            this.radioButtonCNPJ.Name = "radioButtonCNPJ";
            this.radioButtonCNPJ.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCNPJ.TabIndex = 6;
            this.radioButtonCNPJ.TabStop = true;
            this.radioButtonCNPJ.Text = "CNPJ";
            this.radioButtonCNPJ.UseVisualStyleBackColor = true;
            this.radioButtonCNPJ.CheckedChanged += new System.EventHandler(this.radioButtonCNPJ_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(579, 88);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBoxSituacoes
            // 
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoInativo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoAtivo);
            this.groupBoxSituacoes.Controls.Add(this.radioButtonSituacaoTodos);
            this.groupBoxSituacoes.Location = new System.Drawing.Point(470, 39);
            this.groupBoxSituacoes.Name = "groupBoxSituacoes";
            this.groupBoxSituacoes.Size = new System.Drawing.Size(184, 43);
            this.groupBoxSituacoes.TabIndex = 7;
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
            // radioButtonRazaoSocial
            // 
            this.radioButtonRazaoSocial.AutoSize = true;
            this.radioButtonRazaoSocial.Location = new System.Drawing.Point(318, 58);
            this.radioButtonRazaoSocial.Name = "radioButtonRazaoSocial";
            this.radioButtonRazaoSocial.Size = new System.Drawing.Size(88, 17);
            this.radioButtonRazaoSocial.TabIndex = 5;
            this.radioButtonRazaoSocial.Text = "Razão Social";
            this.radioButtonRazaoSocial.UseVisualStyleBackColor = true;
            this.radioButtonRazaoSocial.CheckedChanged += new System.EventHandler(this.radioButtonRazaoSocial_CheckedChanged);
            // 
            // radioButtonNomeFantasia
            // 
            this.radioButtonNomeFantasia.AutoSize = true;
            this.radioButtonNomeFantasia.Checked = true;
            this.radioButtonNomeFantasia.Location = new System.Drawing.Point(216, 58);
            this.radioButtonNomeFantasia.Name = "radioButtonNomeFantasia";
            this.radioButtonNomeFantasia.Size = new System.Drawing.Size(96, 17);
            this.radioButtonNomeFantasia.TabIndex = 4;
            this.radioButtonNomeFantasia.TabStop = true;
            this.radioButtonNomeFantasia.Text = "Nome Fantasia";
            this.radioButtonNomeFantasia.UseVisualStyleBackColor = true;
            this.radioButtonNomeFantasia.CheckedChanged += new System.EventHandler(this.radioButtonNomeFantasia_CheckedChanged);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(152, 58);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 3;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.CheckedChanged += new System.EventHandler(this.radioButtonCodigo_CheckedChanged);
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(67, 13);
            this.maskedTextBoxCNPJ.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCNPJ.TabIndex = 1;
            this.maskedTextBoxCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCNPJ.Visible = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(66, 13);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(588, 20);
            this.txtPesquisar.TabIndex = 2;
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
            this.groupBoxResultado.Location = new System.Drawing.Point(13, 136);
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
            this.colRazaoSocialInstituicao,
            this.colNomeFantasiaInstituicao,
            this.colCNPJInstituicao,
            this.colNomeCidade,
            this.colSiglaEstado,
            this.colTelefoneInstituicao,
            this.colEmailInstituicao,
            this.colSituacaoInstituicao,
            this.usuario});
            this.dataGridViewResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultado.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.ReadOnly = true;
            this.dataGridViewResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultado.Size = new System.Drawing.Size(654, 235);
            this.dataGridViewResultado.TabIndex = 0;
            this.dataGridViewResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewResultado_CellFormatting);
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
            this.colCodigo.ToolTipText = "Código da instituição";
            this.colCodigo.Width = 80;
            // 
            // colRazaoSocialInstituicao
            // 
            this.colRazaoSocialInstituicao.DataPropertyName = "RazaoSocial";
            this.colRazaoSocialInstituicao.HeaderText = "Razao Social";
            this.colRazaoSocialInstituicao.Name = "colRazaoSocialInstituicao";
            this.colRazaoSocialInstituicao.ReadOnly = true;
            this.colRazaoSocialInstituicao.Width = 200;
            // 
            // colNomeFantasiaInstituicao
            // 
            this.colNomeFantasiaInstituicao.DataPropertyName = "NomeFantasia";
            this.colNomeFantasiaInstituicao.HeaderText = "Nome Fantasia";
            this.colNomeFantasiaInstituicao.Name = "colNomeFantasiaInstituicao";
            this.colNomeFantasiaInstituicao.ReadOnly = true;
            this.colNomeFantasiaInstituicao.Width = 200;
            // 
            // colCNPJInstituicao
            // 
            this.colCNPJInstituicao.DataPropertyName = "CNPJ";
            dataGridViewCellStyle3.Format = "\"00.000.000/0000-00\"";
            dataGridViewCellStyle3.NullValue = null;
            this.colCNPJInstituicao.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCNPJInstituicao.HeaderText = "CNPJ";
            this.colCNPJInstituicao.Name = "colCNPJInstituicao";
            this.colCNPJInstituicao.ReadOnly = true;
            this.colCNPJInstituicao.Width = 120;
            // 
            // colNomeCidade
            // 
            this.colNomeCidade.DataPropertyName = "Cidade.Nome";
            this.colNomeCidade.HeaderText = "Cidade";
            this.colNomeCidade.Name = "colNomeCidade";
            this.colNomeCidade.ReadOnly = true;
            this.colNomeCidade.Width = 140;
            // 
            // colSiglaEstado
            // 
            this.colSiglaEstado.DataPropertyName = "Cidade.Estado.Sigla";
            this.colSiglaEstado.HeaderText = "Estado";
            this.colSiglaEstado.Name = "colSiglaEstado";
            this.colSiglaEstado.ReadOnly = true;
            this.colSiglaEstado.Width = 80;
            // 
            // colTelefoneInstituicao
            // 
            this.colTelefoneInstituicao.DataPropertyName = "Telefone";
            dataGridViewCellStyle4.Format = "\"(00) 0000-0000\"";
            dataGridViewCellStyle4.NullValue = null;
            this.colTelefoneInstituicao.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTelefoneInstituicao.HeaderText = "Telefone";
            this.colTelefoneInstituicao.Name = "colTelefoneInstituicao";
            this.colTelefoneInstituicao.ReadOnly = true;
            this.colTelefoneInstituicao.Width = 110;
            // 
            // colEmailInstituicao
            // 
            this.colEmailInstituicao.DataPropertyName = "Email";
            this.colEmailInstituicao.HeaderText = "E-mail";
            this.colEmailInstituicao.Name = "colEmailInstituicao";
            this.colEmailInstituicao.ReadOnly = true;
            this.colEmailInstituicao.Width = 160;
            // 
            // colSituacaoInstituicao
            // 
            this.colSituacaoInstituicao.DataPropertyName = "Situacao";
            this.colSituacaoInstituicao.HeaderText = "Situacao";
            this.colSituacaoInstituicao.Name = "colSituacaoInstituicao";
            this.colSituacaoInstituicao.ReadOnly = true;
            this.colSituacaoInstituicao.Width = 70;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "UsuarioAlterou.NomeReal";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(16, 397);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(96, 13);
            this.lblTotalRegistros.TabIndex = 2;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(250, 393);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(430, 393);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(511, 393);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(592, 393);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnNovaInstituicao
            // 
            this.btnNovaInstituicao.Location = new System.Drawing.Point(331, 393);
            this.btnNovaInstituicao.Name = "btnNovaInstituicao";
            this.btnNovaInstituicao.Size = new System.Drawing.Size(93, 23);
            this.btnNovaInstituicao.TabIndex = 8;
            this.btnNovaInstituicao.Text = "Nova Instituição";
            this.btnNovaInstituicao.UseVisualStyleBackColor = true;
            this.btnNovaInstituicao.Click += new System.EventHandler(this.btnNovaInstituicao_Click);
            // 
            // FrmConsultarInstituicao
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 426);
            this.Controls.Add(this.btnNovaInstituicao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.groupBoxConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarInstituicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar - Instituição";
            this.groupBoxConsultar.ResumeLayout(false);
            this.groupBoxConsultar.PerformLayout();
            this.groupBoxSituacoes.ResumeLayout(false);
            this.groupBoxSituacoes.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConsultar;
        private System.Windows.Forms.RadioButton radioButtonNomeFantasia;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.GroupBox groupBoxSituacoes;
        private System.Windows.Forms.RadioButton radioButtonSituacaoInativo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoAtivo;
        private System.Windows.Forms.RadioButton radioButtonSituacaoTodos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.DataGridView dataGridViewResultado;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton radioButtonCNPJ;
        private System.Windows.Forms.RadioButton radioButtonRazaoSocial;
        private System.Windows.Forms.Button btnNovaInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazaoSocialInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFantasiaInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNPJInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiglaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefoneInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailInstituicao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacaoInstituicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}