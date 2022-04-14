using Domain.Common;
using Domain.Pedidos;
using Domain.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class FormPratos : Form
    {

        #region DAL
        //private PessoaDAL _pessoasDAL = new PessoaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        //private MesaDAL _mesasDAL = new MesaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        private ProdutoDAL _produtosDAL;
        private PratoDAL _pratosDAL;
        private PratoProdutoDAL _pratosProdutosDAL;
        #endregion

        private SqlConnection _connection;
        private bool _carregandoFormulario = true;
        private PratoProduto _pratoProdutoAtual = null;
        private Prato _pratoAtual = null;
        private int _numPrato = 1;
        private decimal _total = 0;
        private Pessoa _pessoaLogin = null;
        private Agendamento _agendamento = null;

        public FormPratos(Agendamento agendamento = null, Pessoa pessoaLogin = null)
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString);

            _produtosDAL = new ProdutoDAL(_connection);
            _pratosDAL = new PratoDAL(_connection);
            _pratosProdutosDAL = new PratoProdutoDAL(_connection);

            //_pratosProdutosDAL.DeletarTodos();

            _agendamento = agendamento;
            _pessoaLogin = pessoaLogin;


            InitializeComponent();
            InicializarFormulario();
        }
        private void FormPratos_Shown(object sender, EventArgs e)
        {
            _total = _pratosProdutosDAL.ObterValorTotal(_agendamento.AgendamentoID, _pessoaLogin.PessoaID);

            InicializarFormulario();
            dgvPratos.ClearSelection();


            dgvPratos.Columns[0].Visible = false;
            dgvPratos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPratos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            //dgvPratos.Columns[1].Visible = false;
            //dgvPratos.Columns[2].Visible = false;
            //dgvPratos.Columns[3].Visible = false;


            //dgvPratos.Columns[7].Visible = false;
            //dgvPratos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvPratos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvPratos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[1].Visible = false;
            dgvProdutos.Columns[2].Visible = false;
            dgvProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[5].Visible = false;
            dgvProdutos.Columns[6].Visible = false;
            dgvProdutos.Columns[7].Visible = false;
            dgvProdutos.Columns[8].Visible = false;
        }
        private void FormPratos_Load(object sender, EventArgs e)
        {

        }
        private void InicializarFormulario()
        {
            _carregandoFormulario = true;
            //dgvPratos.DataSource = _pratosProdutosDAL.ObterTodos(_pessoaLogin);
            dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodos(_pessoaLogin, _agendamento.AgendamentoID);
            dgvPratos.DataSource = _pratosDAL.ObterTodos(_agendamento.AgendamentoID);
            cbProdutos.DataSource = _produtosDAL.ObterTodos();
            _total = _pratosProdutosDAL.ObterValorTotal(_agendamento.AgendamentoID, _pessoaLogin.PessoaID);
            cbProdutos.DisplayMember = "Nome";
            cbProdutos.ValueMember = "ProdutoID";
            btCancelar.Enabled = false;
            lbValor.Text = _total.ToString();
            //btRemover.Enabled = false;
            _pratoProdutoAtual = null;
            dgvPratos.ClearSelection();
            //tbNome.Clear();
            //cbPratos.SelectedIndex = -1;
            cbProdutos.SelectedIndex = -1;
            _carregandoFormulario = false;
            cbProdutos.Focus();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pratoAtual != null && cbProdutos.SelectedItem != null)
                {
                    _pratosProdutosDAL.Gravar(new PratoProduto(
                        _pratoAtual == null ? null :
                        _pratoAtual.PratoID,
                        cbProdutos.SelectedItem == null ? null :
                        (cbProdutos.SelectedItem as Produto).ProdutoID,
                        _pessoaLogin.PessoaID,
                        _agendamento.AgendamentoID
                        ));
                }
                _total += (cbProdutos.SelectedItem as Produto).PrecoUnitario;
                //_pratosProdutosDAL.Gravar(new Item(tbNome.Text,
                //                       cbPessoas.SelectedItem == null ? null :
                //                       (cbPessoas.SelectedItem as Pessoa).PessoaID,
                //                       (_itemAtual == null) ? null : _itemAtual.ItemID));
                _pratoProdutoAtual = null;

                MessageBox.Show("Registro gravado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pratoProdutoAtual == null)
                {
                    MessageBox.Show("Nenhum produto selecionado", "Sem campo de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show($"Confirma remover o PRODUTO", "Dúvida",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                //_total -= _pratosProdutosDAL.ObterValorPrato(_pratoProdutoAtual);
                _pratosProdutosDAL.Remover(_pratoProdutoAtual);

                MessageBox.Show("Registro removido", "Remoção concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void dgvPratos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (!_carregandoFormulario)
            {
                RegistrarPratoAtual(dgvPratos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                    int.Parse(dgvPratos.Rows[e.RowIndex].Cells[2].Value.ToString()),
                                    Guid.Parse(dgvPratos.Rows[e.RowIndex].Cells[0].Value.ToString()));


                dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodosPrato(_pratoAtual, _agendamento.AgendamentoID);
                //cbPratos.SelectedIndex = cbPratos.Items.IndexOf(_pratosProdutosDAL.ObterPratoPeloID(_pratoProdutoAtual));
                //cbProdutos.SelectedIndex = cbProdutos.Items.IndexOf(_pratosProdutosDAL.ObterPodutoPeloID(_pratoProdutoAtual));
                btCancelar.Enabled = true;
                btRemover.Enabled = true;
            }
        }


        private void RegistrarPratoAtual(string nome, int? mesaNum, Guid? pratoID)
        {
            _pratoAtual = new Prato(nome, mesaNum, pratoID);
        }

        private void btAddPrato_Click(object sender, EventArgs e)
        {
            try
            {
                _pratosDAL.Gravar(new Prato("Prato 0"+_numPrato++, 1));

                MessageBox.Show("Registro gravado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btRmvPrato_Click(object sender, EventArgs e)
        {

            if (_pratoAtual == null)
            {
                MessageBox.Show("Nenhum prato selecionado", "Sem campo de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Confirma removar {_pratoAtual.Nome.ToUpper()}", "Dúvida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _pratosDAL.Remover(new Prato("", 0, _pratoAtual == null ? null :
                                        _pratoAtual.PratoID));
            InicializarFormulario();
            MessageBox.Show("Operação realizada", "Succeso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarFormulario();
        }

        //private void cbPratos_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void dgvProdutos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RegistrarPratoProdutoAtual(Guid.Parse(dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString()));

        }

        private void RegistrarPratoProdutoAtual(Guid? produtoID)
        {
            _pratoProdutoAtual = new PratoProduto(_pratoAtual.PratoID, produtoID, _pessoaLogin.PessoaID, _agendamento.AgendamentoID);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }
    }
}
