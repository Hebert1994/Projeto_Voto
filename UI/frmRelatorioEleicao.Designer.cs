namespace PadraoDeProjetoEmCamadas
{
    partial class frmRelatorioEleicao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MODELOEleicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportEleicao = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MODELOEleicaoBindingSource)).BeginInit();

            // 
            // MODELOEleicaoBindingSource
            // 
            this.MODELOEleicaoBindingSource.DataSource = typeof(MODELO.MODELOEleicao);
            // 
            // reportEleicao
            // 
            this.reportEleicao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "RelatorioVoto1";
            reportDataSource2.Value = this.MODELOEleicaoBindingSource;
            this.reportEleicao.LocalReport.DataSources.Add(reportDataSource2);
            this.reportEleicao.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.ReportVoto.rdlc";
            this.reportEleicao.Location = new System.Drawing.Point(0, 0);
            this.reportEleicao.Name = "reportEleicao";
            this.reportEleicao.ServerReport.BearerToken = null;
            this.reportEleicao.Size = new System.Drawing.Size(800, 450);
            this.reportEleicao.TabIndex = 0;
            this.reportEleicao.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmRelatorioEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportEleicao);
            this.Name = "frmRelatorioEleicao";
            this.Text = "Relatorio Eleicao";
            this.Load += new System.EventHandler(this.frmRelatorioVoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MODELOEleicaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportEleicao;
        private System.Windows.Forms.BindingSource MODELOEleicaoBindingSource;
    }
}