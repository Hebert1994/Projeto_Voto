namespace PadraoDeProjetoEmCamadas
{
    partial class frmRelatorioVoto
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
            this.reportVoto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MODELOEleicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MODELOEleicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportVoto
            // 
            this.reportVoto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelatorioVoto1";
            reportDataSource1.Value = this.MODELOEleicaoBindingSource;
            this.reportVoto.LocalReport.DataSources.Add(reportDataSource1);
            this.reportVoto.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.ReportVoto.rdlc";
            this.reportVoto.Location = new System.Drawing.Point(0, 0);
            this.reportVoto.Name = "reportVoto";
            this.reportVoto.ServerReport.BearerToken = null;
            this.reportVoto.Size = new System.Drawing.Size(800, 450);
            this.reportVoto.TabIndex = 0;
            this.reportVoto.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // MODELOEleicaoBindingSource
            // 
            this.MODELOEleicaoBindingSource.DataSource = typeof(MODELO.MODELOEleicao);
            // 
            // frmRelatorioVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportVoto);
            this.Name = "frmRelatorioVoto";
            this.Text = "frmRelatorioVoto";
            this.Load += new System.EventHandler(this.frmRelatorioVoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MODELOEleicaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportVoto;
        private System.Windows.Forms.BindingSource MODELOEleicaoBindingSource;
    }
}