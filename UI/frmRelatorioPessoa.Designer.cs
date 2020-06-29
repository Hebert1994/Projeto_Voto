namespace PadraoDeProjetoEmCamadas
{
    partial class frmRelatorioPessoa
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
            this.MODELOPassoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportPessoa1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MODELOPassoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MODELOPassoaBindingSource
            // 
            this.MODELOPassoaBindingSource.DataSource = typeof(MODELO.MODELOPassoa);
            // 
            // reportPessoa1
            // 
            this.reportPessoa1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportPessoa1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelatorioPessoa";
            reportDataSource1.Value = this.MODELOPassoaBindingSource;
            this.reportPessoa1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportPessoa1.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.ReportPessoa.rdlc";
            this.reportPessoa1.Location = new System.Drawing.Point(0, 0);
            this.reportPessoa1.Name = "reportPessoa1";
            this.reportPessoa1.ServerReport.BearerToken = null;
            this.reportPessoa1.Size = new System.Drawing.Size(663, 450);
            this.reportPessoa1.TabIndex = 0;
            
            // frmRelatorioPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.reportPessoa1);
            this.Name = "frmRelatorioPessoa";
            this.Text = "Relatorio Pessoa";
            this.Load += new System.EventHandler(this.frmRelatorioPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MODELOPassoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource MODELOPassoaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportPessoa1;
    }
}