namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroCandidatos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.IMG = new System.Windows.Forms.PictureBox();
            this.btn_remover_img = new System.Windows.Forms.Button();
            this.btn_buscar_img = new System.Windows.Forms.Button();
            this.TXTDESCRICAO = new System.Windows.Forms.RichTextBox();
            this.TXTSLOGAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.TXTIDEMPRESA = new System.Windows.Forms.TextBox();
            this.TXTIDEELICAO = new System.Windows.Forms.TextBox();
            this.TXTIDPESSOA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDPESSOA = new System.Windows.Forms.Label();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.IMG);
            this.painel_campos.Controls.Add(this.btn_remover_img);
            this.painel_campos.Controls.Add(this.btn_buscar_img);
            this.painel_campos.Controls.Add(this.TXTDESCRICAO);
            this.painel_campos.Controls.Add(this.TXTSLOGAN);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Controls.Add(this.TXTNUMERO);
            this.painel_campos.Controls.Add(this.TXTIDEMPRESA);
            this.painel_campos.Controls.Add(this.TXTIDEELICAO);
            this.painel_campos.Controls.Add(this.TXTIDPESSOA);
            this.painel_campos.Controls.Add(this.label6);
            this.painel_campos.Controls.Add(this.label5);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.IDPESSOA);
            this.painel_campos.Location = new System.Drawing.Point(3, 3);
            this.painel_campos.Size = new System.Drawing.Size(449, 332);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 341);
            this.Painel_botoes.Size = new System.Drawing.Size(449, 54);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // IMG
            // 
            this.IMG.BackColor = System.Drawing.Color.LightGray;
            this.IMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IMG.Location = new System.Drawing.Point(318, 20);
            this.IMG.Name = "IMG";
            this.IMG.Size = new System.Drawing.Size(119, 107);
            this.IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG.TabIndex = 49;
            this.IMG.TabStop = false;
            // 
            // btn_remover_img
            // 
            this.btn_remover_img.Location = new System.Drawing.Point(378, 133);
            this.btn_remover_img.Name = "btn_remover_img";
            this.btn_remover_img.Size = new System.Drawing.Size(61, 23);
            this.btn_remover_img.TabIndex = 48;
            this.btn_remover_img.Text = "Remover";
            this.btn_remover_img.UseVisualStyleBackColor = true;
            this.btn_remover_img.Click += new System.EventHandler(this.btn_remover_img_Click);
            // 
            // btn_buscar_img
            // 
            this.btn_buscar_img.Location = new System.Drawing.Point(318, 133);
            this.btn_buscar_img.Name = "btn_buscar_img";
            this.btn_buscar_img.Size = new System.Drawing.Size(54, 23);
            this.btn_buscar_img.TabIndex = 47;
            this.btn_buscar_img.Text = "Buscar";
            this.btn_buscar_img.UseVisualStyleBackColor = true;
            this.btn_buscar_img.Click += new System.EventHandler(this.btn_buscar_img_Click);
            // 
            // TXTDESCRICAO
            // 
            this.TXTDESCRICAO.Location = new System.Drawing.Point(22, 208);
            this.TXTDESCRICAO.Name = "TXTDESCRICAO";
            this.TXTDESCRICAO.Size = new System.Drawing.Size(417, 110);
            this.TXTDESCRICAO.TabIndex = 46;
            this.TXTDESCRICAO.Text = "";
            // 
            // TXTSLOGAN
            // 
            this.TXTSLOGAN.Location = new System.Drawing.Point(133, 162);
            this.TXTSLOGAN.Name = "TXTSLOGAN";
            this.TXTSLOGAN.Size = new System.Drawing.Size(306, 20);
            this.TXTSLOGAN.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Foto";
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(133, 121);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(158, 20);
            this.TXTNUMERO.TabIndex = 44;
            // 
            // TXTIDEMPRESA
            // 
            this.TXTIDEMPRESA.Location = new System.Drawing.Point(133, 87);
            this.TXTIDEMPRESA.Name = "TXTIDEMPRESA";
            this.TXTIDEMPRESA.Size = new System.Drawing.Size(158, 20);
            this.TXTIDEMPRESA.TabIndex = 43;
            // 
            // TXTIDEELICAO
            // 
            this.TXTIDEELICAO.Location = new System.Drawing.Point(133, 47);
            this.TXTIDEELICAO.Name = "TXTIDEELICAO";
            this.TXTIDEELICAO.Size = new System.Drawing.Size(158, 20);
            this.TXTIDEELICAO.TabIndex = 42;
            // 
            // TXTIDPESSOA
            // 
            this.TXTIDPESSOA.Location = new System.Drawing.Point(133, 13);
            this.TXTIDPESSOA.Name = "TXTIDPESSOA";
            this.TXTIDPESSOA.Size = new System.Drawing.Size(158, 20);
            this.TXTIDPESSOA.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Slogan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Codigo da empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo da eleição";
            // 
            // IDPESSOA
            // 
            this.IDPESSOA.AutoSize = true;
            this.IDPESSOA.Location = new System.Drawing.Point(19, 16);
            this.IDPESSOA.Name = "IDPESSOA";
            this.IDPESSOA.Size = new System.Drawing.Size(92, 13);
            this.IDPESSOA.TabIndex = 34;
            this.IDPESSOA.Text = "Codigo da pessoa";
            // 
            // frmCadastroCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(457, 402);
            this.Name = "frmCadastroCandidatos";
            this.Text = "Cadastro Candidato";
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IMG;
        private System.Windows.Forms.Button btn_remover_img;
        private System.Windows.Forms.Button btn_buscar_img;
        private System.Windows.Forms.RichTextBox TXTDESCRICAO;
        private System.Windows.Forms.TextBox TXTSLOGAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.TextBox TXTIDEMPRESA;
        private System.Windows.Forms.TextBox TXTIDEELICAO;
        private System.Windows.Forms.TextBox TXTIDPESSOA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDPESSOA;
    }
}
