
namespace SistemaAcademico
{
    partial class FrmSelecionarInstituicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarInstituicao));
            this.groupBoxSelecionarInstituicao = new System.Windows.Forms.GroupBox();
            this.btnAdicionarInstituicao = new System.Windows.Forms.Button();
            this.comboBoxInstituicao = new System.Windows.Forms.ComboBox();
            this.labelInstituicao = new System.Windows.Forms.Label();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSelecionarInstituicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelecionarInstituicao
            // 
            this.groupBoxSelecionarInstituicao.Controls.Add(this.btnAdicionarInstituicao);
            this.groupBoxSelecionarInstituicao.Controls.Add(this.comboBoxInstituicao);
            this.groupBoxSelecionarInstituicao.Controls.Add(this.labelInstituicao);
            this.groupBoxSelecionarInstituicao.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelecionarInstituicao.Name = "groupBoxSelecionarInstituicao";
            this.groupBoxSelecionarInstituicao.Size = new System.Drawing.Size(327, 55);
            this.groupBoxSelecionarInstituicao.TabIndex = 0;
            this.groupBoxSelecionarInstituicao.TabStop = false;
            this.groupBoxSelecionarInstituicao.Text = "Selecionar Instituição";
            // 
            // btnAdicionarInstituicao
            // 
            this.btnAdicionarInstituicao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdicionarInstituicao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarInstituicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarInstituicao.Image")));
            this.btnAdicionarInstituicao.Location = new System.Drawing.Point(300, 17);
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
            this.comboBoxInstituicao.Location = new System.Drawing.Point(71, 17);
            this.comboBoxInstituicao.Name = "comboBoxInstituicao";
            this.comboBoxInstituicao.Size = new System.Drawing.Size(223, 21);
            this.comboBoxInstituicao.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxInstituicao, "Selecionar Instituição");
            this.comboBoxInstituicao.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstituicao_SelectedIndexChanged);
            this.comboBoxInstituicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxInstituicao_KeyPress);
            this.comboBoxInstituicao.Leave += new System.EventHandler(this.comboBoxInstituicao_Leave);
            // 
            // labelInstituicao
            // 
            this.labelInstituicao.AutoSize = true;
            this.labelInstituicao.Location = new System.Drawing.Point(7, 20);
            this.labelInstituicao.Name = "labelInstituicao";
            this.labelInstituicao.Size = new System.Drawing.Size(58, 13);
            this.labelInstituicao.TabIndex = 0;
            this.labelInstituicao.Text = "Instituição:";
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(264, 70);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSelecionar.TabIndex = 1;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // FrmSelecionarInstituicao
            // 
            this.AcceptButton = this.buttonSelecionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 99);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.groupBoxSelecionarInstituicao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelecionarInstituicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Instituição";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSelecionarInstituicao_FormClosing);
            this.Load += new System.EventHandler(this.FrmSelecionarInstituicao_Load);
            this.groupBoxSelecionarInstituicao.ResumeLayout(false);
            this.groupBoxSelecionarInstituicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelecionarInstituicao;
        private System.Windows.Forms.ComboBox comboBoxInstituicao;
        private System.Windows.Forms.Label labelInstituicao;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdicionarInstituicao;
    }
}