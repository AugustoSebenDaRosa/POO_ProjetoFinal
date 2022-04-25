namespace WinFormsApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tsmCadastrar_Click(object sender, EventArgs e)
        {
            new FormCadastro().ShowDialog();
        }

        private void tsmLogar_Click(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog();
        }

        private void tsmMesas_Click(object sender, EventArgs e)
        {
            new FormMesa().ShowDialog();
        }

        private void tsmProdutos_Click(object sender, EventArgs e)
        {
            new ProdutoForm().ShowDialog();
        }

        private void tsmFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void tsmCaixa_Click(object sender, EventArgs e)
        {
            new FormCaixa().ShowDialog();
        }

        private void tsmCardapio_Click(object sender, EventArgs e)
        {
            new FormPratosAdmin().ShowDialog();
        }
    }
}
