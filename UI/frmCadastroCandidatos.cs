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
    public partial class frmCadastroCandidatos : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        private frmPrincipal frmPrincipal;

        public frmCadastroCandidatos(frmPrincipal frmPrincipal)
        {
            this.frmPrincipal = frmPrincipal;
            InitializeComponent();
        }
        private string fotoCandidato = "";
        private void alterarPropriedadeImagem(int op)
        {
            if (op == 0)
            {
                btn_buscar_img.Enabled = false;
                btn_remover_img.Enabled = false;
            }
            else if (op == 1)
            {
                btn_buscar_img.Enabled = true;
                btn_remover_img.Enabled = true;
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLCandidatos bllcandidato = new BLLCandidatos(cx);

                MODELOCandidato p = new MODELOCandidato();
                p.Idpessoa = TXTIDPESSOA.Text;
                p.Ideleicao = TXTIDEELICAO.Text;
                p.Idempresa = TXTIDEMPRESA.Text;
                p.Numero = TXTNUMERO.Text;
                p.Slogan = TXTSLOGAN.Text;
                p.Descricao = TXTDESCRICAO.Text;
                if (p.Foto != null)
                    IMG.Image = p.getImagem();


                bllcandidato.Incluir(p);
                MessageBox.Show("Candidato inserido com sucesso id:");


                

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

        private void btn_buscar_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            if (!string.IsNullOrEmpty(op.FileName))
            {
                fotoCandidato = op.FileName;
                IMG.Load(fotoCandidato);
            }
        }

        private void btn_remover_img_Click(object sender, EventArgs e)
        {
            fotoCandidato = "";
            IMG.Image = null;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
            alterarPropriedadeImagem(1);
        }
    }
}
