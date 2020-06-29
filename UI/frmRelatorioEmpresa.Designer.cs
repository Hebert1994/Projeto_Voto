namespace PadraoDeProjetoEmCamadas
{
    partial class frmRelatorioEmpresa
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportEmpresa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MODELOEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MODELOEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportEmpresa
            // 
            this.reportEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelatorioEmpresa";
            reportDataSource1.Value = this.MODELOEmpresaBindingSource;
            this.reportEmpresa.LocalReport.DataSources.Add(reportDataSource1);
            this.reportEmpresa.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.ReportEmpresa.rdlc";
            this.reportEmpresa.Location = new System.Drawing.Point(0, 0);
            this.reportEmpresa.Name = "reportEmpresa";
            this.reportEmpresa.ServerReport.BearerToken = null;
            this.reportEmpresa.Size = new System.Drawing.Size(800, 450);
            this.reportEmpresa.TabIndex = 0;
            
            // 
            // MODELOEmpresaBindingSource
            // 
            this.MODELOEmpresaBindingSource.DataSource = typeof(MODELO.MODELOEmpresa);
            // 
            // frmRelatorioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportEmpresa);
            this.Name = "frmRelatorioEmpresa";
            this.Text = "frmRelatorioEmpresa";
            this.Load += new System.EventHandler(this.frmRelatorioEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MODELOEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportEmpresa;
        private System.Windows.Forms.BindingSource MODELOEmpresaBindingSource;
    }
}