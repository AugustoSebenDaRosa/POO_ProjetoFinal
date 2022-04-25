using Domain.Common;
using Domain.Financeiro;
using Domain.Pedidos;
using Domain.Persistence.DAL;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class FormPratos : Form
    {

        #region DAL
        private ProdutoDAL _produtosDAL;
        private PratoDAL _pratosDAL;
        private PratoProdutoDAL _pratosProdutosDAL;
        private CaixaDAL _caixaDAL;
        #endregion

        private SqlConnection _connection;
        private bool _carregandoFormulario = true;
        private PratoProduto _pratoProdutoAtual = null;
        private Prato _pratoAtual = null;
        private decimal _total = 0;
        private Pessoa _pessoaLogin = null;
        private Agendamento _agendamento = null;

        public FormPratos(Agendamento agendamento = null, Pessoa pessoaLogin = null)
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString);

            _produtosDAL = new ProdutoDAL(_connection);
            _pratosDAL = new PratoDAL(_connection);
            _pratosProdutosDAL = new PratoProdutoDAL(_connection);
            _caixaDAL = new CaixaDAL(_connection);

            //_pratosProdutosDAL.DeletarTodos();

            _agendamento = agendamento;
            _pessoaLogin = pessoaLogin;


            InitializeComponent();
            InicializarFormulario();
        }
        private void FormPratos_Shown(object sender, EventArgs e)
        {

            InicializarFormulario();
            dgvPratos.ClearSelection();


            dgvPratos.Columns[0].Visible = false;
            dgvPratos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPratos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPratos.Columns[3].Visible = false;


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



        }
        private void FormPratos_Load(object sender, EventArgs e)
        {

        }
       
        private void InicializarFormulario()
        {
            _carregandoFormulario = true;
            //dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodos();
            if (_pratoAtual != null) dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodosPrato(_pratoAtual);
            else dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodos();

            dgvPratos.DataSource = _pratosDAL.ObterTodos(_agendamento);

            _total = _pratosProdutosDAL.ObterValorTotal(_agendamento);

            cbPratos.DataSource = _pratosDAL.ObterTodos(null);
            cbPratos.DisplayMember = "Nome";
            cbPratos.ValueMember = "PratoID";

            cbProdutos.DataSource = _produtosDAL.ObterTodos();
            cbProdutos.DisplayMember = "Nome";
            cbProdutos.ValueMember = "ProdutoID";

            btCancelar.Enabled = false;
            lbValor.Text = _total.ToString();
            //btRemover.Enabled = false;
            _pratoProdutoAtual = null;
            dgvPratos.ClearSelection();
            //tbNome.Clear();
            cbPratos.SelectedIndex = -1;
            cbProdutos.SelectedIndex = -1;
            cbProdutos.Focus();
            _carregandoFormulario = false;
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
                        (cbProdutos.SelectedItem as Produto).ProdutoID
                        ));
                    _total += (cbProdutos.SelectedItem as Produto).PrecoUnitario;
                }
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

                dgvProdutos.DataSource = _pratosProdutosDAL.ObterTodosPrato(_pratoAtual);
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
                if (cbPratos.SelectedIndex == -1)
                {
                    MessageBox.Show("Nenhum prato selecionado.", "Sem campo de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IReadOnlyCollection<PratoProduto> _aux = _pratosProdutosDAL.ObterTodosPrato(new Prato(null, null,
                                                                (cbPratos.SelectedItem as Prato).PratoID, null));
                var _pratoAux = new Prato((cbPratos.SelectedItem as Prato).Nome, _agendamento.MesaNum,
                                            Guid.NewGuid(), _agendamento.AgendamentoID);
                _pratosDAL.Gravar(_pratoAux);

                foreach (var p in _aux)
                {
                    _pratosProdutosDAL.Gravar(new PratoProduto(_pratoAux.PratoID, p.ProdutoID));
                }



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
                MessageBox.Show("Nenhum prato selecionado.", "Sem campo de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Confirma remover {_pratoAtual.Nome.ToUpper()}", "Dúvida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if(_pratosProdutosDAL.ObterTodosPrato(_pratoAtual).Count > 0)
            {
                foreach(var p in _pratosProdutosDAL.ObterTodosPrato(_pratoAtual))
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
            if (!_carregandoFormulario)
                RegistrarPratoProdutoAtual(Guid.Parse(dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString()));
        }

        private void RegistrarPratoProdutoAtual(Guid? produtoID)
        {
            if(_pratoAtual!=null)
                _pratoProdutoAtual = new PratoProduto(_pratoAtual.PratoID, produtoID);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            _caixaDAL.Inserir(new Caixa(_agendamento.AgendamentoID, _total, DateTime.Now));
            MessageBox.Show("Valor pago!");
            _total = 0;
            lbValor.Text = "0";
        }
    }
}
