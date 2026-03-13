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

        private void iniciarJanela()
        {
            lblFuncionario.Text = "Olá " + funcionario + "!";
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            iniciarJanela();
        }
    }
}
