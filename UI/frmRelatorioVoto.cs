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
    public partial class frmRelatorioVoto : Form
    {
        private frmPrincipal frmPrincipal;

        public frmRelatorioVoto()
        {
            InitializeComponent();
        }

        public frmRelatorioVoto(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
        }

        private void frmRelatorioVoto_Load(object sender, EventArgs e)
        {

            this.reportVoto.RefreshReport();
            this.reportVoto.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string connstr = "server=;port=;user=;password=;database=";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "SELECT IDELEICAO, IDEMPRESA, NOME, TIPOVOTO,  DATAINICIO, DATAFIM  FROM Eleicao";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<MODELOEleicao> lrp = new List<MODELOEleicao>();
                while (rdr.Read())
                {
                    MODELOEleicao rt = new MODELOEleicao();
                    rt.Ideleicao = Convert.ToInt32(rdr[2].ToString());
                    rt.Nome = rdr[4].ToString();
                    rt.Idempresa = rdr[3].ToString();
                    rt.Datafim = Convert.ToDateTime(rdr[1].ToString());
                    rt.Datainicio = Convert.ToDateTime(rdr[0].ToString());
                    rt.Tipovoto = rdr[5].ToString();

                    lrp.Add(rt);


                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("RelatorioVoto1", lrp);
                this.reportVoto.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.ReportVoto.rdlc";
                this.reportVoto.LocalReport.DataSources.Clear();
                this.reportVoto.LocalReport.DataSources.Add(rds);
                this.reportVoto.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

    }
}

