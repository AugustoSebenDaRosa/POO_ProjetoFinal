using Domain.Pedidos;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class MesaDAL
    {
        private SqlConnection _sqlConnection { get; set; }
        public MesaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Inserir(Mesa mesa)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_MESA(Numero, NumLugares)" +
                "values(@numero, @numLugares)";
            command.Parameters.AddWithValue("@numero", mesa.Numero);
            command.Parameters.AddWithValue("@numLugares", mesa.NumLugares);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public IReadOnlyCollection<Mesa> ObterTodos()
        {
            List<Mesa> mesas = new List<Mesa>();

            _sqlConnection.Open();
            var command = new SqlCommand("Select Numero, NumLugares from TB_MESA order by Numero", _sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetString(1));
                    var mesa = new Mesa(reader.GetInt32(1), reader.GetInt32(0));
                    mesas.Add(mesa);
                }
            }

            _sqlConnection.Close();
            return mesas.AsReadOnly();
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

        public void Gravar(Mesa mesa)
        {
            if (mesa.Numero < 0 || mesa.Numero > 300)
                throw new Exception("Só suportamos até 300 mesas.");
            if (!(mesa.NumLugares == 2 || mesa.NumLugares == 4 || mesa.NumLugares == 6))
                throw new Exception("Mesas precisam ter 2, 4 ou 6 lugares.");
            
            Inserir(mesa);
        }

        public void Remover(Mesa mesa)
        {

            var command = new SqlCommand("delete from TB_MESA where Numero = numero", _sqlConnection);
            command.Parameters.AddWithValue("@numero", mesa.Numero);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar(Mesa mesa)
        {

            var command = new SqlCommand("update TB_MESA set NumLugares = @numLugares where Numero = numero", _sqlConnection);
            command.Parameters.AddWithValue("@numLugares", mesa.NumLugares);
            command.Parameters.AddWithValue("@numero", mesa.Numero);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}
