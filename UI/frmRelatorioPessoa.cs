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
using MySql.Data;
using MODELO;
using Microsoft.Reporting.WinForms;
using DAL;
using BLL;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmRelatorioPessoa : Form
    {
        private frmPrincipal frmPrincipal;

        public frmRelatorioPessoa()
        {
            InitializeComponent();
        }

        public frmRelatorioPessoa(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            InitializeComponent();
        }

        private void frmRelatorioPessoa_Load(object sender, EventArgs e)
        {
            string connstr = "server=;port=;user=;password=;database=";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "SELECT id, Nome, Sexo, Nascimento, Email, CPF  FROM Pessoa";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<MODELOPassoa> lrp = new List<MODELOPassoa>();
                while (rdr.Read())
                {
                    MODELOPassoa rt = new MODELOPassoa();
                    rt.Id = Convert.ToInt32(rdr[0].ToString());
                    rt.Nome = rdr[1].ToString();
                    // DateTime data = Convert.ToDateTime(rdr[2].ToString());
                    // rt.DataNascimento = data;
                    rt.Sexo = rdr[2].ToString();
                    rt.Email = rdr[3].ToString();
                    rt.Cpf = rdr[4].ToString();


                    lrp.Add(rt);


                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("RelatorioPessoa", lrp);
                this.reportPessoa1.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.ReportPessoa.rdlc";
                this.reportPessoa1.LocalReport.DataSources.Clear();
                this.reportPessoa1.LocalReport.DataSources.Add(rds);
                this.reportPessoa1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        
    }
}
       
          
    

