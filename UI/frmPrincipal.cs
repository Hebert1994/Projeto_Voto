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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoa f = new frmCadastroPessoa(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa f = new frmCadastroEmpresa(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void eleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEleicao f = new frmCadastroEleicao(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioPessoa f = new frmRelatorioPessoa(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioEmpresa f = new frmRelatorioEmpresa(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void votoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioEleicao f = new frmRelatorioEleicao(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCandidatos f = new frmCadastroCandidatos(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void urnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUrna f = new frmCadastroUrna(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";


        }

        private void votoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroVoto f = new frmCadastroVoto(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";

        }

        private void eleitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEleitores f = new frmCadastroEleitores(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }
    }
}
