namespace SistemaAcademico
{
    partial class FrmUsuarioPermissao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonSecretariado = new System.Windows.Forms.RadioButton();
            this.radioButtonAdministrador = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxImportarBackup = new System.Windows.Forms.CheckBox();
            this.checkBoxExportarBackup = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxTipo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblCodigoID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonSecretariado);
            this.groupBoxTipo.Controls.Add(this.radioButtonAdministrador);
            this.groupBoxTipo.Location = new System.Drawing.Point(151, 19);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(258, 43);
            this.groupBoxTipo.TabIndex = 7;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo";
            // 
            // radioButtonSecretariado
            // 
            this.radioButtonSecretariado.AutoSize = true;
            this.radioButtonSecretariado.Location = new System.Drawing.Point(97, 19);
            this.radioButtonSecretariado.Name = "radioButtonSecretariado";
            this.radioButtonSecretariado.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSecretariado.TabIndex = 1;
            this.radioButtonSecretariado.Text = "Secretariado";
            this.radioButtonSecretariado.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdministrador
            // 
            this.radioButtonAdministrador.AutoSize = true;
            this.radioButtonAdministrador.Checked = true;
            this.radioButtonAdministrador.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAdministrador.Name = "radioButtonAdministrador";
            this.radioButtonAdministrador.Size = new System.Drawing.Size(88, 17);
            this.radioButtonAdministrador.TabIndex = 0;
            this.radioButtonAdministrador.TabStop = true;
            this.radioButtonAdministrador.Text = "Administrador";
            this.radioButtonAdministrador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxImportarBackup);
            this.groupBox2.Controls.Add(this.checkBoxExportarBackup);
            this.groupBox2.Location = new System.Drawing.Point(6, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 41);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissão";
            // 
            // checkBoxImportarBackup
            // 
            this.checkBoxImportarBackup.AutoSize = true;
            this.checkBoxImportarBackup.Location = new System.Drawing.Point(123, 19);
            this.checkBoxImportarBackup.Name = "checkBoxImportarBackup";
            this.checkBoxImportarBackup.Size = new System.Drawing.Size(110, 17);
            this.checkBoxImportarBackup.TabIndex = 1;
            this.checkBoxImportarBackup.Text = "Backup - Importar";
            this.checkBoxImportarBackup.UseVisualStyleBackColor = true;
            // 
            // checkBoxExportarBackup
            // 
            this.checkBoxExportarBackup.AutoSize = true;
            this.checkBoxExportarBackup.Location = new System.Drawing.Point(6, 19);
            this.checkBoxExportarBackup.Name = "checkBoxExportarBackup";
            this.checkBoxExportarBackup.Size = new System.Drawing.Size(111, 17);
            this.checkBoxExportarBackup.TabIndex = 0;
            this.checkBoxExportarBackup.Text = "Backup - Exportar";
            this.checkBoxExportarBackup.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(354, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblCodigoID
            // 
            this.lblCodigoID.AutoSize = true;
            this.lblCodigoID.Location = new System.Drawing.Point(6, 45);
            this.lblCodigoID.Name = "lblCodigoID";
            this.lblCodigoID.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoID.TabIndex = 2;
            this.lblCodigoID.Text = "Código:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-163, -266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(588, 20);
            this.textBox2.TabIndex = 9;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(-222, -259);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 8;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(358, 167);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(277, 167);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmUsuarioPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 202);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioPermissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario - Permissão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxImportarBackup;
        private System.Windows.Forms.CheckBox checkBoxExportarBackup;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoID;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonSecretariado;
        private System.Windows.Forms.RadioButton radioButtonAdministrador;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
    }
}