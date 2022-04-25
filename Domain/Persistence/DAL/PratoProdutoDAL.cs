using Domain.Common;
using Domain.Pedidos;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class PratoProdutoDAL
    {
        private SqlConnection _sqlConnection { get; set; }
        public PratoProdutoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Gravar(PratoProduto pratoProduto)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_PRATO_PRODUTO(PratoID, ProdutoID)" +
                "values(@pratoID, @produtoID)";
            command.Parameters.AddWithValue("@pratoID", pratoProduto.PratoID);
            command.Parameters.AddWithValue("@produtoID", pratoProduto.ProdutoID);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public IReadOnlyCollection<PratoProduto> ObterTodos()
        {
            List<PratoProduto> pratoProdutos = new List<PratoProduto>();

            _sqlConnection.Open();
            var command = new SqlCommand(
                "SELECT TB_PRATO_PRODUTO.PratoID, TB_PRATO_PRODUTO.ProdutoID, TB_PRATO.Nome, TB_PRODUTO.Nome, TB_PRODUTO.PrecoUnitario " +
                "FROM TB_PRATO_PRODUTO " +
                "INNER JOIN TB_PRATO ON TB_PRATO_PRODUTO.PratoID = TB_PRATO.PratoID " +
                "INNER JOIN TB_PRODUTO on TB_PRATO_PRODUTO.ProdutoID = TB_PRODUTO.ProdutoID " +
                "ORDER BY TB_PRATO.Nome",
                _sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var pratoProduto = new PratoProduto(reader.GetGuid(0), reader.GetGuid(1));
                    pratoProduto.PratoNome = reader.GetString(2);
                    pratoProduto.Nome = reader.GetString(3);
                    pratoProduto.Preco = reader.GetDecimal(4);
                    pratoProduto.Prato = new Prato(reader.GetString(2), 1, reader.GetGuid(0));
                    pratoProduto.Produto = new Produto(reader.GetString(3), reader.GetDecimal(4), reader.GetGuid(1));
                    pratoProdutos.Add(pratoProduto);
                }
            }

            _sqlConnection.Close();
            return pratoProdutos.AsReadOnly();
        }
        public IReadOnlyCollection<PratoProduto> ObterTodosPrato(Prato prato)
        {
            List<PratoProduto> pratoProdutos = new List<PratoProduto>();

            _sqlConnection.Open();
            var command = new SqlCommand(
                "SELECT TB_PRATO_PRODUTO.PratoID, TB_PRATO_PRODUTO.ProdutoID, TB_PRATO.Nome, TB_PRODUTO.Nome, TB_PRODUTO.PrecoUnitario " +
                "FROM TB_PRATO_PRODUTO " +
                "INNER JOIN TB_PRATO ON TB_PRATO_PRODUTO.PratoID = TB_PRATO.PratoID " +
                "INNER JOIN TB_PRODUTO on TB_PRATO_PRODUTO.ProdutoID = TB_PRODUTO.ProdutoID " +
                "WHERE TB_PRATO_PRODUTO.PratoID = @pratoID " +
                "ORDER BY TB_PRATO.Nome",
                _sqlConnection);
            command.Parameters.AddWithValue("@pratoID", prato.PratoID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var pratoProduto = new PratoProduto(reader.GetGuid(0), reader.GetGuid(1));
                    pratoProduto.PratoNome = reader.GetString(2);
                    pratoProduto.Nome = reader.GetString(3);
                    pratoProduto.Preco = reader.GetDecimal(4);
                    pratoProduto.Prato = new Prato(reader.GetString(2), 1, reader.GetGuid(0));
                    pratoProduto.Produto = new Produto(reader.GetString(3), reader.GetDecimal(4), reader.GetGuid(1));
                    pratoProdutos.Add(pratoProduto);
                }
            }

            _sqlConnection.Close();
            return pratoProdutos.AsReadOnly();
        }
        public Prato ObterPratoPeloID(PratoProduto pratoProduto)
        {
            Prato prato = null;

            var command = new SqlCommand("select PratoID, Nome, MesaNum from TB_PRATO where PratoID = @pratoID", _sqlConnection);
            command.Parameters.AddWithValue("@pratoID", pratoProduto.PratoID);

            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    prato = new Prato(reader.GetString(1), reader.GetInt32(2), reader.GetGuid(0));
                }

            }
            _sqlConnection.Close();
            return prato;
        }

        public Produto ObterPodutoPeloID(PratoProduto pratoProduto)
        {
            Produto produto = null;

            var command = new SqlCommand("select ProdutoID, Nome, PrecoUnitario from TB_PRODUTO where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@produtoID", pratoProduto.ProdutoID);

            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto = new Produto(reader.GetString(1), reader.GetDecimal(2), reader.GetGuid(0));
                }

            }
            _sqlConnection.Close();
            return produto;
        }

        public decimal ObterValorTotal(Agendamento agendamento)
        {
            decimal valorTotal = 0;

            _sqlConnection.Open();
            var command = new SqlCommand(
                "SELECT TB_Produto.PrecoUnitario " +
                "FROM TB_PRATO_PRODUTO " +
                "INNER JOIN TB_PRATO ON TB_PRATO_PRODUTO.PratoID = TB_PRATO.PratoID " +
                "INNER JOIN TB_PRODUTO on TB_PRATO_PRODUTO.ProdutoID = TB_PRODUTO.ProdutoID " +
                "WHERE TB_PRATO.AgendamentoID = @agendamentoID ",
                _sqlConnection);
            command.Parameters.AddWithValue("@agendamentoID", agendamento.AgendamentoID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    valorTotal += reader.GetDecimal(0);
                }

            }
            _sqlConnection.Close();
            return valorTotal;
        }

        public void Remover(PratoProduto pratoProduto)
        {

            var command = new SqlCommand("DELETE FROM TB_PRATO_PRODUTO WHERE PratoID = @pratoID AND " +
                "ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@pratoID", pratoProduto.PratoID);
            command.Parameters.AddWithValue("@produtoID", pratoProduto.ProdutoID);

            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        
        public void DeletarTodos()
        {
            var command = new SqlCommand("TRUNCATE TABLE TB_PRATO_PRODUTO", _sqlConnection);

            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}
