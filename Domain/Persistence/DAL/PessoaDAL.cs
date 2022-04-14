using Domain.Common;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class PessoaDAL
    {
        private SqlConnection _sqlConnection { get; set; }
        public PessoaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Inserir(Pessoa pessoa)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_Pessoa(PessoaID, Nome, Cpf, Senha)" +
                "values(@pessoaID, @nome, @cpf, @senha)";
            command.Parameters.AddWithValue("@pessoaID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", pessoa.Nome);
            command.Parameters.AddWithValue("@cpf", pessoa.CPF);
            command.Parameters.AddWithValue("@senha", pessoa.Senha);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void InserirCliente(Cliente cliente)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_Pessoa(PessoaID, Nome, Cpf, Senha)" +
                "values(@pessoaID, @nome, @cpf, @senha)";
            command.Parameters.AddWithValue("@pessoaID", cliente.PessoaID);
            command.Parameters.AddWithValue("@nome", cliente.Nome);
            command.Parameters.AddWithValue("@cpf", cliente.CPF);
            command.Parameters.AddWithValue("@senha", cliente.Senha);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public Cliente Login(string email, string senha)
        {
            Cliente pessoa = null;

            _sqlConnection.Open();
            var command = new SqlCommand(
                "SELECT TB_PESSOA.Nome, TB_PESSOA.Cpf, TB_PESSOA.Senha, TB_CONTATO.Telefone, TB_CONTATO.Email, " +
                "TB_PESSOA.PessoaID, TB_CONTATO.ContatoID " +
                "FROM TB_CONTATO " +
                "INNER JOIN TB_PESSOA ON TB_CONTATO.PessoaID = TB_PESSOA.PessoaID " +
                "WHERE TB_CONTATO.Email = @email",
                _sqlConnection);
            command.Parameters.AddWithValue("@email", email);



            using(var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.GetString(2) != senha)
                    {
                        _sqlConnection.Close();
                        return null;
                    }
                    pessoa = new Cliente(reader.GetString(0), long.Parse(reader.GetString(1)), reader.GetString(2), reader.GetGuid(5));
                    pessoa.Contato = (new Contato(long.Parse(reader.GetDecimal(3).ToString()), reader.GetString(4), reader.GetGuid(5), reader.GetGuid(6)));
                }
            }

            _sqlConnection.Close();
            return pessoa;

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

        public void Gravar(Pessoa pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new Exception("Nome não pode ser em branco");
            if (pessoa.PessoaID == null)
            {
                Inserir(pessoa);
            }
            else
            {
                Atualizar(pessoa);
            }
        }

        public void Remover(Pessoa pessoa)
        {

            var command = new SqlCommand("delete from TB_Pessoa where PessoaID = @pessoaID", _sqlConnection);
            command.Parameters.AddWithValue("@pessoaID", pessoa.PessoaID);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar(Pessoa pessoa)
        {

            var command = new SqlCommand("update TB_Pessoa set Nome = @nome where PessoaID = @pessoaID", _sqlConnection);
            command.Parameters.AddWithValue("@pessoaID", pessoa.PessoaID);
            command.Parameters.AddWithValue("@nome", pessoa.Nome);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}
