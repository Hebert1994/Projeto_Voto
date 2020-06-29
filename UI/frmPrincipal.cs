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
            frmRelatorioVoto f = new frmRelatorioVoto(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        
    }
}
