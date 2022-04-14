using Domain.Pedidos;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class ProdutoDAL
    {
        private SqlConnection _sqlConnection { get; set; }
        public ProdutoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Inserir(Produto produto)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_PRODUTO(ProdutoID, Nome, PrecoUnitario)" +
                "values(@produtoID, @nome, @precoUnitario)";
            command.Parameters.AddWithValue("@produtoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@precoUnitario", produto.PrecoUnitario);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public IReadOnlyCollection<Produto> ObterTodos()
        {
            List<Produto> produtos = new List<Produto>();

            _sqlConnection.Open();
            var command = new SqlCommand("Select ProdutoID, Nome, PrecoUnitario from TB_PRODUTO order by Nome", _sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetString(1));
                    var produto = new Produto(reader.GetString(1), reader.GetDecimal(2), reader.GetGuid(0));
                    produtos.Add(produto);
                }
            }

            _sqlConnection.Close();
            return produtos.AsReadOnly();
        }

        //public Pessoa ObterPeloID(Guid? pessoaID)
        //{
        //    Pessoa pessoa = null;

        //    var command = new SqlCommand("select PessoaID, Nome from TB_Pessoa where PessoaID = @pessoaID", _sqlConnection);
        //    command.Parameters.AddWithValue("@pessoaID", pessoaID);

        //    _sqlConnection.Open();
        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            pessoa = new Pessoa(reader.GetString(1), reader.GetGuid(0));
        //        }

        //    }
        //    _sqlConnection.Close();
        //    return pessoa;
        //}

        public void Gravar(Produto produto)
        {
            VerificarErros(produto);
            if (produto.ProdutoID == null)
            {
                Inserir(produto);
            }
            else
            {
                Atualizar(produto);
            }
        }

        private void VerificarErros(Produto produto)
        {
            string erros = "";
            if (string.IsNullOrEmpty(produto.Nome))
                erros += "Nome não pode ser em branco. ";
            if (produto.PrecoUnitario < 2 || produto.PrecoUnitario > 50)
                erros += "Preço deve estar entre R$2,00 e R$50,00.";

            if (erros.Length > 0) throw new Exception(erros);
        }

        public void Remover(Produto produto)
        {

            var command = new SqlCommand("delete from TB_PRODUTO where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@produtoID", produto.ProdutoID);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar(Produto produto)
        {

            var command = new SqlCommand("update TB_PRODUTO set Nome = @nome, PrecoUnitario = @precoUnitario" +
                                        " where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@produtoID", produto.ProdutoID);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@precoUnitario", produto.PrecoUnitario);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}
