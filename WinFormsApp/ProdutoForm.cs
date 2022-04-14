using Domain.Pedidos;
using Domain.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class ProdutoForm : Form
    {

        #region DAL
        private ProdutoDAL _produtosDAL = new ProdutoDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["Teste"].ConnectionString));
        #endregion

        private bool _carregandoFormulario = true;
        private Produto _produtoAtual = null;

        public ProdutoForm()
        {
            InitializeComponent();
        }

        private void ProdutoForm_Shown(object sender, EventArgs e)
        {
            InicializarFormulario();
            dgvProdutos.ClearSelection();

            dgvProdutos.Columns[0].Visible = false;
            //dgvProdutos.Columns[1].Visible = false;
            //dgvProdutos.Columns[2].Visible = false;
            ////dgvProdutos.Columns[3].Visible = false;
            dgvProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void InicializarFormulario()
        {
            _carregandoFormulario = true;
            dgvProdutos.DataSource = _produtosDAL.ObterTodos();
            btCancelar.Enabled = false;
            btRemover.Enabled = false;
            _produtoAtual = null;
            dgvProdutos.ClearSelection();
            tbNome.Clear();
            tbPreco.Clear();
            _carregandoFormulario = false;
            tbNome.Focus();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                _produtosDAL.Gravar(new Produto(tbNome.Text,
                                       decimal.Parse(tbPreco.Text),
                                       (_produtoAtual == null) ? null : _produtoAtual.ProdutoID));
                _produtoAtual = null;

                MessageBox.Show("Registro gravado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProdutos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (!_carregandoFormulario)
            {
                RegistrarItemAtual(dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    decimal.Parse(dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Guid.Parse(dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString()));

                tbNome.Text = _produtoAtual.Nome;
                tbPreco.Text = _produtoAtual.PrecoUnitario.ToString();
                btCancelar.Enabled = true;
                btRemover.Enabled = true;
            }
        }
        private void RegistrarItemAtual(string nome, decimal precoUnitario, Guid? produtoID = null)
        {
            _produtoAtual = new Produto(nome, precoUnitario, produtoID);
            //_produtoAtual.Pessoa = pessoa;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (_produtoAtual == null)
            {
                MessageBox.Show("Nenhuma pessoa selecionada", "Sem campo de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Confirma removar {_produtoAtual.Nome.ToUpper()}", "Dúvida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _produtosDAL.Remover(_produtoAtual);
            InicializarFormulario();
            MessageBox.Show("Operação realizada", "Succeso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }
    }
}
