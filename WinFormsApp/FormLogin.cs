using Domain.Common;
using Domain.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;


namespace WinFormsApp
{
    public partial class FormLogin : Form
    {
        #region DAL
        private PessoaDAL _pessoasDAL = new PessoaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        private MesaDAL _mesasDAL = new MesaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        private ProdutoDAL _produtosDAL = new ProdutoDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        private PratoDAL _pratosDAL = new PratoDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        private ContatoDAL _contatosDAL = new ContatoDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        private PratoProdutoDAL _pratosProdutosDAL = new PratoProdutoDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        #endregion

        private Pessoa _pessoaLogin = null;

        public FormLogin()
        {
            InitializeComponent();
        }
        private void InicializarFormulario()
        {
            tbEmail.Clear();
            tbSenha.Clear();
        }
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarErros();

                _pessoaLogin = _pessoasDAL.Login(tbEmail.Text, tbSenha.Text);
                if (_pessoaLogin == null)
                    throw new Exception("Senha incorreta.");

                MessageBox.Show("Login efetuado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new FormAgendamento(_pessoaLogin).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerificarErros()
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
                throw new Exception("EMAIL: Não pode ser nulo ou vazio");
            if (string.IsNullOrEmpty(tbSenha.Text))
                throw new Exception("SENHA: Não pode ser nulo ou vazio");
        }
    }
}
