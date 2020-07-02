using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroUrna : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        private frmPrincipal frmPrincipal;

        public frmCadastroUrna()
        {
            InitializeComponent();
        }

        public frmCadastroUrna(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLUrna bllurna = new BLLUrna(cx);

                MODELOUrna p = new MODELOUrna();
                p.Nome = TXTNOME.Text;
                p.IP= TXTId.Text;
                p.Descricao = TXTDESCRICAO.Text;
                TXTId.Text = p.IDurna.ToString();
                bllurna.Incluir(p);
                MessageBox.Show("Usuario inserido com sucesso id:" + p.IDurna);


            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }
    }
}
