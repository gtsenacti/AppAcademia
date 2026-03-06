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
                MessageBox.Show("Logado com sucesso!");
                frmMenu fM = new frmMenu();
                fM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente!");
            }
        }
    }
}
