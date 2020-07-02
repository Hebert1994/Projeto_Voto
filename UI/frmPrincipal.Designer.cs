namespace PadraoDeProjetoEmCamadas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.votoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eleitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.configToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.eleiçãoToolStripMenuItem,
            this.candidatoToolStripMenuItem,
            this.urnaToolStripMenuItem,
            this.votoToolStripMenuItem1,
            this.eleitorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // eleiçãoToolStripMenuItem
            // 
            this.eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
            this.eleiçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eleiçãoToolStripMenuItem.Text = "Eleição";
            this.eleiçãoToolStripMenuItem.Click += new System.EventHandler(this.eleiçãoToolStripMenuItem_Click);
            // 
            // candidatoToolStripMenuItem
            // 
            this.candidatoToolStripMenuItem.Name = "candidatoToolStripMenuItem";
            this.candidatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.candidatoToolStripMenuItem.Text = "Candidato";
            this.candidatoToolStripMenuItem.Click += new System.EventHandler(this.candidatoToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.empresaToolStripMenuItem1,
            this.votoToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem1
            // 
            this.empresaToolStripMenuItem1.Name = "empresaToolStripMenuItem1";
            this.empresaToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.empresaToolStripMenuItem1.Text = "Empresa";
            this.empresaToolStripMenuItem1.Click += new System.EventHandler(this.empresaToolStripMenuItem1_Click);
            // 
            // votoToolStripMenuItem
            // 
            this.votoToolStripMenuItem.Name = "votoToolStripMenuItem";
            this.votoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.votoToolStripMenuItem.Text = "Eleicao";
            this.votoToolStripMenuItem.Click += new System.EventHandler(this.votoToolStripMenuItem_Click);
            // 
            // urnaToolStripMenuItem
            // 
            this.urnaToolStripMenuItem.Name = "urnaToolStripMenuItem";
            this.urnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urnaToolStripMenuItem.Text = "Urna";
            this.urnaToolStripMenuItem.Click += new System.EventHandler(this.urnaToolStripMenuItem_Click);
            // 
            // votoToolStripMenuItem1
            // 
            this.votoToolStripMenuItem1.Name = "votoToolStripMenuItem1";
            this.votoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.votoToolStripMenuItem1.Text = "Voto";
            this.votoToolStripMenuItem1.Click += new System.EventHandler(this.votoToolStripMenuItem1_Click);
            // 
            // eleitorToolStripMenuItem
            // 
            this.eleitorToolStripMenuItem.Name = "eleitorToolStripMenuItem";
            this.eleitorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eleitorToolStripMenuItem.Text = "Eleitor";
            this.eleitorToolStripMenuItem.Click += new System.EventHandler(this.eleitorToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 302);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem votoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eleitorToolStripMenuItem;
    }
}