using Domain.Pedidos;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class PratoDAL
    {
        private SqlConnection _sqlConnection { get; set; }
        public PratoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Inserir(Prato prato)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_PRATO(PratoID, Nome, MesaNum, AgendamentoID)" +
                "values(@pratoID, @nome, @mesaNum, @agendamentoID)";
            command.Parameters.AddWithValue("@pratoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", prato.Nome);
            command.Parameters.AddWithValue("@mesaNum", prato.MesaNum);
            command.Parameters.AddWithValue("@agendamentoID", prato.AgendamentoID);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void InserirAdmin(Prato prato)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_PRATO(PratoID, Nome, MesaNum, AgendamentoID)" +
                "values(@pratoID, @nome, @mesaNum, @agendamentoID)";
            command.Parameters.AddWithValue("@pratoID", prato.PratoID);
            command.Parameters.AddWithValue("@nome", prato.Nome);
            command.Parameters.AddWithValue("@mesaNum", DBNull.Value);
            command.Parameters.AddWithValue("@agendamentoID", DBNull.Value);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public IReadOnlyCollection<Prato> ObterTodos(Guid? agendamentoID)
        {
            List<Prato> pratos = new List<Prato>();

            _sqlConnection.Open();
            var command = new SqlCommand("Select PratoID, Nome, MesaNum, AgendamentoID from TB_PRATO " +
                "WHERE AgendamentoID IS null OR AgendamentoID = @agendamentoID " +
                "Order By Nome"
                , _sqlConnection);
            command.Parameters.AddWithValue("@agendamentoID", agendamentoID == null ? DBNull.Value : agendamentoID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetString(1));
                    var prato = new Prato(reader.GetString(1), reader.IsDBNull(2) ? 0 : reader.GetInt32(2), reader.GetGuid(0),
                                          reader.IsDBNull(3) ? null : reader.GetGuid(3));
                    pratos.Add(prato);
                }
            }

            _sqlConnection.Close();
            return pratos.AsReadOnly();
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

        public void Gravar(Prato prato)
        {
            if (string.IsNullOrEmpty(prato.Nome) && prato.MesaNum == null)
                throw new Exception("Nome não pode ser em branco ou mesa não pode ser nula.");
            if (prato.PratoID == null)
            {
                Inserir(prato);
            }
            else
            {
                Atualizar(prato);
            }
        }

        public void Remover(Prato prato)
        {

            var command = new SqlCommand("delete from TB_PRATO where PratoID = @pratoID", _sqlConnection);
            command.Parameters.AddWithValue("@pratoID", prato.PratoID);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar(Prato prato)
        {
            var command = new SqlCommand("update TB_PRATO set Nome = @nome where PratoID = @pratoID", _sqlConnection);
            command.Parameters.AddWithValue("@pratoID", prato.PratoID);
            command.Parameters.AddWithValue("@nome", prato.Nome);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}
