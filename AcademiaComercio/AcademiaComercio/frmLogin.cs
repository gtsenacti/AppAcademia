namespace AcademiaComercio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "Fábio";
            string senha = "123";

            if (txtUsuario.Text == usuario && txtSenha.Text == senha)
            {
                this.Visible = false;
                MessageBox.Show("Logado com sucesso!");
                frmMenu fM = new frmMenu();
                fM.funcionario = usuario;
                fM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente!");
            }
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmCadastro fc = new frmCadastro();
            fc.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
