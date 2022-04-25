using Domain.Common;
using Domain.Pedidos;
using Domain.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class FormPratosAdmin : Form
    {
        #region DAL
        private ProdutoDAL _produtosDAL;
        private PratoDAL _pratosDAL;
        private PratoProdutoDAL _pratosProdutosDAL;
        private SqlConnection _connection;
        #endregion

        private Pessoa _pessoaLogin = new Cliente("Admin", 0000000, "123", Guid.Parse("2f805f13-7de4-4bf6-a34a-ae08ca2833b7"));

        PratoProduto _pratoProdutoAtual = null;
        Prato _pratoAtual = null;

        private bool _carregandoFormulario = true;
        public FormPratosAdmin()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString);

            _produtosDAL = new ProdutoDAL(_connection);
            _pratosDAL = new PratoDAL(_connection);
            _pratosProdutosDAL = new PratoProdutoDAL(_connection);
            InitializeComponent();
        }

        private void FormPratosAdmin_Shown(object sender, EventArgs e)
        {
            InicializarFormulario();


            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[1].Visible = false;
            dgvProdutos.Columns[2].Visible = false;
            dgvProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[5].Visible = false;
            dgvProdutos.Columns[6].Visible = false;

            dgvPratos.Columns[0].Visible = false;
            dgvPratos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPratos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void InicializarFormulario()
        {

            _carregandoFormulario = true;
            //dgvPratos.DataSource = _pratosProdutosDAL.ObterTodos(_pessoaLogin);
            dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodos();
            dgvPratos.DataSource = _pratosDAL.ObterTodos(null);
            cbProdutos.DataSource = _produtosDAL.ObterTodos();
            cbProdutos.DisplayMember = "Nome";
            cbProdutos.ValueMember = "ProdutoID";
            btCancelar.Enabled = false;
            //btRemover.Enabled = false;
            //_pratoProdutoAtual = null;
            dgvPratos.ClearSelection();
            //tbNome.Clear();
            //cbPratos.SelectedIndex = -1;
            cbProdutos.SelectedIndex = -1;
            _carregandoFormulario = false;
            cbProdutos.Focus();
        }

        private void btAddPrato_Click(object sender, EventArgs e)
        {
            try
            {
                _pratosDAL.InserirAdmin(new Prato(tbPratoNome.Text, null, Guid.NewGuid(), null));

                MessageBox.Show("Registro gravado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InicializarFormulario();
        }

        private void dgvPratos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregandoFormulario)
            {
                RegistrarPratoAtual(dgvPratos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                    Guid.Parse(dgvPratos.Rows[e.RowIndex].Cells[0].Value.ToString()));


                dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodosPrato(_pratoAtual);

                btCancelar.Enabled = true;
                btRmvProduto.Enabled = true;
            }
        }
        private void RegistrarPratoAtual(string nome, Guid? pratoID)
        {
            _pratoAtual = new Prato(nome, null, pratoID);
        }

        private void btAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pratoAtual != null && cbProdutos.SelectedItem != null)
                {
                    _pratosProdutosDAL.Gravar(new PratoProduto(
                        _pratoAtual == null ? null :
                        _pratoAtual.PratoID,
                        cbProdutos.SelectedItem == null ? null :
                        (cbProdutos.SelectedItem as Produto).ProdutoID
                        ));
                }
                //_total += (cbProdutos.SelectedItem as Produto).PrecoUnitario;
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

        private void btRmvProduto_Click(object sender, EventArgs e)
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

        private void btRmvPrato_Click(object sender, EventArgs e)
        {

            if (_pratoAtual == null)
            {
                MessageBox.Show("Nenhum prato selecionado.", "Sem campo de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Confirma remover {_pratoAtual.Nome.ToUpper()}", "Dúvida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (_pratosProdutosDAL.ObterTodosPrato(_pratoAtual).Count > 0)
            {
                foreach (var p in _pratosProdutosDAL.ObterTodosPrato(_pratoAtual))
                {
                    _pratosProdutosDAL.Remover(new PratoProduto(_pratoAtual.PratoID, p.ProdutoID));
                }
            }

            _pratosDAL.Remover(new Prato("", 0, _pratoAtual == null ? null :
                                        _pratoAtual.PratoID));
            InicializarFormulario();
            MessageBox.Show("Operação realizada", "Succeso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarFormulario();
        }

        private void dgvProdutos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_carregandoFormulario == false)
                RegistrarPratoProdutoAtual(Guid.Parse(dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString()));

        }

        private void RegistrarPratoProdutoAtual(Guid? produtoID)
        {
            _pratoProdutoAtual = new PratoProduto(_pratoAtual.PratoID, produtoID);
        }
    }
   
}
