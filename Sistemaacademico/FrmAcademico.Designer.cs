namespace SistemaAcademico
{
    partial class FrmAcademico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcademico));
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltasToolStripMenuItemAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItemAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.pedagogicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltasToolStripMenuItemPedagogico = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItemPedagogico = new System.Windows.Forms.ToolStripMenuItem();
            this.manutencaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaMinistradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.períodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.períodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.pedagogicoToolStripMenuItem,
            this.manutencaoToolStripMenuItem,
            this.parametrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 5;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faltasToolStripMenuItemAluno,
            this.notasToolStripMenuItemAluno});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // faltasToolStripMenuItemAluno
            // 
            this.faltasToolStripMenuItemAluno.Name = "faltasToolStripMenuItemAluno";
            this.faltasToolStripMenuItemAluno.Size = new System.Drawing.Size(180, 22);
            this.faltasToolStripMenuItemAluno.Text = "Faltas";
            this.faltasToolStripMenuItemAluno.Click += new System.EventHandler(this.faltasToolStripMenuItemAluno_Click);
            // 
            // notasToolStripMenuItemAluno
            // 
            this.notasToolStripMenuItemAluno.Name = "notasToolStripMenuItemAluno";
            this.notasToolStripMenuItemAluno.Size = new System.Drawing.Size(180, 22);
            this.notasToolStripMenuItemAluno.Text = "Notas";
            this.notasToolStripMenuItemAluno.Click += new System.EventHandler(this.notasToolStripMenuItemAluno_Click);
            // 
            // pedagogicoToolStripMenuItem
            // 
            this.pedagogicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faltasToolStripMenuItemPedagogico,
            this.notasToolStripMenuItemPedagogico});
            this.pedagogicoToolStripMenuItem.Name = "pedagogicoToolStripMenuItem";
            this.pedagogicoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.pedagogicoToolStripMenuItem.Text = "Pedagógico";
            // 
            // faltasToolStripMenuItemPedagogico
            // 
            this.faltasToolStripMenuItemPedagogico.Name = "faltasToolStripMenuItemPedagogico";
            this.faltasToolStripMenuItemPedagogico.Size = new System.Drawing.Size(105, 22);
            this.faltasToolStripMenuItemPedagogico.Text = "Faltas";
            this.faltasToolStripMenuItemPedagogico.Click += new System.EventHandler(this.faltasToolStripMenuItemPedagogico_Click);
            // 
            // notasToolStripMenuItemPedagogico
            // 
            this.notasToolStripMenuItemPedagogico.Name = "notasToolStripMenuItemPedagogico";
            this.notasToolStripMenuItemPedagogico.Size = new System.Drawing.Size(105, 22);
            this.notasToolStripMenuItemPedagogico.Text = "Notas";
            this.notasToolStripMenuItemPedagogico.Click += new System.EventHandler(this.notasToolStripMenuItemPedagogico_Click);
            // 
            // manutencaoToolStripMenuItem
            // 
            this.manutencaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmaToolStripMenuItem2,
            this.disciplinaMinistradasToolStripMenuItem,
            this.períodosToolStripMenuItem});
            this.manutencaoToolStripMenuItem.Name = "manutencaoToolStripMenuItem";
            this.manutencaoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutencaoToolStripMenuItem.Text = "Manutenção";
            // 
            // turmaToolStripMenuItem2
            // 
            this.turmaToolStripMenuItem2.Name = "turmaToolStripMenuItem2";
            this.turmaToolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.turmaToolStripMenuItem2.Text = "Turma";
            this.turmaToolStripMenuItem2.Click += new System.EventHandler(this.turmaToolStripMenuItem2_Click);
            // 
            // disciplinaMinistradasToolStripMenuItem
            // 
            this.disciplinaMinistradasToolStripMenuItem.Name = "disciplinaMinistradasToolStripMenuItem";
            this.disciplinaMinistradasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.disciplinaMinistradasToolStripMenuItem.Text = "Disciplina Ministradas";
            this.disciplinaMinistradasToolStripMenuItem.Click += new System.EventHandler(this.disciplinaMinistradasToolStripMenuItem_Click);
            // 
            // períodosToolStripMenuItem
            // 
            this.períodosToolStripMenuItem.Name = "períodosToolStripMenuItem";
            this.períodosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.períodosToolStripMenuItem.Text = "Períodos";
            this.períodosToolStripMenuItem.Click += new System.EventHandler(this.períodosToolStripMenuItem_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.períodoToolStripMenuItem});
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parametrosToolStripMenuItem.Text = "Parâmetros";
            // 
            // períodoToolStripMenuItem
            // 
            this.períodoToolStripMenuItem.Name = "períodoToolStripMenuItem";
            this.períodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.períodoToolStripMenuItem.Text = "Período";
            this.períodoToolStripMenuItem.Click += new System.EventHandler(this.períodoToolStripMenuItem_Click);
            // 
            // timerDataHora
            // 
            this.timerDataHora.Enabled = true;
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // FrmAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcademico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acadêmico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedagogicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItemPedagogico;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem períodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltasToolStripMenuItemPedagogico;
        private System.Windows.Forms.ToolStripMenuItem manutencaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem disciplinaMinistradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem períodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltasToolStripMenuItemAluno;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItemAluno;
    }
}