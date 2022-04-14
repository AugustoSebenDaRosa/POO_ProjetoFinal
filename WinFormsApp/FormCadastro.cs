using Domain.Common;
using Domain.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class FormCadastro : Form
    {

        #region DAL
        private PessoaDAL _pessoasDAL;
        private ContatoDAL _contatosDAL;
        #endregion

        private SqlConnection _sqlConnection;
        private bool _carregandoFormulario = true;
        private string _erros = "";
        public FormCadastro()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString);

            _pessoasDAL = new PessoaDAL(_sqlConnection);
            _contatosDAL = new ContatoDAL(_sqlConnection);

            InitializeComponent();
        }

        private void FormCadastro_Shown(object sender, EventArgs e)
        {
            
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarErros();
                var cadastro = new Cliente(tbNome.Text, long.Parse(tbCpf.Text), tbSenha.Text, Guid.NewGuid());

                var contato = new Contato(long.Parse(tbTelefone.Text), tbEmail.Text, cadastro.PessoaID);

                _pessoasDAL.InserirCliente(cadastro);
                _contatosDAL.Inserir(contato);

                MessageBox.Show("Registro gravado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerificarErros()
        {
            if (string.IsNullOrEmpty(tbNome.Text))
                throw new Exception("NOME: Não pode ser nulo ou vazio");
            if (string.IsNullOrEmpty(tbCpf.Text))
                throw new Exception("CPF: Não pode ser nulo ou vazio");
            if (string.IsNullOrEmpty(tbTelefone.Text))
                throw new Exception("TELEFONE: Não pode ser nulo ou vazio");
            if (string.IsNullOrEmpty(tbEmail.Text))
                throw new Exception("EMAIL: Não pode ser nulo ou vazio");
            if (string.IsNullOrEmpty(tbSenha.Text))
                throw new Exception("SENHA: Não pode ser nulo ou vazio");
        }

        private void InicializarFormulario()
        {
            tbNome.Clear();
            tbCpf.Clear();
            tbEmail.Clear();
            tbSenha.Clear();
            tbTelefone.Clear();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
