using Domain.Common;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class ContatoDAL
    {
        private SqlConnection _sqlConnection { get; set; }
        public ContatoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Inserir(Contato contato)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_CONTATO(ContatoID, Telefone, Email, PessoaID)" +
                "values(@contatoID, @telefone, @email, @pessoaID)";
            command.Parameters.AddWithValue("@contatoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@telefone", contato.Telefone);
            command.Parameters.AddWithValue("@email", contato.Email);
            command.Parameters.AddWithValue("@pessoaID", contato.PessoaID);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        //public IReadOnlyCollection<Pessoa> ObterTodos()
        //{
        //    List<Pessoa> pessoas = new List<Pessoa>();

        //    _sqlConnection.Open();
        //    var command = new SqlCommand("Select PessoaID, Nome from TB_Pessoa order by Nome", _sqlConnection);

        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            //Console.WriteLine(reader.GetString(1));
        //            var pessoa = new Pessoa(reader.GetString(1), pessoaID: reader.GetGuid(0));
        //            pessoas.Add(pessoa);
        //        }
        //    }

        //    _sqlConnection.Close();
        //    return pessoas.AsReadOnly();
        //}

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

        //public void Gravar(Pessoa pessoa)
        //{
        //    if (string.IsNullOrEmpty(pessoa.Nome))
        //        throw new Exception("Nome não pode ser em branco");
        //    if (pessoa.PessoaID == null)
        //    {
        //        Inserir(pessoa);
        //    }
        //    else
        //    {
        //        Atualizar(pessoa);
        //    }
        //}

        public void Remover(Contato contato)
        {

            var command = new SqlCommand("delete from TB_CONTATO where ContatoID = @contatoID", _sqlConnection);
            command.Parameters.AddWithValue("@contatoID", contato.ContatoID);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        //private void Atualizar(Contato contato)
        //{

        //    var command = new SqlCommand("update TB_Pessoa set Nome = @nome where PessoaID = @pessoaID", _sqlConnection);
        //    command.Parameters.AddWithValue("@pessoaID", pessoa.PessoaID);
        //    command.Parameters.AddWithValue("@nome", pessoa.Nome);


        //    _sqlConnection.Open();
        //    command.ExecuteNonQuery();
        //    _sqlConnection.Close();
        //}
        #endregion
    }
}
