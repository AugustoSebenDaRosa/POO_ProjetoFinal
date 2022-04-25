using Domain.Common;
using Domain.Pedidos;
using Domain.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;


namespace WinFormsApp
{
    public partial class FormAgendamento : Form
    {
        #region DAL
        private SqlConnection _connectionString;
        private MesaDAL _mesasDAL;
        private AgendamentoDAL _agendamentosDAL;
        #endregion

        private Pessoa _pessoaLogin = null;
        public Agendamento _agendamentoAtual { get; set; }
        public FormAgendamento(Pessoa pessoaLogin)
        {
            _connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString);
            _mesasDAL = new MesaDAL(_connectionString);
            _agendamentosDAL = new AgendamentoDAL(_connectionString);
            _pessoaLogin = pessoaLogin;


            InitializeComponent();
        }

        private void FormAgendamento_Shown(object sender, EventArgs e)
        {
            InicializarFormulario();
            //_agendamentosDAL.DeletarTodos();

            dtpDataHora.Value = DateTime.Now;
            dtpDataHora.Format = DateTimePickerFormat.Custom;
            dtpDataHora.CustomFormat = "MM/dd/yyyy hh:mm";
            dgvMesa.Columns[0].Visible = false;
            dgvMesa.Columns[1].Visible = false;
            dgvMesa.Columns[2].Visible = false;
            dgvMesa.Columns[3].Visible = false;
            dgvMesa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMesa.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMesa.Columns[6].Visible = false;
            dgvMesa.Columns[7].Visible = false;
        }
        private void InicializarFormulario()
        {
            cbMesa.DataSource = _mesasDAL.ObterTodos();
            dgvMesa.DataSource = _agendamentosDAL.ObterTodos();
            //cbMesa.DisplayMember = "MesaNum";
            cbMesa.ValueMember = "Numero";
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbMesa.SelectedItem != null)
                {
                    Guid? guidAux = Guid.NewGuid();
                    _agendamentosDAL.Gravar(new Agendamento(
                        dtpDataHora.Value,
                        cbMesa.SelectedItem == null ? null :
                        (cbMesa.SelectedItem as Mesa).Numero,
                        _pessoaLogin.PessoaID,
                        guidAux
                        ));
                    _agendamentoAtual = new Agendamento(
                        dtpDataHora.Value,
                        cbMesa.SelectedItem == null ? null :
                        (cbMesa.SelectedItem as Mesa).Numero,
                        _pessoaLogin.PessoaID,
                        guidAux
                        );
                }

                MessageBox.Show("Registro gravado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new FormPratos(_agendamentoAtual, _pessoaLogin).ShowDialog();
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMesa_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvMesa.DataSource = _agendamentosDAL.ObterTodos((cbMesa.SelectedItem as Mesa).Numero);
            lbNumLugares.Text = (cbMesa.SelectedItem as Mesa).NumLugares.ToString();
        }
    }
}
