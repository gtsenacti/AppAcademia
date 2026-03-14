using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaComercio
{
    public partial class frmMenu : Form
    {
        public string funcionario;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            iniciarJanela();
        }

        private void iniciarJanela()
        {
            lblFuncionario.Text = "Olá " + funcionario + "!";
        }

        private void btmMatriculas_Click(object sender, EventArgs e)
        {
            frmMatricula fm = new frmMatricula();
            fm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frmServicos fs = new frmServicos();
            fs.ShowDialog();
        }

        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            frmFaturamento fat = new frmFaturamento();
            fat.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos fp = new frmProdutos();
            fp.ShowDialog();
        }
    }
}
