using Microsoft.Reporting.WinForms;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmRelatorioEmpresa : Form
    {
        private frmPrincipal frmPrincipal;

        public frmRelatorioEmpresa()
        {
            InitializeComponent();
        }

        public frmRelatorioEmpresa(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        private void frmRelatorioEmpresa_Load(object sender, EventArgs e)
        {

            string connstr = "server=;port=;user=;password=;database=";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "SELECT IDEMPRESA, NOME, DESCRICAO, CODEMPRESA FROM Empresa";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<MODELOEmpresa> lrp = new List<MODELOEmpresa>();
                while (rdr.Read())
                {
                    MODELOEmpresa rt = new MODELOEmpresa();
                    rt.CodEmpresa = rdr[0].ToString();
                    rt.IdEmpresa = Convert.ToInt32(rdr[1].ToString());
                    rt.Nome = rdr[2].ToString();
                    rt.Descricao = rdr[3].ToString();
                    


                    lrp.Add(rt);


                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("RelatorioEmpresa", lrp);
                this.reportEmpresa.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.ReportPessoa.rdlc";
                this.reportEmpresa.LocalReport.DataSources.Clear();
                this.reportEmpresa.LocalReport.DataSources.Add(rds);
                this.reportEmpresa.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }
    }

        
    
}
